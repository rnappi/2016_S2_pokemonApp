using System;

namespace PokemonApp.App_Code.CrossCutting.Collections
{
    public class RNListItem
    {
        public Object Dado { get; set; }
        public RNListItem Proximo { get; set; }
        public RNListItem Anterior { get; set; }

        public RNListItem()
        {
            Dado = null;
            Proximo = null;
            Anterior = null;
        }
    }
}