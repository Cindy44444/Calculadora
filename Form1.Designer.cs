namespace Calculadora
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
            this.lanum1 = new System.Windows.Forms.Label();
            this.lanum2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lanum1
            // 
            this.lanum1.AutoSize = true;
            this.lanum1.Location = new System.Drawing.Point(50, 34);
            this.lanum1.Name = "lanum1";
            this.lanum1.Size = new System.Drawing.Size(51, 13);
            this.lanum1.TabIndex = 0;
            this.lanum1.Text = "numero 1";
            // 
            // lanum2
            // 
            this.lanum2.AutoSize = true;
            this.lanum2.Location = new System.Drawing.Point(172, 33);
            this.lanum2.Name = "lanum2";
            this.lanum2.Size = new System.Drawing.Size(51, 13);
            this.lanum2.TabIndex = 1;
            this.lanum2.Text = "numero 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 299);
            this.Controls.Add(this.lanum2);
            this.Controls.Add(this.lanum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lanum1;
        private System.Windows.Forms.Label lanum2;
    }
}

