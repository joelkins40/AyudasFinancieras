using AyudasFinancierasV2.Models.Entity;
using AyudasFinancierasV2.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static AyudasFinancierasV2.Models.Entites.AxRow;

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
    }
}