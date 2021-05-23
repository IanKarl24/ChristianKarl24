namespace GymManagement
{
    partial class Scheduling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.schedbtn = new System.Windows.Forms.Button();
            this.timingcombobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Trainer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BMI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Timing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.PM2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PM1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AM2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AM1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrainerNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrainerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Member List";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(752, 442);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(130, 46);
            this.backbtn.TabIndex = 27;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            // 
            // schedbtn
            // 
            this.schedbtn.Location = new System.Drawing.Point(566, 442);
            this.schedbtn.Name = "schedbtn";
            this.schedbtn.Size = new System.Drawing.Size(130, 46);
            this.schedbtn.TabIndex = 26;
            this.schedbtn.Text = "Add Schedule";
            this.schedbtn.UseVisualStyleBackColor = true;
            this.schedbtn.Click += new System.EventHandler(this.schedbtn_Click);
            // 
            // timingcombobox
            // 
            this.timingcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timingcombobox.FormattingEnabled = true;
            this.timingcombobox.Items.AddRange(new object[] {
            "N/A",
            "6AM-8AM",
            "8AM-10AM",
            "6PM-8PM",
            "8PM-10PM"});
            this.timingcombobox.Location = new System.Drawing.Point(704, 93);
            this.timingcombobox.Name = "timingcombobox";
            this.timingcombobox.Size = new System.Drawing.Size(140, 21);
            this.timingcombobox.TabIndex = 25;
            this.timingcombobox.SelectedIndexChanged += new System.EventHandler(this.timingcombobox_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Timing";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(779, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(609, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Trainer
            // 
            this.Trainer.Text = "TrainerID";
            // 
            // BMI
            // 
            this.BMI.Text = "BMI";
            // 
            // Weight
            // 
            this.Weight.Text = "Weight";
            // 
            // Height
            // 
            this.Height.Text = "Height";
            // 
            // Timing
            // 
            this.Timing.Text = "Timing";
            this.Timing.Width = 106;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 79;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 95;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "PhoneNumber";
            this.PhoneNumber.Width = 120;
            // 
            // NAME
            // 
            this.NAME.Text = "Name";
            this.NAME.Width = 131;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.NAME,
            this.PhoneNumber,
            this.Age,
            this.Gender,
            this.Amount,
            this.Timing,
            this.Height,
            this.Weight,
            this.BMI,
            this.Trainer});
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(524, 120);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(438, 287);
            this.listView2.TabIndex = 23;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // PM2
            // 
            this.PM2.Text = "8PM-10PM";
            // 
            // PM1
            // 
            this.PM1.Text = "6PM-8PM";
            // 
            // AM2
            // 
            this.AM2.Text = "8AM-10AM";
            // 
            // AM1
            // 
            this.AM1.Text = "6AM-8AM";
            this.AM1.Width = 64;
            // 
            // TrainerNumber
            // 
            this.TrainerNumber.Text = "TrainerNumber";
            this.TrainerNumber.Width = 102;
            // 
            // TrainerName
            // 
            this.TrainerName.Text = "TrainerName";
            this.TrainerName.Width = 91;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Trainer List";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(190, 68);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(103, 35);
            this.searchBtn.TabIndex = 20;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(20, 71);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(164, 20);
            this.searchtxt.TabIndex = 19;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.TrainerName,
            this.TrainerNumber,
            this.AM1,
            this.AM2,
            this.PM1,
            this.PM2});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(20, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(498, 287);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.schedbtn);
            this.Controls.Add(this.timingcombobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scheduling";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Scheduling_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button schedbtn;
        private System.Windows.Forms.ComboBox timingcombobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader NAME;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Timing;
        private System.Windows.Forms.ColumnHeader Height;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader BMI;
        private System.Windows.Forms.ColumnHeader Trainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader TrainerName;
        private System.Windows.Forms.ColumnHeader TrainerNumber;
        private System.Windows.Forms.ColumnHeader AM1;
        private System.Windows.Forms.ColumnHeader AM2;
        private System.Windows.Forms.ColumnHeader PM1;
        private System.Windows.Forms.ColumnHeader PM2;
    }
}