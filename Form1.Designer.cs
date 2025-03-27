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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.btnResiduo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lanum1
            // 
            this.lanum1.AutoSize = true;
            this.lanum1.Location = new System.Drawing.Point(102, 42);
            this.lanum1.Name = "lanum1";
            this.lanum1.Size = new System.Drawing.Size(51, 13);
            this.lanum1.TabIndex = 0;
            this.lanum1.Text = "numero 1";
            // 
            // lanum2
            // 
            this.lanum2.AutoSize = true;
            this.lanum2.Location = new System.Drawing.Point(236, 42);
            this.lanum2.Name = "lanum2";
            this.lanum2.Size = new System.Drawing.Size(51, 13);
            this.lanum2.TabIndex = 1;
            this.lanum2.Text = "numero 2";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(87, 65);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(81, 20);
            this.txtnum1.TabIndex = 2;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(225, 65);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(74, 20);
            this.txtnum2.TabIndex = 3;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(43, 128);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(53, 23);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(100, 128);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(53, 23);
            this.btnResta.TabIndex = 5;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(159, 128);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(69, 23);
            this.btnMulti.TabIndex = 6;
            this.btnMulti.Text = "Multiplicar";
            this.btnMulti.UseVisualStyleBackColor = true;
            // 
            // btnDivi
            // 
            this.btnDivi.Location = new System.Drawing.Point(234, 128);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(53, 23);
            this.btnDivi.TabIndex = 7;
            this.btnDivi.Text = "Dividir";
            this.btnDivi.UseVisualStyleBackColor = true;
            // 
            // btnResiduo
            // 
            this.btnResiduo.Location = new System.Drawing.Point(293, 128);
            this.btnResiduo.Name = "btnResiduo";
            this.btnResiduo.Size = new System.Drawing.Size(58, 23);
            this.btnResiduo.TabIndex = 8;
            this.btnResiduo.Text = "Residuo";
            this.btnResiduo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 299);
            this.Controls.Add(this.btnResiduo);
            this.Controls.Add(this.btnDivi);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
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
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDivi;
        private System.Windows.Forms.Button btnResiduo;
    }
}

