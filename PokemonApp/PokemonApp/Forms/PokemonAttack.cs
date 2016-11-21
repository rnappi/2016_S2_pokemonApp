using PokemonApp.App_Code.Data.Repository;
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
    public partial class PokemonAttack : Form
    {
        public PokemonAttack(string AttackIds)
        {
            InitializeComponent();
            var Attackrepository = new MoveRepository();
            var arr = AttackIds.Split(';');
            foreach (var attackId in arr)
            {
                var attack = Attackrepository.GetById(Convert.ToInt32(attackId));
                tbAttack.Text += "Name: " + attack.Name + Environment.NewLine;
                tbAttack.Text += "Accuracy: " + attack.Accuracy + Environment.NewLine;
                tbAttack.Text += "Power: " + attack.Power + Environment.NewLine;
                tbAttack.Text += "PP: " + attack.Pp + Environment.NewLine;
                tbAttack.Text += Environment.NewLine;
            }
        }
    }
}
