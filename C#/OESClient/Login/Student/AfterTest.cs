using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic.StudentServiceReference;
using Client.Custom;

namespace Client.Student
{
    /// <summary>
    /// After exam page
    /// </summary>
    public partial class AfterTest : Form
    {
        // If window max or normal
        private bool isMax { get; set; }
        private Point mPoint = new Point();
        private ExamRecord examRecordTemp;
        private bool isTimeOutTemp;
        private int correctNumTemp;
        private TestingContent[] questionListTemp;

        /// <summary>
        /// Init test init
        /// </summary>
        public AfterTest(TestingContent[] questionList, ExamRecord examRecord, bool isTimeOut,int correctNum)
        {
            InitializeComponent();

            questionListTemp = questionList;
            examRecordTemp = examRecord;
            isTimeOutTemp = isTimeOut;
            correctNumTemp = correctNum;

            FinishedInit();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.windowClose.Click += new EventHandler(WindowCloseClick);
            this.windowStatus.Click += new EventHandler(WindowStatusClick);
            this.windowMin.Click += new EventHandler(WindowMinClick);
            this.head.MouseDown += new MouseEventHandler(HeadMouseDown);
            this.head.MouseMove += new MouseEventHandler(HeadMouseMove);

            RadiusBorder resultPaperInTime = this.finishTimeIn.examResultPaper;
            RadiusBorder resultPaperOutTime = this.finishTimeOut.examResultPaper;
            resultPaperInTime.Click += new EventHandler(ResultPaperClick);
            resultPaperOutTime.Click += new EventHandler(ResultPaperClick);
        }

        /// <summary>
        /// Result paper click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultPaperClick(object sender, EventArgs e)
        {
            this.Hide();
            ExamResult examResultPaper = new ExamResult(questionListTemp, examRecordTemp, isTimeOutTemp, correctNumTemp);
            examResultPaper.Show();
        }

        /// <summary>
        /// Finished init
        /// </summary>
        private void FinishedInit()
        {
            string examResInfo = "You score is " + examRecordTemp.ExamScore + " points, you got " + correctNumTemp + " question in this test.";

            if (isTimeOutTemp == true)
            {
                finishTimeOut.Dock = DockStyle.Fill;
                finishTimeOut.Visible = true;

                FinishTimeOut finishTime = this.finishTimeOut;
                
                Label outTime = finishTime.examReultOutTime;
                outTime.Text = examResInfo;
            }
            else
            {
                finishTimeIn.Dock = DockStyle.Fill;
                finishTimeIn.Visible = true;

                FinishTimeIn finishTime = this.finishTimeIn;

                Label inTime = finishTime.examResultInTime;
                inTime.Text = examResInfo;
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
            this.Hide();
            new StudentPlat().Show();
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