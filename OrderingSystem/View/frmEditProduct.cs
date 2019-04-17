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
    public partial class frmEditProduct : Form
    {
        Product product;

        public frmEditProduct()
        {
            InitializeComponent();
        }
        public frmEditProduct(string product_name, decimal price, int id)
        {
            InitializeComponent();
            product = new Product();
            txtName.Text = product_name;
            txtPrice.Text = String.Format("{0:0.##}", price);
            product.id = id;
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
                if (product.isProductEdited())
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
    }
}
