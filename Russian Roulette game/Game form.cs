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
    public partial class Gunshotform : Form
    {
        public Gunshotform()
        {
            InitializeComponent();
        }

        private void buttonload_Click(object sender, EventArgs e)
        {
            Spin.Enabled = true;
            Load.Enabled = false;

            //code to display image in picture box on button click  
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream myStream = myAssembly.GetManifestResourceStream("Gunshotform.Resources.load.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            picturebox.Image = bmp_Object;

        }

        private void buttonspin_Click(object sender, EventArgs e)
        {
            Shoot.Enabled = true;//disabling shoot button
            Spin.Enabled = false;

        }

        private void buttonshoot_Click(object sender, EventArgs e)
        {
            ShootAway.Enabled = true;//disabling ShootAway button
            Shoot.Enabled = false;
        }

        private void buttonshootaway_Click(object sender, EventArgs e)
        {
            Shoot.Enabled = true;//disabling shoot button
            ShootAway.Enabled = false;
        }

        private void buttonplayagain_Click(object sender, EventArgs e)
        {
            Load.Enabled = true;//disabling load button
            Spin.Enabled = false;
            Shoot.Enabled = false;
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Gunshotform_Load(object sender, EventArgs e)
        {

        }

        private void btnpicturebox(object sender, EventArgs e)
        {

        }
    }
}
