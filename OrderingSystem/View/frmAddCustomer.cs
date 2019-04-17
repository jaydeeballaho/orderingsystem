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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer(string name, string address, string cn)
        {
            InitializeComponent();

            txtName.Text = name;
            txtAddress.Text = address;
            txtCN.Text = cn;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var val = new Validation();
            if (val.isTextBoxEmpty(txtName))
            {
                MessageBox.Show("Customer Name is required.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            var val = new Validation();
            val.AllowedOnly(val.LetterWSpecial, txtName);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            var val = new Validation();
            val.AllowedOnly(val.LetterWSpecial, txtAddress);
        }

        private void txtCN_TextChanged(object sender, EventArgs e)
        {
            var val = new Validation();
            val.AllowedOnly(val.NumberOnly, txtCN);
        }
    }
}
