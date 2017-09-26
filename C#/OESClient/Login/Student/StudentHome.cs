using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic.LoginServiceReference;
using Logic;
using Logic.StudentServiceReference;

namespace Client.Student
{
    /// <summary>
    /// Student home
    /// </summary>
    public partial class StudentHome : UserControl
    {
        public const int CHANGE_RGB_1 = 46;
        public const int CHANGE_RGB_2 = 67;
        public const int CHANGE_RGB_3 = 88;

        private StudentExamManage studentExam;
        private ExamAbout examAboutTemp;

        /// <summary>
        /// Student home entity
        /// </summary>
        public StudentHome()
        {
            InitializeComponent();
            studentExam = new StudentExamManage();

            this.noticeContent.Dock = DockStyle.Fill;
            this.noticeContent.Visible = true;

            InitNotice();

            notice.Click += new EventHandler(NoticeClick);
            about.Click += new EventHandler(AboutClick);
            examnationRules.Click += new EventHandler(ExamnationRulesClick);
            systemInformation.Click += new EventHandler(SystemInformationClick);
            contactUs.Click += new EventHandler(ContactUsClick);
        }

        /// <summary>
        /// ContactUsClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactUsClick(object sender, EventArgs e)
        {
            this.aboutInclude.Text = "Contact Us";
            this.aboutChoiceContent.Text = examAboutTemp.ContactUs;
        }

        /// <summary>
        /// SystemInformationClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemInformationClick(object sender, EventArgs e)
        {
            this.aboutInclude.Text = "System Information";
            this.aboutChoiceContent.Text = examAboutTemp.SystemInformation;
        }

        /// <summary>
        /// ExamnationRulesClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExamnationRulesClick(object sender, EventArgs e)
        {
            this.aboutInclude.Text = "Examination rules";
            this.aboutChoiceContent.Text = examAboutTemp.ExaminationRules;
        }

        /// <summary>
        /// To take exam
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToTakeExam(object sender, EventArgs e)
        {
            int currentId = (int)(sender as Control).Tag;
            ToExam toExam = new ToExam((StudentPlat)this.ParentForm, currentId);
            this.ParentForm.Hide();
            toExam.Show();
        }

        /// <summary>
        /// About click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutClick(object sender, EventArgs e)
        {
            this.notice.BackColor = Color.White;
            this.notice.ForeColor = Color.FromArgb(CHANGE_RGB_1, CHANGE_RGB_2, CHANGE_RGB_3);
            this.about.BackColor = Color.FromArgb(CHANGE_RGB_1, CHANGE_RGB_2, CHANGE_RGB_3);
            this.about.ForeColor = Color.White;
            
            this.noticeContent.Visible = false;
            this.aboutContent.Dock = DockStyle.Fill;
            this.aboutContent.Visible = true;
            ExamAbout examAbout = new ExamAbout();
            examAbout.Id = 1;
            examAboutTemp = studentExam.TakeExamAbout(examAbout);
            this.aboutChoiceContent.Text = examAboutTemp.ExaminationRules;
        }

        /// <summary>
        /// Notice click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoticeClick(object sender, EventArgs e)
        {
            this.notice.ForeColor = Color.White;
            this.notice.BackColor = Color.FromArgb(CHANGE_RGB_1, CHANGE_RGB_2, CHANGE_RGB_3);
            this.about.BackColor = Color.White;
            this.about.ForeColor = Color.FromArgb(CHANGE_RGB_1, CHANGE_RGB_2, CHANGE_RGB_3);

            this.aboutContent.Visible = false;
            this.noticeContent.Dock = DockStyle.Fill;
            this.noticeContent.Visible = true;
        }
    }
}