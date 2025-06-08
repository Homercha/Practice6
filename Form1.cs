using System;
using System.Windows.Forms;

namespace Lab06App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbX1.Text) || string.IsNullOrWhiteSpace(tbX2.Text))
                {
                    tbY.Text = "Не введено даних!";
                    return;
                }

                double x1 = double.Parse(tbX1.Text);
                double x2 = double.Parse(tbX2.Text);
                double y = x1 * x2;
                tbY.Text = y.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Введіть коректні числові значення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = "";
            tbX2.Text = "";
            tbY.Text = "";
            tbX1.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
