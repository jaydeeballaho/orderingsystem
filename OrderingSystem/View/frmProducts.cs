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
    public partial class frmProducts : Form
    {
        Product product;

        public frmProducts()
        {
            InitializeComponent();
            product = new Product();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            product.viewProducts(dgvOrderList);
        }

        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                product = new Product();
                product.getProductDetails(int.Parse(dgvOrderList.SelectedRows[0].Cells[0].Value.ToString()));

                var frmEditProduct = new frmEditProduct(product.product_name, product.product_price, product.id);
                if (frmEditProduct.ShowDialog() == DialogResult.OK)
                {
                    product.viewProducts(dgvOrderList);
                }
            }
        }
    }
}
