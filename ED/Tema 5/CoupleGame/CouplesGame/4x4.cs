using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CouplesGame
{
    
    public partial class Form1 : Form
    {
       
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Records.mdf;Integrated Security = True";
        Label firstClicked = null;
        Label secondClicked = null;
        public static Image aux2 = null;
        public static Image aux = null;
        int seg = 0, min = 0, hr = 0;

        public static Image naipenegro = Image.FromFile(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\naipenegro.png");
        public static Image im1 = Image.FromFile(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\Naipe1.png");
        public static Image im2 = Image.FromFile(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\Naipe2.png");
        public static Image im3 = Image.FromFile(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\Naipe3.png");
        public static Image im4 = Image.FromFile(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\Naipe4.png");
        public static Image im5 = Image.FromFile(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\Naipe5.png");
        public static Image im6 = Image.FromFile(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\Naipe6.png");
        public static Image im7 = Image.FromFile(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\Naipe7.png");
        public static Image im8 = Image.FromFile(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\Naipe8.png");

        Random random = new Random();
        List<Image> icons = new List<Image>()
        {
            im1,im1,im2,im2,im3,im3,im4,im4,
            im5,im5,im6,im6,im7,im7,im8,im8
        };

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.BackgroundImage = icons[randomNumber];
                    iconLabel.Image = naipenegro;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        public Form1()
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

            AssignIconsToSquares();
            timer2.Enabled = false;
            tableLayoutPanel1.Enabled = false;
            label1.BackgroundImageLayout = ImageLayout.Center;
            label2.BackgroundImageLayout = ImageLayout.Center;
            label3.BackgroundImageLayout = ImageLayout.Center;
            label4.BackgroundImageLayout = ImageLayout.Center;
            label5.BackgroundImageLayout = ImageLayout.Center;
            label6.BackgroundImageLayout = ImageLayout.Center;
            label7.BackgroundImageLayout = ImageLayout.Center;
            label8.BackgroundImageLayout = ImageLayout.Center;
            label9.BackgroundImageLayout = ImageLayout.Center;
            label10.BackgroundImageLayout = ImageLayout.Center;
            label11.BackgroundImageLayout = ImageLayout.Center;
            label12.BackgroundImageLayout = ImageLayout.Center;
            label13.BackgroundImageLayout = ImageLayout.Center;
            label14.BackgroundImageLayout = ImageLayout.Center;
            label15.BackgroundImageLayout = ImageLayout.Center;
            label16.BackgroundImageLayout = ImageLayout.Center;
            MessageBox.Show("Introduce tu nombre para poder guardar el record.");
        }

        private void label_Click(object sender, EventArgs e)
        {

          
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.Image == null)
                    return;
                
                
                
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    aux = firstClicked.Image;
                    firstClicked.Image = null;
                    return;
                }

                
                secondClicked = clickedLabel;
                aux2 = secondClicked.Image;
                secondClicked.Image = null;
                   
                
                
                
                CheckForWinner();

                if (firstClicked.BackgroundImage == secondClicked.BackgroundImage)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;

                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
                

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.Image = Image.FromFile(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\naipenegro.png"); 
            secondClicked.Image = Image.FromFile(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\naipenegro.png"); 
            firstClicked = null;
            secondClicked = null;
        }

        /// <summary>
        /// Check every icon to see if it is matched, by
        /// comparing its foreground color to its background color.
        /// If all of the icons are matched, the player wins
        /// </summary>
        private void CheckForWinner()
        {
            menu ventanaMenu = new menu();

            foreach (Control control in tableLayoutPanel1.Controls) 
            { 
                Label iconLabel = control as Label;
                if (iconLabel.Image != null) 
                {    
                    return; 
                }
            }

            tableLayoutPanel1.Visible = false;

            String nom = textBox1.Text;
            String segundo = seg.ToString();
            String minuto = min.ToString();
            String hora = hr.ToString();
            String tiempoS = hora + ":" + minuto + ":" + segundo;
            DateTime tiempo = Convert.ToDateTime(tiempoS);
            timer2.Enabled = false;
            MessageBox.Show("Ha hecho coincidir todos los iconos!", "Enhorabuena");

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                var sql = "INSERT INTO [dbo].[Table](NOMBRE,TIEMPO) VALUES (@nom, @tiempo)";
                using (var cmd = new SqlCommand(sql, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@tiempo", tiempo);
                    cmd.ExecuteNonQuery();
                }
            }

            this.Close();
            ventanaMenu.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            menu ventanaMenu = new menu();
            this.Close();
            ventanaMenu.Show();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)){
                MessageBox.Show("Primero introduce un nombre para poder guardar tu record.");
            }   
            else
            {
                textBox1.Visible = false;
                timer2.Enabled = true;
                tableLayoutPanel1.Enabled = true;
            } 
        }

        private void btnPaus_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled != false)
            {
                Image imageReanu = new Bitmap(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\BotonReanudar.png");
                btnPaus.BackgroundImage = imageReanu;
                timer2.Enabled = false;
               
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
            }
            else {
                Image imagePaus = new Bitmap(@"C:\Users\Gabriel\Desktop\CouplesGame\CouplesGame\Resources\BotonPausar.png");
                btnPaus.BackgroundImage = imagePaus;
                timer2.Enabled = true;
                tableLayoutPanel1.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
                label6.Enabled = true;
                label7.Enabled = true;
                label8.Enabled = true;
                label9.Enabled = true;
                label10.Enabled = true;
                label11.Enabled = true;
                label12.Enabled = true;
                label13.Enabled = true;
                label14.Enabled = true;
                label15.Enabled = true;
                label16.Enabled = true;
            } 
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }
            else if(min == 60)
            {
                hr++;
                min = 0;
            }
            lbl_cont.Text = hr.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');
        }
    }
}
