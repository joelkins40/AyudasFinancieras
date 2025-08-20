using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace AyudasFinancierasV2.Models.Entites
{

    [XmlRoot("Row", Namespace = "http://www.emc.com/ax",
IsNullable = true)]
    public class AxRow
    {

        [XmlAttribute("type")]
        public string type { get; set; }
        [XmlAttribute("id")]
        public string id { get; set; }

        [XmlRoot("Item")]
        public class item
        {
            [XmlAttribute]
            public string id { get; set; }
            [XmlAttribute]
            public string value { get; set; }
        }

        [XmlArray("Attributes")]
        [XmlArrayItem("Item")]
        public item[] attributes { get; set; }

        [XmlRoot("Field")]
        class field
        {
            [XmlAttribute]
            public string id { get; set; }
            [XmlAttribute]
            public string value { get; set; }
            [XmlAttribute]
            public string isnull { get; set; }
        }
        [XmlArray("Fields")]
        [XmlArrayItem("Field")]
        public item[] fields { get; set; }
    }

}