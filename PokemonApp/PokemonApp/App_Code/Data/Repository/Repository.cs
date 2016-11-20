using PokemonApp.App_Code.CrossCutting.Collections;
using PokemonApp.App_Code.Entities;

namespace PokemonApp.App_Code.Data.Repository
{
    public static class Repository
    {
        public static RNList<Pokemon> Pokemons { get; set; }
        public static RNList<PokemonType> Types { get; set; }
        public static RNList<Move> Moves { get; set; }
        public static RNList<Inventory> Inventories { get; set; }
    }
}
