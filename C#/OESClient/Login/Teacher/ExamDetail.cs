using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic;
using Logic.TeacherServiceReference;

namespace Client.Teacher
{
    public partial class ExamDetail : Form
    {
        // If window max or normal
        private bool isMax { get; set; }
        private Point mPoint = new Point();

        private TeacherExamManage examManager;
        private ExamSelect examSelect;

        public ExamDetail(int examId)
        {
            InitializeComponent();
            examManager = new TeacherExamManage();
            examSelect = new ExamSelect();
            examSelect.ExamId = examId;
            examSelect.PageSize = 10;
            examSelect.PageIndex = 1;
            examSelect.SortWay = "asc";
            examSelect.SortFields = "";

            ExamJoinDetails();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.windowClose.Click += new EventHandler(WindowCloseClick);
            this.windowStatus.Click += new EventHandler(WindowStatusClick);
            this.windowMin.Click += new EventHandler(WindowMinClick);
            this.head.MouseDown += new MouseEventHandler(HeadMouseDown);
            this.head.MouseMove += new MouseEventHandler(HeadMouseMove);
            this.examDetailDataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(ExamDetailDataGridViewCellFormatting);
        }

        /// <summary>
        /// ExamDetailDataGridViewCellFormatting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExamDetailDataGridViewCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.examDetailDataGridView.Columns[e.ColumnIndex].HeaderText == "IsPass")
            {
                if (object.Equals(e.Value, 1))
                {
                    e.Value = "Pass";
                }
                else if (object.Equals(e.Value, 2))
                {
                    e.Value = "NO Pass";
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private void ExamJoinDetails()
        {
            try
            {
                this.examJoinDetailTableBindingSource.DataSource = examManager.ExamJoinDetails(examSelect);
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                MessageBox.Show(str, "system error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
