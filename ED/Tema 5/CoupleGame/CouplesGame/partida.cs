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
    public partial class partida : Form
    {
        public partida()
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

        private void btn_4x4_Click(object sender, EventArgs e)
        {
            Form1 ventanaForm1 = new Form1();
            this.Close();
            ventanaForm1.Show();
        }

        private void btn_6x6_Click(object sender, EventArgs e)
        {
            _6x6 ventana_6x6 = new _6x6();
            this.Close();
            ventana_6x6.Show();
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
    }
}
