using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;

namespace AyudasFinancierasV2.Models.Entites
{
    public class AxDocumentCreationData
    {
        /// <summary>
        /// Application identifier
        /// </summary>
        int appId;
        /// <summary>
        /// Data source name
        /// </summary>
        string dsn;
        /// <summary>
        /// Full file path of an image file from which
        /// to create a new document
        /// </summary>
        string filePath;
        /// <summary>
        /// Valid types are listed in the AXTypes
        /// Object Enumerations section
        /// </summary>
        EAxFileType fileType;
        /// <summary>
        /// Indicates whether to ignore
        /// document-level security checking while
        /// saving index values
        /// </summary>
        bool ignoreDls;
        /// <summary>
        /// Indicates whether to ignore duplicated
        /// indexes while saving index values
        /// </summary>
        bool ignoreDupIndex;
        /// <summary>
        /// Indicates whether to split multi-page
        /// image files such as PDF, TIFF, and text.
        /// The default value is true. Note that at
        /// this release, TIFF and text images will
        /// be split automatically even if this
        /// parameter is set to false. It is a well
        /// known behavior that if the filetype
        /// parameter is set to something other
        /// than
        /// AXTypes.FileType.FT_UNKNOWN,
        /// multiple PDF pages will be split at the
        /// server side disregarding the value of
        /// this parameter.
        /// </summary>
        bool splitimg;
        /// <summary>
        /// Number of sub-pages in the image file
        /// (if any)
        /// </summary>
        int subpages;


        public AxDocumentCreationData()
        {
        }

        public AxDocumentCreationData(int appId, string dsn,
           string filePath, EAxFileType fileType, bool ignoreDls,
           bool ignoreDupIndex, bool splitimg, int subpages)
        {
            this.appId = appId;
            this.dsn = dsn;
            this.filePath = filePath;
            this.fileType = fileType;
            this.ignoreDls = ignoreDls;
            this.ignoreDupIndex = ignoreDupIndex;
            this.splitimg = splitimg;
            this.subpages = subpages;
        }

        public int AppId { get => appId; set => appId = value; }
        public string Dsn { get => dsn; set => dsn = value; }
        public string FilePath { get => filePath; set => filePath = value; }
        public EAxFileType FileType { get => fileType; set => fileType = value; }
        public bool IgnoreDls { get => ignoreDls; set => ignoreDls = value; }
        public bool IgnoreDupIndex { get => ignoreDupIndex; set => ignoreDupIndex = value; }
        public bool Splitimg { get => splitimg; set => splitimg = value; }
        public int Subpages { get => subpages; set => subpages = value; }

        override public string ToString()
        {
            return "<?xml version=\"1.0\" encoding=\"utf - 16\"?> " +
                    "<ax:AxDocCrtData xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" " +
                    "xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" dsn = \"" +
                    this.Dsn + "\" appid = \"" + this.AppId + "\"" +
                    " filepath = \"" + this.FilePath + "\" ignore_dup_index = \"" +
                    this.IgnoreDupIndex.ToString().ToLower() + "\"" +
                    " ignore_dls = \"" + this.IgnoreDls.ToString().ToLower() +
                    "\" splitimg = \"" + this.Splitimg.ToString().ToLower() +
                    "\" subpages = \"" + this.Subpages + "\" filetype = \"" + this.FileType + "\"" +
                    " xmlns:ax = \"http://www.emc.com/ax\" /> ";
        }

        /*
        public AxDocumentCreationData(int appId, string dsn,
            string filePath, EAxFileType fileType, bool ignoreDls,
            bool ignoreDupIndex, bool splitimg, int subpages, byte[] fileContent)
        {
            this.appId = appId;
            this.dsn = dsn;
            this.filePath = filePath;
            this.fileType = fileType;
            this.ignoreDls = ignoreDls;
            this.ignoreDupIndex = ignoreDupIndex;
            this.splitimg = splitimg;
            this.subpages = subpages;
            this.fileContent = fileContent;
        }*/

