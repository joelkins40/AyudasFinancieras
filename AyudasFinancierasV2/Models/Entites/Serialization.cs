using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.Xml;

namespace AyudasFinancierasV2.Models.Entites
{
    public static class Serialization<T> where T : class
    {

        public static T DeserializeFromXmlFile(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
        public static string Serialize<T>(T value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            try
            {
                var nameSpace = new XmlSerializerNamespaces();
                nameSpace.Add("ax", "http://www.emc.com/ax");
                nameSpace.Add("xsd", "http://www.w3.org/2001/XMLSchema");
                nameSpace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                var xmlserializer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter();
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlserializer.Serialize(writer, value, nameSpace);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }
    }
}