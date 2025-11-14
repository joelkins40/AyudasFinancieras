using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AyudasFinancierasV2.Models.Entity
{
    public class Evaluacion
    {
        public int pid { get; set; }
        public string nivel { get; set; }
        public Periodo periodo { get; set; }
        public List<Respuesta> respuestas { get; set; }
        public Informacion info { get; set; }
    }
}
