using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AyudasFinancierasV2.Models.Entity
{
    public class Pregunta
    {
        public int id { get; set; }
        public int orden { get; set; }
        public string nivel { get; set; }
        public string categoria { get; set; }
        public string posicion { get; set; }
        public string tipo { get; set; }
        public string oculta { get; set; }
        public string pregunta { get; set; }
        public List <Opciones> opciones { get; set; }
        public string respuesta { get; set; }
        public string comentario { get; set; }
    }
}
