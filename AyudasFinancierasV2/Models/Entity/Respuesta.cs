using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AyudasFinancierasV2.Models.Entity
{
    public class Respuesta
    {
        public int id { get; set; }
        public Pregunta pregunta { get; set; }
        public string respuesta { get; set; }
        public string fecha { get; set; }
    }
}
