using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJER16CASH
{
    public partial class Form1 : Form
    {

        Guy joe;
        Guy bob;
        int banco = 100;
        public Form1()
        {
            InitializeComponent();
            joe = new Guy();
            bob = new Guy();
            joe.Nombre = "Joe";
            joe.Apellido = "Joe";
            joe.Cash = 100;
            bob.Nombre = "Bob";
            bob.Apellido = "Bob";
            bob.Cash = 50;
            ActualizaForm();
        }

        public void ActualizaForm() {
            lblJoeCash.Text = joe.Nombre + " tiene " + joe.Cash + " euros.";
            lblBobCash.Text = bob.Nombre + " tiene " + bob.Cash + " euros.";
            lblSaldo.Text = "La banca  tiene: " + banco + "eur.";
        }
        private void buttonGive_Click(object sender, EventArgs e)
        {
            if (banco >= 10)
            {
                joe.Cash = joe.Cash + 10;
                banco = banco - 10;
                ActualizaForm();
            }
            else {
                MessageBox.Show("Estamos en BANCA ROTA");
            }
        }

        private void buttonReceive_Click(object sender, EventArgs e)
        {
            if (bob.Cash >= 5)
            {
                banco = banco + 5;
                bob.Cash = bob.Cash - 5;
                ActualizaForm();
            }
            else
            {
                MessageBox.Show("No tengo saldo suficiente como para darle 5 euros");
            }
        }

        private void buttonJoeaBob_Click(object sender, EventArgs e)
        {
            if (joe.Cash >= 10)
            {
                joe.Cash = joe.Cash - 10;
                bob.Cash = bob.Cash + 10;
                ActualizaForm();
            }
            else
            {
                MessageBox.Show("No tengo saldo suficiente como para darle 5 euros");
            }
        }

        private void buttonBobaJoe_Click(object sender, EventArgs e)
        {
            if (bob.Cash >= 5)
            {
                bob.Cash = bob.Cash - 5;
                joe.Cash = joe.Cash + 5;
                ActualizaForm();
            }
            else
            {
                MessageBox.Show("No tengo saldo suficiente como para darle 5 euros");
            }
        }
    }
}
