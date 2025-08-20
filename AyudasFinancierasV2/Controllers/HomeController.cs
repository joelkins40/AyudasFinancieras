using AyudasFinancierasV2.Models.Entity;
using AyudasFinancierasV2.Models.Services;
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
              
                // Código original comentado para pruebas
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
    }
}