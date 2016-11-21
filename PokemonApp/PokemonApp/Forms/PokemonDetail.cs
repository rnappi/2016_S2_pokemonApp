using PokemonApp.App_Code.Entities;
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
    public partial class PokemonDetail : Form
    {
        private Pokemon pokemon { get; set; }
        public PokemonDetail(Pokemon _pokemon)
        {
            InitializeComponent();
            pokemon = _pokemon;

            pbImage.ImageLocation = "data/images/" + pokemon.Image;
            lbName.Text = pokemon.Name + " #" + pokemon.PokemonId.ToString();
            lbHeight.Text = "Height: " + pokemon.Height.ToString() + " Kg";
            lbWeight.Text = "Weight: " + pokemon.Weight.ToString() + " mm";

            lbHp.Text = "HP: " + pokemon.Hp.ToString();
            lbAttack.Text = "Attack: " + pokemon.Attack.ToString();
            lbDefense.Text = "Defense: " + pokemon.Defense.ToString();
            lbSAttack.Text = "Special Attack: " + pokemon.SpAttack.ToString();
            lbSDefense.Text = "Special Defense: " + pokemon.SpDefense.ToString();
            lbSpeed.Text = "Speed: " + pokemon.Speed.ToString();

            lbType.Text = pokemon.GetTypeName(pokemon.Type);
            tbWeakness.Text = pokemon.GetTypeName(pokemon.Weakness);
            tbSuperEffective.Text = pokemon.GetTypeName(pokemon.SuperEffective);
        }

        private void btAttack_Click(object sender, EventArgs e)
        {
            PokemonAttack pa = new PokemonAttack(pokemon.Moves);
            pa.ShowDialog();
        }
    }
}
