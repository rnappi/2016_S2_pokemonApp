using System;
using PokemonApp.App_Code.Entities;
using PokemonApp.App_Code.CrossCutting.Collections;

namespace PokemonApp.App_Code.Data.Repository
{
    public class PokemonRepository : RepositoryBase<Pokemon>
    {
        public override RNList<Pokemon> GetAll()
        {
            if (Repository.Pokemons == null)
            {
                try
                {
                    var output = new RNList<Pokemon>();
                    var xmlData = XmlLoadData.LoadXmlData<Pokemon>("data/pokemon.xml");
                    foreach (var pokemon in xmlData)
                    {
                        output.InserirNoFim(pokemon);
                    }
                    Repository.Pokemons = output;
                }
                catch (Exception error)
                {
                    throw error;
                }
            }

            return Repository.Pokemons;
        }

        public override Pokemon GetById(int id)
        {
            return GetAll().Find("PokemonId", id);
        }
    }
}