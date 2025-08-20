using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace AyudasFinancierasV2.Models.Entites
{
    public class AxDocumentIndex
    {
        string id;
        string pdim;
        string aidYear;
        string aidPeriod;
        string aidFond;
        string treqCode;
        string aplicationForm;
        string activityDate;
        string documentId;

        public AxDocumentIndex(string documentId, string id, string pdim, string aidYear,
                    string aidPeriod, string aidFond, string treqCode, string aplicationForm,
                    string activityDate)
        {
            this.DocumentId = documentId;
            this.id = id;
            this.pdim = pdim;
            this.aidYear = aidYear;
            this.aidPeriod = aidPeriod;
            this.aidFond = aidFond;
            this.treqCode = treqCode;
            this.aplicationForm = aplicationForm;
            this.activityDate = activityDate;
        }

        public string Id { get => id; set => id = value; }
        public string Pdim { get => pdim; set => pdim = value; }
        public string AidYear { get => aidYear; set => aidYear = value; }
        public string AidPeriod { get => aidPeriod; set => aidPeriod = value; }
        public string AidFond { get => aidFond; set => aidFond = value; }
        public string AplicationForm { get => aplicationForm; set => aplicationForm = value; }
        public string ActivityDate { get => activityDate; set => activityDate = value; }
        public string TreqCode { get => treqCode; set => treqCode = value; }
        public string DocumentId { get => documentId; set => documentId = value; }

        override public string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<?xml version = \"1.0\" encoding = \"utf - 16\" ?>");
            stringBuilder.Append(" <ax:QueryItem xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" ");
            stringBuilder.Append(" 	xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" id=\"" + this.DocumentId + "\" ");
            stringBuilder.Append(" 	xmlns:ax=\"http://www.emc.com/ax\"> ");
            stringBuilder.Append(" 	<ax:Attributes /> ");
            stringBuilder.Append(" 	<ax:Fields> ");
            stringBuilder.Append(" 		<ax:Field id=\"1\" value=\"" + this.Id + "\" isNull=\"false\" /> ");
            stringBuilder.Append(" 		<ax:Field id=\"2\" value=\"" + this.Pdim + "\" isNull=\"false\" /> ");
            stringBuilder.Append(" 		<ax:Field id=\"3\" value=\"" + this.AidYear + "\" isNull=\"false\" /> ");
            stringBuilder.Append(" 		<ax:Field id=\"4\" value=\"" + this.AidPeriod + "\" isNull=\"false\" /> ");
            stringBuilder.Append(" 		<ax:Field id=\"5\" value=\"" + this.TreqCode + "\" isNull=\"false\" /> ");
            stringBuilder.Append(" 		<ax:Field id=\"6\" value=\"\" isNull=\"true\" /> ");
            stringBuilder.Append(" 		<ax:Field id=\"7\" value=\"" + this.AidFond + "\" isNull=\"false\" /> ");
            stringBuilder.Append(" 		<ax:Field id=\"8\" value=\"" + this.AplicationForm + "\" isNull=\"false\" /> ");
            stringBuilder.Append(" 		<ax:Field id=\"9\" value=\"" + this.ActivityDate + "\" isNull=\"true\" /> ");
            stringBuilder.Append(" 		<ax:Field id=\"10\" value=\"\" isNull=\"true\" /> ");
            stringBuilder.Append(" 	</ax:Fields> ");
            stringBuilder.Append(" </ax:QueryItem> ");
            return stringBuilder.ToString();
        }
    }
}