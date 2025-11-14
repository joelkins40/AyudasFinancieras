using AyudasFinancierasV2.Models.Entity;
using AyudasFinancierasV2.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace AyudasFinancierasV2.Controllers
{
    [Authorize]
    public class BecasController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                Evaluacion item = new Evaluacion();
                item.pid = InformacionServices.ObtenerPidm(User.Identity.Name);
                var matricula = InformacionServices.ObtenerMatricula(item.pid).Result;
                item.info = InformacionServices.getInformacion(item.pid);
                item.periodo = InformacionServices.getPeriodoActivo(matricula);
                ViewBag.becas = BecasServices.validarBeca(item);
                return View();
            }
            else
            {
                return Redirect("https://www.udem.edu.mx/");
            }
        }
        [HttpPost]
        public JsonResult getUrlBeca(string code="")
        {
            var pidm= InformacionServices.ObtenerPidm(User.Identity.Name);
            var matricula = InformacionServices.ObtenerMatricula(pidm).Result;
           var info = InformacionServices.getInformacion(pidm);
           var periodo = InformacionServices.getPeriodoActivo(matricula);
            Beca beca= new Beca();
            beca.code = code;
            beca.nivel = info.NIVEL.Substring(0, 2);
            beca.anio = info.PERIODO_EFECTIVO.Substring(2, 4);
            string url = InformacionServices.getUrlBSA(beca.code,beca.anio,beca.nivel);
            return Json(url, JsonRequestBehavior.AllowGet);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        [HttpPost]
        public ActionResult Step3(List<string> selectedBecas)
        {
            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    if (selectedBecas == null || !selectedBecas.Any())
                    {
                        return RedirectToAction("Index");
                    }
                    Evaluacion item = new Evaluacion();
                    item.pid = InformacionServices.ObtenerPidm(User.Identity.Name);
                    var matricula = InformacionServices.ObtenerMatricula(item.pid).Result;
                    item.info = InformacionServices.getInformacion(item.pid);
                    item.periodo = InformacionServices.getPeriodoActivo(matricula);
                    int aidyCode;
                    if (int.TryParse(item.periodo.CODIGO, out aidyCode))
                    {
                        bool guardadoExitoso = BecasServices.GuardarBecasSeleccionadas(item.pid, aidyCode, selectedBecas);
                        if (!guardadoExitoso)
                        {
                            System.Diagnostics.Debug.WriteLine("Error al guardar becas seleccionadas en la base de datos");
                        }
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"No se pudo convertir el código del período a entero: {item.periodo.CODIGO}");
                    }
                    return RedirectToAction("Step3");
                }
                else
                {
                    return Redirect("https://www.udem.edu.mx/");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en Step3: {ex.Message}");
                return RedirectToAction("Index");
            }
        }
        public ActionResult Step3()
        {
            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    Evaluacion item = new Evaluacion();
                    item.pid = InformacionServices.ObtenerPidm(User.Identity.Name);
                    var matricula = InformacionServices.ObtenerMatricula(item.pid).Result;
                    item.info = InformacionServices.getInformacion(item.pid);
                    item.periodo = InformacionServices.getPeriodoActivo(matricula);
                    List<Beca> becasGuardadas = new List<Beca>();
                    int aidyCode;
                    if (int.TryParse(item.periodo.CODIGO, out aidyCode))
                    {
                        var becasGuardadasDB = BecasServices.ConsultarBecasGuardadas(item.pid, aidyCode);
                        if (becasGuardadasDB != null && becasGuardadasDB.Any())
                        {
                            var todasLasBecas = BecasServices.validarBeca(item);
                            foreach (var becaGuardada in becasGuardadasDB)
                            {
                                var becaCompleta = todasLasBecas?.FirstOrDefault(b => b.code == becaGuardada.code);
                                if (becaCompleta != null)
                                {
                                    becasGuardadas.Add(becaCompleta);
                                }
                                else
                                {
                                    becasGuardadas.Add(becaGuardada);
                                }
                            }
                        }
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"No se pudo convertir el código del período a entero: {item.periodo.CODIGO}");
                    }
                    if (!becasGuardadas.Any())
                    {
                        return RedirectToAction("Index");
                    }
                    ViewBag.selectedBecas = becasGuardadas;
                    return View();
                }
                else
                {
                    return Redirect("https://www.udem.edu.mx/");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al consultar becas guardadas: {ex.Message}");
                return RedirectToAction("Index");
            }
        }
    }
}