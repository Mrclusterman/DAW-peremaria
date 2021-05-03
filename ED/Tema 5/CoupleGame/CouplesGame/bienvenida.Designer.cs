
namespace CouplesGame
{
    partial class bienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bienvenida));
            this.btn_emp = new System.Windows.Forms.Button();
            this.btn_musica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_emp
            // 
            this.btn_emp.BackColor = System.Drawing.Color.Transparent;
            this.btn_emp.BackgroundImage = global::CouplesGame.Properties.Resources.BotonEmpezar;
            this.btn_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_emp.FlatAppearance.BorderSize = 0;
            this.btn_emp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_emp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp.ForeColor = System.Drawing.Color.Transparent;
            this.btn_emp.Location = new System.Drawing.Point(163, 266);
            this.btn_emp.Name = "btn_emp";
            this.btn_emp.Size = new System.Drawing.Size(167, 58);
            this.btn_emp.TabIndex = 0;
            this.btn_emp.UseVisualStyleBackColor = false;
            this.btn_emp.Click += new System.EventHandler(this.btn_emp_Click);
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
            this.btn_musica.Location = new System.Drawing.Point(422, 299);
            this.btn_musica.Name = "btn_musica";
            this.btn_musica.Size = new System.Drawing.Size(61, 59);
            this.btn_musica.TabIndex = 4;
            this.btn_musica.UseVisualStyleBackColor = false;
            this.btn_musica.Click += new System.EventHandler(this.btn_musica_Click);
            // 
            // bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::CouplesGame.Properties.Resources.fondobienvenida;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btn_musica);
            this.Controls.Add(this.btn_emp);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "bienvenida";
            this.Text = "Bienvenid@!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_emp;
        private System.Windows.Forms.Button btn_musica;
    }
}