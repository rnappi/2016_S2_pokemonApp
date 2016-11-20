using PokemonApp.App_Code.CrossCutting.Collections;
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
    public partial class Pokedex : Form
    {
        public RNList<Pokemon> Pokemons { get; set; }

        public Pokedex()
        {
            InitializeComponent();
        }

        private void Pokedex_Load(object sender, EventArgs e)
        {
            Pokemons = new PokemonRepository().GetAll();
            for (int i = 0; i < Pokemons.Count(); i++)
            {
                lpPokemons.Controls.Add(new UCPokemon(Pokemons.RetornarDaPosicao(i)));
            }
        }
    }
}
