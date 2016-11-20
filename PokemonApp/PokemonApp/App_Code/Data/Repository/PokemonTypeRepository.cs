using PokemonApp.App_Code.CrossCutting.Collections;
using PokemonApp.App_Code.Entities;
using System;
using System.Collections.Generic;

namespace PokemonApp.App_Code.Data.Repository
{
    public class PokemonTypeRepository : RepositoryBase<PokemonType>
    {
        public override RNList<PokemonType> GetAll()
        {
            if (Repository.Types == null)
            {
                try
                {
                    var output = new RNList<PokemonType>();
                    var xmlData = XmlLoadData.LoadXmlData<PokemonType>("data/type.xml");
                    foreach (var type in xmlData)
                    {
                        output.InserirNoFim(type);
                    }
                    Repository.Types = output;
                }
                catch (Exception error)
                {
                    throw error;
                }
            }

            return Repository.Types;
        }

        public override PokemonType GetById(int id)
        {
            return GetAll().Find("TypeId", id);
        }
    }
}