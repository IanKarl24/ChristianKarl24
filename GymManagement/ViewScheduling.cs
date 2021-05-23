using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GymManagement
{
    public partial class Scheduling : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        OleDbCommand cmd = new OleDbCommand();
        string sql, sql1;
        public Scheduling()
        {
            InitializeComponent();
        }

        private void load_data(string sql, ListView lst)
        {
            listView1.Items.Clear();
            using (OleDbDataAdapter da = new OleDbDataAdapter(sql, con))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        //Add Item to ListView.
                        ListViewItem item = new ListViewItem(row["ID"].ToString());
                        item.SubItems.Add(row["TrainerName"].ToString());
                        item.SubItems.Add(row["TrainerNumber"].ToString());
                        item.SubItems.Add(row["AM1"].ToString());
                        item.SubItems.Add(row["AM2"].ToString());
                        item.SubItems.Add(row["PM1"].ToString());
                        item.SubItems.Add(row["PM2"].ToString());
                        listView1.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Record is Not Existing");
                    sql = "SELECT * FROM TrainerList";
                    load_data(sql, listView1);
                }
            }

        }

        private void load_data2(string sql, ListView lst)
        {
            listView2.Items.Clear();
            using (OleDbDataAdapter da = new OleDbDataAdapter(sql, con))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        //Add Item to ListView.
                        ListViewItem item = new ListViewItem(row["ID"].ToString());
                        item.SubItems.Add(row["MemberName"].ToString());
                        item.SubItems.Add(row["PhoneNumber"].ToString());
                        item.SubItems.Add(row["Age"].ToString());
                        item.SubItems.Add(row["Gender"].ToString());
                        item.SubItems.Add(row["MonthlyAmount"].ToString());
                        item.SubItems.Add(row["Timing"].ToString());
                        item.SubItems.Add(row["Height"].ToString());
                        item.SubItems.Add(row["Weight"].ToString());
                        item.SubItems.Add(row["BMI"].ToString());
                        item.SubItems.Add(row["Trainer"].ToString());
                        listView2.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Record is Not Existing");
                    sql = "SELECT * FROM GymDatabase";
                    load_data2(sql, listView2);
                }
            }

        }

        private void ViewScheduling_Load(object sender, EventArgs e)
        {
            sql = "SELECT * FROM TrainerList";
            sql1 = "SELECT * FROM GymDatabase";
            load_data(sql, listView1);
            load_data2(sql1, listView2);
        }

        private void timingcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timingcombobox.Text == "N/A")
            {
                sql = "SELECT * FROM GymDatabase";
                load_data2(sql1, listView2);
            }
            else if (timingcombobox.Text == "6AM-8AM")
            {
                sql = "SELECT * FROM GymDatabase WHERE Timing='" + timingcombobox.Text + "' AND Trainer Is NULL";
                load_data2(sql, listView2);
            }
            else if (timingcombobox.Text == "8AM-10AM")
            {
                sql = "SELECT * FROM GymDatabase WHERE Timing='" + timingcombobox.Text + "' AND Trainer Is NULL";
                load_data2(sql, listView2);
            }
            else if (timingcombobox.Text == "6PM-8PM")
            {
                sql = "SELECT * FROM GymDatabase WHERE Timing='" + timingcombobox.Text + "' AND Trainer Is NULL";
                load_data2(sql, listView2);
            }
            else if (timingcombobox.Text == "8PM-10PM")
            {
                sql = "SELECT * FROM GymDatabase WHERE Timing='" + timingcombobox.Text + "' AND Trainer Is NULL";
                load_data2(sql, listView2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM GymDatabase WHERE ID LIKE '%" + textBox1.Text + "%' OR MemberName LIKE '%" + textBox1.Text + "%'";
            load_data2(sql, listView2);
        }

        private void schedbtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0 || listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select From Lists first");
            }
            else if (listView2.SelectedItems[0].SubItems[6].Text == "6AM-8AM")
            {
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM TrainerList WHERE AM1='" + listView2.SelectedItems[0].SubItems[0].Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Member Already Assigned");
                }
                else
                {
                    da = new OleDbDataAdapter("SELECT * FROM TrainerList WHERE ID=" + listView1.SelectedItems[0].SubItems[0].Text, con);
                    dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        DialogResult diag = MessageBox.Show("Are you sure to Edit?", "Are you Sure", MessageBoxButtons.YesNo);
                        if (diag == DialogResult.Yes)
                        {
                            con.Open();
                            cmd = new OleDbCommand("UPDATE TrainerList SET TrainerName='" + row["TrainerName"].ToString() + "', TrainerNumber='" + row["TrainerNumber"].ToString() + "', AM1='" + listView2.SelectedItems[0].SubItems[0].Text + "' WHERE ID=" + listView1.SelectedItems[0].SubItems[0].Text, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Updated");
                            con.Close();
                        }
                    }
                }

            }

            else if (listView2.SelectedItems[0].SubItems[6].Text == "8AM-10AM")
            {
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM TrainerList WHERE AM2='" + listView2.SelectedItems[0].SubItems[0].Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Member Already Assigned");
                }
                else
                {
                    da = new OleDbDataAdapter("SELECT * FROM TrainerList WHERE ID=" + listView1.SelectedItems[0].SubItems[0].Text, con);
                    dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        DialogResult diag = MessageBox.Show("Are you sure to Edit?", "Are you Sure", MessageBoxButtons.YesNo);
                        if (diag == DialogResult.Yes)
                        {
                            con.Open();
                            cmd = new OleDbCommand("UPDATE TrainerList SET TrainerName='" + row["TrainerName"].ToString() + "', TrainerNumber='" + row["TrainerNumber"].ToString() + "', AM2='" + listView2.SelectedItems[0].SubItems[0].Text + "' WHERE ID=" + listView1.SelectedItems[0].SubItems[0].Text, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Updated");
                            con.Close();
                        }
                    }
                }
            }

            else if (listView2.SelectedItems[0].SubItems[6].Text == "6PM-8PM")
            {
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM TrainerList WHERE PM1='" + listView2.SelectedItems[0].SubItems[0].Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Member Already Assigned");
                }
                else
                {
                    da = new OleDbDataAdapter("SELECT * FROM TrainerList WHERE ID=" + listView1.SelectedItems[0].SubItems[0].Text, con);
                    dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        DialogResult diag = MessageBox.Show("Are you sure to Edit?", "Are you Sure", MessageBoxButtons.YesNo);
                        if (diag == DialogResult.Yes)
                        {
                            con.Open();
                            cmd = new OleDbCommand("UPDATE TrainerList SET TrainerName='" + row["TrainerName"].ToString() + "', TrainerNumber='" + row["TrainerNumber"].ToString() + "', PM1='" + listView2.SelectedItems[0].SubItems[0].Text + "' WHERE ID=" + listView1.SelectedItems[0].SubItems[0].Text, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Updated");
                            con.Close();
                        }
                    }
                }
            }

            else if (listView2.SelectedItems[0].SubItems[6].Text == "8PM-10PM")
            {
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM TrainerList WHERE PM2='" + listView2.SelectedItems[0].SubItems[0].Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Member Already Assigned");
                }
                else
                {
                    da = new OleDbDataAdapter("SELECT * FROM TrainerList WHERE ID=" + listView1.SelectedItems[0].SubItems[0].Text, con);
                    dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        DialogResult diag = MessageBox.Show("Are you sure to Edit?", "Are you Sure", MessageBoxButtons.YesNo);
                        if (diag == DialogResult.Yes)
                        {
                            con.Open();
                            cmd = new OleDbCommand("UPDATE TrainerList SET TrainerName='" + row["TrainerName"].ToString() + "', TrainerNumber='" + row["TrainerNumber"].ToString() + "', PM2='" + listView2.SelectedItems[0].SubItems[0].Text + "' WHERE ID=" + listView1.SelectedItems[0].SubItems[0].Text, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Updated");
                            con.Close();
                        }
                    }
                }
            }
            sql = "SELECT * FROM TrainerList";
            load_data(sql, listView1);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM TrainerList WHERE ID LIKE '%" + searchtxt.Text + "%' OR TrainerName LIKE '%" + searchtxt.Text + "%'";
            load_data(sql, listView1);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void timingcombobox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Scheduling_Load(object sender, EventArgs e)
        {
            sql = "SELECT * FROM TrainerList";
            sql1 = "SELECT * FROM GymDatabase";
            load_data(sql, listView1);
            load_data2(sql1, listView2);
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            sql = "SELECT * FROM TrainerList WHERE ID LIKE '%" + searchtxt.Text + "%' OR TrainerName LIKE '%" + searchtxt.Text + "%'";
            load_data(sql, listView1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sql = "SELECT * FROM GymDatabase WHERE ID LIKE '%" + textBox1.Text + "%' OR MemberName LIKE '%" + textBox1.Text + "%'";
            load_data2(sql, listView2);
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                sql = "SELECT * FROM TrainerList";
                load_data(sql, listView1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                sql = "SELECT * FROM GymDatabase";
                load_data2(sql, listView2);
            }
        }
    }
}
