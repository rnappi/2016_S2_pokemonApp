using PokemonApp.App_Code.Data.Repository;
using PokemonApp.App_Code.Entities;
using PokemonApp.UserControlls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonApp.Forms
{
    public partial class PokemonInventory : Form
    {
        private Inventory i;
        private InventoryRepository ir;
        public PokemonInventory()
        {
            InitializeComponent();
            ir = new InventoryRepository();
            i = ir.GetById(1);

            var pr = new PokemonRepository();
            var arr = i.Pokemons.Split(';');
            foreach (var pokemonId in arr)
            {
                lpPokemons.Controls.Add(new UCPokemonInventory(pr.GetById(Convert.ToInt32(pokemonId))));
            }
        }
    }
}
