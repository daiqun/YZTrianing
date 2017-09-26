namespace Client.Teacher
{
    partial class ExamList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datePiickerPanel = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.keyWordBtn = new System.Windows.Forms.Label();
            this.keyWordSelect = new System.Windows.Forms.TextBox();
            this.teacherManageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableHead = new System.Windows.Forms.Panel();
            this.numOfQualified = new System.Windows.Forms.Label();
            this.passRateSort = new System.Windows.Forms.Label();
            this.effectiveTimeSort = new System.Windows.Forms.Label();
            this.avgScoreSort = new System.Windows.Forms.Label();
            this.examNameSort = new System.Windows.Forms.Label();
            this.examineeCount = new System.Windows.Forms.Label();
            this.idSort = new System.Windows.Forms.Label();
            this.totalQuantity = new System.Windows.Forms.Label();
            this.teacherDataGridView = new System.Windows.Forms.DataGridView();
            this.paginatorBar = new System.Windows.Forms.Panel();
            this.pageSize = new System.Windows.Forms.ComboBox();
            this.perPage = new System.Windows.Forms.Label();
            this.toSelectPage = new System.Windows.Forms.TextBox();
            this.includePage = new System.Windows.Forms.FlowLayoutPanel();
            this.bar1 = new System.Windows.Forms.Label();
            this.bar2 = new System.Windows.Forms.Label();
            this.bar3 = new System.Windows.Forms.Label();
            this.bar4 = new System.Windows.Forms.Label();
            this.bar5 = new System.Windows.Forms.Label();
            this.nextPage = new System.Windows.Forms.Label();
            this.frontPage = new System.Windows.Forms.Label();
            this.monthCalendarBegin = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarEnd = new System.Windows.Forms.MonthCalendar();
            this.rowNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectiveTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examineeCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfQualifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.go = new Client.Custom.RadiusBorder();
            this.timeSearch = new Client.Custom.RadiusBorder();
            this.beginTime = new Client.Custom.RadiusBorder();
            this.endTime = new Client.Custom.RadiusBorder();
            this.keyWordBox = new Client.Custom.RadiusBorder();
            this.panel1.SuspendLayout();
            this.datePiickerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherManageBindingSource)).BeginInit();
            this.tableHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            this.paginatorBar.SuspendLayout();
            this.includePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datePiickerPanel);
            this.panel1.Controls.Add(this.keyWordBtn);
            this.panel1.Controls.Add(this.keyWordBox);
            this.panel1.Controls.Add(this.keyWordSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 70);
            this.panel1.TabIndex = 0;
            // 
            // datePiickerPanel
            // 
            this.datePiickerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datePiickerPanel.Controls.Add(this.timeSearch);
            this.datePiickerPanel.Controls.Add(this.beginTime);
            this.datePiickerPanel.Controls.Add(this.endTime);
            this.datePiickerPanel.Controls.Add(this.shapeContainer2);
            this.datePiickerPanel.Location = new System.Drawing.Point(682, 10);
            this.datePiickerPanel.Name = "datePiickerPanel";
            this.datePiickerPanel.Size = new System.Drawing.Size(276, 47);
            this.datePiickerPanel.TabIndex = 18;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(276, 47);
            this.shapeContainer2.TabIndex = 20;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 97;
            this.lineShape1.X2 = 110;
            this.lineShape1.Y1 = 29;
            this.lineShape1.Y2 = 29;
            // 
            // keyWordBtn
            // 
            this.keyWordBtn.BackColor = System.Drawing.Color.White;
            this.keyWordBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyWordBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.keyWordBtn.Image = global::Client.Properties.Resources.ICN_Search_15x20_png;
            this.keyWordBtn.Location = new System.Drawing.Point(180, 29);
            this.keyWordBtn.Name = "keyWordBtn";
            this.keyWordBtn.Size = new System.Drawing.Size(23, 23);
            this.keyWordBtn.TabIndex = 16;
            this.keyWordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyWordSelect
            // 
            this.keyWordSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyWordSelect.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyWordSelect.Location = new System.Drawing.Point(31, 30);
            this.keyWordSelect.Multiline = true;
            this.keyWordSelect.Name = "keyWordSelect";
            this.keyWordSelect.Size = new System.Drawing.Size(150, 25);
            this.keyWordSelect.TabIndex = 1;
            // 
            // teacherManageBindingSource
            // 
            this.teacherManageBindingSource.DataMember = "TeacherManage";
            this.teacherManageBindingSource.DataSource = typeof(Client.DataProcess.TeacherManageDataSet);
            // 
            // tableHead
            // 
            this.tableHead.AutoSize = true;
            this.tableHead.BackColor = System.Drawing.Color.White;
            this.tableHead.Controls.Add(this.numOfQualified);
            this.tableHead.Controls.Add(this.passRateSort);
            this.tableHead.Controls.Add(this.effectiveTimeSort);
            this.tableHead.Controls.Add(this.avgScoreSort);
            this.tableHead.Controls.Add(this.examNameSort);
            this.tableHead.Controls.Add(this.examineeCount);
            this.tableHead.Controls.Add(this.idSort);
            this.tableHead.Controls.Add(this.totalQuantity);
            this.tableHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableHead.Location = new System.Drawing.Point(0, 70);
            this.tableHead.Name = "tableHead";
            this.tableHead.Size = new System.Drawing.Size(980, 40);
            this.tableHead.TabIndex = 14;
            // 
            // numOfQualified
            // 
            this.numOfQualified.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numOfQualified.BackColor = System.Drawing.Color.White;
            this.numOfQualified.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfQualified.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.numOfQualified.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.numOfQualified.Location = new System.Drawing.Point(755, 6);
            this.numOfQualified.Name = "numOfQualified";
            this.numOfQualified.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.numOfQualified.Size = new System.Drawing.Size(119, 30);
            this.numOfQualified.TabIndex = 7;
            this.numOfQualified.Text = "Number of qualified";
            this.numOfQualified.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passRateSort
            // 
            this.passRateSort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.passRateSort.BackColor = System.Drawing.Color.White;
            this.passRateSort.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passRateSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.passRateSort.Image = global::Client.Properties.Resources.ICN_Decrese_10x15_png;
            this.passRateSort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passRateSort.Location = new System.Drawing.Point(882, 7);
            this.passRateSort.Name = "passRateSort";
            this.passRateSort.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.passRateSort.Size = new System.Drawing.Size(81, 30);
            this.passRateSort.TabIndex = 6;
            this.passRateSort.Tag = "PassRate";
            this.passRateSort.Text = "Pass rate";
            this.passRateSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // effectiveTimeSort
            // 
            this.effectiveTimeSort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.effectiveTimeSort.BackColor = System.Drawing.Color.White;
            this.effectiveTimeSort.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectiveTimeSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.effectiveTimeSort.Image = global::Client.Properties.Resources.ICN_Decrese_10x15_png;
            this.effectiveTimeSort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.effectiveTimeSort.Location = new System.Drawing.Point(300, 6);
            this.effectiveTimeSort.Name = "effectiveTimeSort";
            this.effectiveTimeSort.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.effectiveTimeSort.Size = new System.Drawing.Size(102, 30);
            this.effectiveTimeSort.TabIndex = 2;
            this.effectiveTimeSort.Tag = "EffectiveTime";
            this.effectiveTimeSort.Text = "Effective Time";
            this.effectiveTimeSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgScoreSort
            // 
            this.avgScoreSort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.avgScoreSort.BackColor = System.Drawing.Color.White;
            this.avgScoreSort.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgScoreSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.avgScoreSort.Image = global::Client.Properties.Resources.ICN_Decrese_10x15_png;
            this.avgScoreSort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avgScoreSort.Location = new System.Drawing.Point(548, 6);
            this.avgScoreSort.Name = "avgScoreSort";
            this.avgScoreSort.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.avgScoreSort.Size = new System.Drawing.Size(107, 30);
            this.avgScoreSort.TabIndex = 4;
            this.avgScoreSort.Tag = "AvgScore";
            this.avgScoreSort.Text = "Average score";
            this.avgScoreSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // examNameSort
            // 
            this.examNameSort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.examNameSort.BackColor = System.Drawing.Color.White;
            this.examNameSort.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examNameSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examNameSort.Image = global::Client.Properties.Resources.ICN_Decrese_10x15_png;
            this.examNameSort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.examNameSort.Location = new System.Drawing.Point(85, 8);
            this.examNameSort.Name = "examNameSort";
            this.examNameSort.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.examNameSort.Size = new System.Drawing.Size(62, 30);
            this.examNameSort.TabIndex = 0;
            this.examNameSort.Tag = "ExamName";
            this.examNameSort.Text = "Name";
            this.examNameSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // examineeCount
            // 
            this.examineeCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.examineeCount.BackColor = System.Drawing.Color.White;
            this.examineeCount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examineeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examineeCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.examineeCount.Location = new System.Drawing.Point(646, 6);
            this.examineeCount.Name = "examineeCount";
            this.examineeCount.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.examineeCount.Size = new System.Drawing.Size(101, 30);
            this.examineeCount.TabIndex = 5;
            this.examineeCount.Text = "Examinee count";
            this.examineeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idSort
            // 
            this.idSort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.idSort.BackColor = System.Drawing.Color.White;
            this.idSort.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.idSort.Image = global::Client.Properties.Resources.ICN_Decrese_10x15_png;
            this.idSort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.idSort.Location = new System.Drawing.Point(203, 6);
            this.idSort.Name = "idSort";
            this.idSort.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.idSort.Size = new System.Drawing.Size(41, 30);
            this.idSort.TabIndex = 1;
            this.idSort.Tag = "Id";
            this.idSort.Text = "Id";
            this.idSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalQuantity
            // 
            this.totalQuantity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.totalQuantity.BackColor = System.Drawing.Color.White;
            this.totalQuantity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.totalQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalQuantity.Location = new System.Drawing.Point(415, 6);
            this.totalQuantity.Name = "totalQuantity";
            this.totalQuantity.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.totalQuantity.Size = new System.Drawing.Size(133, 30);
            this.totalQuantity.TabIndex = 3;
            this.totalQuantity.Text = "Total question quantity";
            this.totalQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teacherDataGridView
            // 
            this.teacherDataGridView.AllowUserToAddRows = false;
            this.teacherDataGridView.AllowUserToResizeColumns = false;
            this.teacherDataGridView.AllowUserToResizeRows = false;
            this.teacherDataGridView.AutoGenerateColumns = false;
            this.teacherDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teacherDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.teacherDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teacherDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.teacherDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.teacherDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.teacherDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.teacherDataGridView.ColumnHeadersHeight = 40;
            this.teacherDataGridView.ColumnHeadersVisible = false;
            this.teacherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNumberDataGridViewTextBoxColumn,
            this.examNameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.effectiveTimeDataGridViewTextBoxColumn,
            this.questionQuantityDataGridViewTextBoxColumn,
            this.avgScoreDataGridViewTextBoxColumn,
            this.examineeCountDataGridViewTextBoxColumn,
            this.numOfQualifiedDataGridViewTextBoxColumn,
            this.passRateDataGridViewTextBoxColumn});
            this.teacherDataGridView.DataSource = this.teacherManageBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.teacherDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.teacherDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.teacherDataGridView.EnableHeadersVisualStyles = false;
            this.teacherDataGridView.GridColor = System.Drawing.Color.White;
            this.teacherDataGridView.Location = new System.Drawing.Point(0, 110);
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.teacherDataGridView.RowHeadersVisible = false;
            this.teacherDataGridView.RowHeadersWidth = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            this.teacherDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.teacherDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.teacherDataGridView.RowTemplate.Height = 30;
            this.teacherDataGridView.RowTemplate.ReadOnly = true;
            this.teacherDataGridView.Size = new System.Drawing.Size(980, 300);
            this.teacherDataGridView.TabIndex = 15;
            // 
            // paginatorBar
            // 
            this.paginatorBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paginatorBar.BackColor = System.Drawing.Color.White;
            this.paginatorBar.Controls.Add(this.go);
            this.paginatorBar.Controls.Add(this.pageSize);
            this.paginatorBar.Controls.Add(this.perPage);
            this.paginatorBar.Controls.Add(this.toSelectPage);
            this.paginatorBar.Controls.Add(this.includePage);
            this.paginatorBar.Controls.Add(this.nextPage);
            this.paginatorBar.Controls.Add(this.frontPage);
            this.paginatorBar.Location = new System.Drawing.Point(315, 460);
            this.paginatorBar.Name = "paginatorBar";
            this.paginatorBar.Size = new System.Drawing.Size(380, 36);
            this.paginatorBar.TabIndex = 16;
            // 
            // pageSize
            // 
            this.pageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pageSize.FormattingEnabled = true;
            this.pageSize.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "50"});
            this.pageSize.Location = new System.Drawing.Point(193, 9);
            this.pageSize.Name = "pageSize";
            this.pageSize.Size = new System.Drawing.Size(36, 20);
            this.pageSize.TabIndex = 6;
            // 
            // perPage
            // 
            this.perPage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.perPage.Location = new System.Drawing.Point(233, 10);
            this.perPage.Name = "perPage";
            this.perPage.Size = new System.Drawing.Size(59, 20);
            this.perPage.TabIndex = 5;
            this.perPage.Text = "Per page";
            // 
            // toSelectPage
            // 
            this.toSelectPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toSelectPage.Location = new System.Drawing.Point(302, 10);
            this.toSelectPage.Multiline = true;
            this.toSelectPage.Name = "toSelectPage";
            this.toSelectPage.Size = new System.Drawing.Size(30, 18);
            this.toSelectPage.TabIndex = 1;
            // 
            // includePage
            // 
            this.includePage.Controls.Add(this.bar1);
            this.includePage.Controls.Add(this.bar2);
            this.includePage.Controls.Add(this.bar3);
            this.includePage.Controls.Add(this.bar4);
            this.includePage.Controls.Add(this.bar5);
            this.includePage.Location = new System.Drawing.Point(33, 15);
            this.includePage.Name = "includePage";
            this.includePage.Size = new System.Drawing.Size(125, 15);
            this.includePage.TabIndex = 1;
            // 
            // bar1
            // 
            this.bar1.Location = new System.Drawing.Point(3, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(15, 15);
            this.bar1.TabIndex = 1;
            // 
            // bar2
            // 
            this.bar2.Location = new System.Drawing.Point(24, 0);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(25, 15);
            this.bar2.TabIndex = 2;
            // 
            // bar3
            // 
            this.bar3.Location = new System.Drawing.Point(55, 0);
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(15, 15);
            this.bar3.TabIndex = 3;
            // 
            // bar4
            // 
            this.bar4.Location = new System.Drawing.Point(76, 0);
            this.bar4.Name = "bar4";
            this.bar4.Size = new System.Drawing.Size(25, 15);
            this.bar4.TabIndex = 4;
            // 
            // bar5
            // 
            this.bar5.Location = new System.Drawing.Point(107, 0);
            this.bar5.Name = "bar5";
            this.bar5.Size = new System.Drawing.Size(15, 15);
            this.bar5.TabIndex = 5;
            // 
            // nextPage
            // 
            this.nextPage.Image = global::Client.Properties.Resources.BTN_PageRight_20x15_png_;
            this.nextPage.Location = new System.Drawing.Point(165, 12);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(20, 15);
            this.nextPage.TabIndex = 1;
            // 
            // frontPage
            // 
            this.frontPage.Image = global::Client.Properties.Resources.BTN_PageLeft_20x15_png;
            this.frontPage.Location = new System.Drawing.Point(7, 12);
            this.frontPage.Name = "frontPage";
            this.frontPage.Size = new System.Drawing.Size(20, 15);
            this.frontPage.TabIndex = 0;
            // 
            // monthCalendarBegin
            // 
            this.monthCalendarBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendarBegin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendarBegin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendarBegin.Location = new System.Drawing.Point(590, 60);
            this.monthCalendarBegin.Name = "monthCalendarBegin";
            this.monthCalendarBegin.TabIndex = 17;
            this.monthCalendarBegin.TitleBackColor = System.Drawing.Color.Black;
            this.monthCalendarBegin.Visible = false;
            // 
            // monthCalendarEnd
            // 
            this.monthCalendarEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendarEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendarEnd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendarEnd.Location = new System.Drawing.Point(710, 60);
            this.monthCalendarEnd.Name = "monthCalendarEnd";
            this.monthCalendarEnd.TabIndex = 18;
            this.monthCalendarEnd.TitleBackColor = System.Drawing.Color.Black;
            this.monthCalendarEnd.Visible = false;
            // 
            // rowNumberDataGridViewTextBoxColumn
            // 
            this.rowNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rowNumberDataGridViewTextBoxColumn.DataPropertyName = "RowNumber";
            this.rowNumberDataGridViewTextBoxColumn.HeaderText = "RowNumber";
            this.rowNumberDataGridViewTextBoxColumn.Name = "rowNumberDataGridViewTextBoxColumn";
            this.rowNumberDataGridViewTextBoxColumn.Width = 60;
            // 
            // examNameDataGridViewTextBoxColumn
            // 
            this.examNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.examNameDataGridViewTextBoxColumn.DataPropertyName = "ExamName";
            this.examNameDataGridViewTextBoxColumn.FillWeight = 154.1399F;
            this.examNameDataGridViewTextBoxColumn.HeaderText = "ExamName";
            this.examNameDataGridViewTextBoxColumn.Name = "examNameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 581.3277F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 110;
            // 
            // effectiveTimeDataGridViewTextBoxColumn
            // 
            this.effectiveTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.effectiveTimeDataGridViewTextBoxColumn.DataPropertyName = "EffectiveTime";
            this.effectiveTimeDataGridViewTextBoxColumn.FillWeight = 7.55588F;
            this.effectiveTimeDataGridViewTextBoxColumn.HeaderText = "EffectiveTime";
            this.effectiveTimeDataGridViewTextBoxColumn.Name = "effectiveTimeDataGridViewTextBoxColumn";
            this.effectiveTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // questionQuantityDataGridViewTextBoxColumn
            // 
            this.questionQuantityDataGridViewTextBoxColumn.DataPropertyName = "QuestionQuantity";
            this.questionQuantityDataGridViewTextBoxColumn.FillWeight = 7.55588F;
            this.questionQuantityDataGridViewTextBoxColumn.HeaderText = "QuestionQuantity";
            this.questionQuantityDataGridViewTextBoxColumn.Name = "questionQuantityDataGridViewTextBoxColumn";
            // 
            // avgScoreDataGridViewTextBoxColumn
            // 
            this.avgScoreDataGridViewTextBoxColumn.DataPropertyName = "AvgScore";
            this.avgScoreDataGridViewTextBoxColumn.FillWeight = 7.55588F;
            this.avgScoreDataGridViewTextBoxColumn.HeaderText = "AvgScore";
            this.avgScoreDataGridViewTextBoxColumn.Name = "avgScoreDataGridViewTextBoxColumn";
            // 
            // examineeCountDataGridViewTextBoxColumn
            // 
            this.examineeCountDataGridViewTextBoxColumn.DataPropertyName = "ExamineeCount";
            this.examineeCountDataGridViewTextBoxColumn.FillWeight = 7.55588F;
            this.examineeCountDataGridViewTextBoxColumn.HeaderText = "ExamineeCount";
            this.examineeCountDataGridViewTextBoxColumn.Name = "examineeCountDataGridViewTextBoxColumn";
            // 
            // numOfQualifiedDataGridViewTextBoxColumn
            // 
            this.numOfQualifiedDataGridViewTextBoxColumn.DataPropertyName = "NumOfQualified";
            this.numOfQualifiedDataGridViewTextBoxColumn.FillWeight = 7.55588F;
            this.numOfQualifiedDataGridViewTextBoxColumn.HeaderText = "NumOfQualified";
            this.numOfQualifiedDataGridViewTextBoxColumn.Name = "numOfQualifiedDataGridViewTextBoxColumn";
            // 
            // passRateDataGridViewTextBoxColumn
            // 
            this.passRateDataGridViewTextBoxColumn.DataPropertyName = "PassRate";
            this.passRateDataGridViewTextBoxColumn.FillWeight = 7.55588F;
            this.passRateDataGridViewTextBoxColumn.HeaderText = "PassRate";
            this.passRateDataGridViewTextBoxColumn.Name = "passRateDataGridViewTextBoxColumn";
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.go.BorderColor = System.Drawing.Color.Empty;
            this.go.BorderSize = 0F;
            this.go.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.FontColor = System.Drawing.Color.White;
            this.go.ForeColor = System.Drawing.Color.White;
            this.go.Location = new System.Drawing.Point(341, 10);
            this.go.Name = "go";
            this.go.Radius = 0.1F;
            this.go.Size = new System.Drawing.Size(28, 18);
            this.go.TabIndex = 13;
            this.go.Text = "Go";
            // 
            // timeSearch
            // 
            this.timeSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.timeSearch.BorderSize = 1F;
            this.timeSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSearch.FontColor = System.Drawing.Color.Empty;
            this.timeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.timeSearch.Location = new System.Drawing.Point(217, 14);
            this.timeSearch.Name = "timeSearch";
            this.timeSearch.Radius = 6F;
            this.timeSearch.Size = new System.Drawing.Size(50, 30);
            this.timeSearch.TabIndex = 19;
            this.timeSearch.Text = "Date";
            // 
            // beginTime
            // 
            this.beginTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.beginTime.BorderSize = 1F;
            this.beginTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginTime.FontColor = System.Drawing.Color.Empty;
            this.beginTime.Location = new System.Drawing.Point(3, 14);
            this.beginTime.Name = "beginTime";
            this.beginTime.Radius = 6F;
            this.beginTime.Size = new System.Drawing.Size(90, 30);
            this.beginTime.TabIndex = 17;
            // 
            // endTime
            // 
            this.endTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.endTime.BorderSize = 1F;
            this.endTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTime.FontColor = System.Drawing.Color.Empty;
            this.endTime.Location = new System.Drawing.Point(116, 14);
            this.endTime.Name = "endTime";
            this.endTime.Radius = 6F;
            this.endTime.Size = new System.Drawing.Size(90, 30);
            this.endTime.TabIndex = 18;
            // 
            // keyWordBox
            // 
            this.keyWordBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.keyWordBox.BorderSize = 1F;
            this.keyWordBox.Enabled = false;
            this.keyWordBox.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyWordBox.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.keyWordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.keyWordBox.Location = new System.Drawing.Point(28, 26);
            this.keyWordBox.Name = "keyWordBox";
            this.keyWordBox.Radius = 10F;
            this.keyWordBox.Size = new System.Drawing.Size(180, 30);
            this.keyWordBox.TabIndex = 16;
            // 
            // ExamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.monthCalendarEnd);
            this.Controls.Add(this.monthCalendarBegin);
            this.Controls.Add(this.paginatorBar);
            this.Controls.Add(this.teacherDataGridView);
            this.Controls.Add(this.tableHead);
            this.Controls.Add(this.panel1);
            this.Name = "ExamList";
            this.Size = new System.Drawing.Size(980, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.datePiickerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teacherManageBindingSource)).EndInit();
            this.tableHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
            this.paginatorBar.ResumeLayout(false);
            this.paginatorBar.PerformLayout();
            this.includePage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource teacherManageBindingSource;
        private System.Windows.Forms.Panel tableHead;
        private System.Windows.Forms.Label numOfQualified;
        private System.Windows.Forms.Label passRateSort;
        private System.Windows.Forms.Label effectiveTimeSort;
        private System.Windows.Forms.Label avgScoreSort;
        private System.Windows.Forms.Label examNameSort;
        private System.Windows.Forms.Label examineeCount;
        private System.Windows.Forms.Label idSort;
        private System.Windows.Forms.Label totalQuantity;
        private System.Windows.Forms.DataGridView teacherDataGridView;
        private System.Windows.Forms.TextBox keyWordSelect;
        public Custom.RadiusBorder keyWordBox;
        private System.Windows.Forms.Label keyWordBtn;
        private System.Windows.Forms.Panel paginatorBar;
        private Custom.RadiusBorder go;
        private System.Windows.Forms.ComboBox pageSize;
        private System.Windows.Forms.Label perPage;
        private System.Windows.Forms.TextBox toSelectPage;
        private System.Windows.Forms.FlowLayoutPanel includePage;
        private System.Windows.Forms.Label bar1;
        private System.Windows.Forms.Label bar2;
        private System.Windows.Forms.Label bar3;
        private System.Windows.Forms.Label bar4;
        private System.Windows.Forms.Label bar5;
        private System.Windows.Forms.Label nextPage;
        private System.Windows.Forms.Label frontPage;
        private Custom.RadiusBorder beginTime;
        private Custom.RadiusBorder endTime;
        private Custom.RadiusBorder timeSearch;
        private System.Windows.Forms.Panel datePiickerPanel;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.MonthCalendar monthCalendarBegin;
        private System.Windows.Forms.MonthCalendar monthCalendarEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectiveTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examineeCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfQualifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passRateDataGridViewTextBoxColumn;
    }
}
