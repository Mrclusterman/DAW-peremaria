
namespace Ejercicio18
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReducir = new System.Windows.Forms.Button();
            this.buttonAumentar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNormalForm = new System.Windows.Forms.Button();
            this.buttonRedForm = new System.Windows.Forms.Button();
            this.buttonPurpleForm = new System.Windows.Forms.Button();
            this.buttonGreenForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownTxt = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonNormalTxt = new System.Windows.Forms.Button();
            this.buttonRedTxt = new System.Windows.Forms.Button();
            this.buttonPurpleTxt = new System.Windows.Forms.Button();
            this.buttonGreenTxt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxUnder = new System.Windows.Forms.CheckBox();
            this.checkBoxItalic = new System.Windows.Forms.CheckBox();
            this.checkBoxBold = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.lbox_Fuentes = new System.Windows.Forms.ListBox();
            this.labeltxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTxt)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.buttonReducir);
            this.panel1.Controls.Add(this.buttonAumentar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 159);
            this.panel1.TabIndex = 0;
            // 
            // buttonReducir
            // 
            this.buttonReducir.Location = new System.Drawing.Point(152, 53);
            this.buttonReducir.Name = "buttonReducir";
            this.buttonReducir.Size = new System.Drawing.Size(115, 33);
            this.buttonReducir.TabIndex = 2;
            this.buttonReducir.Text = "Reducir";
            this.buttonReducir.UseVisualStyleBackColor = true;
            this.buttonReducir.Click += new System.EventHandler(this.buttonReducir_Click);
            // 
            // buttonAumentar
            // 
            this.buttonAumentar.Location = new System.Drawing.Point(15, 53);
            this.buttonAumentar.Name = "buttonAumentar";
            this.buttonAumentar.Size = new System.Drawing.Size(115, 33);
            this.buttonAumentar.TabIndex = 1;
            this.buttonAumentar.Text = "Aumentar";
            this.buttonAumentar.UseVisualStyleBackColor = true;
            this.buttonAumentar.Click += new System.EventHandler(this.buttonAumentar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Propiedades del Form";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonNormalForm);
            this.groupBox1.Controls.Add(this.buttonRedForm);
            this.groupBox1.Controls.Add(this.buttonPurpleForm);
            this.groupBox1.Controls.Add(this.buttonGreenForm);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color de formulario";
            // 
            // buttonNormalForm
            // 
            this.buttonNormalForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonNormalForm.Location = new System.Drawing.Point(233, 29);
            this.buttonNormalForm.Name = "buttonNormalForm";
            this.buttonNormalForm.Size = new System.Drawing.Size(31, 27);
            this.buttonNormalForm.TabIndex = 6;
            this.buttonNormalForm.UseVisualStyleBackColor = false;
            this.buttonNormalForm.Click += new System.EventHandler(this.buttonNormalForm_Click);
            // 
            // buttonRedForm
            // 
            this.buttonRedForm.BackColor = System.Drawing.Color.Red;
            this.buttonRedForm.Image = global::Ejercicio18.Properties.Resources.rojo;
            this.buttonRedForm.Location = new System.Drawing.Point(169, 29);
            this.buttonRedForm.Name = "buttonRedForm";
            this.buttonRedForm.Size = new System.Drawing.Size(31, 27);
            this.buttonRedForm.TabIndex = 5;
            this.buttonRedForm.UseVisualStyleBackColor = false;
            this.buttonRedForm.Click += new System.EventHandler(this.buttonRedForm_Click);
            // 
            // buttonPurpleForm
            // 
            this.buttonPurpleForm.BackColor = System.Drawing.Color.Purple;
            this.buttonPurpleForm.Image = global::Ejercicio18.Properties.Resources.morado;
            this.buttonPurpleForm.Location = new System.Drawing.Point(98, 29);
            this.buttonPurpleForm.Name = "buttonPurpleForm";
            this.buttonPurpleForm.Size = new System.Drawing.Size(31, 27);
            this.buttonPurpleForm.TabIndex = 4;
            this.buttonPurpleForm.UseVisualStyleBackColor = false;
            this.buttonPurpleForm.Click += new System.EventHandler(this.buttonPurpleForm_Click);
            // 
            // buttonGreenForm
            // 
            this.buttonGreenForm.BackColor = System.Drawing.Color.Green;
            this.buttonGreenForm.Image = global::Ejercicio18.Properties.Resources.verde;
            this.buttonGreenForm.Location = new System.Drawing.Point(20, 29);
            this.buttonGreenForm.Name = "buttonGreenForm";
            this.buttonGreenForm.Size = new System.Drawing.Size(31, 27);
            this.buttonGreenForm.TabIndex = 3;
            this.buttonGreenForm.UseVisualStyleBackColor = false;
            this.buttonGreenForm.Click += new System.EventHandler(this.buttonGreenForm_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.numericUpDownTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 187);
            this.panel2.TabIndex = 2;
            // 
            // numericUpDownTxt
            // 
            this.numericUpDownTxt.Location = new System.Drawing.Point(15, 48);
            this.numericUpDownTxt.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownTxt.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownTxt.Name = "numericUpDownTxt";
            this.numericUpDownTxt.Size = new System.Drawing.Size(198, 30);
            this.numericUpDownTxt.TabIndex = 7;
            this.numericUpDownTxt.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownTxt.ValueChanged += new System.EventHandler(this.numericUpDownTxt_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tamaño del texto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonNormalTxt);
            this.groupBox2.Controls.Add(this.buttonRedTxt);
            this.groupBox2.Controls.Add(this.buttonPurpleTxt);
            this.groupBox2.Controls.Add(this.buttonGreenTxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 72);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color de Texto";
            // 
            // buttonNormalTxt
            // 
            this.buttonNormalTxt.BackColor = System.Drawing.Color.Black;
            this.buttonNormalTxt.Image = global::Ejercicio18.Properties.Resources.negro;
            this.buttonNormalTxt.Location = new System.Drawing.Point(221, 39);
            this.buttonNormalTxt.Name = "buttonNormalTxt";
            this.buttonNormalTxt.Size = new System.Drawing.Size(31, 27);
            this.buttonNormalTxt.TabIndex = 11;
            this.buttonNormalTxt.UseVisualStyleBackColor = false;
            this.buttonNormalTxt.Click += new System.EventHandler(this.buttonNormalTxt_Click);
            // 
            // buttonRedTxt
            // 
            this.buttonRedTxt.BackColor = System.Drawing.Color.Red;
            this.buttonRedTxt.Image = global::Ejercicio18.Properties.Resources.rojo;
            this.buttonRedTxt.Location = new System.Drawing.Point(150, 40);
            this.buttonRedTxt.Name = "buttonRedTxt";
            this.buttonRedTxt.Size = new System.Drawing.Size(31, 27);
            this.buttonRedTxt.TabIndex = 10;
            this.buttonRedTxt.UseVisualStyleBackColor = false;
            this.buttonRedTxt.Click += new System.EventHandler(this.buttonRedTxt_Click);
            // 
            // buttonPurpleTxt
            // 
            this.buttonPurpleTxt.BackColor = System.Drawing.Color.Purple;
            this.buttonPurpleTxt.Image = global::Ejercicio18.Properties.Resources.morado;
            this.buttonPurpleTxt.Location = new System.Drawing.Point(84, 39);
            this.buttonPurpleTxt.Name = "buttonPurpleTxt";
            this.buttonPurpleTxt.Size = new System.Drawing.Size(31, 27);
            this.buttonPurpleTxt.TabIndex = 9;
            this.buttonPurpleTxt.UseVisualStyleBackColor = false;
            this.buttonPurpleTxt.Click += new System.EventHandler(this.buttonPurpleTxt_Click);
            // 
            // buttonGreenTxt
            // 
            this.buttonGreenTxt.BackColor = System.Drawing.Color.Green;
            this.buttonGreenTxt.Image = global::Ejercicio18.Properties.Resources.verde;
            this.buttonGreenTxt.Location = new System.Drawing.Point(18, 39);
            this.buttonGreenTxt.Name = "buttonGreenTxt";
            this.buttonGreenTxt.Size = new System.Drawing.Size(31, 27);
            this.buttonGreenTxt.TabIndex = 8;
            this.buttonGreenTxt.UseVisualStyleBackColor = false;
            this.buttonGreenTxt.Click += new System.EventHandler(this.buttonGreenTxt_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.checkBoxUnder);
            this.panel3.Controls.Add(this.checkBoxItalic);
            this.panel3.Controls.Add(this.checkBoxBold);
            this.panel3.Controls.Add(this.buttonClose);
            this.panel3.Controls.Add(this.buttonShow);
            this.panel3.Controls.Add(this.buttonHide);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 119);
            this.panel3.TabIndex = 4;
            // 
            // checkBoxUnder
            // 
            this.checkBoxUnder.AutoSize = true;
            this.checkBoxUnder.Location = new System.Drawing.Point(331, 87);
            this.checkBoxUnder.Name = "checkBoxUnder";
            this.checkBoxUnder.Size = new System.Drawing.Size(130, 29);
            this.checkBoxUnder.TabIndex = 17;
            this.checkBoxUnder.Text = "Subrayado";
            this.checkBoxUnder.UseVisualStyleBackColor = true;
            this.checkBoxUnder.CheckedChanged += new System.EventHandler(this.checkBoxUnder_CheckedChanged);
            // 
            // checkBoxItalic
            // 
            this.checkBoxItalic.AutoSize = true;
            this.checkBoxItalic.Location = new System.Drawing.Point(176, 87);
            this.checkBoxItalic.Name = "checkBoxItalic";
            this.checkBoxItalic.Size = new System.Drawing.Size(101, 29);
            this.checkBoxItalic.TabIndex = 16;
            this.checkBoxItalic.Text = "Cursiva";
            this.checkBoxItalic.UseVisualStyleBackColor = true;
            this.checkBoxItalic.CheckedChanged += new System.EventHandler(this.checkBoxItalic_CheckedChanged);
            // 
            // checkBoxBold
            // 
            this.checkBoxBold.AutoSize = true;
            this.checkBoxBold.Location = new System.Drawing.Point(21, 87);
            this.checkBoxBold.Name = "checkBoxBold";
            this.checkBoxBold.Size = new System.Drawing.Size(96, 29);
            this.checkBoxBold.TabIndex = 15;
            this.checkBoxBold.Text = "Negrita";
            this.checkBoxBold.UseVisualStyleBackColor = true;
            this.checkBoxBold.CheckedChanged += new System.EventHandler(this.checkBoxBold_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(313, 29);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(149, 33);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "Cerrar";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(158, 29);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(149, 33);
            this.buttonShow.TabIndex = 13;
            this.buttonShow.Text = "Mostrar Texto";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(3, 29);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(149, 33);
            this.buttonHide.TabIndex = 12;
            this.buttonHide.Text = "Ocultar Texto";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // lbox_Fuentes
            // 
            this.lbox_Fuentes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbox_Fuentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_Fuentes.FormattingEnabled = true;
            this.lbox_Fuentes.ItemHeight = 25;
            this.lbox_Fuentes.Location = new System.Drawing.Point(586, 29);
            this.lbox_Fuentes.Name = "lbox_Fuentes";
            this.lbox_Fuentes.Size = new System.Drawing.Size(216, 479);
            this.lbox_Fuentes.TabIndex = 18;
            this.lbox_Fuentes.SelectedIndexChanged += new System.EventHandler(this.lbox_Fuentes_SelectedIndexChanged);
            // 
            // labeltxt
            // 
            this.labeltxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeltxt.AutoSize = true;
            this.labeltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltxt.Location = new System.Drawing.Point(364, 255);
            this.labeltxt.Name = "labeltxt";
            this.labeltxt.Size = new System.Drawing.Size(81, 25);
            this.labeltxt.TabIndex = 13;
            this.labeltxt.Text = "TEXTO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 535);
            this.Controls.Add(this.lbox_Fuentes);
            this.Controls.Add(this.labeltxt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Formatos de Fuentes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTxt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReducir;
        private System.Windows.Forms.Button buttonAumentar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRedForm;
        private System.Windows.Forms.Button buttonPurpleForm;
        private System.Windows.Forms.Button buttonGreenForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lbox_Fuentes;
        private System.Windows.Forms.NumericUpDown numericUpDownTxt;
        private System.Windows.Forms.Button buttonRedTxt;
        private System.Windows.Forms.Button buttonPurpleTxt;
        private System.Windows.Forms.Button buttonGreenTxt;
        private System.Windows.Forms.CheckBox checkBoxUnder;
        private System.Windows.Forms.CheckBox checkBoxItalic;
        private System.Windows.Forms.CheckBox checkBoxBold;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Label labeltxt;
        private System.Windows.Forms.Button buttonNormalForm;
        private System.Windows.Forms.Button buttonNormalTxt;
    }
}

