using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic.StudentServiceReference;
using Logic;
using Logic.LoginServiceReference;
using Client.Properties;

namespace Client.Student
{
    /// <summary>
    /// Show my exam list
    /// </summary>
    public partial class MyExamList : UserControl
    {
        public const string STRING_EMPTY = "";
        public const int INT_ZERO = 0;
        public const int INT_ONE = 1;
        public const int INT_TWO = 2;
        public const int INT_TEN = 10;
        public const string DO_IT = "Do it";
        public const string PASS = "Pass";
        public const string NO_PASS = "No Pass";
        public const string COLUM_HEADTEXT_OPERATION = "Operation";
        public const string COLUM_HEADTEXT_EXAM_SCORE = "ExamSocre";
        public const string PERCENT_SPACER = "-/100";
        public const string PERCENT_X = "/100";

        public virtual FontStyle Underline { get; set; }
        private StudentExamManage studentExam;
        private StudentSelect studentSelect;

        /// <summary>
        /// My exam init
        /// </summary>
        public MyExamList()
        {
            InitializeComponent();

            studentSelect = new StudentSelect();
            studentExam = new StudentExamManage();
            
            studentSelect.StudentSortName = STRING_EMPTY;
            studentSelect.StudentSortDirction = "asc";
            studentSelect.CurrentPage = INT_ONE;
            studentSelect.PageSize = INT_TEN;
            studentSelect.IsFinished = STRING_EMPTY;
            studentSelect.Id = Login.userOverall.Id;

            pagination();
            StudentExamShow();
            this.pageSize.SelectedItem = "" + 10;
            
            this.studentDataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(StudentDataGridViewCellFormatting);
            this.studentDataGridView.CellContentClick += new DataGridViewCellEventHandler(StudentDataGridViewCellContentClick);
            this.frontPage.Click += new EventHandler(FrontPageClick);
            this.nextPage.Click += new EventHandler(NextPageClick);
            this.finishedExam.Click += new EventHandler(FinishedExamClick);
            this.unFinishedExam.Click += new EventHandler(UnFinishedClick);
            this.allExam.Click += new EventHandler(AllExamClick);
            this.nameSort.Click += new EventHandler(SortClick);
            this.sortId.Click += new EventHandler(SortClick);
            this.sortEffectiveTime.Click += new EventHandler(SortClick);
            this.sortPassCriteria.Click += new EventHandler(SortClick);
            this.sortExamScore.Click += new EventHandler(SortClick);
            this.sortOperation.Click += new EventHandler(SortClick);
            this.pageSize.SelectedValueChanged += new EventHandler(PageSizeSelectedValueChanged);
            this.toSelectPage.KeyPress += new KeyPressEventHandler(ToSelectPageKeyPress);
            this.go.Click += new EventHandler(GoClick);
        }

        /// <summary>
        /// GoClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoClick(object sender, EventArgs e)
        {
            int toPage;

            if (this.toSelectPage.Text == string.Empty || this.toSelectPage.Text == "")
            {
                toPage = 1;
            }
            else
            {
                toPage = Convert.ToInt32(this.toSelectPage.Text.Trim());
            }

            int pageCount = (GetStudentExamCount() - 1) / studentSelect.PageSize + 1;

            if (toPage > pageCount)
            {
                toPage = pageCount;
            }
            else if (toPage < 1)
            {
                toPage = 1;
            }

            studentSelect.CurrentPage = toPage;
            pagination();
            StudentExamShow();
        }

        /// <summary>
        /// To select page keyPress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToSelectPageKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// PageSize selected value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageSizeSelectedValueChanged(object sender, EventArgs e)
        {
            studentSelect.CurrentPage = 1;
            studentSelect.PageSize = Convert.ToInt32(this.pageSize.SelectedItem);
            GetStudentExamCount();
            pagination();
            StudentExamShow();
        }

        /// <summary>
        /// Name sort click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortClick(object sender, EventArgs e)
        {
            foreach (Label lbl in this.sortGroup.Controls)
            {
                lbl.Image = Resources.ICN_Decrese_10x15_png;
                sortDuration.Image = null;
            }

            studentSelect.StudentSortName = (sender as Label).Tag.ToString();

            if (studentSelect.StudentSortDirction == "asc")
            {
                studentSelect.StudentSortDirction = "desc";
                (sender as Label).Image = Resources.ICN_Increase_10x15_png;
            }
            else if (studentSelect.StudentSortDirction == "desc")
            {
                studentSelect.StudentSortDirction = "asc";
                (sender as Label).Image = Resources.ICN_Decrese_10x15_png;
            }

            pagination();
            StudentExamShow();
        }

