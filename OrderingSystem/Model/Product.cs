using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    class Product
    {
        public int id { get; set; }
        public string product_name { get; set; }
        public decimal product_price { get; set; }

        //add, edit, delete, view, search

        public bool isProductAdded()
        {
            try
            {
                bool isAdded = false;
                var sql = "INSERT INTO product (product_name, product_price) VALUES (@0, @1);";
                if (Database.isConnected())
                {
                    Database.executeSQL(sql, product_name, product_price);
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

        public bool isProductEdited()
        {
            try
            {
                bool isEdited = false;
                var sql = "UPDATE product SET product_name=@0, product_price=@1 WHERE id = @2;";
                if (Database.isConnected())
                {
                    Database.executeSQL(sql, product_name, product_price, id);
                    Database.commit();
                    isEdited = true;
                }
                return isEdited;
            }
            catch (Exception e)
            {
                Database.rollBack();
                return false;
            }
        }

        public void getProductDetails(int i)
        {
            try
            {
                var sql = "SELECT * FROM product WHERE id = @0;";
                if (Database.isConnected())
                {
                    Database.executeReader(sql, i);
                    while (Database.reader.Read())
                    {
                        id = int.Parse(Database.reader[0].ToString());
                        product_name = Database.reader[1].ToString();
                        product_price = decimal.Parse(Database.reader[2].ToString());
                    }
                    Database.reader.Close();
                }
            }
            catch
            {

            }
        }

        public void viewProducts(DataGridView dgv)
        {
            dgv.Rows.Clear();
            int i = 1;
            var sql = "SELECT * FROM product order by product_name ASC;";
            try
            {
                if (Database.isConnected())
                {
                    Database.executeReader(sql);
                    while (Database.reader.Read())
                    {
                        dgv.Rows.Add(Database.reader[0].ToString(), i.ToString(),
                            Database.reader[1].ToString(), "₱" + Database.reader[2].ToString(), "Edit");
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
