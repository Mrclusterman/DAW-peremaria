
namespace CouplesGame
{
    partial class Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            this.record4 = new System.Windows.Forms.DataGridView();
            this.record6 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.record4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.record6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // record4
            // 
            this.record4.AllowUserToAddRows = false;
            this.record4.AllowUserToDeleteRows = false;
            this.record4.AllowUserToOrderColumns = true;
            this.record4.AllowUserToResizeColumns = false;
            this.record4.AllowUserToResizeRows = false;
            this.record4.BackgroundColor = System.Drawing.Color.Black;
            this.record4.Enabled = false;
            this.record4.GridColor = System.Drawing.Color.Black;
            this.record4.Location = new System.Drawing.Point(12, 84);
            this.record4.Name = "record4";
            this.record4.Size = new System.Drawing.Size(244, 249);
            this.record4.TabIndex = 0;
            this.record4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.record4_CellContentClick);
            // 
            // record6
            // 
            this.record6.AllowUserToAddRows = false;
            this.record6.AllowUserToDeleteRows = false;
            this.record6.AllowUserToOrderColumns = true;
            this.record6.AllowUserToResizeColumns = false;
            this.record6.AllowUserToResizeRows = false;
            this.record6.BackgroundColor = System.Drawing.Color.Black;
            this.record6.Enabled = false;
            this.record6.GridColor = System.Drawing.Color.Black;
            this.record6.Location = new System.Drawing.Point(284, 84);
            this.record6.Name = "record6";
            this.record6.Size = new System.Drawing.Size(244, 249);
            this.record6.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CouplesGame.Properties.Resources.BotonRecords;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(156, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver.BackgroundImage = global::CouplesGame.Properties.Resources.BotonMenu;
            this.btn_volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Location = new System.Drawing.Point(353, 366);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(120, 35);
            this.btn_volver.TabIndex = 3;
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CouplesGame.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 454);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.record6);
            this.Controls.Add(this.record4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Record";
            this.Text = "Records";
            ((System.ComponentModel.ISupportInitialize)(this.record4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.record6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView record4;
        private System.Windows.Forms.DataGridView record6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_volver;
    }
}