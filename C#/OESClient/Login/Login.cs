using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Client.Properties;
using Logic;
using System.Security.Cryptography;
using Logic.LoginServiceReference;
using OESLogic;

namespace Client
{
    /// <summary>
    /// Login page
    /// </summary>
    public partial class Login : Form
    {
        public const string USERNAME_PLCACEHOLDER = "Username";
        public const string PASSWORD_PLCACEHOLDER = "Password";
        public const string STRING_EMPTY = "";
        public const string SPACER = "-";
        public const string USERNAME_OR_PASSWORD_ERROR = "Username is not exists or password error";
        public const string USERNAME_AND_PASSWORD_IS_NULL = "Username and Password is null";
        public const string USERNAME_IS_NULL = "Username is null";
        public const string PASSWORD_IS_NULL = "Password is null";
        public const char ASTERISK = '*';
        public const int INT_ZERO = 0;

        // If remember passowrd
        private bool isRemember { get; set; }
        private Point mPoint = new Point();

        public static User userOverall = null;
        public static int userRoleId;
        private UserLogin userLogin;

        /// <summary>
        /// Initialize component
        /// </summary>
        public Login()
        {
            InitializeComponent();
            userLogin = new UserLogin();
            this.StartPosition = FormStartPosition.CenterScreen;

            loginBtn.Click += new EventHandler(LoginBtnClick);
            rememberMeIcon.Click += new EventHandler(RememberMeIconClick);
            password.Enter += new EventHandler(PasswordEnter);
            password.Leave += new EventHandler(PasswordLeave);
            userName.Enter += new EventHandler(UserNameEnter);
            password.KeyDown += new KeyEventHandler(PasswordKeyDown);
            userName.Leave += new EventHandler(UserNameLeave);

            windowClose.Click += new EventHandler(WindowCloseClick);
            head.MouseDown += new MouseEventHandler(HeadMouseDown);
            head.MouseMove += new MouseEventHandler(HeadMouseMove);
        }

        /// <summary>
        /// Enter to login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtnClick(sender, e);
            }
        }

        /// <summary>
        /// Username leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserNameLeave(object sender, EventArgs e)
        {
            if (this.userName.Text == string.Empty)
            {
                this.userName.Text = USERNAME_PLCACEHOLDER;
            }
        }

        /// <summary>
        /// Username enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserNameEnter(object sender, EventArgs e)
        {
            if (this.userName.Text == USERNAME_PLCACEHOLDER)
            {
                this.userName.Text = STRING_EMPTY;
            }

            this.userNameError.Visible = false;
        }

        /// <summary>
        /// Password leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordLeave(object sender, EventArgs e)
        {
            if (this.password.Text == string.Empty)
            {
                this.password.Text = PASSWORD_PLCACEHOLDER;
            }
        }

        /// <summary>
        /// Password enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordEnter(object sender, EventArgs e)
        {
            this.password.PasswordChar = ASTERISK;
            this.password.Text = STRING_EMPTY;
            this.passwordError.Visible = false;
        }

        /// <summary>
        /// Is remember me
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RememberMeIconClick(object sender, EventArgs e)
        {
            if (isRemember == false)
            {
                this.rememberMeIcon.Image = Resources.BTN_RemeberMe_Select_12x12;
                isRemember = true;
            }
            else
            {
                this.rememberMeIcon.Image = Resources.BTN_RemeberMe_Unselect_12X12;
                isRemember = false;
            }
        }

        /// <summary>
        /// User login check params
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtnClick(object sender, EventArgs e)
        {
            CancelEventArgs args = new CancelEventArgs();
            bool usernameIsNull = this.UserNameValidating(sender, args);
            bool passwordIsNull = this.PasswordValidating(sender, args);

            if (!args.Cancel)
            {
                try
                {
                    // MD5 escape
                    byte[] arr = Encoding.UTF8.GetBytes(this.password.Text.Trim());
                    MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
                    byte[] hashVal = provider.ComputeHash(arr);
                    string password = BitConverter.ToString(hashVal).Replace(SPACER, string.Empty);

                    // Login result
                    User user = new User();
                    user.Username = this.userName.Text.Trim();
                    user.Password = password;

                    User result;

                    try
                    {
                        result = userLogin.VerifyUserLogin(user);

                        if (result != null)
                        {
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                            userOverall = result;
                            result.Password = null;

                            UserRole userRole = new UserRole();
                            userRole.UserId = result.Id;
                            int[] roleId = userLogin.JudgeUserType(userRole);
                            userRoleId = roleId[0];
                        }
                        else
                        {
                            this.loginPopInfo.Visible = true;
                            this.loginPopInfo.Text = USERNAME_OR_PASSWORD_ERROR;
                        }
                    }
                    catch (Exception ex)
                    {
                        string str = ex.Message;
                        MessageBox.Show(str, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                }
                catch (UserNotExistsException)
                {
                    this.loginPopInfo.Visible = true;
                    this.loginPopInfo.Text = USERNAME_OR_PASSWORD_ERROR;
                }
            }
            else
            {
                if (usernameIsNull)
                {
                    if (passwordIsNull)
                    {
                        this.loginPopInfo.Text = USERNAME_AND_PASSWORD_IS_NULL;
                    }
                    else
                    {
                        this.loginPopInfo.Visible = true;
                        this.loginPopInfo.Text = USERNAME_IS_NULL;
                    }
                }
                else
                {
                    if (passwordIsNull)
                    {
                        this.loginPopInfo.Text = PASSWORD_IS_NULL;
                    }
                }
            }
        }

        /// <summary>
        /// Validate username is null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private bool UserNameValidating(object sender, CancelEventArgs e)
        {
            bool flag = false;

            if (this.userName.Text.Length != INT_ZERO && this.userName.Text != USERNAME_PLCACEHOLDER)
            {
                this.loginPopInfo.Visible = false;
                this.userNameError.Visible = false;
            }
            else
            {
                this.loginPopInfo.Visible = true;
                this.userNameError.Visible = true;
                e.Cancel = true;
                flag = true;
            }

            return flag;
        }

        /// <summary>
        /// Validate password is null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private bool PasswordValidating(object sender, CancelEventArgs e)
        {
            bool flag = false;

            if (this.password.Text.Length != INT_ZERO && this.password.Text != PASSWORD_PLCACEHOLDER)
            {
                this.loginPopInfo.Visible = false;
                this.passwordError.Visible = false;
            }
            else
            {
                this.loginPopInfo.Visible = true;
                this.passwordError.Visible = true;
                e.Cancel = true;
                flag = true;
            }

            return flag;
        }

        /// <summary>
        /// Close login page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowCloseClick(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// Debugger message
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }

        /// <summary>
        /// Head mouse down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeadMouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = e.X;
            mPoint.Y = e.Y;
        }

        /// <summary>
        /// Head mouse move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeadMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-mPoint.X, -mPoint.Y);
                Location = myPosittion;
            }
        }
    }
}