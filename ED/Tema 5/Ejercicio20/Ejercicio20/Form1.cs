using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio20
{
    public partial class Form1 : Form
    {
        ToolTip toolTip1 = new ToolTip();
        public Form1()
        {
            InitializeComponent();
            this.mskTBFecha.Mask = "00/00/0000";
            this.mskTBFecha.ValidatingType = typeof(DateTime);
            this.mskTBFecha.TypeValidationCompleted += new TypeValidationEventHandler(mskTBFecha_TypeValidationCompleted);
            this.mskTBHora.Mask = "00:00";
            this.mskTBHora.ValidatingType = typeof(DateTime);
            this.mskTBID.Mask = "V00000000";
            this.mskTBID.ValidatingType = typeof(String);
            this.mskTBMatricula.Mask = "0000LLL";
            this.mskTBMatricula.ValidatingType = typeof(String);
            this.mskTBTlf.Mask = "000000000";
            this.mskTBTlf.ValidatingType = typeof(String);
            this.mskTBPrecio.Mask = "00000000€";
            this.mskTBPrecio.ValidatingType = typeof(String);
        }

        private void buttonRellenar_Click(object sender, EventArgs e)
        {

        }
        void mskTBFecha_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "Fecha Inválida";
                toolTip1.Show("La fecha introducida no es válida", mskTBFecha, 0, 20, 5000);
                e.Cancel = true;
            }
  
        }
        private void mskTBHora_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "ERROR";
                toolTip1.Show("La hora introducida no es válida", mskTBHora, 0, 20, 5000);
                e.Cancel = true;
            }
        }

        private void mskTBID_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput || mskTBID.Text.Substring(0, 1) != "V")
            {
                if (!mskTBID.MaskCompleted)
                {
                    toolTip1.ToolTipTitle = "Id incorrecto";
                    toolTip1.Show("Letra y los 8 números de Dni", mskTBID, 0, 20, 5000);
                    e.Cancel = true;
                    mskTBID.Focus();
                }
                else
                {
                    toolTip1.ToolTipTitle = "Id incorrecto";
                    toolTip1.Show("El Id debe comenzar por V", mskTBID, 0, 20, 5000);
                    e.Cancel = true;
                    mskTBID.Focus();
                }
            }
            else
            {
                mskTBTlf.Focus();
            }
        }
        private void mskTBTlf_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "ERROR";
                toolTip1.Show("El teléfono introducido no es válido", mskTBTlf, 0, 20, 5000);
                e.Cancel = true;
            }
        }
        private void mskTBPrecio_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "ERROR";
                toolTip1.Show("El precio introducido no es válido", mskTBPrecio, 0, 20, 5000);
                e.Cancel = true;
            }
        }
        private void mskTBMatricula_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "ERROR";
                toolTip1.Show("La matrícula introducida no es válida", mskTBMatricula, 0, 20, 5000);
                e.Cancel = true;
            }
        }
    }
}
