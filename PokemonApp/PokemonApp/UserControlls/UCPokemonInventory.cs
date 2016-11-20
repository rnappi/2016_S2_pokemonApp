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

namespace PokemonApp.UserControlls
{
    public partial class UCPokemonInventory : UserControl
    {
        private Pokemon pokemon;
        public UCPokemonInventory(Pokemon _pokemon)
        {
            InitializeComponent();
            pokemon = _pokemon;
            pbImage.ImageLocation = "data/images/" + pokemon.Image;
            lbName.Text = pokemon.Name;
            lbNumber.Text = "#" + pokemon.PokemonId.ToString();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            PokemonDetail pd = new PokemonDetail(pokemon);
            pd.ShowDialog();
        }
    }
}
