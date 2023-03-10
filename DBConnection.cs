using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Stock
{
    class DBConnection
    {
        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                string sql = "datasource=localhost;user=root;password=;database=stock";
                conn = new MySqlConnection(sql);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error " + ex);
                return conn;
            }

        }
    }
}
