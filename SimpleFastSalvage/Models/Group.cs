using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SimpleFastSalvage.Models
{
    public class Group
    {
        [XmlText]
        public string Permission { get; set; }
        [XmlAttribute("Interval")]
        public float Interval { get; set; }
    }
}
