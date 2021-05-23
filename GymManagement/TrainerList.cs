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
    public partial class TrainerList : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        OleDbCommand cmd = new OleDbCommand();
        string sql;
        public TrainerList()
        {
            InitializeComponent();
        }

        private void TrainerList_Load(object sender, EventArgs e)
        {
            sql = "SELECT * FROM TrainerList";
            load_data(sql, listView1);
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
                    //Loop through the DataTable.
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
                    MessageBox.Show("Record not Existing");
                    sql = "SELECT * FROM TrainerList";
                    load_data(sql, listView1);
                }
            }
        }

       
        
       
        

        private void schedbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select from the List");
            }
            else
            {
                savebtn.Enabled = true;
                trainertxt.Enabled = true;
                numbertxt.Enabled = true;
                if (listView1.SelectedItems.Count > 0)
                {
                    idlbl.Text = listView1.SelectedItems[0].SubItems[0].Text;
                    trainertxt.Text = listView1.SelectedItems[0].SubItems[1].Text;
                    numbertxt.Text = listView1.SelectedItems[0].SubItems[2].Text;
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select from the List");
            }
            else
            {
                DialogResult diag = MessageBox.Show("Are You Sure to Delete Record?", "Delete Record", MessageBoxButtons.YesNo);
                if (diag == DialogResult.Yes)
                {
                    cmd = new OleDbCommand("Delete from TrainerList WHERE ID=" + listView1.SelectedItems[0].SubItems[0].Text, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                    sql = "SELECT * FROM TrainerList";
                    load_data(sql, listView1);
                    con.Close();
                }
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            if (trainertxt.Text == "" || numbertxt.Text == "")
            {
                MessageBox.Show("Please fill up all the Fields");
            }
            else
            {
                OleDbDataAdapter da = new OleDbDataAdapter("Select * From TrainerList WHERE TrainerName='" + trainertxt.Text + "' AND TrainerNumber='" + numbertxt.Text + "'", con);
                con.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Info already Exist");
                }
                else
                {
                    cmd = new OleDbCommand("UPDATE TrainerList SET TrainerName='" + trainertxt.Text + "', TrainerNumber='" + numbertxt.Text + "' WHERE ID=" + idlbl.Text, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");
                    sql = "SELECT * FROM TrainerList";
                    load_data(sql, listView1);
                }
                con.Close();
            }
            trainertxt.Text = "";
            numbertxt.Text = "";
            trainertxt.Enabled = false;
            numbertxt.Enabled = false;

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Scheduling sd = new Scheduling();
            sd.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM TrainerList WHERE ID LIKE '%"+phoneTxtBox.Text+"%' OR TrainerName LIKE '%"+phoneTxtBox.Text+"%'";
            load_data(sql, listView1);
        }

        private void phoneTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (phoneTxtBox.Text == "")
            {
                sql = "SELECT * FROM TrainerList";
                load_data(sql, listView1);
            }
        }
    }
}
