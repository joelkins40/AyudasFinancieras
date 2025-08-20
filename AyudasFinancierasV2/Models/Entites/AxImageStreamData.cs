using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace AyudasFinancierasV2.Models.Entites
{
    [XmlRoot(Namespace = "http://www.emc.com/ax")]
    public class AxImageStreamData
    {
        bool encryption;
        int maxbytes;
        long startbyte;
        [XmlAttribute("encryption")]
        public bool Encryption { get => encryption; set => encryption = value; }
        [XmlAttribute("maxbytes")]
        public int Maxbytes { get => maxbytes; set => maxbytes = value; }
        [XmlAttribute("startbyte")]
        public long Startbyte { get => startbyte; set => startbyte = value; }
        override public string ToString()
        {
            return Serialization<AxImageStreamData>.Serialize(this);
        }
    }
}