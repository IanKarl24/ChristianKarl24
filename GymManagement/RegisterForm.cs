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
    public partial class RegisterForm : Form
    {
        OleDbConnection conn=new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb");
        public RegisterForm()
        {
            InitializeComponent();
        }

       

        

       

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            txtbox1.Text = "";
            phoneTxtBox.Text = "";
            bunifuMaterialTextbox1.Text = "";
            gendercombobox.SelectedIndex = -1;
            bunifuMaterialTextbox2.Text = "";
            timingcombobox.SelectedIndex = -1;
            bunifuMaterialTextbox3.Text = "";
            bunifuMaterialTextbox4.Text = "";
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text == "" || phoneTxtBox.Text == "" || bunifuMaterialTextbox1.Text == "" || gendercombobox.Text == "" || bunifuMaterialTextbox2.Text == "" || timingcombobox.Text == "" || bunifuMaterialTextbox3.Text == "" || bunifuMaterialTextbox4.Text == "")
            {
                MessageBox.Show("Fill all the Fields!");
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand("Insert into GymDatabase(MemberName, PhoneNumber, Age, Gender, MonthlyAmount, Timing, Height, Weight, BMI) values('" + txtbox1.Text + "', " + phoneTxtBox.Text + ", " + bunifuMaterialTextbox1.Text + ", '" + gendercombobox.Text + "', " + bunifuMaterialTextbox1.Text + ", '" + timingcombobox.Text + "', " + bunifuMaterialTextbox3.Text + ", " + bunifuMaterialTextbox4.Text + ", " + float.Parse(bunifuMaterialTextbox4.Text) / (float.Parse(bunifuMaterialTextbox3.Text) * float.Parse(bunifuMaterialTextbox3.Text)) + ")", conn);
                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account Registered");
                conn.Close();
            }
            txtbox1.Text = "";
            phoneTxtBox.Text = "";
            bunifuMaterialTextbox1.Text = "";
            gendercombobox.SelectedIndex = -1;
            bunifuMaterialTextbox2.Text = "";
            timingcombobox.SelectedIndex = -1;
            bunifuMaterialTextbox3.Text = "";
            bunifuMaterialTextbox4.Text = "";
        }
    }
}
