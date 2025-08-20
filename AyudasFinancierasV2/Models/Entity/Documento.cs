using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyudasFinancierasV2.Models.Entites;

namespace AyudasFinancierasV2.Models.Entity
{
    public class Documento
    {
        public string pidm { get; set; }

        public string matricula { get; set; }
        public string nombre { get; set; }
        public string error { get; set; }
        public FileInfoFtp fileInfo { get; set; }
    }
}