        /*
        public int AppId { get => appId; set => appId = value; }
        public string Dsn { get => dsn; set => dsn = value; }
        public string FilePath { get => filePath; set => filePath = value; }
        public EAxFileType FileType { get => fileType; set => fileType = value; }
        public bool IgnoreDls { get => ignoreDls; set => ignoreDls = value; }
        public bool IgnoreDupIndex { get => ignoreDupIndex; set => ignoreDupIndex = value; }
        public bool Splitimg { get => splitimg; set => splitimg = value; }
        public int Subpages { get => subpages; set => subpages = value; }
        public byte[]  filecontent { get => fileContent; set => fileContent = value; }
        */
        /*
        override public string ToString()
        {
            string fileContentBase64 = string.Empty;

            if(this.fileContent != null && this.fileContent.Length > 0)
            {
                // 🧩 OPCIONAL: Comprimir antes de convertir a Base64
                // Si no quieres comprimir, elimina esta sección y deja directamente el Convert.ToBase64String(this.fileContent)
                using (var input = new MemoryStream(this.fileContent))
                using (var output = new MemoryStream())
                {
                    using (var gzip = new GZipStream(output, CompressionMode.Compress))
                    {
                        input.CopyTo(gzip);
                    }
                    fileContentBase64 = Convert.ToBase64String(output.ToArray());
                }
            }

            var settings = new XmlWriterSettings
            {
                Encoding = new UTF8Encoding(false),
                Indent = false,
                OmitXmlDeclaration = false
            };

            using (var sw = new StringWriter())
            using (var writer = XmlWriter.Create(sw, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("ax", "AxDocCrtData", "http://www.emc.com/ax");

                writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
                writer.WriteAttributeString("xmlns", "xsd", null, "http://www.w3.org/2001/XMLSchema");
                writer.WriteAttributeString("dsn", this.Dsn);
                writer.WriteAttributeString("appid", this.AppId.ToString());

                if (!string.IsNullOrWhiteSpace(this.FilePath))
                {
                    writer.WriteAttributeString("filepath", this.FilePath);
                }

                writer.WriteAttributeString("ignore_dup_index", this.IgnoreDupIndex.ToString().ToLower());
                writer.WriteAttributeString("ignore_dls", this.IgnoreDls.ToString().ToLower());
                writer.WriteAttributeString("splitimg", this.Splitimg.ToString().ToLower());
                writer.WriteAttributeString("subpages", this.Subpages.ToString());
                writer.WriteAttributeString("filetype", this.FileType.ToString());

                if (!string.IsNullOrEmpty(fileContentBase64))
                {
                    writer.WriteElementString("ax", "filecontent", "http://www.emc.com/ax", fileContentBase64);
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();

                return sw.ToString();
            }


            /*
            //Si el archivo se encuentra en memoria, lo convierte a Base64
            string fileContentBase64 = string.Empty;

            Console.WriteLine($"FileContent length: {this.fileContent?.Length}");

            if (this.fileContent != null && this.fileContent.Length > 0)
            {
                fileContentBase64 = Convert.ToBase64String(this.fileContent);
            }

            string xml = "<?xml version=\"1.0\" encoding=\"utf - 16\"?> " +
                        "<ax:AxDocCrtData xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" " +
                        "xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" dsn = \"" +
                        this.Dsn + "\" appid = \"" + this.AppId + "\"" +
                        (string.IsNullOrWhiteSpace(this.FilePath) ? "" : " filepath = \"" + this.FilePath + "\"") +
                        " ignore_dup_index = \"" + this.IgnoreDupIndex.ToString().ToLower() + "\"" +
                        " ignore_dls = \"" + this.IgnoreDls.ToString().ToLower() +
                        "\" splitimg = \"" + this.Splitimg.ToString().ToLower() +
                        "\" subpages = \"" + this.Subpages + "\" filetype = \"" + this.FileType + "\"" +
                        " xmlns:ax = \"http://www.emc.com/ax\" > ";

            if (!string.IsNullOrEmpty(fileContentBase64))
            {
                xml += $"<ax:filecontent>{fileContentBase64}</ax:filecontent>";
            }

            xml += "</ax:AxDocCrtData>";

            return xml;
    }*/
    }

}
