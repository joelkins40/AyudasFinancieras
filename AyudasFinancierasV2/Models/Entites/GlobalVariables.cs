using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AyudasFinancierasV2.Models.Entites
{
    public static class GlobalVariables
    {
        public static readonly string dataSource;
        public static readonly string xtUser;
        public static readonly string xtPass;

        static GlobalVariables()
        {
            dataSource = ConfigurationManager.AppSettings["XTDataSource"];
            xtUser = ConfigurationManager.AppSettings["XtUser"];
            xtPass = ConfigurationManager.AppSettings["XtPass"];
        }
    }

    
}