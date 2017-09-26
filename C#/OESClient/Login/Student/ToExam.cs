using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic.StudentServiceReference;
using Logic;
using Client.Custom;

namespace Client.Student
{
    /// <summary>
    /// To exam page
    /// </summary>
    public partial class ToExam : Form
    {
        // If window max or normal
        private bool isMax { get; set; }
        private Point mPoint = new Point();
        private int currentExamId;
        private int seconds;
        private Exam currentExam;
        private StudentPlat studentPlatTemp;
        private StudentExamManage studentExamManage;

        /// <summary>
        /// To exam page init
        /// </summary>
        public ToExam(StudentPlat studentPlat, int currentId)
        {
            InitializeComponent();
            studentExamManage = new StudentExamManage();

            currentExamId = currentId;
            studentPlatTemp = studentPlat;
            ExamInfoShow();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.windowClose.Click += new EventHandler(WindowCloseClick);
            this.windowStatus.Click += new EventHandler(WindowStatusClick);
            this.windowMin.Click += new EventHandler(WindowMinClick);
            this.head.MouseDown += new MouseEventHandler(HeadMouseDown);
            this.head.MouseMove += new MouseEventHandler(HeadMouseMove);
            this.startTest.Click += new EventHandler(StartTestClick);
            this.timer1.Tick += new EventHandler(StartTheExam);
            this.returnBtn.Click += new EventHandler(ReturnBtnClick);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnBtnClick(object sender, EventArgs e)
        {
            this.Hide();
            studentPlatTemp.Show();
        }

        /// <summary>
        /// Start test click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartTestClick(object sender, EventArgs e)
        {
            Testing testing = new Testing(currentExam);
            this.Hide();
            testing.Show();
        }

        /// <summary>
        /// Exam info show
        /// </summary>
        /// <param name="currentId"></param>
        private void ExamInfoShow()
        {
            Exam exam = new Exam();
            exam.Id = currentExamId;

            try
            {
                currentExam = studentExamManage.CurrentExam(exam);
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                MessageBox.Show(str, "system error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.examName.Text += currentExam.ExamName;
            this.effectiveTime.Text += currentExam.EffectiveTime;
            this.duration.Text += currentExam.Duration;
            this.questionCount.Text += currentExam.QuestionQuantity;
            this.examId.Text += currentExam.Id;
            this.examEndTime.Text += currentExam.EffectiveTime.AddMinutes(currentExam.Duration);
            this.totalScore.Text += currentExam.TotalScore;
            this.notcieContent.Text = currentExam.Notice;
            bool res = StringUtil.CompareMax(DateTime.Now, currentExam.EffectiveTime);

            if (res == true)
            {
                this.timeToStart.Text = "00:00:00:00";
            }
            else
            {
                TimerToStart();
            }
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
            this.Close();
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

        /// <summary>
        /// Timer to start
        /// </summary>
        private void TimerToStart()
        {
            timer1.Interval = 1000;
            timer1.Enabled = false;

            seconds = StringUtil.TimeDifference(currentExam.EffectiveTime, DateTime.Now);
            ShowTime();
            timer1.Start();
        }

        /// <summary>
        /// Rest time tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartTheExam(object sender, EventArgs e)
        {
            seconds--;

            if (seconds < 0)
            {
                timer1.Stop();
                return;
            }

            ShowTime();
        }

        /// <summary>
        /// Exam show time
        /// </summary>
        private void ShowTime()
        {
            long day = seconds / (60 * 60 * 24);
            long hour = (seconds - day * (60 * 60 * 24)) / (60 * 60);
            long minute = (seconds - day * (60 * 60 * 24) - hour * (60 * 60)) / 60;
            long second = seconds - day * (60 * 60 * 24) - hour * (60 * 60) - minute * 60;

            timeToStart.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", day, hour, minute, second);
        }
    }
}