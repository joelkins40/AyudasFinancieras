using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace AyudasFinancierasV2.Models.Entites
{
    [XmlRoot("AxDocumentExportData", Namespace = "http://www.emc.com/ax", IsNullable = true)]
    public class AxDocumentExportData
    {

        AxImageExportFormatData format;

        AxFormTypes formtype;

        bool hideAnnotations;

        string pageRange;

        bool PDFFileUseLink;

        bool pdfForceHideAnnotations;

        bool singlePDFFile;

        [XmlAttribute("format")]
        public AxImageExportFormatData Format { get => format; set => format = value; }
        [XmlAttribute("formtype")]
        public AxFormTypes Formtype { get => formtype; set => formtype = value; }
        [XmlAttribute("hideAnnotations")]
        public bool HideAnnotations { get => hideAnnotations; set => hideAnnotations = value; }
        [XmlAttribute("pageRange")]
        public string PageRange { get => pageRange; set => pageRange = value; }
        [XmlAttribute("PDFFileUseLink")]
        public bool PDFFileUseLink1 { get => PDFFileUseLink; set => PDFFileUseLink = value; }
        [XmlAttribute("pdfForceHideAnnotations")]
        public bool PdfForceHideAnnotations { get => pdfForceHideAnnotations; set => pdfForceHideAnnotations = value; }
        [XmlAttribute("singlePDFFile")]
        public bool SinglePDFFile { get => singlePDFFile; set => singlePDFFile = value; }





        override public string ToString()
        {
            return Serialization<AxDocumentIndex>.Serialize(this);
        }
    }
}