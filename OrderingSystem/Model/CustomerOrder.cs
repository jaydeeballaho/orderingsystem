using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OrderingSystem
{
    class CustomerOrder
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public DateTime order_date { get; set; }
        
        public int product_id { get; set; }
        public decimal amount { get; set; }
        public int quantity { get; set; }

        public bool isCustomerOrderAdded()
        {
            try
            {
                bool isAdded = false;
                var sql = "INSERT INTO customer_order (customer_id, order_date) VALUES (@0, CURRENT_TIMESTAMP);";
                if (Database.isConnected())
                {
                    Database.executeSQL(sql, customer_id);
                    Database.commit();
                    isAdded = true;
                }
                return isAdded;
            }
            catch
            {
                Database.rollBack();
                return false;
            }
        }

        public bool isOrderDetailsAdded()
        {
            try
            {
                bool isAdded = false;
                var sql = "INSERT INTO order_details (customer_order_id, product_id, amount, quantity) VALUES (@0, @1, @2, @3);";
                if (Database.isConnected())
                {
                    Database.executeSQL(sql, id, product_id, amount, quantity);
                    Database.commit();
                    isAdded = true;
                }
                return isAdded;
            }
            catch
            {
                Database.rollBack();
                return false;
            }
        }

        public void fetchCustomerOrderID()
        {
            string sql = "SELECT LAST_INSERT_ID()";
            if (Database.isConnected())
            {
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Database.connection);
                id = int.Parse(cmd.ExecuteScalar().ToString());
            }
        }

        public void viewTransactionHistory(DataGridView dgv)
        {
            dgv.Rows.Clear();
            int i = 1;
            var sql = "SELECT a.id, c.name, a.order_date, SUM(b.quantity), SUM(b.amount * b.quantity) FROM customer c INNER join customer_order a ON c.id = a.customer_id INNER JOIN order_details b ON a.id = b.customer_order_id GROUP BY b.customer_order_id order by a.created_at DESC;";
            try
            {
                if (Database.isConnected())
                {
                    Database.executeReader(sql);
                    while (Database.reader.Read())
                    {
                        dgv.Rows.Add(Database.reader[0].ToString(), i.ToString(),
                            Database.reader[1].ToString(), DateTime.Parse(Database.reader[2].ToString()).ToString("MM-dd-yyyy"),
                            Database.reader[3].ToString(), "₱" + Database.reader[4].ToString());
                        i++;
                    }
                    dgv.ClearSelection();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Database.reader.Close();
            }
        }
    }
}
