using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio18
{
    public partial class Form1 : Form
    {
        String texto = "TEXTO";
        FontFamily[] fuentes;

        InstalledFontCollection installedFontCollection = new InstalledFontCollection();

        
  
        public Form1()
        {
            fuentes = new InstalledFontCollection().Families;
            InitializeComponent();
            foreach (FontFamily x in fuentes)
            {
                lbox_Fuentes.Items.Add(x.Name);
            }

        }

        private void buttonAumentar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(Size.Width + 25, Size.Height + 25);
            
        }

        private void buttonReducir_Click(object sender, EventArgs e)
        {
            this.Size = new Size(Size.Width - 25, Size.Height - 25);
        }

        private void buttonGreenForm_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void buttonPurpleForm_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void buttonRedForm_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void buttonNormalForm_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Empty;
        }

        private void numericUpDownTxt_ValueChanged(object sender, EventArgs e)
        {
            int size =(int) numericUpDownTxt.Value;
            labeltxt.Font = new Font(labeltxt.Font.FontFamily,size,labeltxt.Font.Style);
            
        }

        private void buttonGreenTxt_Click(object sender, EventArgs e)
        {
            labeltxt.ForeColor = System.Drawing.Color.Green;
        }

        private void buttonPurpleTxt_Click(object sender, EventArgs e)
        {
            labeltxt.ForeColor = System.Drawing.Color.Purple;
        }

        private void buttonRedTxt_Click(object sender, EventArgs e)
        {
            labeltxt.ForeColor = System.Drawing.Color.Red;
        }

        private void buttonNormalTxt_Click(object sender, EventArgs e)
        {
            labeltxt.ForeColor = System.Drawing.Color.Black;
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            labeltxt.Text = "";
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            labeltxt.Text = texto;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxBold_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxBold.Checked)
            {
                labeltxt.Font = new Font(labeltxt.Font, labeltxt.Font.Style | FontStyle.Bold);
            }
            else
            {
                labeltxt.Font = new Font(labeltxt.Font, labeltxt.Font.Style ^ FontStyle.Bold);
            }
        }

        private void checkBoxItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBold.Checked)
            {
                labeltxt.Font = new Font(labeltxt.Font, labeltxt.Font.Style | FontStyle.Italic);
            }
            else
            {
                labeltxt.Font = new Font(labeltxt.Font, labeltxt.Font.Style ^ FontStyle.Italic);
            }
        }

        private void checkBoxUnder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBold.Checked)
            {
                labeltxt.Font = new Font(labeltxt.Font, labeltxt.Font.Style | FontStyle.Underline);
            }
            else
            {
                labeltxt.Font = new Font(labeltxt.Font, labeltxt.Font.Style ^ FontStyle.Underline);
            }
        }

        private void lbox_Fuentes_SelectedIndexChanged(object sender, EventArgs e)
        {

            int size = (int)numericUpDownTxt.Value;
            labeltxt.Font = new Font(fuentes[lbox_Fuentes.SelectedIndex].Name, lbox_Fuentes.Font.Size, labeltxt.Font.Style);
        }
    }
}
