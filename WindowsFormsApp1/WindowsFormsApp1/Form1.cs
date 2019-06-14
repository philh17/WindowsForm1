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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pressMe_Click(object sender, EventArgs e)
        {
            double dPcent = double.Parse(txtPercent.Text);
            double dGross = double.Parse(txtGross.Text);

            double dStep1 = dPcent + 100;
            double dStep2 = dGross / dStep1;
            double dStep3 = dStep2 * 100;
            double dStep4 = dGross - dStep3;

            MessageBox.Show("Gross: " + Math.Round(dGross, 2) + "\nPercentage: " + Math.Round(dPcent, 2) + "%" + "\n% Value: " + Math.Round(dStep4, 2) + "\nNet: " + Math.Round(dStep3, 2), "Net Calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clearText();
        }

        private void clearText()
        {
            txtPercent.Clear();
            txtGross.Clear();
        }

        private void pressMe_MouseLeave(object sender, EventArgs e)
        {
            pressMe.BackColor = Color.DarkGray;
            pressMe.ForeColor = Color.Black;
        }

        private void pressMe_MouseMove(object sender, MouseEventArgs e)
        {
            pressMe.BackColor = Color.Green;
            pressMe.ForeColor = Color.White;
        }

        private void numberCheck(TextBox boxName)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(boxName.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                boxName.Text = boxName.Text.Remove(boxName.Text.Length - 1);
            }
        }

        private void txtPercent_TextChanged(object sender, EventArgs e)
        {
            numberCheck(txtPercent);
        }

        private void txtGross_TextChanged(object sender, EventArgs e)
        {
            numberCheck(txtGross);
        }
    }
}
