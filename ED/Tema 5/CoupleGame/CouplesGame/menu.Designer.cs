
namespace CouplesGame
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.btn_nueva = new System.Windows.Forms.Button();
            this.btn_records = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_musica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nueva
            // 
            this.btn_nueva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nueva.BackColor = System.Drawing.Color.Transparent;
            this.btn_nueva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nueva.BackgroundImage")));
            this.btn_nueva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nueva.FlatAppearance.BorderSize = 0;
            this.btn_nueva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_nueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_nueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nueva.Location = new System.Drawing.Point(135, 58);
            this.btn_nueva.Name = "btn_nueva";
            this.btn_nueva.Size = new System.Drawing.Size(213, 61);
            this.btn_nueva.TabIndex = 0;
            this.btn_nueva.UseVisualStyleBackColor = false;
            this.btn_nueva.Click += new System.EventHandler(this.btn_nueva_Click);
            // 
            // btn_records
            // 
            this.btn_records.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_records.BackColor = System.Drawing.Color.Transparent;
            this.btn_records.BackgroundImage = global::CouplesGame.Properties.Resources.BotonRecords;
            this.btn_records.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_records.FlatAppearance.BorderSize = 0;
            this.btn_records.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_records.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_records.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_records.Location = new System.Drawing.Point(135, 135);
            this.btn_records.Name = "btn_records";
            this.btn_records.Size = new System.Drawing.Size(213, 61);
            this.btn_records.TabIndex = 1;
            this.btn_records.UseVisualStyleBackColor = false;
            this.btn_records.Click += new System.EventHandler(this.btn_records_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.BackgroundImage = global::CouplesGame.Properties.Resources.BotonSalir;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(135, 223);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(213, 61);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_musica
            // 
            this.btn_musica.BackColor = System.Drawing.Color.Transparent;
            this.btn_musica.BackgroundImage = global::CouplesGame.Properties.Resources.botonMusicaOn;
            this.btn_musica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_musica.FlatAppearance.BorderSize = 0;
            this.btn_musica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_musica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_musica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_musica.Location = new System.Drawing.Point(411, 290);
            this.btn_musica.Name = "btn_musica";
            this.btn_musica.Size = new System.Drawing.Size(61, 59);
            this.btn_musica.TabIndex = 5;
            this.btn_musica.UseVisualStyleBackColor = false;
            this.btn_musica.Click += new System.EventHandler(this.btn_musica_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CouplesGame.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btn_musica);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_records);
            this.Controls.Add(this.btn_nueva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "menu";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nueva;
        private System.Windows.Forms.Button btn_records;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_musica;
    }
}