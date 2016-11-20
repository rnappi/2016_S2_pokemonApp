using PokemonApp.App_Code.CrossCutting.Collections;
using PokemonApp.App_Code.Entities;
using System;

namespace PokemonApp.App_Code.Data.Repository
{
    public class MoveRepository : RepositoryBase<Move>
    {
        public override RNList<Move> GetAll()
        {
            if (Repository.Moves == null)
            {
                try
                {
                    var output = new RNList<Move>();
                    var xmlData = XmlLoadData.LoadXmlData<Move>("data/move.xml");
                    foreach (var move in xmlData)
                    {
                        output.InserirNoFim(move);
                    }
                    Repository.Moves = output;
                }
                catch (Exception error)
                {
                    throw error;
                }
            }

            return Repository.Moves;
        }

        public override Move GetById(int id)
        {
            return GetAll().Find("MoveId", id);
        }
    }
}