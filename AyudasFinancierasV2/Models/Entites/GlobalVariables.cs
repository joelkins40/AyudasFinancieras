using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using static System.Net.WebRequestMethods;

namespace AyudasFinancierasV2.Models.Entites
{
    public static class GlobalVariables
    {
        public static readonly string dataSource;
        public static readonly string xtUser;
        public static readonly string xtPass;
        public static readonly string ftpip;
        public static readonly string ftpUser;
        public static readonly string ftpPassword;
        public static readonly string ftpRuta;

        static GlobalVariables()
        {
            // Leer configuraciones desde web.config
            dataSource = ConfigurationManager.AppSettings["XTDataSource"] ?? "OTGMGR";
            xtUser = ConfigurationManager.AppSettings["XtUser"] ?? "DOCSIAF";
            xtPass = ConfigurationManager.AppSettings["XtPass"] ?? "DOCSIAF1!";
            ftpip = ConfigurationManager.AppSettings["FTPServer"] ?? "172.19.6.184";
            ftpUser = ConfigurationManager.AppSettings["FTPUser"] ?? "ftptstaydafn";
            ftpPassword = ConfigurationManager.AppSettings["FTPPassword"] ?? "Rep0AyudaFnT3t$";
            ftpRuta = ConfigurationManager.AppSettings["FTPPath"] ?? "//TBDMFILES/RepositorioAyudasFinancieras/TEST/";
        }

    }
}