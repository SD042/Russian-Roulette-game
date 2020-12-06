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
            Gunshotform game_obj = new Gunshotform();
            game_obj.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
