using Rocket.API;
using SimpleFastSalvage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SimpleFastSalvage.Configuration
{
    public class SimpleFastSalvageConfiguration : IRocketPluginConfiguration
    {
        [XmlArrayItem(ElementName = "Groups")]
        public List<Group> Groups { get; set; }

        public void LoadDefaults()
        {
            Groups = new List<Group>
            {
                new Group{ Permission = "default", Interval = 5f},
                new Group{ Permission = "vip", Interval = 3f},
            };
        }
    }
}
