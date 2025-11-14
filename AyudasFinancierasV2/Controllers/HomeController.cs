using AyudasFinancierasV2.Models.Entity;
using AyudasFinancierasV2.Models.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
namespace AyudasFinancierasV2.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
               int pidm = InformacionServices.ObtenerPidm(User.Identity.Name);
                var matricula = InformacionServices.ObtenerMatricula(pidm).Result;
                ViewBag.activas = InformacionServices.getBecasActivas(Convert.ToString(matricula));
                ViewBag.noactivas = InformacionServices.getBecasNoActivas(Convert.ToString(matricula));
                ViewBag.historial = InformacionServices.getHistoricoBecas(Convert.ToString(matricula));
                ViewBag.solicitud = InformacionServices.getSolicitudes(Convert.ToString(matricula));
                ViewBag.becas = InformacionServices.getBecasActuales(Convert.ToString(pidm));
                List <Renovacion> renovaciones = InformacionServices.getRenovaciones(matricula);
                ViewBag.renovacion = renovaciones;
                ViewBag.historialrenovacion = InformacionServices.getHistorialRenovaciones(matricula);
                ViewBag.periodo = InformacionServices.getPeriodoActivo(matricula);
                ViewBag.matricula = matricula;
                ViewBag.Talento = InformacionServices.getTalentoBecario(pidm);
                if (renovaciones.Count!=0)
                {
                    ViewBag.condicionado = renovaciones.Any(r => r.ESTATUS.ToUpper().Contains("CONDICIONADO") || r.CONDICION_ANT.ToUpper().Equals("Y"));
                }
                else
                {
                    ViewBag.condicionado = false;
                }
                return View();
            }
            else
            {
                return Redirect("https://www.udem.edu.mx/");
            }
        }
        [HttpPost]
        public JsonResult getEstatus(string item) 
        {
            int pidm = InformacionServices.ObtenerPidm(User.Identity.Name);
             item = InformacionServices.ObtenerMatricula(pidm).Result;
            List<DatosHisotricoBecas> estatusDocumentos = new List<DatosHisotricoBecas>();
            estatusDocumentos = InformacionServices.getEstatusDocumentos(item);
            return Json(estatusDocumentos, JsonRequestBehavior.AllowGet);
        }
        [WebMethod]
        public ActionResult DisplayDocument(string documento)
        {
            int pidm = InformacionServices.ObtenerPidm(User.Identity.Name);
            var matricula = InformacionServices.ObtenerMatricula(pidm).Result;
            Documento doc = new Documento();
            doc.nombre = documento;
             doc.pidm = pidm.ToString();
             doc.matricula = matricula;
            return View(InformacionServices.DisplayFile(doc));
        }
        public ActionResult AceptarBeca(string codigo, int anio)
        {
            if (User.Identity.IsAuthenticated)
            {
                try
                {
                    int pidm = InformacionServices.ObtenerPidm(User.Identity.Name);
                    var matricula = InformacionServices.ObtenerMatricula(pidm).Result;
                    var aceptacionBecaService = new AceptacionBecaService(); 
                    ViewBag.PeriodoActivo = InformacionServices.getPeriodoActivo(matricula); 

                    InfoAdmisionFinanciera infoAdmision = aceptacionBecaService.ObtenerInfoAdmisionFinancieraOracle(pidm, codigo, anio);

                    var datosAceptacion = aceptacionBecaService.ObtenerDatosAceptacionBeca(matricula, infoAdmision);
                    if (datosAceptacion == null)
                    {
                        ViewBag.Error = "No se encontraron datos de beca para tu matr�cula.";
                        return View("Error");
                    }
                    if (string.IsNullOrEmpty(codigo))
                    {
                        codigo = aceptacionBecaService.GenerarCodigoBeca(matricula, "ExcelenciaAcademica");
                    }
                    ViewBag.CodigoBeca = codigo;
                    ViewBag.Matricula = matricula;
                    ViewBag.Pidm = pidm;
                    ViewBag.AnioBeca = anio;
                    ViewBag.InfoAdmision = infoAdmision; // Pasar la informaci�n de admisi�n a la vista
                    return View(datosAceptacion);
                }
                catch (Exception ex)
                {
                    ViewBag.Error = "Error al cargar los datos de la beca: " + ex.Message;
                    return View("Error");
                }
            }
            else
            {
                return Redirect("https://www.udem.edu.mx/");
            }
        }
        [HttpPost]
        public JsonResult AceptarBecaConfirmar(string matricula, string firmaBeneficiario, string codigoBeca, int anioBeca)
        {
            int pidm = InformacionServices.ObtenerPidm(User.Identity.Name);
            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    var aceptacionBecaService = new AceptacionBecaService();
                    string resultado = aceptacionBecaService.AceptarBecaPorMatricula(pidm, codigoBeca, anioBeca);
                    if (resultado.StartsWith("ÉXITO"))
                    {
                        return Json(new
                        {
                            success = true,
                            message = "Beca aceptada exitosamente",
                            detalle = resultado
                        });
                    }
                    else if (resultado.StartsWith("INFO"))
                    {
                        return Json(new
                        {
                            success = false,
                            message = "No se encontr� la beca para actualizar",
                            detalle = resultado
                        });
                    }
                    else
                    {
                        return Json(new
                        {
                            success = false,
                            message = "Error al aceptar la beca",
                            detalle = resultado
                        });
                    }
                }
                else
                {
                    return Json(new
                    {
                        success = false,
                        message = "Usuario no autenticado"
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    success = false,
                    message = "Error interno del servidor: " + ex.Message
                });
            }
        }

        [HttpPost]
        public JsonResult GuardarPDFBeca(string matricula, string codigoBeca, string tipoDocumento,string periodo)
        {
            try
            {
                if (User.Identity.IsAuthenticated && Request.Files.Count > 0)
                {
                    HttpPostedFileBase file = Request.Files[0];
                    if (file != null && file.ContentLength > 0)
                    {
                        int pidm = InformacionServices.ObtenerPidm(User.Identity.Name);
                        
                        // Crear el objeto Documento con los datos existentes
                        var documento = new Documento
                        {
                            matricula = matricula,
                            pidm = pidm.ToString(),
                            nombre = "CARTA DE ACEPTACIÓN DE AF",
                            apellidos = User.Identity.Name, // O puedes obtener el nombre completo del usuario
                            periodo = periodo,
                            beca = codigoBeca,
                            file = file
                        };

                        // Primero verificar si ya existe el documento
                        try
                        {
                            var documentoExistente = InformacionServices.DisplayFile(documento);
                            string resultadoActualizacion="";
                            // Si llegamos aquí, el documento existe, así que lo actualizamos
                            if (documentoExistente.error ==null)
                            {
                                 resultadoActualizacion = InformacionServices.ActualizarDocumento(documento);

                            }
                            else
                            {
                                resultadoActualizacion = InformacionServices.GuardarDocumento(documento);

                            }

                            return Json(new
                            {
                                success = true,
                                message = "Documento actualizado exitosamente",
                                detalle = resultadoActualizacion,
                                accion = "actualizado"
                            });
                        }
                        catch (Exception)
                        {
                            
                            return Json(new
                            {
                                success = true,
                                message = "No se pudo guardar correctamente",
                                detalle = "",
                                accion = "Error"
                            });
                        }
                    }
                    else
                    {
                        return Json(new
                        {
                            success = false,
                            message = "No se recibió ningún archivo válido"
                        });
                    }
                }
                else
                {
                    return Json(new
                    {
                        success = false,
                        message = "Usuario no autenticado o no se enviaron archivos"
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    success = false,
                    message = "Error al guardar el documento: " + ex.Message
                });
            }
        }

        [HttpPost]
        public JsonResult RechazarBeca(string codigo, string nombre, int anio)
        {
            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    int pidm = InformacionServices.ObtenerPidm(User.Identity.Name);
                    var matricula = InformacionServices.ObtenerMatricula(pidm).Result;
                    var aceptacionBecaService = new AceptacionBecaService();
                    string resultado = aceptacionBecaService.RechazarBecaPorMatricula(pidm, codigo, anio);
                    if (resultado.StartsWith("ÉXITO"))
                    {
                        return Json(new { 
                            success = true, 
                            message = "La beca ha sido rechazada exitosamente.",
                            detalle = resultado
                        }, JsonRequestBehavior.AllowGet);
                    }
                    else if (resultado.StartsWith("INFO"))
                    {
                        return Json(new { 
                            success = false, 
                            message = "No se encontr� la beca para actualizar.",
                            detalle = resultado
                        }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { 
                            success = false, 
                            message = "Error al procesar el rechazo de la beca.",
                            detalle = resultado
                        }, JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json(new { 
                        success = false, 
                        message = "Usuario no autenticado." 
                    }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { 
                    success = false, 
                    message = "Error interno del servidor: " + ex.Message 
                }, JsonRequestBehavior.AllowGet);
            }
        }
        [WebMethod]
        public string updateDocumento(string clave)
        {
            return "";
        }


       
    }
}