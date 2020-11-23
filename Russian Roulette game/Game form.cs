using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Russian_Roulette_game.Properties;

namespace Russian_Roulette_game
{
    public partial class Gunshotform : Form
    {
        Game_logic logic_obj = new Game_logic();


        public Gunshotform()
        {
            InitializeComponent();
        }

        private void buttonload_Click(object sender, EventArgs e)
        {
            Spin.Enabled = true;//Enablingbling spin button
            Load.Enabled = false;//Disabling load button

            //code to display image in picture box on button click  
            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Roulette_game.Resources.load.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            picturebox.Image = bmp_Object;

            //sound code
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Russian_Roulette_game.Properties.Resources.load1);

            Sound_Object.Play();



        }

        private void buttonspin_Click(object sender, EventArgs e)
        {
            Shoot.Enabled = true;//Enabling shoot button
            Spin.Enabled = false;//disabling spin button
            //code to display image in picture box on button click  

           Assembly myAssembly = Assembly.GetExecutingAssembly(); 

           Stream myStream = myAssembly.GetManifestResourceStream("Russian_Roulette_game.Resources.Spin.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            picturebox.Image = bmp_Object;

            MessageBox.Show("Bullet position after spining the chamber is" + logic_obj.spin_position.ToString());

        }

        private void buttonshoot_Click(object sender, EventArgs e)
        {
            ShootAway.Enabled = true;//Enabling ShootAway button
            Shoot.Enabled = false;//Disabling Shoot button
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Roulette_game.Resources.shoot.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            picturebox.Image = bmp_Object;

            logic_obj.shoot_position = logic_obj.shoot();
            if (logic_obj.shoot_position == 1)
            {
                MessageBox.Show("Bullet shoot on your head.You are dead");
            }
            else
            {
                MessageBox.Show("empty shoot");
            }
        }

        private void buttonshootaway_Click(object sender, EventArgs e)
        {


            Shoot.Enabled = true;//disabling shoot button
            ShootAway.Enabled = false;
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Roulette_game.Resources.Shoot_Away.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            picturebox.Image = bmp_Object;

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Russian_Roulette_game.Properties.Resources.shootaway);

            Sound_Object.Play();






        }

        private void buttonplayagain_Click(object sender, EventArgs e)
        {
            Application.Restart();
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
