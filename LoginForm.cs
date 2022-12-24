using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Stock
{
    public partial class LoginForm : Form
    {
        MySqlConnection sqlcon;
        int count = 0;
        public LoginForm()
        {
            InitializeComponent();
            DBConnection DBConnect = new DBConnection();
            sqlcon = DBConnect.GetConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool valid = true;
                if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtpassword.Text))
                {
                    MessageBox.Show("Need to Fill all the values", "login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }
                if (valid)
                {
                    string usertype = null;
                    MySqlCommand cmd = new MySqlCommand("select role from users where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", sqlcon);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    Boolean records = dr.HasRows;
                    if (records)
                    {
                        while (dr.Read())
                        {
                            usertype = dr[0].ToString();
                        }
                        if (usertype.Equals("ADMIN"))
                        {
                            dashboard obj = new dashboard();
                            obj.Show();
                            this.Hide();
                        }
                        if (usertype.Equals("USER"))
                        {
                            MessageBox.Show("Login as Manager", "login Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //ManagerMenu obj = new ManagerMenu();
                            //j.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password! Please try again", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        count++;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid ", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                count++;
            }
            if (count >= 3)
            {
                MessageBox.Show("3 Invalid Login attempts, Sytem is shutting down Please Contact the Administrator or mailto:smpmaneth@gmail.com ", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
