using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonApp.App_Code.Entities;
using PokemonApp.Forms;
using PokemonApp.App_Code.Data.Repository;

namespace PokemonApp.UserControlls
{
    public partial class UCPokemon : UserControl
    {
        private Pokemon pokemon;
        public UCPokemon(Pokemon _pokemon)
        {
            InitializeComponent();
            pokemon = _pokemon;
            lbNumber.Text = "#" + pokemon.PokemonId.ToString();
            lbName.Text = pokemon.Name;
            lbType.Text = pokemon.GetTypeName(pokemon.Type);
            pbImage.ImageLocation = "data/images/" + pokemon.Image;
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            PokemonDetail detail = new PokemonDetail(pokemon);
            detail.ShowDialog();
        }

        private void btCapture_Click(object sender, EventArgs e)
        {
            var capture = new PokemonCapture();
            capture.DoCapture(pokemon, new InventoryRepository().GetById(1));
            MessageBox.Show("Pokemon capturado com sucesso!");
        }
    }
}
