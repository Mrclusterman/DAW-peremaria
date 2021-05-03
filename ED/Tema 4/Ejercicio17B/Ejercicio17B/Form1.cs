using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio17B
{
    public partial class Form1 : Form
    {
        Triangulo triangulo1;

        public Form1()
        {
            InitializeComponent();
            triangulo1 = new Triangulo();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            triangulo1.LadoBase = (int)Convert.ToDouble(textBoxBase.Text);
            triangulo1.LadoLibre = (int)Convert.ToDouble(textBoxLado.Text);
            triangulo1.Altura = (int)Convert.ToDouble(textBoxAltura.Text);
            triangulo1.crear();
            buttonArea.Enabled = true;
            buttonEquilatero.Enabled = true;
            buttonLadoMayor.Enabled = true;
        }

        private void buttonEquilatero_Click(object sender, EventArgs e)
        {
            triangulo1.EsEquilatero();
        }

        private void buttonLadoMayor_Click(object sender, EventArgs e)
        {
            triangulo1.LadoMayor();
        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            triangulo1.Area();
        }
    }
}
