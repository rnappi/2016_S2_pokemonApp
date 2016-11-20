using System;
using System.Xml.Serialization;

namespace PokemonApp.App_Code.Entities
{
    public class Inventory
    {
        [XmlAttribute("id")]
        public int InventoryId { get; set; }

        [XmlAttribute("userId")]
        public int UserId { get; set; }

        [XmlAttribute("pokemons")]
        public string Pokemons { get; set; }

        public void AddPokemon(Pokemon pokemon)
        {
            if (!String.IsNullOrWhiteSpace(Pokemons))
                Pokemons += ";";
            Pokemons += pokemon.PokemonId;
        }
    }
}