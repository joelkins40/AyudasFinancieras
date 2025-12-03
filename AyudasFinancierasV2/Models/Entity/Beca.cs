using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AyudasFinancierasV2.Models.Entity
{
    public class Beca
    {
        public string code { get; set; }
        public string nombre { get; set; }
        public string anio { get; set; }
        public string nivel { get; set; }
        public double desde { get; set; }
        public double hasta { get; set; }
        public string icon { get; set; }
        public string uri { get; set; }
        public string fecha { get; set; }
        public string pidm { get; set; }
        public string porcentaje { get; set; }
        public Periodo periodo { get; set; }
    }
}
