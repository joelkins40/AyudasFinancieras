
using AyudasFinancierasV2.Models.Entity;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Net;
using System.Web;
using AyudasFinancierasV2.Models.Entites;

namespace AyudasFinancierasV2.Models.Entity
{
    /// <summary>
    /// Estructura que representa una petición de un token de sesión
    /// </summary>
    public class Documento
    {
        public string nombre { get; set; }
        public string pidm { get; set; }
        public string matricula { get; set; }
        public string periodo { get; set; }
        public string apellidos { get; set; }
        public string error { get; set; }
        
        public FileInfoFtp fileInfo { get; set; }
        public HttpPostedFileBase file { get; set; }
        public string beca { get; set; }
    }
}