using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AyudasFinancierasV2.Models.Entity
{
    public class Renovacion
    {
        public string MATRICULA { get; set; }
        public string ESTATUS { get; set; }
        public double PROMEDIO { get; set; }
        public double PROM_REQUERIDO { get; set; }
        public int REPROBADAS { get; set; }
        public int PERIODOS_BECA { get; set; }
        public string TALENTO { get; set; }
        public string CONDICION_ANT { get; set; }
        public string FECHA { get; set; }
        public string DESCRIPCION { get; set; }
        public string PERIODO { get; set; }
    }
}
