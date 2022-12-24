using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Stock
{
    public partial class dashboard : Form
    {
        MySqlConnection sqlcon;
        public dashboard()
        {
            InitializeComponent();
            DBConnection DBConnect = new DBConnection();
            sqlcon = DBConnect.GetConnection();
            LoadItems();
            LoadBranches();

        }
        private void LoadTable(string sql = "select * from items", DataGridView Table = null)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, sqlcon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Table.DataSource = dt;

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void LoadItems(string sql = "select Item from items")
        {
            try
            {
                MySqlCommand cd = new MySqlCommand(sql, sqlcon);
                MySqlDataReader dr = cd.ExecuteReader();

                if (dr.HasRows)
                {
                    cmbitemsissue.Items.Clear();
                    cmbitemname.Items.Clear();


                    while (dr.Read())
                    {


                        cmbitemsissue.Items.Add(dr[0].ToString());
                        cmbitemname.Items.Add(dr[0].ToString());



                    }
                }

                dr.Close();
                LoadTable("select * from items", DataGridView1);
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
                        cmbbranchissue.Items.Add(dr[0].ToString());
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
                MySqlCommand cd = new MySqlCommand("select Quantity from items WHERE item = '" + cmbitemsissue.SelectedItem + "'", sqlcon);
                MySqlDataReader dr = cd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        qty = Int32.Parse(dr[0].ToString());
                    }
                }
                dr.Close();
                lblbalanceissue.Text = qty.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = true;


            if (String.IsNullOrEmpty((string)cmbitemsissue.SelectedItem) || String.IsNullOrEmpty((string)cmbbranchissue.SelectedItem) || String.IsNullOrEmpty(txtamountissue.Text))
            {
                MessageBox.Show("Need to fill all the Fields", "Issuing Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            try
            {
                valid = IsvalidInt(txtamountissue.Text);
                if (valid)
                {

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `issuings`(`item`, `amount`, `branch`, `date`) VALUES('" + cmbitemsissue.SelectedItem.ToString() + "', '" + txtamountissue.Text + "', '" + cmbbranchissue.SelectedItem.ToString() + "', '')");
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
                else
                {
                    MessageBox.Show("Need to fill all the Fields in the Correct Form", "Issuing Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MySqlCommand cd = new MySqlCommand("select Quantity from items WHERE item = '" + cmbitemsissue.SelectedItem + "'", sqlcon);
                    MySqlDataReader dr = cd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            qty = Int32.Parse(dr[0].ToString());
                        }
                    }
                    dr.Close();

                    qty = qty - Int32.Parse(txtamountissue.Text);
                    MySqlCommand cmd = new MySqlCommand("UPDATE items SET Quantity = '" + qty + "' WHERE item = '" + cmbitemsissue.SelectedItem + "'");
                    cmd.Connection = sqlcon;
                    int NoRows = cmd.ExecuteNonQuery();
                }
                updateBallance();
                LoadTable("select * from items", DataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data" + ex, "Issuings Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBallance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool valid = true;

            if (String.IsNullOrEmpty(txtitemname.Text) && (String.IsNullOrEmpty(txtammount.Text) || String.IsNullOrEmpty((string)cmbitemname.SelectedItem)))
            {
                MessageBox.Show("Need to fill all the Fields", "Issuing Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            try
            {
                if (valid)
                {
                   
                    MySqlCommand cmd = new MySqlCommand();
                    if (newradio.Checked && valid)
                    {
                        valid = true;
                        cmd = new MySqlCommand("INSERT INTO `items`(`Item`,`Item_Code`, `Quantity`,`date`) VALUES('" + txtitemname.Text + "','" + txtitmcode.Text + "', '" + txtammount.Text + "' , '" + datepicker.Value.ToString() + "')");
                    }
                    if (existingradio.Checked && valid)
                    {
                        valid = true;
                        int qty = 0;
                        MySqlCommand cd = new MySqlCommand("select Quantity from items WHERE item = '" + cmbitemname.SelectedItem + "'", sqlcon);
                        MySqlDataReader dr = cd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                qty = Int32.Parse(dr[0].ToString());
                            }
                        }
                        dr.Close();
                        valid = IsvalidInt(txtammount.Text);
                        if (valid)
                        {
                            cmd = new MySqlCommand("UPDATE items SET Quantity = '" + (qty + Int32.Parse(txtammount.Text)) + "', date = '" + datepicker.Value.ToString() + "' WHERE item = '" + cmbitemname.SelectedItem + "'");

                        }

                    }
                    valid = (newradio.Checked || existingradio.Checked) ? true : false;
                    valid = IsvalidInt(txtammount.Text);
                    if (valid)
                    {
                        cmd.Connection = sqlcon;
                        int NoRows = cmd.ExecuteNonQuery();

                        if (NoRows > 0)
                        {
                            MessageBox.Show("Items Added", "Recieved Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTable("select * from items", DataGridView1);
                        }
                        else
                        {
                            MessageBox.Show("Record Fail to Add", "Recieved Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select New or Existing item or Check the Inserted Values ", "Issuing Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data" + ex, "Recieved Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newradio_Click(object sender, EventArgs e)
        {
            if (newradio.Checked)
            {
                lblitmcode.Show();
                txtitmcode.Show();
                txtitemname.Show();
                cmbitemname.Hide();
            }
            if (existingradio.Checked)
            {
                lblitmcode.Hide();
                txtitmcode.Hide();
                txtitemname.Hide();
                cmbitemname.Show();
                LoadItems();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            LoadTable("select * from items", DataGridView1);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1issue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadTable("select * from items where Item ='" + cmbsearchitem.Text + "' ", DataGridView1);
        }

        private void cmbsearchitem_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadTable("select * from items where Item LIKE '%" + cmbsearchitem.Text + "%' ", DataGridView1);
        }

        private bool IsvalidInt(object value)
        {
            int i;
            bool IsValid = int.TryParse((string)value, out i);
            return IsValid;
        }
    }
}
