
namespace Ejercicio17B
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.textBoxLado = new System.Windows.Forms.TextBox();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonEquilatero = new System.Windows.Forms.Button();
            this.buttonLadoMayor = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(46, 56);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(63, 25);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura";
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.Location = new System.Drawing.Point(46, 172);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(56, 25);
            this.lblLado.TabIndex = 1;
            this.lblLado.Text = "Lado";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(46, 115);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(57, 25);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAltura.Location = new System.Drawing.Point(144, 53);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(145, 30);
            this.textBoxAltura.TabIndex = 3;
            // 
            // textBoxBase
            // 
            this.textBoxBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBase.Location = new System.Drawing.Point(144, 110);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(146, 30);
            this.textBoxBase.TabIndex = 4;
            // 
            // textBoxLado
            // 
            this.textBoxLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLado.Location = new System.Drawing.Point(144, 169);
            this.textBoxLado.Name = "textBoxLado";
            this.textBoxLado.Size = new System.Drawing.Size(146, 30);
            this.textBoxLado.TabIndex = 5;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Location = new System.Drawing.Point(338, 100);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(117, 79);
            this.buttonCrear.TabIndex = 6;
            this.buttonCrear.Text = "Crear Triangulo";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonEquilatero
            // 
            this.buttonEquilatero.Enabled = false;
            this.buttonEquilatero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquilatero.Location = new System.Drawing.Point(51, 245);
            this.buttonEquilatero.Name = "buttonEquilatero";
            this.buttonEquilatero.Size = new System.Drawing.Size(125, 46);
            this.buttonEquilatero.TabIndex = 7;
            this.buttonEquilatero.Text = "Equilatero";
            this.buttonEquilatero.UseVisualStyleBackColor = true;
            this.buttonEquilatero.Click += new System.EventHandler(this.buttonEquilatero_Click);
            // 
            // buttonLadoMayor
            // 
            this.buttonLadoMayor.Enabled = false;
            this.buttonLadoMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLadoMayor.Location = new System.Drawing.Point(182, 245);
            this.buttonLadoMayor.Name = "buttonLadoMayor";
            this.buttonLadoMayor.Size = new System.Drawing.Size(125, 46);
            this.buttonLadoMayor.TabIndex = 8;
            this.buttonLadoMayor.Text = "Lado Mayor";
            this.buttonLadoMayor.UseVisualStyleBackColor = true;
            this.buttonLadoMayor.Click += new System.EventHandler(this.buttonLadoMayor_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.Enabled = false;
            this.buttonArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArea.Location = new System.Drawing.Point(313, 245);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(132, 46);
            this.buttonArea.TabIndex = 9;
            this.buttonArea.Text = "Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 334);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonLadoMayor);
            this.Controls.Add(this.buttonEquilatero);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.textBoxLado);
            this.Controls.Add(this.textBoxBase);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.lblAltura);
            this.Name = "Form1";
            this.Text = "Clase Triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.TextBox textBoxLado;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonEquilatero;
        private System.Windows.Forms.Button buttonLadoMayor;
        private System.Windows.Forms.Button buttonArea;
    }
}

