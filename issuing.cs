using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Stock
{
    public partial class issuing : Form
    {
        MySqlConnection sqlcon;
        public issuing()
        {
            InitializeComponent();
            DBConnection DBConnect = new DBConnection();
            sqlcon = DBConnect.GetConnection();
            LoadItems();
            LoadBranches();
        }

        private void issuing_Load(object sender, EventArgs e)
        {

        }
        private void LoadItems()
        {
            try
            {
                MySqlCommand cd = new MySqlCommand("select Item from items", sqlcon);
                MySqlDataReader dr = cd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cmbitems.Items.Add(dr[0].ToString());
                    }
                }
                dr.Close();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void LoadBranches()
        {
            try
            {
                MySqlCommand cd = new MySqlCommand("select branch from branches", sqlcon);
                MySqlDataReader dr = cd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cmbbranch.Items.Add(dr[0].ToString());
                    }
                }
                dr.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void updateBallance()
        {
            try
            {
                int qty = 0;
                MySqlCommand cd = new MySqlCommand("select Quantity from items WHERE item = '" + cmbitems.SelectedItem + "'", sqlcon);
                MySqlDataReader dr = cd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        qty = Int32.Parse(dr[0].ToString());
                    }
                }
                dr.Close();
                lblbalance.Text = qty.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = true;


            if (String.IsNullOrEmpty((string)cmbitems.SelectedItem) || String.IsNullOrEmpty((string)cmbbranch.SelectedItem) || String.IsNullOrEmpty(txtamount.Text))
            {
                MessageBox.Show("Need to fill all the Fields", "Issuing Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            try
            {
                if (valid)
                {

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `issuings`(`item`, `amount`, `branch`, `date`) VALUES('" + cmbitems.SelectedItem.ToString() + "', '" + txtamount.Text + "', '" + cmbbranch.SelectedItem.ToString() + "', '')");
                    cmd.Connection = sqlcon;
                    int NoRows = cmd.ExecuteNonQuery();

                    if (NoRows > 0)
                    {
                        MessageBox.Show("Details Added", "Issuings Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record Fail to Add", "Issuings Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data" + ex, "Issuings Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (valid)
                {
                    int qty = 0;
                    MySqlCommand cd = new MySqlCommand("select Quantity from items WHERE item = '" + cmbitems.SelectedItem + "'", sqlcon);
                    MySqlDataReader dr = cd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            qty= Int32.Parse(dr[0].ToString());
                        }
                    }
                    dr.Close();

                    qty = qty - Int32.Parse(txtamount.Text);
                    MySqlCommand cmd = new MySqlCommand("UPDATE items SET Quantity = '" + qty + "' WHERE item = '" + cmbitems.SelectedItem + "'") ;
                    cmd.Connection = sqlcon;
                    int NoRows = cmd.ExecuteNonQuery();
                }
                updateBallance();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data" + ex, "Issuings Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBallance();
        }
    }
}
