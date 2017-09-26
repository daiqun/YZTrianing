using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic.LoginServiceReference;

namespace Client.Student
{
    /// <summary>
    /// StudentPlat
    /// </summary>
    public partial class StudentPlat : Form
    {
        public const int CHANGE_RGB_1 = 210;
        public const int CHANGE_RGB_2 = 218;
        public const int CHANGE_RGB_3 = 227;

        // If window max or normal
        private bool isMax { get; set; }
        private Point mPoint = new Point();

        /// <summary>
        /// Student plat entity
        /// </summary>
        public StudentPlat()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.userNameShow.Text = Login.userOverall.Username;
            this.studentHome.Dock = DockStyle.Fill;

            this.logout.Click += new EventHandler(LogoutClick);
            this.examHome.Click += new EventHandler(ExamHomeClick);
            this.myExamPage.Click += new EventHandler(MyExamClick);
            this.windowClose.Click += new EventHandler(WindowCloseClick);
            this.windowStatus.Click += new EventHandler(WindowStatusClick);
            this.windowMin.Click += new EventHandler(WindowMinClick);
            this.head.MouseDown += new MouseEventHandler(HeadMouseDown);
            this.head.MouseMove += new MouseEventHandler(HeadMouseMove);
            this.userNameShow.Click += new EventHandler(UserNameShowClick);
        }

        private void UserNameShowClick(object sender, EventArgs e)
        {
            this.Hide();
            UserCenter userCenter = new UserCenter();
            userCenter.Show();
        }

        /// <summary>
        /// User logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutClick(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        /// <summary>
        /// My exam click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyExamClick(object sender, EventArgs e)
        {
            this.examHome.BackColor = Color.White;
            this.myExamPage.BackColor = Color.FromArgb(CHANGE_RGB_1, CHANGE_RGB_2, CHANGE_RGB_3);
            this.myExamList.Dock = DockStyle.Fill;
            this.myExamList.Visible = true;
            this.studentHome.Visible = false;
        }

        /// <summary>
        /// Exam home click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExamHomeClick(object sender, EventArgs e)
        {
            this.examHome.BackColor = Color.FromArgb(CHANGE_RGB_1, CHANGE_RGB_2, CHANGE_RGB_3);
            this.myExamPage.BackColor = Color.White;
            this.myExamList.Visible = false;
            this.studentHome.Dock = DockStyle.Fill;
            this.studentHome.Visible = true;
        }

        /// <summary>
        /// Window min click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowMinClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Window status click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowStatusClick(object sender, EventArgs e)
        {
            if (isMax == false)
            {
                this.WindowState = FormWindowState.Maximized;
                isMax = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                isMax = false;
            }
        }

        /// <summary>
        /// Window close click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowCloseClick(object sender, EventArgs e)
        {
            Application.Exit();
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