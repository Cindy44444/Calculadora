using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtnum1.Text);
            int num2 = Convert.ToInt32(txtnum2.Text);
            MessageBox.Show($"Suma:{num1 + num2}");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtnum1.Text);
            int num2 = Convert.ToInt32(txtnum2.Text);
            MessageBox.Show($"Resta:{num1 - num2}");

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtnum1.Text);
            int num2 = Convert.ToInt32(txtnum2.Text);
            MessageBox.Show($"Multi:{num1 * num2}");
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtnum1.Text);
            int num2 = Convert.ToInt32(txtnum2.Text);
            MessageBox.Show($"Divi:{num1 / num2}");
        }

        private void btnResiduo_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtnum1.Text);
            int num2 = Convert.ToInt32(txtnum2.Text);
            MessageBox.Show($"Residuo:{num1 % num2}");
        }
    }
}
