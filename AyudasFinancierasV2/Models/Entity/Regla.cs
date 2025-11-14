using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AyudasFinancierasV2.Models.Entity
{
    public class Regla
    {
        public int id { get; set; }
        public Beca beca { get; set; }
        public Pregunta pregunta { get; set; }
        public string nombre { get; set; }
        public string valor { get; set; }
        public double min { get; set; }
        public double max { get; set; }
        public bool isValid  { get; set; }
        public bool udemPrepa { get; set; }
    }
}
