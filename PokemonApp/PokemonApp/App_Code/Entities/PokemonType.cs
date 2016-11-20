using System.Collections.Generic;
using System.Xml.Serialization;

namespace PokemonApp.App_Code.Entities
{
    public class PokemonType
    {
        [XmlAttribute("id")]
        public int TypeId { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("weakness")]
        public string Weakness { get; set; }

        [XmlAttribute("ineffective")]
        public string Ineffective { get; set; }

        [XmlAttribute("superEffective")]
        public string SuperEffective { get; set; }
    }
}