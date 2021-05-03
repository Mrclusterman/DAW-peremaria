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
    public partial class menu : Form
    {
        
        public menu()
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

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            partida ventanaPartida = new partida();
            this.Hide();
            ventanaPartida.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show("¿Desea salir del juego?", "Sistema", buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btn_records_Click(object sender, EventArgs e)
        {
            Record ventanaRecord = new Record();
            this.Hide();
            ventanaRecord.Show();
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
