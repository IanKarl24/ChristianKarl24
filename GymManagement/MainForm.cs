using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MemberList ml = new MemberList();
            ml.Show();
            this.Hide();
        }

       

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
        {
            ChooseRegForm cr = new ChooseRegForm();
            cr.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            TrainerList tr = new TrainerList();
            tr.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
