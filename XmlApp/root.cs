using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlApp
{
    [XmlRoot("salon")]

   public class root
    {
        [XmlElement("spa")]

        public List<spa> Children { get; set; }


        
    }
}
