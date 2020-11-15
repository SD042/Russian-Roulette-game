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
            //code to display image in picture box on button click  

            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();

            System.IO.Stream myStream = myAssembly.GetManifestResourceStream("Gunshotform.Resources.load.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            picturebox.Image = bmp_Object;

        }

        private void buttonspin_Click(object sender, EventArgs e)
        {

        }

        private void buttonshoot_Click(object sender, EventArgs e)
        {

        }

        private void buttonshootaway_Click(object sender, EventArgs e)
        {

        }

        private void buttonplayagain_Click(object sender, EventArgs e)
        {

        }

        private void buttonexit_Click(object sender, EventArgs e)
        {

        }

        private void Gunshotform_Load(object sender, EventArgs e)
        {

        }
    }
