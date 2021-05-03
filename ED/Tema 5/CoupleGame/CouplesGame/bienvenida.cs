using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CouplesGame
{
    public partial class bienvenida : Form
    {
        public static int cont = 0;
        public static SoundPlayer player = new SoundPlayer();
        public bienvenida()
        {
            InitializeComponent();
            player.SoundLocation = "C:\\Users\\Gabriel\\Desktop\\CouplesGame\\CouplesGame\\Resources\\JurassicPark.wav";
            player.Play();
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            menu ventanaMenu = new menu();
            this.Hide();
            ventanaMenu.Show();
        }

        private void btn_musica_Click(object sender, EventArgs e)
        {
            
            if (cont == 0)
            {
                Image imagenmusicaoff = new Bitmap(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\BotonMusicaOFF.png");
                btn_musica.BackgroundImage = imagenmusicaoff;
                player.Stop();
                cont++;
            }
            else
            {
                Image imagenmusicaon = new Bitmap(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\BotonMusicaOn.png");
                btn_musica.BackgroundImage = imagenmusicaon;
                player.Play();
                cont--;
            }
        }
    }
}
