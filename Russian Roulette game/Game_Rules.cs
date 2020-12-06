using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roulette_game
{
    public partial class Game_Rules : Form
    {
        public Game_Rules()
        {
            InitializeComponent();
        }

        private void btn_Back(object sender, EventArgs e)
        {
            Game_Rules game_obj = new Game_Rules();
            game_obj.Show();
            this.Hide();
        }
    }
}
