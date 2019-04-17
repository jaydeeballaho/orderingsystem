using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        public frmPayment(decimal total)
        {
            InitializeComponent();
            txtTotal.Text = total.ToString();
        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {
            if (txtChange.Text.Length > 0)
            {
                if (decimal.Parse(txtChange.Text.ToString()) < 0)
                {
                    btnSave.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                }
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            var val = new Validation();
            val.AllowedOnly(val.NumberOnly, txtCash);

            if (txtCash.Text.Length > 0)
            {
                decimal cash = decimal.Parse(txtCash.Text.ToString());
                decimal total = decimal.Parse(txtTotal.Text.ToString());
                decimal chnge = cash-total;

                if (chnge < 0)
                {
                    txtChange.Text = "0.00";
                    btnSave.Enabled = false;
                }
                else
                {
                    txtChange.Text = chnge.ToString();
                    btnSave.Enabled = true;
                }
            }
            else
            {
                txtChange.Text = "0.00";
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