        /// <summary>
        /// Student dataGridView cell content click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if ((int)studentDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == 0)
                {
                    int currentId = (int)studentDataGridView.Rows[e.RowIndex].Cells[2].Value;
                    ToExam toExam = new ToExam((StudentPlat)this.ParentForm, currentId);
                    this.ParentForm.Hide();
                    toExam.Show();
                }
            }
        }

        /// <summary>
        /// All exam click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllExamClick(object sender, EventArgs e)
        {
            this.allExam.BackColor = Color.FromArgb(46, 67, 88);
            this.allExam.ForeColor = Color.White;
            this.unFinishedExam.BackColor = Color.White;
            this.finishedExam.BackColor = Color.White;
            this.unFinishedExam.ForeColor = Color.FromArgb(46, 67, 88);
            this.finishedExam.ForeColor = Color.FromArgb(46, 67, 88);
            studentSelect.IsFinished = "";

            pagination();
            StudentExamShow();
        }

        /// <summary>
        /// UnFinished click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnFinishedClick(object sender, EventArgs e)
        {
            this.unFinishedExam.BackColor = Color.FromArgb(46, 67, 88);
            this.unFinishedExam.ForeColor = Color.White;
            this.allExam.BackColor = Color.White;
            this.finishedExam.BackColor = Color.White;
            this.allExam.ForeColor = Color.FromArgb(46, 67, 88);
            this.finishedExam.ForeColor = Color.FromArgb(46, 67, 88);
            studentSelect.IsFinished = "Unfinished";
            studentSelect.CurrentPage = INT_ONE;

            pagination();
            StudentExamShow();
        }

        /// <summary>
        /// Finished exam show
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishedExamClick(object sender, EventArgs e)
        {
            this.finishedExam.BackColor = Color.FromArgb(46, 67, 88);
            this.finishedExam.ForeColor = Color.White;
            this.allExam.BackColor = Color.White;
            this.unFinishedExam.BackColor = Color.White;
            this.allExam.ForeColor = Color.FromArgb(46, 67, 88);
            this.unFinishedExam.ForeColor = Color.FromArgb(46, 67, 88);
            studentSelect.IsFinished = "Finished";
            studentSelect.CurrentPage = INT_ONE;

            pagination();
            StudentExamShow();
        }

        /// <summary>
        /// Next page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextPageClick(object sender, EventArgs e)
        {
            studentSelect.CurrentPage++;
            int pageCount = (GetStudentExamCount() - 1) / studentSelect.PageSize + 1;

            if (studentSelect.CurrentPage > pageCount)
            {
                studentSelect.CurrentPage = pageCount;
            }

            pagination();
            StudentExamShow();
        }

        /// <summary>
        /// Front page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrontPageClick(object sender, EventArgs e)
        {
            studentSelect.CurrentPage--;

            if (studentSelect.CurrentPage < 1)
            {
                studentSelect.CurrentPage = 1;
            }

            pagination();
            StudentExamShow();
        }

        /// <summary>
        /// Format is pass
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentDataGridViewCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.studentDataGridView.Columns[e.ColumnIndex].HeaderText == COLUM_HEADTEXT_OPERATION)
            {
                if (object.Equals(e.Value, INT_ZERO))
                {
                    e.Value = DO_IT;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Underline);
                    e.CellStyle.ForeColor = Color.FromArgb(41, 103, 147);
                }
                else if (object.Equals(e.Value, INT_ONE))
                {
                    e.Value = PASS;
                }
                else if (object.Equals(e.Value, INT_TWO))
                {
                    e.Value = NO_PASS;
                }
            }
            else if (this.studentDataGridView.Columns[e.ColumnIndex].HeaderText == COLUM_HEADTEXT_EXAM_SCORE)
            {
                if (object.Equals(e.Value, System.DBNull.Value))
                {
                    e.Value += PERCENT_SPACER;
                }
                else
                {
                    e.Value += PERCENT_X;
                }
            }
            else if (this.studentDataGridView.Columns[e.ColumnIndex].HeaderText == "Id")
            {
                int idLen = e.Value.ToString().Length;

                for (int i = 0; i < 6 - idLen; i++)
                {
                    e.Value = "0" + e.Value;
                }

                e.Value = "E" + e.Value;
            }
        }

        /// <summary>
        /// Student exam
        /// </summary>
        private void StudentExamShow()
        {
            try
            {
                this.studentExamListBindingSource.DataSource = studentExam.StudentExam(studentSelect);
                PageStyle();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                MessageBox.Show(str, "system error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Get student exam count
        /// </summary>
        /// <returns></returns>
        private int GetStudentExamCount()
        {
            int count = 0;

            try
            {
                count = studentExam.StudentExamCount(studentSelect);
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                MessageBox.Show(str, "system error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

            return count;
        }

        /// <summary>
        /// Page style
        /// </summary>
        public void PageStyle()
        {
            foreach (Label lab in this.includePage.Controls)
            {
                lab.ForeColor = Color.FromArgb(10, 10, 10);

                if (lab.Text == studentSelect.CurrentPage.ToString())
                {
                    lab.ForeColor = Color.FromArgb(254, 153, 1);
                }
            }
        }

        /// <summary>
        /// pagination
        /// </summary>
        private void pagination()
        {
            string[] sta = new string[5];

            for (int i = 0; i < pageNum().Length; i++)
            {
                sta[i] = pageNum()[i];
            }

            bar1.Text = sta[0];
            bar2.Text = sta[1];
            bar3.Text = sta[2];
            bar4.Text = sta[3];
            bar5.Text = sta[4];
        }

        /// <summary>
        /// pageNum
        /// </summary>
        /// <returns>string[]</returns>
        public string[] pageNum()
        {
            // Pagination display
            int pageCount = (GetStudentExamCount() - 1) / studentSelect.PageSize + 1;
            int currentPage = studentSelect.CurrentPage;

            string[] pages = new string[5];

            if (pageCount <= 5)
            {
                pages = new string[pageCount];

                for (int index = 0; index < pageCount; index++)
                {
                    pages[index] = (index + 1).ToString();
                }
            }
            else if (currentPage - 1 <= 2)
            {
                pages[0] = "1";
                pages[1] = "2";
                pages[2] = "3";
                pages[3] = "...";
                pages[4] = pageCount.ToString();
            }
            else if ((currentPage - 1 > 2) && (pageCount - currentPage > 2))
            {
                pages[0] = "1";
                pages[1] = "...";
                pages[2] = currentPage.ToString();
                pages[3] = "...";
                pages[4] = pageCount.ToString();
            }
            else if (pageCount - currentPage <= 2)
            {
                pages[0] = "1";
                pages[1] = "...";
                pages[2] = (pageCount - 2).ToString();
                pages[3] = (pageCount - 1).ToString();
                pages[4] = pageCount.ToString();
            }

            return pages;
        }
    }
}