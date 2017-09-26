namespace Client.Student
{
    partial class StudentPlat
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
            this.head = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.windowClose = new System.Windows.Forms.Label();
            this.windowMin = new System.Windows.Forms.Label();
            this.windowStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmpLogo = new System.Windows.Forms.Label();
            this.navigationBar = new System.Windows.Forms.Panel();
            this.myExamPage = new System.Windows.Forms.Label();
            this.examHome = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.userNameShow = new System.Windows.Forms.Label();
            this.chinese = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.myExamList = new Client.Student.MyExamList();
            this.studentHome = new Client.Student.StudentHome();
            this.head.SuspendLayout();
            this.panel2.SuspendLayout();
            this.navigationBar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.head.Controls.Add(this.panel2);
            this.head.Controls.Add(this.label1);
            this.head.Controls.Add(this.cmpLogo);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1024, 38);
            this.head.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.windowClose);
            this.panel2.Controls.Add(this.windowMin);
            this.panel2.Controls.Add(this.windowStatus);
            this.panel2.Location = new System.Drawing.Point(888, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 25);
            this.panel2.TabIndex = 7;
            // 
            // windowClose
            // 
            this.windowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowClose.Image = global::Client.Properties.Resources.ICN_Client_Close_Program_21X21;
            this.windowClose.Location = new System.Drawing.Point(83, 0);
            this.windowClose.Name = "windowClose";
            this.windowClose.Size = new System.Drawing.Size(26, 23);
            this.windowClose.TabIndex = 5;
            // 
            // windowMin
            // 
            this.windowMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowMin.Image = global::Client.Properties.Resources.ICN_Client_Min_Program_22X22;
            this.windowMin.Location = new System.Drawing.Point(13, 1);
            this.windowMin.Name = "windowMin";
            this.windowMin.Size = new System.Drawing.Size(29, 22);
            this.windowMin.TabIndex = 4;
            // 
            // windowStatus
            // 
            this.windowStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowStatus.Image = global::Client.Properties.Resources.ICN_Client_Max_Or_Normal_Program_22X22;
            this.windowStatus.Location = new System.Drawing.Point(48, 1);
            this.windowStatus.Name = "windowStatus";
            this.windowStatus.Size = new System.Drawing.Size(29, 22);
            this.windowStatus.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Online Exam System Client";
            // 
            // cmpLogo
            // 
            this.cmpLogo.Image = global::Client.Properties.Resources.LOGO_Client_Titel_120x20;
            this.cmpLogo.Location = new System.Drawing.Point(20, 12);
            this.cmpLogo.Name = "cmpLogo";
            this.cmpLogo.Size = new System.Drawing.Size(136, 20);
            this.cmpLogo.TabIndex = 1;
            // 
            // navigationBar
            // 
            this.navigationBar.BackColor = System.Drawing.Color.White;
            this.navigationBar.Controls.Add(this.myExamPage);
            this.navigationBar.Controls.Add(this.examHome);
            this.navigationBar.Controls.Add(this.flowLayoutPanel1);
            this.navigationBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar.Location = new System.Drawing.Point(0, 38);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(1024, 40);
            this.navigationBar.TabIndex = 2;
            // 
            // myExamPage
            // 
            this.myExamPage.Font = new System.Drawing.Font("Arial", 13.5F);
            this.myExamPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.myExamPage.Location = new System.Drawing.Point(137, 0);
            this.myExamPage.Name = "myExamPage";
            this.myExamPage.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.myExamPage.Size = new System.Drawing.Size(100, 40);
            this.myExamPage.TabIndex = 4;
            this.myExamPage.Text = "My Exam";
            this.myExamPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // examHome
            // 
            this.examHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.examHome.Font = new System.Drawing.Font("Arial", 13.5F);
            this.examHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.examHome.Location = new System.Drawing.Point(39, 0);
            this.examHome.Margin = new System.Windows.Forms.Padding(0);
            this.examHome.Name = "examHome";
            this.examHome.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.examHome.Size = new System.Drawing.Size(80, 40);
            this.examHome.TabIndex = 3;
            this.examHome.Text = "Home";
            this.examHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.userNameShow);
            this.flowLayoutPanel1.Controls.Add(this.chinese);
            this.flowLayoutPanel1.Controls.Add(this.logout);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(753, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(256, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Image = global::Client.Properties.Resources.ICN_Client_PersonalInformation_20x20;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 22);
            this.label5.TabIndex = 2;
            // 
            // userNameShow
            // 
            this.userNameShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameShow.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.userNameShow.Location = new System.Drawing.Point(37, 0);
            this.userNameShow.Name = "userNameShow";
            this.userNameShow.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.userNameShow.Size = new System.Drawing.Size(86, 22);
            this.userNameShow.TabIndex = 1;
            this.userNameShow.Text = "UserName";
            // 
            // chinese
            // 
            this.chinese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chinese.Font = new System.Drawing.Font("SimHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chinese.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.chinese.Location = new System.Drawing.Point(129, 0);
            this.chinese.Name = "chinese";
            this.chinese.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.chinese.Size = new System.Drawing.Size(55, 22);
            this.chinese.TabIndex = 3;
            this.chinese.Text = "中文";
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logout.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.logout.Location = new System.Drawing.Point(190, 0);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.logout.Size = new System.Drawing.Size(58, 22);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.myExamList);
            this.panel4.Controls.Add(this.studentHome);
            this.panel4.Location = new System.Drawing.Point(20, 98);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(980, 640);
            this.panel4.TabIndex = 3;
            // 
            // myExamList
            // 
            this.myExamList.BackColor = System.Drawing.Color.White;
            this.myExamList.Location = new System.Drawing.Point(486, 79);
            this.myExamList.Name = "myExamList";
            this.myExamList.Size = new System.Drawing.Size(278, 312);
            this.myExamList.TabIndex = 1;
            this.myExamList.Underline = System.Drawing.FontStyle.Regular;
            this.myExamList.Visible = false;
            // 
            // studentHome
            // 
            this.studentHome.BackColor = System.Drawing.Color.White;
            this.studentHome.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.studentHome.Location = new System.Drawing.Point(58, 38);
            this.studentHome.Margin = new System.Windows.Forms.Padding(4);
            this.studentHome.Name = "studentHome";
            this.studentHome.Size = new System.Drawing.Size(250, 324);
            this.studentHome.TabIndex = 0;
            // 
            // StudentPlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentPlat";
            this.Text = "StudentPlat";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.navigationBar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label windowClose;
        private System.Windows.Forms.Label windowMin;
        private System.Windows.Forms.Label windowStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cmpLogo;
        private System.Windows.Forms.Panel navigationBar;
        private System.Windows.Forms.Label myExamPage;
        private System.Windows.Forms.Label examHome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label userNameShow;
        private System.Windows.Forms.Label chinese;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Panel panel4;
        private StudentHome studentHome;
        private MyExamList myExamList;
    }
}