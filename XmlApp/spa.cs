using System.Xml.Serialization;

namespace XmlApp
{
    public class spa
    {
        [XmlElement("name")]
        public string name { get; set; }

        [XmlElement("master")]
        public string master { get; set; }

        [XmlElement("price")]
        public string price { get; set; }

    }
}
