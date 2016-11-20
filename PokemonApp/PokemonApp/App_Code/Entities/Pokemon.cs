using PokemonApp.App_Code.CrossCutting.Collections;
using PokemonApp.App_Code.Data.Repository;
using System;
using System.Xml.Serialization;

namespace PokemonApp.App_Code.Entities
{
    public class Pokemon
    {
        [XmlAttribute("id")]
        public int PokemonId { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("weight")]
        public int Weight { get; set; }

        [XmlAttribute("height")]
        public int Height { get; set; }

        [XmlAttribute("exp")]
        public int Exp { get; set; }

        [XmlAttribute("hp")]
        public int Hp { get; set; }

        [XmlAttribute("speed")]
        public int Speed { get; set; }

        [XmlAttribute("attack")]
        public int Attack { get; set; }

        [XmlAttribute("defense")]
        public int Defense { get; set; }

        [XmlAttribute("spAttack")]
        public int SpAttack { get; set; }

        [XmlAttribute("spDefense")]
        public int SpDefense { get; set; }

        [XmlAttribute("image")]
        public string Image { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("evolutions")]
        public string Evolutions { get; set; }

        [XmlAttribute("moves")]
        public string Moves { get; set; }

        [XmlAttribute("weakness")]
        public string Weakness { get; set; }

        [XmlAttribute("super_effective")]
        public string SuperEffective { get; set; }

        [XmlAttribute("no_effect")]
        public string NoEffect { get; set; }

        [XmlAttribute("ineffective")]
        public string Ineffective;

        [XmlAttribute("customName")]
        public string CUstomName;

        public RNList<PokemonType> GetType(string ids)
        {
            var typeRepository = new PokemonTypeRepository();
            var arr = ids.Split(';');
            var output = new RNList<PokemonType>();
            foreach (var typeId in arr)
            {
                output.InserirNoFim(typeRepository.GetById(Convert.ToInt32(typeId)));
            }
            return output;
        }

        public string GetTypeName(string ids)
        {
            var output = String.Empty;
            var types = GetType(ids);
            for (int i = 0; i < types.Count(); i++)
            {
                output += types.RetornarDaPosicao(i).Name;
                if (i < types.Count() - 1)
                    output += " / ";
            }

            return output;
        }
    }
}