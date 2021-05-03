
namespace CouplesGame
{
    partial class partida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(partida));
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_musica = new System.Windows.Forms.Button();
            this.btn_6x6 = new System.Windows.Forms.Button();
            this.btn_4x4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver.BackgroundImage = global::CouplesGame.Properties.Resources.BotonMenu;
            this.btn_volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Location = new System.Drawing.Point(155, 208);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(167, 55);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
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
            this.btn_musica.TabIndex = 3;
            this.btn_musica.UseVisualStyleBackColor = false;
            this.btn_musica.Click += new System.EventHandler(this.btn_musica_Click);
            // 
            // btn_6x6
            // 
            this.btn_6x6.BackColor = System.Drawing.Color.Transparent;
            this.btn_6x6.BackgroundImage = global::CouplesGame.Properties.Resources.boton6x6;
            this.btn_6x6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_6x6.FlatAppearance.BorderSize = 0;
            this.btn_6x6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_6x6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_6x6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_6x6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6x6.Location = new System.Drawing.Point(155, 138);
            this.btn_6x6.Name = "btn_6x6";
            this.btn_6x6.Size = new System.Drawing.Size(167, 55);
            this.btn_6x6.TabIndex = 4;
            this.btn_6x6.UseVisualStyleBackColor = false;
            this.btn_6x6.Click += new System.EventHandler(this.btn_6x6_Click);
            // 
            // btn_4x4
            // 
            this.btn_4x4.BackColor = System.Drawing.Color.Transparent;
            this.btn_4x4.BackgroundImage = global::CouplesGame.Properties.Resources.boton4x4;
            this.btn_4x4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_4x4.FlatAppearance.BorderSize = 0;
            this.btn_4x4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_4x4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_4x4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_4x4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4x4.Location = new System.Drawing.Point(155, 66);
            this.btn_4x4.Name = "btn_4x4";
            this.btn_4x4.Size = new System.Drawing.Size(167, 55);
            this.btn_4x4.TabIndex = 5;
            this.btn_4x4.UseVisualStyleBackColor = false;
            this.btn_4x4.Click += new System.EventHandler(this.btn_4x4_Click);
            // 
            // partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CouplesGame.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btn_4x4);
            this.Controls.Add(this.btn_6x6);
            this.Controls.Add(this.btn_musica);
            this.Controls.Add(this.btn_volver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "partida";
            this.Text = "Nueva Partida";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_musica;
        private System.Windows.Forms.Button btn_6x6;
        private System.Windows.Forms.Button btn_4x4;
    }
}