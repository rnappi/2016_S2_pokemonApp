using System.Xml.Serialization;

namespace PokemonApp.App_Code.Entities
{
    public class Move
    {
        [XmlAttribute("id")]
        public int MoveId { get; set; }

        [XmlAttribute("accuracy")]
        public int Accuracy { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("power")]
        public int Power { get; set; }

        [XmlAttribute("pp")]
        public int Pp { get; set; }
    }
}