using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic.StudentServiceReference;
using Client.Properties;

namespace Client.Student
{
    /// <summary>
    /// Exam result show
    /// </summary>
    public partial class ExamResult : Form
    {
        // If window max or normal
        private bool isMax { get; set; }
        private Point mPoint = new Point();

        /// <summary>
        /// Exam result init
        /// </summary>
        public ExamResult(TestingContent[] questionList, ExamRecord examRecord, bool isTimeOut, int correctNum)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            windowClose.Click += new EventHandler(WindowCloseClick);
            windowStatus.Click += new EventHandler(WindowStatusClick);
            windowMin.Click += new EventHandler(WindowMinClick);
            head.MouseDown += new MouseEventHandler(HeadMouseDown);
            head.MouseMove += new MouseEventHandler(HeadMouseMove);
            allQuestionContent.MouseWheel += new MouseEventHandler(AllQuestionContentMouseWheel);
            allQuestionContent.MouseHover += new EventHandler(AllQuestionContentMouseHover);

            this.examNameShow.Text += Testing.tempExam.ExamName;
            this.effectiveTimeShow.Text += Testing.tempExam.EffectiveTime;
            this.examDurationShow.Text += Testing.tempExam.Duration;
            this.questionCountShow.Text += Testing.tempExam.QuestionQuantity;
            this.examIdShow.Text += Testing.tempExam.Id;
            this.examTotalScore.Text += Testing.tempExam.TotalScore;
            this.examGetScoreShow.Text += examRecord.ExamScore;
            this.examGetScore.Text = examRecord.ExamScore.ToString();
            this.trueQuestionCount.Text = "There are " + correctNum + " questions correct.";


            for (int i = 0; i < questionList.Length; i++)
			{
                InitQuestion();
                //a,a,b,b,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,

                string[] compareAnwser = examRecord.UserAnwser.Split(',');

                // question number
                questionNum.Text = (i + 1).ToString();
                //question title
                questionTitle.Text = questionList[i].QuestionContent;

                //question content
                letterA.Text = "A";
                letterB.Text = "B";
                letterC.Text = "C";
                letterD.Text = "D";
                contentChoiceA.Text = questionList[i].ChoiceA;
                contentChoiceB.Text = questionList[i].ChoiceB;
                contentChoiceC.Text = questionList[i].ChoiceC;
                contentChoiceD.Text = questionList[i].ChoiceD;

                //choice anwser select
                choiceAPic.Image = Resources.BTN_Radio_Unselected_16x16_png;
                choiceBPic.Image = Resources.BTN_Radio_Unselected_16x16_png;
                choiceCPic.Image = Resources.BTN_Radio_Unselected_16x16_png;
                choiceDPic.Image = Resources.BTN_Radio_Unselected_16x16_png;

                if (compareAnwser[i] == "a")
                {
                    choiceAPic.Image = Resources.BTN_Radio_Selected_16x16_png;
                }
                else if (compareAnwser[i] == "b")
                {
                    choiceBPic.Image = Resources.BTN_Radio_Selected_16x16_png;
                }
                else if (compareAnwser[i] == "c")
                {
                    choiceCPic.Image = Resources.BTN_Radio_Selected_16x16_png;
                }
                else if (compareAnwser[i] == "d")
                {
                    choiceDPic.Image = Resources.BTN_Radio_Selected_16x16_png;
                }

                //true anwser style
                if (questionList[i].CorrectAnwser == "a")
                {
                    choiceAPanel.BackColor = Color.FromArgb(210, 218, 227);
                }
                else if (questionList[i].CorrectAnwser == "b")
                {
                    choiceBPanel.BackColor = Color.FromArgb(210, 218, 227);
                }
                else if (questionList[i].CorrectAnwser == "c")
                {
                    choiceCPanel.BackColor = Color.FromArgb(210, 218, 227);
                }
                else if (questionList[i].CorrectAnwser == "d")
                {
                    choiceDPanel.BackColor = Color.FromArgb(210, 218, 227);
                }

                // is true style
                if (questionList[i].CorrectAnwser == compareAnwser[i])
                {
                    isTrueIcon.Image = Resources.ICN_Right_15x15;
                    questionNum.BorderColor = Color.FromArgb(254, 153, 1);
                }
                else
                {
                    isTrueIcon.Image = Resources.ICN_Wrong_15x15;
                    questionNum.BorderColor = Color.Red;
                }
                
                allQuestionContent.Controls.Add(questionContent);
			}
        }

        /// <summary>
        /// All question content mouseHover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllQuestionContentMouseHover(object sender, EventArgs e)
        {
            this.allQuestionContent.Focus();
        }

        /// <summary>
        /// All question content mouse wheel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllQuestionContentMouseWheel(object sender, MouseEventArgs e)
        {
            Point mousePoint = new Point(e.X, e.Y);
            mousePoint.Offset(this.Location.X, this.Location.Y);

            if (allQuestionContent.RectangleToScreen(allQuestionContent.DisplayRectangle).Contains(mousePoint))
            {
                allQuestionContent.AutoScrollPosition = new Point(0, allQuestionContent.VerticalScroll.Value - e.Delta);
            }
        }

        /// <summary>
        /// Window min click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowMinClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
                WindowState = FormWindowState.Maximized;
                isMax = true;
            }
            else
            {
                WindowState = FormWindowState.Normal;
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