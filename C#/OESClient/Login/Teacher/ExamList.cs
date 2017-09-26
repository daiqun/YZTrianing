using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic.TeacherServiceReference;
using Logic;
using Client.Properties;
using Client.Custom;

namespace Client.Teacher
{
    /// <summary>
    /// Exam list manage
    /// </summary>
    public partial class ExamList : UserControl
    {
        private TeacherSelect teacherSelect;
        private TeacherExamManage examManager;
        private DateTime beginDate = Convert.ToDateTime("1753-03-1");
        private DateTime endDate = Convert.ToDateTime("3000-03-1");

        /// <summary>
        /// Exam list show
        /// </summary>
        public ExamList()
        {
            InitializeComponent();

            teacherSelect = new TeacherSelect();
            examManager = new TeacherExamManage();

            this.pageSize.SelectedItem = "10";
            teacherSelect.TeacherSortName = "";
            teacherSelect.TeacherSortDirction = "asc";
            teacherSelect.Name = "";
            teacherSelect.PageSize = 10;
            teacherSelect.CurrentPage = 1;
            teacherSelect.StartTime = beginDate;
            teacherSelect.EndTime = endDate;
            TeacherManageExam();

            this.frontPage.Click += new EventHandler(FrontPageClick);
            this.nextPage.Click += new EventHandler(NextPageClick);
            this.keyWordSelect.KeyUp += new KeyEventHandler(KeyWordSelectKeyUp);
            this.keyWordBtn.Click += new EventHandler(KeyWordBtnClick);
            this.pageSize.SelectedValueChanged +=new EventHandler(PageSizeSelectedValueChanged);
            this.toSelectPage.KeyPress += new KeyPressEventHandler(ToSelectPageKeyPress);
            this.go.Click += new EventHandler(GoClick);

            this.examNameSort.Click += new EventHandler(SortClick);
            this.idSort.Click += new EventHandler(SortClick);
            this.effectiveTimeSort.Click += new EventHandler(SortClick);
            this.avgScoreSort.Click += new EventHandler(SortClick);
            this.passRateSort.Click += new EventHandler(SortClick);
            this.beginTime.Click += new EventHandler(BeginDateClick);
            this.endTime.Click += new EventHandler(EndTimeClick);
            this.monthCalendarBegin.DateSelected+= new DateRangeEventHandler(MonthCalendarBeginDateChanged);
            this.monthCalendarEnd.DateSelected += new DateRangeEventHandler(MonthCalendarEndDateSelected);
            this.teacherDataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(TeacherDataGridViewCellFormatting);
            this.teacherDataGridView.CellContentClick += new DataGridViewCellEventHandler(TeacherDataGridViewCellContentClick);
        }

        /// <summary>
        /// TeacherDataGridViewCellContentClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeacherDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int currentExamId = (int)teacherDataGridView.Rows[e.RowIndex].Cells[2].Value;
                ExamDetail examDetail = new ExamDetail(currentExamId);
                this.ParentForm.Hide();
                examDetail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeacherDataGridViewCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.teacherDataGridView.Columns[e.ColumnIndex].HeaderText == "ExamName")
            {
                e.CellStyle.ForeColor = Color.FromArgb(41, 103, 147);
            }
            else if (this.teacherDataGridView.Columns[e.ColumnIndex].HeaderText == "Id")
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
        /// Sort button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortClick(object sender, EventArgs e)
        {
            this.examNameSort.Image = Resources.ICN_Decrese_10x15_png;
            this.idSort.Image = Resources.ICN_Decrese_10x15_png;
            this.effectiveTimeSort.Image = Resources.ICN_Decrese_10x15_png;
            this.avgScoreSort.Image = Resources.ICN_Decrese_10x15_png;
            this.passRateSort.Image = Resources.ICN_Decrese_10x15_png;

            teacherSelect.TeacherSortName = (sender as Label).Tag.ToString();

            if (teacherSelect.TeacherSortDirction == "asc")
            {
                teacherSelect.TeacherSortDirction = "desc";
                (sender as Label).Image = Resources.ICN_Increase_10x15_png;

            }
            else if (teacherSelect.TeacherSortDirction == "desc")
            {
                teacherSelect.TeacherSortDirction = "asc";
                (sender as Label).Image = Resources.ICN_Decrese_10x15_png;
            }
            
            TeacherManageExam();
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

            int pageCount = (GetExamListCount() - 1) / teacherSelect.PageSize + 1;

            if (toPage > pageCount)
            {
                toPage = pageCount;
            }
            else if (toPage < 1)
            {
                toPage = 1;
            }

            teacherSelect.CurrentPage = toPage;
            pagination();
            TeacherManageExam();
        }

