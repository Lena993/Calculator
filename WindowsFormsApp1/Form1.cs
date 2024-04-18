using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {

        double x, y, result;
        char operation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            x = double.Parse(txtDisplay.Text);
            operation = char.Parse(btn.Text);
            txtDisplay.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            y = double.Parse(txtDisplay.Text);

            switch (operation)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;
            }

            txtDisplay.Text = result.ToString();
        }
    }
}
