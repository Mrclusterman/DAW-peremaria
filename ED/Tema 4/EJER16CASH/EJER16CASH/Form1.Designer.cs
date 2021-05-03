
namespace EJER16CASH
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
            this.lblJoeCash = new System.Windows.Forms.Label();
            this.lblBobCash = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.buttonGive = new System.Windows.Forms.Button();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.buttonJoeaBob = new System.Windows.Forms.Button();
            this.buttonBobaJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJoeCash
            // 
            this.lblJoeCash.AutoSize = true;
            this.lblJoeCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoeCash.Location = new System.Drawing.Point(29, 32);
            this.lblJoeCash.Name = "lblJoeCash";
            this.lblJoeCash.Size = new System.Drawing.Size(0, 20);
            this.lblJoeCash.TabIndex = 0;
            // 
            // lblBobCash
            // 
            this.lblBobCash.AutoSize = true;
            this.lblBobCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBobCash.Location = new System.Drawing.Point(29, 74);
            this.lblBobCash.Name = "lblBobCash";
            this.lblBobCash.Size = new System.Drawing.Size(0, 20);
            this.lblBobCash.TabIndex = 1;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(29, 119);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 20);
            this.lblSaldo.TabIndex = 2;
            // 
            // buttonGive
            // 
            this.buttonGive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGive.Location = new System.Drawing.Point(24, 163);
            this.buttonGive.Name = "buttonGive";
            this.buttonGive.Size = new System.Drawing.Size(110, 60);
            this.buttonGive.TabIndex = 3;
            this.buttonGive.Text = "Dar 10E a Joe";
            this.buttonGive.UseVisualStyleBackColor = true;
            this.buttonGive.Click += new System.EventHandler(this.buttonGive_Click);
            // 
            // buttonReceive
            // 
            this.buttonReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReceive.Location = new System.Drawing.Point(170, 163);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(118, 60);
            this.buttonReceive.TabIndex = 4;
            this.buttonReceive.Text = "Recibir 5E de Bob";
            this.buttonReceive.UseVisualStyleBackColor = true;
            this.buttonReceive.Click += new System.EventHandler(this.buttonReceive_Click);
            // 
            // buttonJoeaBob
            // 
            this.buttonJoeaBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJoeaBob.Location = new System.Drawing.Point(24, 238);
            this.buttonJoeaBob.Name = "buttonJoeaBob";
            this.buttonJoeaBob.Size = new System.Drawing.Size(110, 60);
            this.buttonJoeaBob.TabIndex = 6;
            this.buttonJoeaBob.Text = "Joe da 10E a Bob";
            this.buttonJoeaBob.UseVisualStyleBackColor = true;
            this.buttonJoeaBob.Click += new System.EventHandler(this.buttonJoeaBob_Click);
            // 
            // buttonBobaJoe
            // 
            this.buttonBobaJoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBobaJoe.Location = new System.Drawing.Point(170, 238);
            this.buttonBobaJoe.Name = "buttonBobaJoe";
            this.buttonBobaJoe.Size = new System.Drawing.Size(110, 60);
            this.buttonBobaJoe.TabIndex = 7;
            this.buttonBobaJoe.Text = "Bob da 5E a Joe";
            this.buttonBobaJoe.UseVisualStyleBackColor = true;
            this.buttonBobaJoe.Click += new System.EventHandler(this.buttonBobaJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 337);
            this.Controls.Add(this.buttonBobaJoe);
            this.Controls.Add(this.buttonJoeaBob);
            this.Controls.Add(this.buttonReceive);
            this.Controls.Add(this.buttonGive);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblBobCash);
            this.Controls.Add(this.lblJoeCash);
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJoeCash;
        private System.Windows.Forms.Label lblBobCash;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button buttonGive;
        private System.Windows.Forms.Button buttonReceive;
        private System.Windows.Forms.Button buttonJoeaBob;
        private System.Windows.Forms.Button buttonBobaJoe;
    }
}

