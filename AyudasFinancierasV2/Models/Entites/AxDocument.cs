
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;
using AyudasFinancierasV2.AxServiceInterface;
using AyudasFinancierasV2.Models.Entity;

namespace AyudasFinancierasV2.Models.Entites
{
    public class AxDocument
    {
        ///// <summary>
        ///// Application identifier
        ///// </summary>
        //int appid;
        ///// <summary>
        ///// Application name
        ///// </summary>
        //string appName;
        /// <summary>
        /// Data source name
        /// </summary>
        string dsn;
        /// <summary>
        /// Full file path of an image file from which
        //  to create a new document
        /// </summary>
        string filepath;
        /// <summary>
        /// Valid types are listed in the AXTypes
        //  Object Enumerations section
        /// </summary>
        EAxFileType filetype;
        /// <summary>
        /// Indicates whether to ignore
        ///  document-level security checking while
        ///  saving index values
        /// </summary>
        bool ignoreDls;
        /// <summary>
        /// Indicates whether to ignore duplicated
        /// indexes while saving index values
        /// </summary>
        bool ignoreDupindex;
        /// <summary>
        /// Indicates whether to split multi-page
        ///image files such as PDF, TIFF, and text.
        ///The default value is true. Note that at
        ///this release, TIFF and text images will
        ///be split automatically even if this
        ///parameter is set to false. It is a well
        ///known behavior that if the filetype
        ///parameter is set to something other
        ///than
        ///AXTypes.FileType.FT_UNKNOWN,
        ///multiple PDF pages will be split at the
        ///server side disregarding the value of
        ///this parameter.
        /// </summary>
        bool splitimg;
        /// <summary>
        /// Number of sub-pages in the image file
        ///(if any)
        /// </summary>
        string subpages;

        public AxDocument()
        {
        }

        public AxDocument(string dsn, string filepath, EAxFileType filetype, bool ignoreDls, bool ignoreDupindex, bool splitimg, string subpages)
        {
            this.Dsn = dsn;
            this.Filepath = filepath;
            this.Filetype = filetype;
            this.IgnoreDls = ignoreDls;
            this.IgnoreDupindex = ignoreDupindex;
            this.Splitimg = splitimg;
            this.Subpages = subpages;
        }

        public string Dsn { get => dsn; set => dsn = value; }
        public string Filepath { get => filepath; set => filepath = value; }
        public EAxFileType Filetype { get; set; }
        public bool IgnoreDls { get => ignoreDls; set => ignoreDls = value; }
        public bool IgnoreDupindex { get => ignoreDupindex; set => ignoreDupindex = value; }
        public bool Splitimg { get => splitimg; set => splitimg = value; }
        public string Subpages { get => subpages; set => subpages = value; }

        override public string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<?xml version=\"1.0\" encoding=\"utf-16\"?>");
            stringBuilder.Append("<ax:AxDocCrtData xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"");
            stringBuilder.Append("	xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" dsn=\"" + this.Dsn + "\" appid=\"403\"");
            stringBuilder.Append("	filepath=\"" + this.Filepath + "\" ignore_dup_index=\"" + this.IgnoreDupindex + "\"");
            stringBuilder.Append("	ignore_dls=\"" + this.IgnoreDls + "\" splitimg=\"" + this.Splitimg + "\" subpages=\"" + this.Subpages + "\" filetype=\"" + this.Filetype + "\"");
            stringBuilder.Append("	xmlns:ax=\"http://www.emc.com/ax\" />");
            return stringBuilder.ToString();
        }

        public static void DeleteDocument(Documento documento)
        {
            AxServicesInterface axServicesInterface = new AxServicesInterface();
            string sessionTicket = axServicesInterface.Login("", GlobalVariables.dataSource,
                /*"OTGMGR", "u_pick_it",*//*"BSASSBUSR1", "u_pick_it",*/ GlobalVariables.xtUser, GlobalVariables.xtPass,
                                                        Convert.ToInt32(EAxType.AxFeature_FullTextSearch));

            AxDocumentIndexQueryData newDocument = new AxDocumentIndexQueryData();

            newDocument.addField(1, false, documento.matricula);//MAtricula
            newDocument.addField(2, false, documento.pidm);//PIDM
            newDocument.addField(3, false, documento.nombre);//Tipo de documento
            newDocument.addField(4, false, documento.apellidos);//Apellido
            newDocument.addField(5, true);
            newDocument.addField(6, true);
            newDocument.addField(7, true);
            newDocument.addField(8, false, documento.periodo);
            newDocument.addField(9, true);
            newDocument.addField(10, false, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            newDocument.addField(11, true);
            newDocument.addField(12, true);

            string result = "";
            string rowString = "";
            AxRow row = new AxRow();
            try
            {
                result = axServicesInterface.QueryApplicationIndexesByAppId(
                    sessionTicket, GlobalVariables.dataSource, 504, false, true, newDocument.ToString(), 0, 1, 20);

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(result);
                rowString = xml.GetElementsByTagName(
                       "ax:Rows")[0].InnerXml.
                       Replace("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"", "").
                       Replace("xsi:", "");
                if (rowString != "")
                {
                    row =
                        Serialization<AxRow>
                        .DeserializeFromXmlFile(rowString);
                }
                else
                {
                    axServicesInterface.Logout(sessionTicket);
                    return;
                }

                axServicesInterface.OpenDocumentByRef(sessionTicket, row.attributes[2].value, false, false, "");
                axServicesInterface.LockDocumentByRef(sessionTicket, row.attributes[2].value);
                result = axServicesInterface.DeleteDocumentByRef(sessionTicket, row.attributes[2].value);

            }
            catch (Exception ex)
            {
                throw new HttpException(
                    (int)HttpStatusCode.InternalServerError, ex.Message);
            }
            finally
            {
                if (rowString != "")
                {
                    axServicesInterface.CloseDocumentByRef(sessionTicket, row.attributes[2].value, false, "");
                    axServicesInterface.Logout(sessionTicket);
                }
            }

        }








    }
}