using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Web;

namespace AyudasFinancierasV2.Models.Entites
{
    public class AxDocumentIndex
    {
        string id;
        string pdim;
        string docType;
        string lastName;
        string termCode;
        string activityDate;
        
        string documentId;

        public AxDocumentIndex(string documentId, string id, string pdim, string docType, string lastName,
                               string termCode, string activityDate)
        {
            this.DocumentId = documentId;
            this.id = id;
            this.pdim = pdim;
            this.docType = docType;
            this.lastName = lastName;
            this.termCode = termCode;
            this.activityDate = activityDate;
        }

        public string Id { get => id; set => id = value; }
        public string Pdim { get => pdim; set => pdim = value; }
        public string DocType { get => docType; set => docType = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string TermCode { get => termCode; set => termCode = value; }
        public string ActivityDate { get => activityDate; set => activityDate = value; }
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
            stringBuilder.Append(" 	<ax:Field id=\"1\" value=\"" + this.Id + "\" isNull=\"false\" /> ");
            stringBuilder.Append(" 	<ax:Field id=\"2\" value=\"" + this.Pdim + "\" isNull=\"false\" /> ");
            stringBuilder.Append(" 	<ax:Field id=\"3\" value=\"" + this.DocType + "\" isNull=\"false\" /> ");
            stringBuilder.Append(" 	<ax:Field id=\"4\" value=\"" + this.LastName + "\" isNull=\"false\" /> ");
            stringBuilder.Append(" 	<ax:Field id=\"5\" value=\"\" isNull=\"true\" /> ");
            stringBuilder.Append(" 	<ax:Field id=\"6\" value=\"\" isNull=\"true\" /> ");
            stringBuilder.Append(" 	<ax:Field id=\"7\" value=\"\" isNull=\"true\" /> ");
            stringBuilder.Append(" 	<ax:Field id=\"8\" value=\"" + this.TermCode + "\" isNull=\"false\" /> ");
            stringBuilder.Append(" 	<ax:Field id=\"9\" value=\"\" isNull=\"true\" /> ");
            stringBuilder.Append(" 	<ax:Field id=\"10\" value=\"" + this.ActivityDate + "\" isNull=\"true\" /> ");
            stringBuilder.Append(" 	<ax:Field id=\"11\" value=\"\" isNull=\"true\" /> ");
            stringBuilder.Append(" 	<ax:Field id=\"12\" value=\"\" isNull=\"true\" /> ");
            stringBuilder.Append(" 	</ax:Fields> ");
            stringBuilder.Append(" </ax:QueryItem> ");
            return stringBuilder.ToString();
        }
    }
}