namespace Client.Teacher
{
    partial class TeacherManage
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
            this.examHome = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconUser = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loginOutBtn = new System.Windows.Forms.Label();
            this.examList = new Client.Teacher.ExamList();
            this.head.SuspendLayout();
            this.panel2.SuspendLayout();
            this.navigationBar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.head.TabIndex = 2;
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
            this.navigationBar.Controls.Add(this.examHome);
            this.navigationBar.Controls.Add(this.flowLayoutPanel1);
            this.navigationBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar.Location = new System.Drawing.Point(0, 38);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(1024, 40);
            this.navigationBar.TabIndex = 3;
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
            this.examHome.Size = new System.Drawing.Size(92, 40);
            this.examHome.TabIndex = 3;
            this.examHome.Text = "Exam List";
            this.examHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.iconUser);
            this.flowLayoutPanel1.Controls.Add(this.userNameText);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.loginOutBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(753, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(256, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // iconUser
            // 
            this.iconUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconUser.Image = global::Client.Properties.Resources.ICN_Client_PersonalInformation_20x20;
            this.iconUser.Location = new System.Drawing.Point(3, 0);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(28, 22);
            this.iconUser.TabIndex = 2;
            // 
            // userNameText
            // 
            this.userNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameText.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.userNameText.Location = new System.Drawing.Point(37, 0);
            this.userNameText.Name = "userNameText";
            this.userNameText.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.userNameText.Size = new System.Drawing.Size(86, 22);
            this.userNameText.TabIndex = 1;
            this.userNameText.Text = "UserName";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("SimHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.label7.Location = new System.Drawing.Point(129, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(55, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "中文";
            // 
            // loginOutBtn
            // 
            this.loginOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginOutBtn.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.loginOutBtn.Location = new System.Drawing.Point(190, 0);
            this.loginOutBtn.Name = "loginOutBtn";
            this.loginOutBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.loginOutBtn.Size = new System.Drawing.Size(58, 22);
            this.loginOutBtn.TabIndex = 4;
            this.loginOutBtn.Text = "Logout";
            // 
            // examList
            // 
            this.examList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.examList.BackColor = System.Drawing.Color.White;
            this.examList.Location = new System.Drawing.Point(20, 98);
            this.examList.Name = "examList";
            this.examList.Size = new System.Drawing.Size(980, 640);
            this.examList.TabIndex = 4;
            // 
            // TeacherManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.examList);
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherManage";
            this.Text = "TeacherManage";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.navigationBar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label examHome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label iconUser;
        private System.Windows.Forms.Label userNameText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label loginOutBtn;
        private ExamList examList;
    }
}