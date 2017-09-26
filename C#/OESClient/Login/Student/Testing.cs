using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic.StudentServiceReference;
using Logic;
using Client.DataProcess;
using Client.Properties;
using Logic.LoginServiceReference;

namespace Client.Student
{
    /// <summary>
    /// In testing page
    /// </summary>
    public partial class Testing : Form
    {
        // If window max or normal
        private bool isMax { get; set; }
        private Point mPoint = new Point();
        private int currentExamId;
        public static Exam tempExam;
        private int seconds;
        private int flag;
        private TestingContent[] questionList;
        private string currentChoice;
        private int examScore = 0;
        private int correctNum = 0;
        private string userAnwser = "";
        private bool isTimeOut = false;
        private ExamRecord examRecord;

        private StudentExamManage studentExamManage;

        /// <summary>
        /// In testing page init
        /// </summary>
        public Testing(Exam exam)
        {
            InitializeComponent();
            studentExamManage = new StudentExamManage();
            tempExam = exam;
            currentExamId = exam.Id;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.examCareful.Text += exam.QuestionPoints + " points each.";
            this.questionNum.Text = (flag + 1).ToString();

            IntoContent(flag);
            TimerToStart();

            this.windowClose.Click += new EventHandler(WindowCloseClick);
            this.windowStatus.Click += new EventHandler(WindowStatusClick);
            this.windowMin.Click += new EventHandler(WindowMinClick);
            this.head.MouseDown += new MouseEventHandler(HeadMouseDown);
            this.head.MouseMove += new MouseEventHandler(HeadMouseMove);
            this.timer1.Tick += new EventHandler(RestTimeTick);
            this.choiceACheck.Click += new EventHandler(ChoiceCheckClick);
            this.choiceBCheck.Click += new EventHandler(ChoiceCheckClick);
            this.choiceCCheck.Click += new EventHandler(ChoiceCheckClick);
            this.choiceDCheck.Click += new EventHandler(ChoiceCheckClick);
            this.nextQuesion.Click += new EventHandler(NextQuesionClick);
        }

        /// <summary>
        /// Choice check click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChoiceCheckClick(object sender, EventArgs e)
        {
            InitCheck();
            (sender as Label).Image = Resources.BTN_Radio_Selected_16x16_png;
            var ss = (sender as Label).Name.Substring(6, 1).ToLower();
            currentChoice = ss;
        }

        /// <summary>
        /// Next quesion click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextQuesionClick(object sender, EventArgs e)
        {
            if (string.Empty == currentChoice || currentChoice == null)
            {
                MessageBox.Show("please choice a anwser");
            }
            else
            {
                flag++;

                userAnwser += currentChoice + ",";

                if (flag <= questionList.Length)
                {
                    if (currentChoice == CurrentTesting(flag - 1).CorrectAnwser)
                    {
                        examScore += tempExam.QuestionPoints;
                        correctNum++;
                    }

                    this.questionNum.Text = (flag + 1).ToString();

                    InitCheck();
                    currentChoice = null;

                    if (flag <= questionList.Length - 1)
                    {
                        IntoContent(flag);
                    }

                    if (flag == questionList.Length - 1)
                    {
                        this.nextQuesion.Text = "Submit";
                    }

                    if (flag == questionList.Length)
                    {
                        //ExamSubmit
                        ExamSubmit();
                    }
                }
            }
        }

        /// <summary>
        /// ExamSubmit include system and hand submit
        /// </summary>
        public void ExamSubmit()
        {
            examRecord = new ExamRecord();

            int isPass = examScore >= tempExam.PassCriteria ? 1 : 2;

            examRecord.ExamScore = examScore;
            examRecord.IsPass = isPass;

            examRecord.UserId = Login.userOverall.Id;
            examRecord.ExamId = tempExam.Id;
            examRecord.UserAnwser = userAnwser;
            examRecord.EffectiveTime = tempExam.EffectiveTime;
            examRecord.SubmitTime = System.DateTime.Now;

            try
            {
                studentExamManage.AddExamRecord(examRecord);
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                MessageBox.Show(str, "system error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AfterTest afterTest = new AfterTest(questionList, examRecord, isTimeOut, correctNum);
            this.Hide();
            afterTest.Show();
        }

        /// <summary>
        /// Rest time tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestTimeTick(object sender, EventArgs e)
        {
            seconds--;

            if (seconds < 0)
            {
                timer1.Stop();
                isTimeOut = true;
                //ExamSubmit
                ExamSubmit();

                return;
            }

            ShowTime();
        }

        /// <summary>
        /// InitCheck
        /// </summary>
        public void InitCheck()
        {
            this.choiceACheck.Image = Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceBCheck.Image = Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceCCheck.Image = Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceDCheck.Image = Resources.BTN_Radio_Unselected_16x16_png;
        }

        /// <summary>
        /// Timer to start
        /// </summary>
        private void TimerToStart()
        {
            timer1.Interval = 1000;
            timer1.Enabled = false;
            seconds = tempExam.Duration * 60;
            ShowTime();
            timer1.Start();
        }

        /// <summary>
        /// Exam show time
        /// </summary>
        private void ShowTime()
        {
            long hour = seconds / (60 * 60);
            long minute = (seconds - hour * (60 * 60)) / 60;
            long second = seconds - hour * (60 * 60) - minute * 60;
            examRestTime.Text = string.Format("{0:00}:{1:00}:{2:00}", hour, minute, second);
        }

        /// <summary>
        /// Into content
        /// </summary>
        /// <param name="flag"></param>
        private void IntoContent(int flag)
        {
            TestingContent currentQuestion = CurrentTesting(flag);
            this.currentQuestion.Text = flag + 1 + "/" + tempExam.QuestionQuantity;
            this.questionContent.Text = currentQuestion.QuestionContent;
            this.choiceAContent.Text = currentQuestion.ChoiceA;
            this.choiceBContent.Text = currentQuestion.ChoiceB;
            this.choiceCContent.Text = currentQuestion.ChoiceC;
            this.choiceDContent.Text = currentQuestion.ChoiceD;
            this.choiceAIcon.Text = "A";
            this.choiceBIcon.Text = "B";
            this.choiceCIcon.Text = "C";
            this.choiceDIcon.Text = "D";
        }

        /// <summary>
        /// Current question
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        private TestingContent CurrentTesting(int flag)
        {
            TestingContent testingContent = new TestingContent();
            testingContent.ExamId = currentExamId;

            try
            {
                questionList = studentExamManage.CurrentTesting(testingContent);
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                MessageBox.Show(str, "system error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return questionList[flag];
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
    }
}