using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AyudasFinancierasV2.Models.Entites
{
    public class DataBase
    {
        List<OracleParameter> parameterList;

        Dictionary<String, String> filters;
        Dictionary<String, String> outParameters;
        Dictionary<String, OracleDbType> dbTypeList;
        Dictionary<String, int> sizeList;
        DataTable result;

    }
}