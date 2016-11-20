using PokemonApp.App_Code.Data.Repository;
using System;

namespace PokemonApp.App_Code.Entities
{
    public class PokemonCapture
    {
        public void DoCapture(Pokemon pokemon, Inventory inventory)
        {
            try
            {
                inventory.AddPokemon(pokemon);
                var inventoryRepository = new InventoryRepository();
                inventoryRepository.Save();
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}