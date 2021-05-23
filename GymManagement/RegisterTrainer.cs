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
    public partial class RegisterTrainer : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        OleDbCommand cmd = new OleDbCommand();
        string sql;
        public RegisterTrainer()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (nameTxtBox.Text == "" || phoneTxtBox.Text == "")
            {
                MessageBox.Show("Fill up the Fields");
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand("INSERT INTO TrainerList(TrainerName, TrainerNumber) values('" + nameTxtBox.Text + "', '" + phoneTxtBox.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trainer Registered");
                con.Close();
            }
            nameTxtBox.Clear();
            phoneTxtBox.Clear();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            nameTxtBox.Clear();
            phoneTxtBox.Clear();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
