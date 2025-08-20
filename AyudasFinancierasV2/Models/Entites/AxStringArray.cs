using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace AyudasFinancierasV2.Models.Entites
{
    [XmlRoot("AxStringArray", Namespace = "http://www.emc.com/ax", IsNullable = true)]
    public class AxStringArray
    {
        [XmlElement("String")]
        public string[] itemString;



        override public string ToString()
        {
            return Serialization<AxDocumentIndex>.Serialize(this);
        }
    }
}