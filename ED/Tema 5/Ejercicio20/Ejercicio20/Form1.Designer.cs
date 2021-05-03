
namespace Ejercicio20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTBHora = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTBFecha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskTBTlf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTBID = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mskTBPrecio = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskTBMatricula = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRellenar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskTBHora);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskTBFecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha y Hora";
            // 
            // mskTBHora
            // 
            this.mskTBHora.Location = new System.Drawing.Point(77, 55);
            this.mskTBHora.Name = "mskTBHora";
            this.mskTBHora.Size = new System.Drawing.Size(100, 22);
            this.mskTBHora.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora:";
            // 
            // mskTBFecha
            // 
            this.mskTBFecha.Location = new System.Drawing.Point(77, 24);
            this.mskTBFecha.Name = "mskTBFecha";
            this.mskTBFecha.Size = new System.Drawing.Size(100, 22);
            this.mskTBFecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox2.Controls.Add(this.mskTBTlf);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.mskTBID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Empleado";
            // 
            // mskTBTlf
            // 
            this.mskTBTlf.Location = new System.Drawing.Point(77, 60);
            this.mskTBTlf.Name = "mskTBTlf";
            this.mskTBTlf.Size = new System.Drawing.Size(100, 22);
            this.mskTBTlf.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tlf:";
            // 
            // mskTBID
            // 
            this.mskTBID.Location = new System.Drawing.Point(77, 30);
            this.mskTBID.Name = "mskTBID";
            this.mskTBID.Size = new System.Drawing.Size(100, 22);
            this.mskTBID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.mskTBPrecio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.mskTBMatricula);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion Coche";
            // 
            // mskTBPrecio
            // 
            this.mskTBPrecio.Location = new System.Drawing.Point(77, 61);
            this.mskTBPrecio.Name = "mskTBPrecio";
            this.mskTBPrecio.Size = new System.Drawing.Size(100, 22);
            this.mskTBPrecio.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Valor";
            // 
            // mskTBMatricula
            // 
            this.mskTBMatricula.Location = new System.Drawing.Point(77, 27);
            this.mskTBMatricula.Name = "mskTBMatricula";
            this.mskTBMatricula.Size = new System.Drawing.Size(100, 22);
            this.mskTBMatricula.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Matricula";
            // 
            // buttonRellenar
            // 
            this.buttonRellenar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRellenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(203)))), ((int)(((byte)(125)))));
            this.buttonRellenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRellenar.Location = new System.Drawing.Point(358, 495);
            this.buttonRellenar.Name = "buttonRellenar";
            this.buttonRellenar.Size = new System.Drawing.Size(116, 57);
            this.buttonRellenar.TabIndex = 3;
            this.buttonRellenar.Text = "Rellenar Formulario";
            this.buttonRellenar.UseVisualStyleBackColor = false;
            this.buttonRellenar.Click += new System.EventHandler(this.buttonRellenar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(187)))), ((int)(((byte)(235)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Ejercicio20.Properties.Resources.car;
            this.pictureBox1.Location = new System.Drawing.Point(218, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(856, 564);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRellenar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Formulario Venta de Coches";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskTBHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTBFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskTBTlf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTBID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mskTBPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTBMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRellenar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

