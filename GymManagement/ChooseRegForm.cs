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
    public partial class ChooseRegForm : Form
    {
        public ChooseRegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterTrainer rt = new RegisterTrainer();
            rt.Show();
            this.Hide();
        }
    }
}
