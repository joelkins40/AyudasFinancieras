using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace AyudasFinancierasV2.Models.Entites
{
    public class AxDocumentIndexQueryData
    {
        List<AxFieldValue> AXFields;

        public AxDocumentIndexQueryData()
        {
            this.AXFields = new List<AxFieldValue>();
        }
        public void addField(int id, bool isNull, string value = "")
        {
            AxFieldValue axFieldValueTemp = new AxFieldValue();

            axFieldValueTemp.Id = id;
            axFieldValueTemp.IsNull = isNull;
            axFieldValueTemp.Value = value;

            AXFields.Add(axFieldValueTemp);
        }
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<?xml version=\"1.0\" encoding=\"utf - 16\"?> ");
            sb.Append(" <ax:AxIndexQueryData xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"");
            sb.Append(" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" ");
            sb.Append(" xmlns:ax=\"http://www.emc.com/ax\"   >");
            sb.Append("            <ax:Fields>");

            foreach (var item in this.AXFields)
            {
                sb.Append(item.ToString());
            }

            sb.Append("        </ax:Fields> ");
            sb.Append(" </ax:AxIndexQueryData>");
            return sb.ToString();
        }
    }
}