        /// <summary>
        /// PageSize selected value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageSizeSelectedValueChanged(object sender, EventArgs e)
        {
            teacherSelect.CurrentPage = 1;
            teacherSelect.PageSize = Convert.ToInt32(this.pageSize.SelectedItem);
            GetExamListCount();
            pagination();
            TeacherManageExam();
        }

        /// <summary>
        /// Begin date click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeginDateClick(object sender, EventArgs e)
        {
            this.monthCalendarEnd.Visible = false;
            this.monthCalendarBegin.Visible = true;
        }

        /// <summary>
        /// EndTimeClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndTimeClick(object sender, EventArgs e)
        {
            this.monthCalendarBegin.Visible = false;
            this.monthCalendarEnd.Visible = true;
        }

        /// <summary>
        /// MonthCalendarBeginDateChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MonthCalendarBeginDateChanged(object sender, DateRangeEventArgs e)
        {
            this.beginTime.Text = monthCalendarBegin.SelectionStart.ToShortDateString();
            this.monthCalendarBegin.Visible = false;
        }

        /// <summary>
        /// MonthCalendarEndDateSelected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MonthCalendarEndDateSelected(object sender, DateRangeEventArgs e)
        {
            this.endTime.Text = monthCalendarEnd.SelectionStart.ToShortDateString();
            this.monthCalendarEnd.Visible = false;
        }

        /// <summary>
        /// KeyWord btn click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyWordBtnClick(object sender, EventArgs e)
        {
            teacherSelect.Name = keyWordSelect.Text;

            if (StringUtil.IsEmpty(this.beginTime.Text) && StringUtil.IsEmpty(this.endTime.Text))
            {
                teacherSelect.StartTime = beginDate;
                teacherSelect.EndTime = endDate;
            }
            else if (StringUtil.IsEmpty(this.beginTime.Text))
            {
                teacherSelect.StartTime = beginDate;
                teacherSelect.EndTime = Convert.ToDateTime(this.endTime.Text);
            }
            else if (StringUtil.IsEmpty(this.endTime.Text))
            {
                teacherSelect.StartTime = Convert.ToDateTime(this.beginTime.Text);
                teacherSelect.EndTime = endDate;
            }
            else
            {
                teacherSelect.StartTime = Convert.ToDateTime(this.beginTime.Text);
                teacherSelect.EndTime = Convert.ToDateTime(this.endTime.Text);
            }

            TeacherManageExam();
        }

        /// <summary>
        /// KeyWord select key up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyWordSelectKeyUp(object sender, KeyEventArgs e)
        {
            teacherSelect.Name = keyWordSelect.Text;
            TeacherManageExam();
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
        /// Next page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextPageClick(object sender, EventArgs e)
        {
            teacherSelect.CurrentPage++;

            if (teacherSelect.Name == string.Empty)
            {
                teacherSelect.Name = "";
            }

            int pageCount = (GetExamListCount() - 1)/ teacherSelect.PageSize + 1;

            if (teacherSelect.CurrentPage > pageCount)
            {
                teacherSelect.CurrentPage = pageCount;
            }

            teacherSelect.CurrentPage = teacherSelect.CurrentPage;
            TeacherManageExam();
        }

        /// <summary>
        /// Front page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrontPageClick(object sender, EventArgs e)
        {
            teacherSelect.CurrentPage--;

            if (teacherSelect.CurrentPage < 1)
            {
                teacherSelect.CurrentPage = 1;
            }

            TeacherManageExam();
        }

        /// <summary>
        /// Teacher manage exam list
        /// </summary>
        /// <param name="teacherSelect"></param>
        private void TeacherManageExam()
        {
            try
            {
                pagination();
                PageStyle();
                this.teacherManageBindingSource.DataSource = examManager.ExamList(teacherSelect);
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                MessageBox.Show(str, "system error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Get exam list count
        /// </summary>
        /// <param name="teacherSelect"></param>
        /// <returns></returns>
        private int GetExamListCount()
        {
            int count = 0;

            try
            {
                count = examManager.ExamListCount(teacherSelect);
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

                if (lab.Text == teacherSelect.CurrentPage.ToString())
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
            int pageCount = (GetExamListCount() - 1) / teacherSelect.PageSize + 1;
            int currentPage = teacherSelect.CurrentPage;

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