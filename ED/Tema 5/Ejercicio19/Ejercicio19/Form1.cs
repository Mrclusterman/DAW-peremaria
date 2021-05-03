using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio19
{
    public partial class Form1 : Form
    {
        int BotonPagar = 0;
        MenuComida menu;
        public Form1()
        {
            menu = new MenuComida();
            InitializeComponent();
            tBBurger.Text = menu.CantBurger.ToString();
            tBPapas.Text = menu.CantPapas.ToString();
            tBSoda.Text = menu.CantSoda.ToString();
            tBPizza.Text = menu.CantPizza.ToString();
            tBNugget.Text = menu.CantNugget.ToString();
            tBSalad.Text = menu.CantSalad.ToString();
            tBYogur.Text = menu.CantYogur.ToString();
            tBAgua.Text = menu.CantAgua.ToString();
        }

        private void rBttnHam_CheckedChanged(object sender, EventArgs e)
        {
            if (rBttnHam.Checked == true)
            {
                btnnMenuHamResta.Visible = true;
                btnnMenuHamSuma.Visible = true;
            }
            else {
                btnnMenuHamResta.Visible = false;
                btnnMenuHamSuma.Visible = false;
            }
        }

        private void rBttnPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (rBttnPizza.Checked == true)
            {
                btnnMenuPizzaSuma.Visible = true;
                btnnMenuPizzaResta.Visible = true;
            }
            else
            {
                btnnMenuPizzaSuma.Visible = false;
                btnnMenuPizzaResta.Visible = false;
            }
           
        }

        private void rBttnEnsalada_CheckedChanged(object sender, EventArgs e)
        {
            if (rBttnEnsalada.Checked == true)
            {
                btnnMenuEnsSuma.Visible = true;
                btnnMenuEnsResta.Visible = true;
            }
            else
            {
                btnnMenuEnsSuma.Visible = false;
                btnnMenuEnsResta.Visible = false;
            }
    
        }

        private void rBttnOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (rBttnOtro.Checked == true)
            {
                btnnBurgerResta.Visible = true;
                btnnBurgerSuma.Visible = true;
                bttnPapasSuma.Visible = true;
                bttnPapasResta.Visible = true;
                bttnSodaResta.Visible = true;
                bttnSodaSuma.Visible = true;
                bttnPizzaResta.Visible = true;
                bttnPizzaSuma.Visible = true;
                bttnNuggetResta.Visible = true;
                bttnNuggetSuma.Visible = true;
                bttnSaladResta.Visible = true;
                bttnSaladSuma.Visible = true;
                bttnYogurResta.Visible = true;
                bttnYogurSuma.Visible = true;
                bttnAguaResta.Visible = true;
                bttnAguaSuma.Visible = true;
            }
            else {
                btnnBurgerResta.Visible = false;
                btnnBurgerSuma.Visible = false;
                bttnPapasSuma.Visible = false;
                bttnPapasResta.Visible = false;
                bttnSodaResta.Visible = false;
                bttnSodaSuma.Visible = false;
                bttnPizzaResta.Visible = false;
                bttnPizzaSuma.Visible = false;
                bttnNuggetResta.Visible = false;
                bttnNuggetSuma.Visible = false;
                bttnSaladResta.Visible = false;
                bttnSaladSuma.Visible = false;
                bttnYogurResta.Visible = false;
                bttnYogurSuma.Visible = false;
                bttnAguaResta.Visible = false;
                bttnAguaSuma.Visible = false;
            }
        }

        private void btnnBurgerSuma_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBBurger.Text);
            if (valor < 5)
            {
                menu.CantBurger++;
                tBBurger.Text = menu.CantBurger.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se pueden añadir mas de 5 cantidades", "Error", buttons);
            }

        }

        private void btnnBurgerResta_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBBurger.Text);
            if (valor >= 1)
            {
                menu.CantBurger--;
                tBBurger.Text = menu.CantBurger.ToString();
            }
            else {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se puede restar a 0", "Error", buttons);
            }
        }

        private void bttnPapasSuma_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBPapas.Text);
            if (valor < 5)
            {
                menu.CantPapas++;
                tBPapas.Text = menu.CantPapas.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se pueden añadir mas de 5 cantidades", "Error", buttons);
            }
        }

        private void bttnPapasResta_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBPapas.Text);
            if (valor >= 1)
            {
                menu.CantPapas--;
                tBPapas.Text = menu.CantPapas.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se puede restar a 0", "Error", buttons);
            }
        }

        private void bttnSodaSuma_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBSoda.Text);
            if (valor < 5)
            {
                menu.CantSoda++;
                tBSoda.Text = menu.CantSoda.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se pueden añadir mas de 5 cantidades", "Error", buttons);
            }
        }

        private void bttnSodaResta_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBSoda.Text);
            if (valor >= 1)
            {
                menu.CantSoda--;
                tBSoda.Text = menu.CantSoda.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se puede restar a 0", "Error", buttons);
            }
        }

        private void bttnPizzaSuma_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBPizza.Text);
            if (valor < 5)
            {
                menu.CantPizza++;
                tBPizza.Text = menu.CantPizza.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se pueden añadir mas de 5 cantidades", "Error", buttons);
            }
        }

        private void bttnPizzaResta_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBPizza.Text);
            if (valor >= 1)
            {
                menu.CantPizza--;
                tBPizza.Text = menu.CantPizza.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se puede restar a 0", "Error", buttons);
            }
        }

        private void bttnNuggetSuma_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBNugget.Text);
            if (valor < 5)
            {
                menu.CantNugget++;
                tBNugget.Text = menu.CantNugget.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se pueden añadir mas de 5 cantidades", "Error", buttons);
            }
        }

        private void bttnNuggetResta_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBNugget.Text);
            if (valor >= 1)
            {
                menu.CantNugget--;
                tBNugget.Text = menu.CantNugget.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se puede restar a 0", "Error", buttons);
            }
        }

        private void bttnSaladSuma_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBSalad.Text);
            if (valor < 5)
            {
                menu.CantSalad++;
                tBSalad.Text = menu.CantSalad.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se pueden añadir mas de 5 cantidades", "Error", buttons);
            }
        }

        private void bttnSaladResta_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBSalad.Text);
            if (valor >= 1)
            {
                menu.CantSalad--;
                tBSalad.Text = menu.CantSalad.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se puede restar a 0", "Error", buttons);
            }
        }

        private void bttnYogurSuma_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBYogur.Text);
            if (valor < 5)
            {
                menu.CantYogur++;
                tBYogur.Text = menu.CantYogur.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se pueden añadir mas de 5 cantidades", "Error", buttons);
            }
        }

        private void bttnYogurResta_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBYogur.Text);
            if (valor >= 1)
            {
                menu.CantYogur--;
                tBYogur.Text = menu.CantYogur.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se puede restar a 0", "Error", buttons);
            }
        }

        private void bttnAguaSuma_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBAgua.Text);
            if (valor < 5)
            {
                menu.CantAgua++;
                tBAgua.Text = menu.CantAgua.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se pueden añadir mas de 5 cantidades", "Error", buttons);
            }
        }

        private void bttnAguaResta_Click(object sender, EventArgs e)
        {
            int valor = Int16.Parse(tBAgua.Text);
            if (valor >= 1)
            {
                menu.CantAgua--;
                tBAgua.Text = menu.CantAgua.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se puede restar a 0", "Error", buttons);
            }
        }

        private void btnnMenuHamSuma_Click(object sender, EventArgs e)
        {
            if (menu.ContMenuBurguer < 5 && menu.CantSoda < 5) {
                menu.ContMenuBurguer++;
                menu.CantBurger++;
                tBBurger.Text = menu.CantBurger.ToString();
                menu.CantPapas++;
                tBPapas.Text = menu.CantPapas.ToString();
                menu.CantSoda++;
                tBSoda.Text = menu.CantSoda.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se pueden añadir mas de 5 cantidades", "Error", buttons);
            }
        }

        private void btnnMenuHamResta_Click(object sender, EventArgs e)
        {
            if (menu.ContMenuBurguer >= 1)
            {
                menu.ContMenuBurguer--;
                menu.CantBurger--;
                tBBurger.Text = menu.CantBurger.ToString();
                menu.CantPapas--;
                tBPapas.Text = menu.CantPapas.ToString();
                menu.CantSoda--;
                tBSoda.Text = menu.CantSoda.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se puede restar a 0", "Error", buttons);
            }
        }

        private void btnnMenuPizzaSuma_Click(object sender, EventArgs e)
        {
            if (menu.ContMenuPizza < 5 && menu.CantSoda < 5)
            {
                menu.ContMenuPizza++;
                menu.CantPizza++;
                tBPizza.Text = menu.CantPizza.ToString();
                menu.CantNugget++;
                tBNugget.Text = menu.CantNugget.ToString();
                menu.CantSoda++;
                tBSoda.Text = menu.CantSoda.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se pueden añadir mas de 5 cantidades", "Error", buttons);
            }
        }

        private void btnnMenuPizzaResta_Click(object sender, EventArgs e)
        {
            if (menu.ContMenuPizza >= 1)
            {
                menu.ContMenuPizza--;
                menu.CantPizza--;
                tBPizza.Text = menu.CantPizza.ToString();
                menu.CantNugget--;
                tBNugget.Text = menu.CantNugget.ToString();
                menu.CantSoda--;
                tBSoda.Text = menu.CantSoda.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se puede restar a 0", "Error", buttons);
            }

        }

        private void btnnMenuEnsSuma_Click(object sender, EventArgs e)
        {
            if (menu.ContMenuSalad < 5)
            {
                menu.ContMenuSalad++;
                menu.CantSalad++;
                tBSalad.Text = menu.CantSalad.ToString();
                menu.CantYogur++;
                tBYogur.Text = menu.CantYogur.ToString();
                menu.CantAgua++;
                tBAgua.Text = menu.CantAgua.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se pueden añadir mas de 5 cantidades", "Error", buttons);
            }
        }

        private void btnnMenuEnsResta_Click(object sender, EventArgs e)
        {
            if (menu.ContMenuSalad >= 1)
            {
                menu.ContMenuSalad--;
                menu.CantSalad--;
                tBSalad.Text = menu.CantSalad.ToString();
                menu.CantYogur--;
                tBYogur.Text = menu.CantYogur.ToString();
                menu.CantAgua--;
                tBAgua.Text = menu.CantAgua.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se puede restar a 0", "Error", buttons);
            }
        }

        private void bttnPagar_Click(object sender, EventArgs e)
        {
            BotonPagar++;
            double cantidadSubTotal = Convert.ToDouble(menu.CantBurger) * menu.PrecioBurger + Convert.ToDouble(menu.CantPapas) * menu.PrecioPapas + Convert.ToDouble(menu.CantSoda) * menu.PrecioSoda + Convert.ToDouble(menu.CantPizza) * menu.PrecioPizza + Convert.ToDouble(menu.CantNugget) * menu.PrecioNugget + Convert.ToDouble(menu.CantSalad) * menu.PrecioSalad + Convert.ToDouble(menu.CantYogur) * menu.PrecioYogur + Convert.ToDouble(menu.CantAgua) * menu.PrecioAgua;
            double cantidadTotal = cantidadSubTotal * 1.16;
            double cantidadIva = cantidadTotal - cantidadSubTotal;
            if (BotonPagar == 1) {

                tBSubTotal.Text = "$" + cantidadSubTotal.ToString();
                tBPago.Text = "$" + cantidadTotal.ToString();
                tBIVA.Text = "$" + cantidadIva.ToString();
            }
            if (BotonPagar == 2) {
                if (mTextBoxCP.Text != "") {
                    double devuelta = Double.Parse(tBPagado.Text) - cantidadTotal;
                    tBVuelta.Text = "$" + devuelta.ToString();
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Pago realiazdo con exito", "Gracias por su compra", buttons);

                }
                else
                {
                    BotonPagar--;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Debe introducir un codifo postal", "Error", buttons);
                }

            }
        }

        private void bttnNew_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result =MessageBox.Show("¿Desea reiniciar el programa?", "Sistema", buttons);
            if (result == DialogResult.Yes)
            {
                Application.Restart();

            }
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show("¿Desea salir del programa?", "Sistema", buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
            
        }
    }
}
