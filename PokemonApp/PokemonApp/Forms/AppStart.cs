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
    public partial class AppStart : Form
    {
        public AppStart()
        {
            InitializeComponent();
        }

        private void btAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void btPokedex_Click(object sender, EventArgs e)
        {
            Pokedex pokedex = new Pokedex();
            pokedex.ShowDialog();
        }

        private void btInventory_Click(object sender, EventArgs e)
        {
            PokemonInventory inventory = new PokemonInventory();
            inventory.ShowDialog();
        }
    }
}
