using System;
using PokemonApp.App_Code.CrossCutting.Collections;
using PokemonApp.App_Code.Entities;
using System.Collections.Generic;

namespace PokemonApp.App_Code.Data.Repository
{
    public class InventoryRepository : RepositoryBase<Inventory>
    {
        public override RNList<Inventory> GetAll()
        {
            if (Repository.Inventories == null)
            {
                var output = new RNList<Inventory>();
                var xmlData = XmlLoadData.LoadXmlData<Inventory>("data/inventory.xml");
                foreach (var inventory in xmlData)
                {
                    output.InserirNoFim(inventory);
                }
                Repository.Inventories = output;
            }
            return Repository.Inventories;
        }

        public override Inventory GetById(int id)
        {
            return GetAll().Find("InventoryId", id);
        }

        public void Save()
        {
            var saveList = new List<Inventory>();
            var inventories = GetAll();
            for (int i = 0; i < inventories.Count(); i++)
                saveList.Add(inventories.RetornarDaPosicao(i));
            XmlLoadData.SaveXmlData<Inventory>(saveList, "data/inventory.xml");
        }
    }
}