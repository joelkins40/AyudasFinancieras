using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace AyudasFinancierasV2.Models.Entites
{
    public class FileInfoFtp
    {
        public FileInfoFtp()
        {
        }
        public string FileName { get; internal set; }
        public string FileType { get; internal set; }
        [JsonIgnore]
        public string FileId { get; }
        private string fileContent;

        public string FileContentSize { get; internal set; }
        public string FileContent
        {
            get => fileContent;
            set
            {
                fileContent = value;
                this.FileContentSize = (value.Length / 1000).ToString("#0.00");
            }
        }
    }
}