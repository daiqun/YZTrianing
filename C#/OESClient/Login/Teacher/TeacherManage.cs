using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client.Teacher
{
    public partial class TeacherManage : Form
    {
        // If window max or normal
        private bool isMax { get; set; }
        private Point mPoint = new Point();

        /// <summary>
        /// Teacher manage exam
        /// </summary>
        public TeacherManage()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.userNameText.Text = Login.userOverall.Username;

            windowClose.Click += new EventHandler(CloseTeacherExamClick);
            windowStatus.Click += new EventHandler(WindowChangeClick);
            windowMin.Click += new EventHandler(WindowMinClick);
            head.MouseDown += new MouseEventHandler(HeadMouseDown);
            head.MouseMove += new MouseEventHandler(HeadMouseMove);
            this.loginOutBtn.Click += new EventHandler(LoginOutBtnClick);
        }

        /// <summary>
        /// LoginOutBtn click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginOutBtnClick(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        /// <summary>
        /// Window click to min
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowMinClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Window change max or normal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowChangeClick(object sender, EventArgs e)
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
        /// Close the teacher manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseTeacherExamClick(object sender, EventArgs e)
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