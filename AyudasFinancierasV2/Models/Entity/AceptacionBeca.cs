using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace AyudasFinancierasV2.Models.Entity
{
    public class AceptacionBeca
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string EscuelaProcedencia { get; set; }
        public string PorcentajeAyudaFinanciera { get; set; }
        public DateTime FechaOfrecimiento { get; set; }
        public string Programa { get; set; }
        public string Periodo { get; set; }
        public string Campus { get; set; }
        public string Tiempo { get; set; }
        public string Talento { get; set; }
        public string Horas { get; set; }
        public string TipoAdmision { get; set; } // "Profesional"
        public int PuntosExamenAdmision { get; set; } // 1300
        public int PuntosMinimosRequeridos { get; set; } // 1300
        public PoliticasAsignacion PoliticasAsignacion { get; set; }
        public PoliticasRenovacion PoliticasRenovacion { get; set; }
        public List<Compromiso> Compromisos { get; set; }
        public bool EstaAceptada { get; set; }
        public DateTime FechaAceptacion { get; set; }
        public string LugarFirma { get; set; }
        public DateTime FechaFirma { get; set; }
        public string FirmaBeneficiario { get; set; }

        public string NombreAyudaFinanciera { get; set; }
        public string NIVEL_ANTERIOR { get; set; }

        

        public AceptacionBeca()
        {
            Compromisos = new List<Compromiso>();
            PoliticasAsignacion = new PoliticasAsignacion();
            PoliticasRenovacion = new PoliticasRenovacion();
        }
    }
    public class PoliticasAsignacion
    {
        public double PromedioMinimoRequerido { get; set; } // 95
        public bool DebeAprobarTodasMaterias { get; set; }
        public int PuntosMinimosExamen { get; set; } // 1300
        public bool DebeCompletarSolicitud { get; set; }
        public string ConsultarProcesoAdmision { get; set; } // "Profesional"
    }
    public class PoliticasRenovacion
    {
        public string PromedioMinimoRenovacion { get; set; } // 90
        public bool DebeAprobarTodasMateriasRenovacion { get; set; }
        public string NotaImportante { get; set; }
        public string ConsideracionesAdicionales { get; set; }
    }
    public class Compromiso
    {
        public int Numero { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<string> Incisos { get; set; }
        public Compromiso()
        {
            Incisos = new List<string>();
        }
    }
}