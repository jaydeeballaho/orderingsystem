using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OrderingSystem
{
    class Database
    {
        public static string connectionString = "Server=" + Properties.Settings.Default.host +
                                                 ";Port=" + Properties.Settings.Default.port +
                                                 ";Database=" + Properties.Settings.Default.database +
                                                 ";User=" + Properties.Settings.Default.username +
                                                 ";Password=" + Properties.Settings.Default.password;
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public static MySqlTransaction transaction;
        public static MySqlDataReader reader;
       
        public static bool isConnected()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    closeConnection();
                }
                connection.ConnectionString = connectionString;
                connection.Open();
                transaction = connection.BeginTransaction();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public static void commit()
        {
            transaction.Commit();
            transaction = connection.BeginTransaction();
        }

        public static void rollBack()
        {
            transaction.Rollback();
            transaction = connection.BeginTransaction();
        }

        public static void closeConnection()
        {
            try
            {
                connection.Close();
            }
            catch
            {
                // Do something
            }
            finally
            {
                connection.Close();
            }
        }
        //This is use to execute add,edit and delete query.
        public static void executeSQL(string sql, params object[] list)
        {
            var cmd = new MySqlCommand(sql, connection, transaction);
            for (int i = 0; i < list.Length; i++)
            {
                cmd.Parameters.AddWithValue("@" + i, list[i]);
            }
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        //This is use to execute view/search query using data reader.
        public static void executeReader(string sql, params object[] list)
        {
            var cmd = new MySqlCommand(sql, connection, transaction);
            for (int i = 0; i < list.Length; i++)
            {
                cmd.Parameters.AddWithValue("@" + i, list[i]);
            }
            var myReader = cmd.ExecuteReader();
            reader = myReader;
        }
    }
}
