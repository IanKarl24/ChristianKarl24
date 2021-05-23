namespace GymManagement
{
    partial class TrainerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerList));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrainerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrainerNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AM1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AM2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PM1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PM2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idlbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.phoneTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.savebtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.trainertxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.numbertxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fitness Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(162, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trainer List";
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
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(431, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(508, 371);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // TrainerName
            // 
            this.TrainerName.Text = "TrainerName";
            this.TrainerName.Width = 91;
            // 
            // TrainerNumber
            // 
            this.TrainerNumber.Text = "TrainerNumber";
            this.TrainerNumber.Width = 102;
            // 
            // AM1
            // 
            this.AM1.Text = "6AM-8AM";
            this.AM1.Width = 64;
            // 
            // AM2
            // 
            this.AM2.Text = "8AM-10AM";
            // 
            // PM1
            // 
            this.PM1.Text = "6PM-8PM";
            // 
            // PM2
            // 
            this.PM2.Text = "8PM-10PM";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.idlbl.Location = new System.Drawing.Point(15, 110);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(15, 17);
            this.idlbl.TabIndex = 30;
            this.idlbl.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(15, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "ID";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Trainer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Trainer Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phoneTxtBox.ForeColor = System.Drawing.Color.White;
            this.phoneTxtBox.HintForeColor = System.Drawing.Color.Empty;
            this.phoneTxtBox.HintText = "";
            this.phoneTxtBox.isPassword = true;
            this.phoneTxtBox.LineFocusedColor = System.Drawing.Color.Teal;
            this.phoneTxtBox.LineIdleColor = System.Drawing.Color.Gray;
            this.phoneTxtBox.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.phoneTxtBox.LineThickness = 3;
            this.phoneTxtBox.Location = new System.Drawing.Point(238, 110);
            this.phoneTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(172, 44);
            this.phoneTxtBox.TabIndex = 38;
            this.phoneTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneTxtBox.OnValueChanged += new System.EventHandler(this.phoneTxtBox_OnValueChanged);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "SEARCH";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 30;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton21.Location = new System.Drawing.Point(272, 78);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(109, 39);
            this.bunifuThinButton21.TabIndex = 39;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "EDIT";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 30;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton22.Location = new System.Drawing.Point(204, 174);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(109, 39);
            this.bunifuThinButton22.TabIndex = 40;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "DELETE";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 30;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton23.Location = new System.Drawing.Point(321, 174);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(109, 39);
            this.bunifuThinButton23.TabIndex = 41;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton24.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "BACK";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 30;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton24.Location = new System.Drawing.Point(204, 250);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(109, 39);
            this.bunifuThinButton24.TabIndex = 42;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton25.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "VIEW ";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 30;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton25.Location = new System.Drawing.Point(321, 250);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(109, 39);
            this.bunifuThinButton25.TabIndex = 43;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // savebtn
            // 
            this.savebtn.ActiveBorderThickness = 1;
            this.savebtn.ActiveCornerRadius = 20;
            this.savebtn.ActiveFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savebtn.ActiveForecolor = System.Drawing.Color.White;
            this.savebtn.ActiveLineColor = System.Drawing.Color.Aqua;
            this.savebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.savebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savebtn.BackgroundImage")));
            this.savebtn.ButtonText = "SAVE";
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.Black;
            this.savebtn.IdleBorderThickness = 1;
            this.savebtn.IdleCornerRadius = 30;
            this.savebtn.IdleFillColor = System.Drawing.Color.Aqua;
            this.savebtn.IdleForecolor = System.Drawing.Color.White;
            this.savebtn.IdleLineColor = System.Drawing.Color.Aqua;
            this.savebtn.Location = new System.Drawing.Point(34, 272);
            this.savebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(109, 39);
            this.savebtn.TabIndex = 44;
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savebtn.Click += new System.EventHandler(this.bunifuThinButton26_Click);
            // 
            // trainertxt
            // 
            this.trainertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trainertxt.Enabled = false;
            this.trainertxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.trainertxt.ForeColor = System.Drawing.Color.White;
            this.trainertxt.HintForeColor = System.Drawing.Color.Empty;
            this.trainertxt.HintText = "";
            this.trainertxt.isPassword = true;
            this.trainertxt.LineFocusedColor = System.Drawing.Color.Teal;
            this.trainertxt.LineIdleColor = System.Drawing.Color.Gray;
            this.trainertxt.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.trainertxt.LineThickness = 3;
            this.trainertxt.Location = new System.Drawing.Point(13, 157);
            this.trainertxt.Margin = new System.Windows.Forms.Padding(4);
            this.trainertxt.Name = "trainertxt";
            this.trainertxt.Size = new System.Drawing.Size(172, 44);
            this.trainertxt.TabIndex = 45;
            this.trainertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // numbertxt
            // 
            this.numbertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numbertxt.Enabled = false;
            this.numbertxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.numbertxt.ForeColor = System.Drawing.Color.White;
            this.numbertxt.HintForeColor = System.Drawing.Color.Empty;
            this.numbertxt.HintText = "";
            this.numbertxt.isPassword = true;
            this.numbertxt.LineFocusedColor = System.Drawing.Color.Teal;
            this.numbertxt.LineIdleColor = System.Drawing.Color.Gray;
            this.numbertxt.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.numbertxt.LineThickness = 3;
            this.numbertxt.Location = new System.Drawing.Point(13, 219);
            this.numbertxt.Margin = new System.Windows.Forms.Padding(4);
            this.numbertxt.Name = "numbertxt";
            this.numbertxt.Size = new System.Drawing.Size(172, 44);
            this.numbertxt.TabIndex = 46;
            this.numbertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TrainerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(939, 371);
            this.Controls.Add(this.numbertxt);
            this.Controls.Add(this.trainertxt);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.phoneTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrainerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainerList";
            this.Load += new System.EventHandler(this.TrainerList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader TrainerName;
        private System.Windows.Forms.ColumnHeader TrainerNumber;
        private System.Windows.Forms.ColumnHeader AM1;
        private System.Windows.Forms.ColumnHeader AM2;
        private System.Windows.Forms.ColumnHeader PM1;
        private System.Windows.Forms.ColumnHeader PM2;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneTxtBox;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 savebtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuMaterialTextbox numbertxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox trainertxt;
    }
}