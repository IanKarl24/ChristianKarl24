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
    public partial class MemberList : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        OleDbCommand cmd = new OleDbCommand();
        string sql;
        public MemberList()
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
                        //Loop through the DataTable.
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
                            listView1.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Record is Not Existing");
                        sql = "SELECT * FROM GymDatabase";
                        load_data(sql, listView1);
                    }
                }
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM GymDatabase WHERE ID LIKE '%" + bunifuMaterialTextbox1.Text + "%' OR MemberName LIKE '%" + bunifuMaterialTextbox1.Text + "%'";
            load_data(sql, listView1);
        }

        private void MemberList_Load(object sender, EventArgs e)
        {
            sql = "SELECT * FROM GymDatabase";
            load_data(sql, listView1);
        }

      

      

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idlbl.Text = "0";
            savebtn.Enabled = false;
            membertxt.Enabled = false;
            phonetxt.Enabled = false;
            agetxt.Enabled = false;
            gendercombo.Enabled = false;
            monthlytxt.Enabled = false;
            timingcombo.Enabled = false;
            heighttxt.Enabled = false;
            weighttxt.Enabled = false;
            membertxt.Text = "";
            phonetxt.Text = "";
            agetxt.Text = "";
            gendercombo.SelectedIndex = -1;
            monthlytxt.Text = "";
            timingcombo.SelectedIndex = -1;
            heighttxt.Text = "";
            weighttxt.Text = "";
            bmilbl.Text = "0";
        }

       

       
        private void bunifuThinButton21_Click(object sender, EventArgs e)
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
                    cmd = new OleDbCommand("Delete From GymDatabase WHERE ID=" + listView1.SelectedItems[0].SubItems[0].Text, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                    sql = "SELECT * FROM GymDatabase";
                    load_data(sql, listView1);
                    con.Close();
                }
            }
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
                membertxt.Enabled = true;
                phonetxt.Enabled = true;
                agetxt.Enabled = true;
                gendercombo.Enabled = true;
                monthlytxt.Enabled = true;
                timingcombo.Enabled = true;
                heighttxt.Enabled = true;
                weighttxt.Enabled = true;
                if (listView1.SelectedItems.Count > 0)
                {
                    idlbl.Text = listView1.SelectedItems[0].SubItems[0].Text;
                    membertxt.Text = listView1.SelectedItems[0].SubItems[1].Text;
                    phonetxt.Text = listView1.SelectedItems[0].SubItems[2].Text;
                    agetxt.Text = listView1.SelectedItems[0].SubItems[3].Text;
                    gendercombo.Text = listView1.SelectedItems[0].SubItems[4].Text;
                    monthlytxt.Text = listView1.SelectedItems[0].SubItems[5].Text;
                    timingcombo.Text = listView1.SelectedItems[0].SubItems[6].Text;
                    heighttxt.Text = listView1.SelectedItems[0].SubItems[7].Text;
                    weighttxt.Text = listView1.SelectedItems[0].SubItems[8].Text;
                    bmilbl.Text = listView1.SelectedItems[0].SubItems[9].Text;
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM GymDatabase WHERE ID LIKE '%" + bunifuMaterialTextbox1.Text + "%' OR MemberName LIKE '%" + bunifuMaterialTextbox1.Text + "%'";
            load_data(sql, listView1);
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (membertxt.Text == "" || phonetxt.Text == "" || agetxt.Text == "" || gendercombo.Text == "" || monthlytxt.Text == "" || timingcombo.Text == "" || weighttxt.Text == "")
            {
                MessageBox.Show("Fill all the Fields");
            }
            else
            {
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from GymDatabase where MemberName='" + membertxt.Text + "' AND PhoneNumber='" + phonetxt.Text + "' AND Age=" + agetxt.Text + " AND Gender='" + gendercombo.Text + "' AND MonthlyAmount=" + monthlytxt.Text + " AND Timing='" + timingcombo.Text + "' AND Height=" + heighttxt.Text + " AND Weight=" + weighttxt.Text, con);
                con.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Info already Exist");
                    con.Close();
                }
                else
                {
                    cmd = new OleDbCommand("UPDATE GymDatabase SET MemberName='" + membertxt.Text + "', PhoneNumber='" + phonetxt.Text + "', Age=" + agetxt.Text + ", Gender='" + gendercombo.Text + "', MonthlyAmount=" + monthlytxt.Text + ", Timing='" + timingcombo.Text + "', Height=" + heighttxt.Text + ", Weight=" + weighttxt.Text + ", BMI=" + float.Parse(weighttxt.Text) / (float.Parse(heighttxt.Text) * float.Parse(heighttxt.Text)) + " WHERE ID=" + idlbl.Text, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");
                    sql = "SELECT * FROM GymDatabase";
                    load_data(sql, listView1);
                    con.Close();
                    idlbl.Text = "0";
                    savebtn.Enabled = false;
                    membertxt.Enabled = false;
                    phonetxt.Enabled = false;
                    agetxt.Enabled = false;
                    gendercombo.Enabled = false;
                    monthlytxt.Enabled = false;
                    timingcombo.Enabled = false;
                    heighttxt.Enabled = false;
                    weighttxt.Enabled = false;
                    membertxt.Text = "";
                    phonetxt.Text = "";
                    agetxt.Text = "";
                    gendercombo.SelectedIndex = -1;
                    monthlytxt.Text = "";
                    timingcombo.SelectedIndex = -1;
                    heighttxt.Text = "";
                    weighttxt.Text = "";
                    bmilbl.Text = "0";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                sql = "SELECT * FROM GymDatabase";
                load_data(sql, listView1);
            }
        }

    }
}
