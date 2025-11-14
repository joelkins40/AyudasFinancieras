using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AyudasFinancierasV2.Models.Entity
{
    public class DatosHisotricoBecas
    {
        public string periodo { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public string porcentaje { get; set; }
        public string documento { get; set; }
        public string estatus { get; set; }
        public string mensaje { get; set; }
        public string fecha { get; set; }
        public string tipo { get; set; }
    }
}
