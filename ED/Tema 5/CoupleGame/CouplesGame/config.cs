using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouplesGame
{
    public partial class config : Form
    {
        
        public config()
        {
            InitializeComponent();
            if (bienvenida.cont == 0)
            {
                Image imagenmusicaon = new Bitmap(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\BotonMusicaOn.png");
                btn_musica.BackgroundImage = imagenmusicaon;


            }
            else
            {
                Image imagenmusicaoff = new Bitmap(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\BotonMusicaOFF.png");
                btn_musica.BackgroundImage = imagenmusicaoff;

            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            menu ventanaMenu = new menu();
            this.Close();
            ventanaMenu.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_musica_Click(object sender, EventArgs e)
        {
            if (bienvenida.cont == 0)
            {
                Image imagenmusicaoff = new Bitmap(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\BotonMusicaOFF.png");
                btn_musica.BackgroundImage = imagenmusicaoff;
                bienvenida.player.Stop();
                bienvenida.cont++;
            }
            else
            {
                Image imagenmusicaon = new Bitmap(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\BotonMusicaOn.png");
                btn_musica.BackgroundImage = imagenmusicaon;
                bienvenida.player.Play();
                bienvenida.cont--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bienvenida.naipe = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bienvenida.naipe = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bienvenida.naipe = 3;
        }

        /*private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }*/
    }
}
