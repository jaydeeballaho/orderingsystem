using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class frmMain : Form
    {

        Button btnAddProduct;
        Product product;
        Customer customer;
        CustomerOrder customerOrder;

        public frmMain()
        {
            InitializeComponent();
            customer = new Customer();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadProduct();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Button box = (Button)sender;
            if (box.Name == "btnAdd")
            {
                var frmAddProduct = new frmAddProduct();
                if (frmAddProduct.ShowDialog() == DialogResult.OK)
                {
                    loadProduct();
                }
            }
            else
            {
                product = new Product();
                product.getProductDetails(int.Parse(box.Name));
                if (dgvOrderList.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvOrderList.Rows.Count; i++)
                    {
                       if (product.id == int.Parse(dgvOrderList.Rows[i].Cells[0].Value.ToString()))
                        {
                            decimal qty = 0;
                            decimal total = 0;
                            qty = decimal.Parse(dgvOrderList.Rows[i].Cells[3].Value.ToString()) + 1;
                            total = product.product_price * qty;

                            //update the list
                            dgvOrderList.Rows[i].Cells[3].Value = qty;
                            dgvOrderList.Rows[i].Cells[4].Value = "₱" + total;

                            dgvOrderList.ClearSelection();
                            calculateTotal();

                            return;
                        }
                    }
                    dgvOrderList.Rows.Add(product.id, product.product_name, "₱" + product.product_price, 1,
                                      "₱" + (product.product_price));
                }
                else
                {
                    dgvOrderList.Rows.Add(product.id, product.product_name, "₱" + product.product_price, 1,
                                      "₱" + (product.product_price));
                }
                
                dgvOrderList.ClearSelection();
                calculateTotal();
            }
        }

        private void loadProduct()
        {
            flowPanel.Controls.Clear();
            createAddProductButton();
            var sql = "SELECT * FROM product ORDER BY product_name ASC;";
            if (Database.isConnected())
            {
                var cmd = new MySqlCommand(sql, Database.connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Button btn = new Button();
                    btn.Name = reader[0].ToString();
                    btn.Size = new Size(150, 121);
                    btn.Text = reader[1].ToString().ToUpper() + "\n\n" + "₱" + reader[2].ToString();
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.ForeColor = Color.White;
                    btn.BackColor = Color.FromArgb(200, 40, 60);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Margin = new Padding(5, 5, 5, 5);
                   // btn.ContextMenuStrip = this.cMS;
                    flowPanel.Controls.Add(btn);
                    btn.Click += new EventHandler(ButtonClicked);
                }
                reader.Close();
            }
        }

        private void createAddProductButton()
        {
            btnAddProduct = new Button();
            btnAddProduct.Name = "btnAdd";
            btnAddProduct.Size = new Size(150, 121);
            btnAddProduct.Text = "New Product";
            btnAddProduct.TextAlign = ContentAlignment.MiddleCenter;
            btnAddProduct.ForeColor = Color.Black;
            btnAddProduct.BackColor = Color.LightGray;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.Margin = new Padding(5, 5, 5, 5);
            flowPanel.Controls.Add(btnAddProduct);
            btnAddProduct.Click += new EventHandler(ButtonClicked);
        }

        private void calculateTotal()
        {
            if (dgvOrderList.Rows.Count > 0)
            {
                decimal total = 0;
                for (int i = 0; i < dgvOrderList.Rows.Count; i++)
                {
                    product = new Product();
                    product.getProductDetails(int.Parse(dgvOrderList.Rows[i].Cells[0].Value.ToString()));
                    total += product.product_price * int.Parse(dgvOrderList.Rows[i].Cells[3].Value.ToString());
                }
                lblSubTotal.Text = "₱" + total;
                lblTotal.Text = "₱" + total;
            }
            else
            {
                lblSubTotal.Text = "₱0.00";
                lblTotal.Text = "₱0.00";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvOrderList.Rows.Clear();
            calculateTotal();
            lblDiscount.Text = "₱0.00";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            resetOrder();
        }

        private void resetOrder()
        {
            dgvOrderList.Rows.Clear();
            calculateTotal();

            lblName.Text = "Name: 1 Guest";
            lblAddress.Text = "Address:";
            lblContact.Text = "Contact:";

            lblDiscount.Text = "₱0.00";

            customer = new Customer();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (getTotal() > 0)
            {
                var frmPayment = new frmPayment(getTotal());
                if (frmPayment.ShowDialog() == DialogResult.OK)
                {
                    customer.isCustomerAdded();
                    customer.fetchCustomerID();

                    customerOrder = new CustomerOrder();
                    customerOrder.customer_id = customer.id;
                    customerOrder.isCustomerOrderAdded();
                    customerOrder.fetchCustomerOrderID();

                    for (int i = 0; i < dgvOrderList.Rows.Count; i++)
                    {
                        product = new Product();
                        product.getProductDetails(int.Parse(dgvOrderList.Rows[i].Cells[0].Value.ToString()));

                        customerOrder.product_id = product.id;
                        customerOrder.amount = product.product_price;
                        customerOrder.quantity = int.Parse(dgvOrderList.Rows[i].Cells[3].Value.ToString());

                        customerOrder.isOrderDetailsAdded();
                    }
                    resetOrder();
                }
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var frmAddCustomer = new frmAddCustomer(customer.name, customer.address, customer.contact_no);
            if (frmAddCustomer.ShowDialog() == DialogResult.OK)
            {
                lblName.Text = "Name: " + frmAddCustomer.txtName.Text;
                lblAddress.Text = "Address: " + frmAddCustomer.txtAddress.Text;
                lblContact.Text = "Contact: " + frmAddCustomer.txtCN.Text;

                customer.name = frmAddCustomer.txtName.Text;
                customer.address = frmAddCustomer.txtAddress.Text;
                customer.contact_no = frmAddCustomer.txtCN.Text;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private decimal getTotal()
        {
            decimal total = 0;

            if (dgvOrderList.Rows.Count > 0)
            {
                for (int i = 0; i < dgvOrderList.Rows.Count; i++)
                {
                    product = new Product();
                    product.getProductDetails(int.Parse(dgvOrderList.Rows[i].Cells[0].Value.ToString()));
                    total += product.product_price * int.Parse(dgvOrderList.Rows[i].Cells[3].Value.ToString());
                }
            }
            else
            {
                total = 0;
            }
            return total;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var frmHistory = new frmHistory();
            frmHistory.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            var frmHistory = new frmProducts();
            frmHistory.ShowDialog();
        }
    }
}
