namespace Client
{
    partial class Login
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
            this.windowClose = new System.Windows.Forms.Label();
            this.companyIcon = new System.Windows.Forms.Label();
            this.clientLogo = new System.Windows.Forms.Label();
            this.loginPopInfo = new System.Windows.Forms.Label();
            this.userNameLable = new System.Windows.Forms.Label();
            this.passwordLable = new System.Windows.Forms.Label();
            this.userNameIcon = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.passwordIcon = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.userNameError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.rememberMeIcon = new System.Windows.Forms.Label();
            this.rememberMeHref = new System.Windows.Forms.LinkLabel();
            this.forgotPasswordHref = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new Client.Custom.RadiusBorder();
            this.head.SuspendLayout();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.White;
            this.head.Controls.Add(this.windowClose);
            this.head.Controls.Add(this.companyIcon);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(700, 30);
            this.head.TabIndex = 0;
            // 
            // windowClose
            // 
            this.windowClose.Image = global::Client.Properties.Resources.ICN_Client_Close_Program_29X20;
            this.windowClose.Location = new System.Drawing.Point(663, 6);
            this.windowClose.Name = "windowClose";
            this.windowClose.Size = new System.Drawing.Size(29, 20);
            this.windowClose.TabIndex = 2;
            // 
            // companyIcon
            // 
            this.companyIcon.Image = global::Client.Properties.Resources.LOGO_Client_Titel_120x20_black;
            this.companyIcon.Location = new System.Drawing.Point(10, 6);
            this.companyIcon.Name = "companyIcon";
            this.companyIcon.Size = new System.Drawing.Size(122, 20);
            this.companyIcon.TabIndex = 1;
            // 
            // clientLogo
            // 
            this.clientLogo.Image = global::Client.Properties.Resources.LOGO_Client_Login_40X300;
            this.clientLogo.Location = new System.Drawing.Point(200, 80);
            this.clientLogo.Name = "clientLogo";
            this.clientLogo.Size = new System.Drawing.Size(300, 40);
            this.clientLogo.TabIndex = 2;
            // 
            // loginPopInfo
            // 
            this.loginPopInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(203)))), ((int)(((byte)(155)))));
            this.loginPopInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPopInfo.ForeColor = System.Drawing.Color.Red;
            this.loginPopInfo.Location = new System.Drawing.Point(200, 135);
            this.loginPopInfo.Name = "loginPopInfo";
            this.loginPopInfo.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.loginPopInfo.Size = new System.Drawing.Size(300, 20);
            this.loginPopInfo.TabIndex = 12;
            this.loginPopInfo.Visible = false;
            // 
            // userNameLable
            // 
            this.userNameLable.BackColor = System.Drawing.Color.White;
            this.userNameLable.Location = new System.Drawing.Point(200, 170);
            this.userNameLable.Name = "userNameLable";
            this.userNameLable.Size = new System.Drawing.Size(300, 35);
            this.userNameLable.TabIndex = 13;
            // 
            // passwordLable
            // 
            this.passwordLable.BackColor = System.Drawing.Color.White;
            this.passwordLable.Location = new System.Drawing.Point(200, 225);
            this.passwordLable.Name = "passwordLable";
            this.passwordLable.Size = new System.Drawing.Size(300, 35);
            this.passwordLable.TabIndex = 14;
            // 
            // userNameIcon
            // 
            this.userNameIcon.BackColor = System.Drawing.Color.White;
            this.userNameIcon.Image = global::Client.Properties.Resources.ICN_Usename_20x20;
            this.userNameIcon.Location = new System.Drawing.Point(213, 179);
            this.userNameIcon.Name = "userNameIcon";
            this.userNameIcon.Size = new System.Drawing.Size(20, 20);
            this.userNameIcon.TabIndex = 15;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.White;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName.CausesValidation = false;
            this.userName.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.userName.Location = new System.Drawing.Point(245, 180);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(245, 23);
            this.userName.TabIndex = 16;
            this.userName.Text = "Username";
            // 
            // passwordIcon
            // 
            this.passwordIcon.BackColor = System.Drawing.Color.White;
            this.passwordIcon.Image = global::Client.Properties.Resources.ICN_Password_20x15;
            this.passwordIcon.Location = new System.Drawing.Point(215, 234);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(15, 20);
            this.passwordIcon.TabIndex = 17;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.CausesValidation = false;
            this.password.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.password.Location = new System.Drawing.Point(245, 235);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(245, 23);
            this.password.TabIndex = 18;
            this.password.Text = "Password";
            // 
            // userNameError
            // 
            this.userNameError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.userNameError.Image = global::Client.Properties.Resources.ICN_Client_Login_Wrong_20X20;
            this.userNameError.Location = new System.Drawing.Point(516, 178);
            this.userNameError.Name = "userNameError";
            this.userNameError.Size = new System.Drawing.Size(21, 21);
            this.userNameError.TabIndex = 19;
            this.userNameError.Visible = false;
            // 
            // passwordError
            // 
            this.passwordError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.passwordError.Image = global::Client.Properties.Resources.ICN_Client_Login_Wrong_20X20;
            this.passwordError.Location = new System.Drawing.Point(516, 233);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(21, 21);
            this.passwordError.TabIndex = 20;
            this.passwordError.Visible = false;
            // 
            // rememberMeIcon
            // 
            this.rememberMeIcon.BackColor = System.Drawing.Color.White;
            this.rememberMeIcon.Image = global::Client.Properties.Resources.BTN_RemeberMe_Unselect_12X12;
            this.rememberMeIcon.Location = new System.Drawing.Point(200, 335);
            this.rememberMeIcon.Name = "rememberMeIcon";
            this.rememberMeIcon.Size = new System.Drawing.Size(12, 12);
            this.rememberMeIcon.TabIndex = 21;
            // 
            // rememberMeHref
            // 
            this.rememberMeHref.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberMeHref.ForeColor = System.Drawing.Color.White;
            this.rememberMeHref.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.rememberMeHref.LinkColor = System.Drawing.Color.White;
            this.rememberMeHref.Location = new System.Drawing.Point(218, 335);
            this.rememberMeHref.Name = "rememberMeHref";
            this.rememberMeHref.Size = new System.Drawing.Size(91, 15);
            this.rememberMeHref.TabIndex = 22;
            this.rememberMeHref.TabStop = true;
            this.rememberMeHref.Text = "Remember me";
            // 
            // forgotPasswordHref
            // 
            this.forgotPasswordHref.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordHref.ForeColor = System.Drawing.Color.White;
            this.forgotPasswordHref.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgotPasswordHref.LinkColor = System.Drawing.Color.White;
            this.forgotPasswordHref.Location = new System.Drawing.Point(396, 335);
            this.forgotPasswordHref.Name = "forgotPasswordHref";
            this.forgotPasswordHref.Size = new System.Drawing.Size(107, 15);
            this.forgotPasswordHref.TabIndex = 23;
            this.forgotPasswordHref.TabStop = true;
            this.forgotPasswordHref.Text = "Forgot password?";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.loginBtn.BorderColor = System.Drawing.Color.Empty;
            this.loginBtn.BorderSize = 0F;
            this.loginBtn.Font = new System.Drawing.Font("Arial", 14.5F);
            this.loginBtn.FontColor = System.Drawing.Color.Empty;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(200, 279);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Radius = 3F;
            this.loginBtn.Size = new System.Drawing.Size(300, 35);
            this.loginBtn.TabIndex = 24;
            this.loginBtn.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.forgotPasswordHref);
            this.Controls.Add(this.rememberMeHref);
            this.Controls.Add(this.rememberMeIcon);
            this.Controls.Add(this.passwordError);
            this.Controls.Add(this.userNameError);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordIcon);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userNameIcon);
            this.Controls.Add(this.passwordLable);
            this.Controls.Add(this.userNameLable);
            this.Controls.Add(this.loginPopInfo);
            this.Controls.Add(this.clientLogo);
            this.Controls.Add(this.head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.head.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label companyIcon;
        private System.Windows.Forms.Label windowClose;
        private System.Windows.Forms.Label clientLogo;
        private System.Windows.Forms.Label loginPopInfo;
        private System.Windows.Forms.Label userNameLable;
        private System.Windows.Forms.Label passwordLable;
        private System.Windows.Forms.Label userNameIcon;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label passwordIcon;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label userNameError;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label rememberMeIcon;
        private System.Windows.Forms.LinkLabel rememberMeHref;
        private System.Windows.Forms.LinkLabel forgotPasswordHref;
        private Custom.RadiusBorder loginBtn;
    }
}

