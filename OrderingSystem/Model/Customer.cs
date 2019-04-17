using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    class Customer
    {
        public Customer()
        {
            name = "1 Guest";
            address = "";
            contact_no = "";
        }

        public int id { get; set; }
        public string name { get; set; }
        public string contact_no { get; set; }
        public string address { get; set; }

        //add, edit, delete, view, search

        public bool isCustomerAdded()
        {
            try
            {
                bool isAdded = false;
                var sql = "INSERT INTO customer (name, address, contact_no) VALUES (@0, @1, @2);";
                if (Database.isConnected())
                {
                    Database.executeSQL(sql, name, address, contact_no);
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

        public void fetchCustomerID()
        {
            string sql = "SELECT LAST_INSERT_ID()";
            if (Database.isConnected())
            {
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Database.connection);
                id = int.Parse(cmd.ExecuteScalar().ToString());
            }
        }
    }
}
