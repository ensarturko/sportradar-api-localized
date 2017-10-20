using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Oregon.Data.Model
{
    interface IBaseXmlModel
    {
        [XmlAttribute("id")]
        string Id { get; set; }

        [XmlAttribute("name")]
        string Name { get; set; }
    }
}
