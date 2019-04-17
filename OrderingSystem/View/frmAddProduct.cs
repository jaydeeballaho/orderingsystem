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
    public partial class frmAddProduct : Form
    {
        Product product;

        public frmAddProduct()
        {
            InitializeComponent();
            product = new Product();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var val = new Validation();
            if (val.isTextBoxEmpty(txtName, txtPrice))
            {
                MessageBox.Show("Product name and price is required.");
                return;
            }
            else
            {
                product.product_name = txtName.Text.ToString();
                product.product_price = decimal.Parse(txtPrice.Text);
                if (product.isProductAdded())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Product failed to save.");
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            var val = new Validation();
            val.AllowedOnly(val.LetterWSpecial, txtName);
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            var val = new Validation();
            val.AllowedOnly(val.NumberOnly, txtPrice);
        }
    }
}
