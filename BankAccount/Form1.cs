using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
    public partial class frmBackAccount : Form
    {
        public frmBackAccount()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBalance.Text = String.Empty;
            txtDeposit.Text = String.Empty;
            txtInterest.Text = String.Empty;
            txtNumMonths.Text = String.Empty;

            txtDeposit.Focus();
        }

        double deposit;
        int months;
        double interest;
        double final;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double intRate;

            if(txtDeposit.Text == String.Empty || 
                txtInterest.Text == String.Empty || 
                txtNumMonths.Text == String.Empty)
            {
                MessageBox.Show("Error Input", "Please fix the input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            deposit = Convert.ToDouble(txtDeposit.Text);
            interest = Convert.ToDouble(txtInterest.Text);
            months = Convert.ToInt32(txtNumMonths.Text);

            intRate = interest / 1200;

            if(interest == 0)
                final = deposit * months;
            else
                final = deposit * (Math.Pow(1 + intRate, months) - 1) / intRate;

            txtBalance.Text = String.Format("{0:f2}", final);
        }

        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
                e.Handled = false;
            else if (e.KeyChar == 13)
                txtInterest.Focus();
            else if (e.KeyChar == '.')
                if (txtDeposit.Text.IndexOf(".") == -1)
                    e.Handled = false;
                else
                    e.Handled = true;
            else
                e.Handled = true;

        }

        private void txtInterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
                e.Handled = false;
            else if (e.KeyChar == 13)
                txtNumMonths.Focus();
            else if (e.KeyChar == '.')
                if (txtNumMonths.Text.IndexOf(".") == -1)
                    e.Handled = false;
                else
                    e.Handled = true;
            else
                e.Handled = true;
        }

        private void txtNumMonths_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
                e.Handled = false;
            else if (e.KeyChar == 13)
                txtBalance.Focus();
            else
                e.Handled = true;
        }
    }
}
