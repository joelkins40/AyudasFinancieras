using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace AyudasFinancierasV2.Models.Entity
{
    public class InfoAdmisionFinanciera
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Tiempo { get; set; }
        public string EscuelaProcedencia { get; set; }
        public string NombreAyudaFinanciera { get; set; }
        public string Periodo { get; set; }
        public string PorcentajeBeca { get; set; }
        public DateTime? FechaOfrecimiento { get; set; }
        public decimal? Promedio { get; set; }
        public string PromedioRenovacion { get; set; }
        public int?  PAA { get; set; }
        public string Programa { get; set; }
        public string Campus { get; set; }
        public string Nivel { get; set; }
        public string Talento { get; set; }
        public string Horas { get; set; }
        public string NivelAnterior { get; set; }

        public InfoAdmisionFinanciera()
        {
        }
    }
}