namespace AQC_Manager
{
    partial class mainWindow
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
            this.mainTabCtrl = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.aboutSbtn = new System.Windows.Forms.Button();
            this.testing = new System.Windows.Forms.Button();
            this.noticeGroup = new System.Windows.Forms.GroupBox();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnWPS = new System.Windows.Forms.Button();
            this.btnExpiry = new System.Windows.Forms.Button();
            this.btnEmloyees = new System.Windows.Forms.Button();
            this.compainy = new System.Windows.Forms.TabPage();
            this.emloyees = new System.Windows.Forms.TabPage();
            this.btnRemoveEmp = new System.Windows.Forms.Button();
            this.empEditSave = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEmpAddNew = new System.Windows.Forms.Button();
            this.wps = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.expiries = new System.Windows.Forms.TabPage();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainTabCtrl.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.emloyees.SuspendLayout();
            this.wps.SuspendLayout();
            this.expiries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabCtrl
            // 
            this.mainTabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabCtrl.Controls.Add(this.mainPage);
            this.mainTabCtrl.Controls.Add(this.compainy);
            this.mainTabCtrl.Controls.Add(this.emloyees);
            this.mainTabCtrl.Controls.Add(this.wps);
            this.mainTabCtrl.Controls.Add(this.expiries);
            this.mainTabCtrl.Location = new System.Drawing.Point(12, 126);
            this.mainTabCtrl.Name = "mainTabCtrl";
            this.mainTabCtrl.SelectedIndex = 0;
            this.mainTabCtrl.Size = new System.Drawing.Size(760, 424);
            this.mainTabCtrl.TabIndex = 0;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.aboutSbtn);
            this.mainPage.Controls.Add(this.testing);
            this.mainPage.Controls.Add(this.noticeGroup);
            this.mainPage.Controls.Add(this.btnCompany);
            this.mainPage.Controls.Add(this.btnWPS);
            this.mainPage.Controls.Add(this.btnExpiry);
            this.mainPage.Controls.Add(this.btnEmloyees);
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(752, 398);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "MAIN";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // aboutSbtn
            // 
            this.aboutSbtn.BackColor = System.Drawing.Color.Transparent;
            this.aboutSbtn.BackgroundImage = global::AQC_Manager.Properties.Resources._1434683082_about;
            this.aboutSbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutSbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.aboutSbtn.FlatAppearance.BorderSize = 0;
            this.aboutSbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.aboutSbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.aboutSbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutSbtn.Location = new System.Drawing.Point(3, 368);
            this.aboutSbtn.Name = "aboutSbtn";
            this.aboutSbtn.Size = new System.Drawing.Size(29, 24);
            this.aboutSbtn.TabIndex = 3;
            this.aboutSbtn.UseVisualStyleBackColor = false;
            this.aboutSbtn.Click += new System.EventHandler(this.aboutSbtn_Click);
            // 
            // testing
            // 
            this.testing.Location = new System.Drawing.Point(38, 368);
            this.testing.Name = "testing";
            this.testing.Size = new System.Drawing.Size(75, 23);
            this.testing.TabIndex = 2;
            this.testing.Text = "testing...";
            this.testing.UseVisualStyleBackColor = true;
            this.testing.Click += new System.EventHandler(this.testing_Click);
            // 
            // noticeGroup
            // 
            this.noticeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeGroup.Location = new System.Drawing.Point(431, 6);
            this.noticeGroup.Name = "noticeGroup";
            this.noticeGroup.Size = new System.Drawing.Size(318, 386);
            this.noticeGroup.TabIndex = 1;
            this.noticeGroup.TabStop = false;
            this.noticeGroup.Text = "Notice Board";
            this.buttonInfo.SetToolTip(this.noticeGroup, "\"Latest News, Epiries,Company Informations");
            // 
            // btnCompany
            // 
            this.btnCompany.BackgroundImage = global::AQC_Manager.Properties.Resources._1433180300_factory;
            this.btnCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompany.FlatAppearance.BorderSize = 0;
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompany.Location = new System.Drawing.Point(111, 45);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(65, 66);
            this.btnCompany.TabIndex = 0;
            this.buttonInfo.SetToolTip(this.btnCompany, "Company Informations");
            this.btnCompany.UseVisualStyleBackColor = false;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnWPS
            // 
            this.btnWPS.BackgroundImage = global::AQC_Manager.Properties.Resources._1432639004_Salary;
            this.btnWPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWPS.FlatAppearance.BorderSize = 0;
            this.btnWPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWPS.Location = new System.Drawing.Point(16, 181);
            this.btnWPS.Name = "btnWPS";
            this.btnWPS.Size = new System.Drawing.Size(75, 75);
            this.btnWPS.TabIndex = 0;
            this.buttonInfo.SetToolTip(this.btnWPS, "\"WPS\"");
            this.btnWPS.UseVisualStyleBackColor = true;
            this.btnWPS.Click += new System.EventHandler(this.btnWPS_Click);
            // 
            // btnExpiry
            // 
            this.btnExpiry.BackColor = System.Drawing.Color.Transparent;
            this.btnExpiry.BackgroundImage = global::AQC_Manager.Properties.Resources.config_date;
            this.btnExpiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpiry.FlatAppearance.BorderSize = 0;
            this.btnExpiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpiry.Location = new System.Drawing.Point(191, 36);
            this.btnExpiry.Name = "btnExpiry";
            this.btnExpiry.Size = new System.Drawing.Size(75, 75);
            this.btnExpiry.TabIndex = 0;
            this.btnExpiry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExpiry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpiry.UseMnemonic = false;
            this.btnExpiry.UseVisualStyleBackColor = true;
            this.btnExpiry.Click += new System.EventHandler(this.btnExpiry_Click);
            // 
            // btnEmloyees
            // 
            this.btnEmloyees.BackColor = System.Drawing.Color.Transparent;
            this.btnEmloyees.BackgroundImage = global::AQC_Manager.Properties.Resources._1432580807_free_17;
            this.btnEmloyees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmloyees.FlatAppearance.BorderSize = 0;
            this.btnEmloyees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmloyees.Location = new System.Drawing.Point(16, 41);
            this.btnEmloyees.Name = "btnEmloyees";
            this.btnEmloyees.Size = new System.Drawing.Size(75, 75);
            this.btnEmloyees.TabIndex = 0;
            this.btnEmloyees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmloyees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInfo.SetToolTip(this.btnEmloyees, "\"View Emplyees Details\"");
            this.btnEmloyees.UseMnemonic = false;
            this.btnEmloyees.UseVisualStyleBackColor = true;
            this.btnEmloyees.Click += new System.EventHandler(this.btnEmloyees_Click);
            // 
            // compainy
            // 
            this.compainy.Location = new System.Drawing.Point(4, 22);
            this.compainy.Name = "compainy";
            this.compainy.Size = new System.Drawing.Size(752, 398);
            this.compainy.TabIndex = 4;
            this.compainy.Text = "Company";
            this.compainy.UseVisualStyleBackColor = true;
            // 
            // emloyees
            // 
            this.emloyees.AutoScroll = true;
            this.emloyees.Controls.Add(this.btnRemoveEmp);
            this.emloyees.Controls.Add(this.empEditSave);
            this.emloyees.Controls.Add(this.btn_Next);
            this.emloyees.Controls.Add(this.btn_Prev);
            this.emloyees.Controls.Add(this.button3);
            this.emloyees.Controls.Add(this.btnEmpAddNew);
            this.emloyees.ImageKey = "(none)";
            this.emloyees.Location = new System.Drawing.Point(4, 22);
            this.emloyees.Name = "emloyees";
            this.emloyees.Padding = new System.Windows.Forms.Padding(3);
            this.emloyees.Size = new System.Drawing.Size(752, 398);
            this.emloyees.TabIndex = 2;
            this.emloyees.Text = "Employees";
            this.emloyees.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEmp
            // 
            this.btnRemoveEmp.Location = new System.Drawing.Point(253, 7);
            this.btnRemoveEmp.Name = "btnRemoveEmp";
            this.btnRemoveEmp.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveEmp.TabIndex = 35;
            this.btnRemoveEmp.Text = "Delete";
            this.btnRemoveEmp.UseVisualStyleBackColor = true;
            // 
            // empEditSave
            // 
            this.empEditSave.Location = new System.Drawing.Point(172, 7);
            this.empEditSave.Name = "empEditSave";
            this.empEditSave.Size = new System.Drawing.Size(75, 23);
            this.empEditSave.TabIndex = 32;
            this.empEditSave.Text = "Edit";
            this.empEditSave.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(714, 148);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(32, 100);
            this.btn_Next.TabIndex = 18;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(6, 148);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(32, 100);
            this.btn_Prev.TabIndex = 18;
            this.btn_Prev.Text = "<";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "List View";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEmpAddNew
            // 
            this.btnEmpAddNew.Location = new System.Drawing.Point(9, 6);
            this.btnEmpAddNew.Name = "btnEmpAddNew";
            this.btnEmpAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnEmpAddNew.TabIndex = 3;
            this.btnEmpAddNew.Text = "Add New";
            this.btnEmpAddNew.UseVisualStyleBackColor = true;
            this.btnEmpAddNew.Click += new System.EventHandler(this.btnEmpAddNew_Click);
            // 
            // wps
            // 
            this.wps.Controls.Add(this.button9);
            this.wps.Controls.Add(this.button8);
            this.wps.Controls.Add(this.button7);
            this.wps.Controls.Add(this.button6);
            this.wps.Controls.Add(this.button5);
            this.wps.Controls.Add(this.button4);
            this.wps.Location = new System.Drawing.Point(4, 22);
            this.wps.Name = "wps";
            this.wps.Padding = new System.Windows.Forms.Padding(3);
            this.wps.Size = new System.Drawing.Size(752, 398);
            this.wps.TabIndex = 1;
            this.wps.Text = "WPS";
            this.wps.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(405, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "button4";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(324, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "button4";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(243, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "button4";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(162, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "button4";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(81, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "View Record";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "New WPS";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // expiries
            // 
            this.expiries.Controls.Add(this.button15);
            this.expiries.Controls.Add(this.button14);
            this.expiries.Controls.Add(this.button13);
            this.expiries.Controls.Add(this.button12);
            this.expiries.Controls.Add(this.button11);
            this.expiries.Controls.Add(this.button10);
            this.expiries.Location = new System.Drawing.Point(4, 22);
            this.expiries.Name = "expiries";
            this.expiries.Size = new System.Drawing.Size(752, 398);
            this.expiries.TabIndex = 3;
            this.expiries.Text = "Expiries";
            this.expiries.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(405, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 0;
            this.button15.Text = "Daman";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(324, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 0;
            this.button14.Text = "Driving Licences";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(243, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 0;
            this.button13.Text = "Labore Card";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(162, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 0;
            this.button12.Text = "ID Card";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(81, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 0;
            this.button11.Text = "Visa";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(0, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "Passport";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::AQC_Manager.Properties.Resources.xxxxx11;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.mainTabCtrl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AQC";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.mainTabCtrl.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.emloyees.ResumeLayout(false);
            this.wps.ResumeLayout(false);
            this.expiries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabCtrl;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TabPage wps;
        private System.Windows.Forms.Button btnEmloyees;
        private System.Windows.Forms.TabPage emloyees;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnWPS;
        private System.Windows.Forms.ToolTip buttonInfo;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage expiries;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TabPage compainy;
        private System.Windows.Forms.GroupBox noticeGroup;
        private System.Windows.Forms.Button btnExpiry;
        private System.Windows.Forms.Button btnEmpAddNew;
        private System.Windows.Forms.Button testing;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button empEditSave;
        private System.Windows.Forms.Button btnRemoveEmp;
        private System.Windows.Forms.Button aboutSbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

