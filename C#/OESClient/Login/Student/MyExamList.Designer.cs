namespace Client.Student
{
    partial class MyExamList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.unFinishedExam = new System.Windows.Forms.Label();
            this.finishedExam = new System.Windows.Forms.Label();
            this.allExam = new System.Windows.Forms.Label();
            this.sortGroup = new System.Windows.Forms.Panel();
            this.sortEffectiveTime = new System.Windows.Forms.Label();
            this.sortOperation = new System.Windows.Forms.Label();
            this.sortId = new System.Windows.Forms.Label();
            this.nameSort = new System.Windows.Forms.Label();
            this.sortExamScore = new System.Windows.Forms.Label();
            this.sortPassCriteria = new System.Windows.Forms.Label();
            this.sortDuration = new System.Windows.Forms.Label();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.rowNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectiveTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passCriteriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examSocreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentExamListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paginatorBar = new System.Windows.Forms.Panel();
            this.go = new Client.Custom.RadiusBorder();
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
            this.panel1.SuspendLayout();
            this.sortGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentExamListBindingSource)).BeginInit();
            this.paginatorBar.SuspendLayout();
            this.includePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.unFinishedExam);
            this.panel1.Controls.Add(this.finishedExam);
            this.panel1.Controls.Add(this.allExam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 70);
            this.panel1.TabIndex = 2;
            // 
            // unFinishedExam
            // 
            this.unFinishedExam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.unFinishedExam.BackColor = System.Drawing.Color.White;
            this.unFinishedExam.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unFinishedExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.unFinishedExam.Location = new System.Drawing.Point(611, 26);
            this.unFinishedExam.Name = "unFinishedExam";
            this.unFinishedExam.Size = new System.Drawing.Size(100, 30);
            this.unFinishedExam.TabIndex = 3;
            this.unFinishedExam.Text = "Unfinished";
            this.unFinishedExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finishedExam
            // 
            this.finishedExam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.finishedExam.BackColor = System.Drawing.Color.White;
            this.finishedExam.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishedExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.finishedExam.Location = new System.Drawing.Point(440, 26);
            this.finishedExam.Name = "finishedExam";
            this.finishedExam.Size = new System.Drawing.Size(100, 30);
            this.finishedExam.TabIndex = 2;
            this.finishedExam.Text = "Finished";
            this.finishedExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allExam
            // 
            this.allExam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.allExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.allExam.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allExam.ForeColor = System.Drawing.Color.White;
            this.allExam.Location = new System.Drawing.Point(272, 26);
            this.allExam.Name = "allExam";
            this.allExam.Size = new System.Drawing.Size(100, 30);
            this.allExam.TabIndex = 1;
            this.allExam.Text = "ALL";
            this.allExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortGroup
            // 
            this.sortGroup.AutoSize = true;
            this.sortGroup.BackColor = System.Drawing.Color.White;
            this.sortGroup.Controls.Add(this.sortEffectiveTime);
            this.sortGroup.Controls.Add(this.sortOperation);
            this.sortGroup.Controls.Add(this.sortId);
            this.sortGroup.Controls.Add(this.nameSort);
            this.sortGroup.Controls.Add(this.sortExamScore);
            this.sortGroup.Controls.Add(this.sortPassCriteria);
            this.sortGroup.Controls.Add(this.sortDuration);
            this.sortGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.sortGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sortGroup.Location = new System.Drawing.Point(0, 70);
            this.sortGroup.Name = "sortGroup";
            this.sortGroup.Size = new System.Drawing.Size(980, 32);
            this.sortGroup.TabIndex = 1;
            // 
            // sortEffectiveTime
            // 
            this.sortEffectiveTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortEffectiveTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortEffectiveTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sortEffectiveTime.Image = global::Client.Properties.Resources.ICN_Decrese_10x15_png;
            this.sortEffectiveTime.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.sortEffectiveTime.Location = new System.Drawing.Point(326, 0);
            this.sortEffectiveTime.Name = "sortEffectiveTime";
            this.sortEffectiveTime.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.sortEffectiveTime.Size = new System.Drawing.Size(118, 32);
            this.sortEffectiveTime.TabIndex = 2;
            this.sortEffectiveTime.Tag = "EffectiveTime";
            this.sortEffectiveTime.Text = "Effective Time";
            this.sortEffectiveTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sortOperation
            // 
            this.sortOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortOperation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sortOperation.Image = global::Client.Properties.Resources.ICN_Decrese_10x15_png;
            this.sortOperation.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.sortOperation.Location = new System.Drawing.Point(854, 0);
            this.sortOperation.Name = "sortOperation";
            this.sortOperation.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.sortOperation.Size = new System.Drawing.Size(92, 32);
            this.sortOperation.TabIndex = 6;
            this.sortOperation.Tag = "Operation";
            this.sortOperation.Text = "Operation";
            this.sortOperation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sortId
            // 
            this.sortId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortId.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sortId.Image = global::Client.Properties.Resources.ICN_Decrese_10x15_png;
            this.sortId.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.sortId.Location = new System.Drawing.Point(230, 0);
            this.sortId.Name = "sortId";
            this.sortId.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.sortId.Size = new System.Drawing.Size(40, 32);
            this.sortId.TabIndex = 1;
            this.sortId.Tag = "Id";
            this.sortId.Text = "Id";
            this.sortId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameSort
            // 
            this.nameSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameSort.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.nameSort.Image = global::Client.Properties.Resources.ICN_Decrese_10x15_png;
            this.nameSort.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.nameSort.Location = new System.Drawing.Point(104, 0);
            this.nameSort.Name = "nameSort";
            this.nameSort.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.nameSort.Size = new System.Drawing.Size(62, 32);
            this.nameSort.TabIndex = 0;
            this.nameSort.Tag = "ExamName";
            this.nameSort.Text = "Name";
            this.nameSort.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sortExamScore
            // 
            this.sortExamScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortExamScore.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortExamScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sortExamScore.Image = global::Client.Properties.Resources.ICN_Decrese_10x15_png;
            this.sortExamScore.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.sortExamScore.Location = new System.Drawing.Point(706, 0);
            this.sortExamScore.Name = "sortExamScore";
            this.sortExamScore.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.sortExamScore.Size = new System.Drawing.Size(136, 32);
            this.sortExamScore.TabIndex = 5;
            this.sortExamScore.Tag = "ExamScore";
            this.sortExamScore.Text = "Exam/TotalScore";
            this.sortExamScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sortPassCriteria
            // 
            this.sortPassCriteria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortPassCriteria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortPassCriteria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sortPassCriteria.Image = global::Client.Properties.Resources.ICN_Decrese_10x15_png;
            this.sortPassCriteria.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.sortPassCriteria.Location = new System.Drawing.Point(593, 0);
            this.sortPassCriteria.Name = "sortPassCriteria";
            this.sortPassCriteria.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.sortPassCriteria.Size = new System.Drawing.Size(113, 32);
            this.sortPassCriteria.TabIndex = 4;
            this.sortPassCriteria.Tag = "PassCriteria";
            this.sortPassCriteria.Text = "Pass Criteria";
            this.sortPassCriteria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sortDuration
            // 
            this.sortDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortDuration.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sortDuration.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.sortDuration.Location = new System.Drawing.Point(483, 0);
            this.sortDuration.Name = "sortDuration";
            this.sortDuration.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.sortDuration.Size = new System.Drawing.Size(102, 32);
            this.sortDuration.TabIndex = 3;
            this.sortDuration.Text = "Duration(mins)";
            this.sortDuration.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToAddRows = false;
            this.studentDataGridView.AllowUserToResizeColumns = false;
            this.studentDataGridView.AllowUserToResizeRows = false;
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.studentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.ColumnHeadersVisible = false;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNumberDataGridViewTextBoxColumn,
            this.examNameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.effectiveTimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.passCriteriaDataGridViewTextBoxColumn,
            this.examSocreDataGridViewTextBoxColumn,
            this.operationDataGridViewTextBoxColumn});
            this.studentDataGridView.DataSource = this.studentExamListBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.studentDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentDataGridView.GridColor = System.Drawing.Color.White;
            this.studentDataGridView.Location = new System.Drawing.Point(0, 102);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.RowHeadersVisible = false;
            this.studentDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.studentDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.studentDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.studentDataGridView.RowTemplate.Height = 30;
            this.studentDataGridView.RowTemplate.ReadOnly = true;
            this.studentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentDataGridView.Size = new System.Drawing.Size(980, 300);
            this.studentDataGridView.TabIndex = 11;
            // 
            // rowNumberDataGridViewTextBoxColumn
            // 
            this.rowNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rowNumberDataGridViewTextBoxColumn.DataPropertyName = "RowNumber";
            this.rowNumberDataGridViewTextBoxColumn.FillWeight = 5F;
            this.rowNumberDataGridViewTextBoxColumn.HeaderText = "RowNumber";
            this.rowNumberDataGridViewTextBoxColumn.Name = "rowNumberDataGridViewTextBoxColumn";
            this.rowNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // examNameDataGridViewTextBoxColumn
            // 
            this.examNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.examNameDataGridViewTextBoxColumn.DataPropertyName = "ExamName";
            this.examNameDataGridViewTextBoxColumn.FillWeight = 67.87527F;
            this.examNameDataGridViewTextBoxColumn.HeaderText = "ExamName";
            this.examNameDataGridViewTextBoxColumn.Name = "examNameDataGridViewTextBoxColumn";
            this.examNameDataGridViewTextBoxColumn.Width = 115;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 67.87527F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 120;
            // 
            // effectiveTimeDataGridViewTextBoxColumn
            // 
            this.effectiveTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.effectiveTimeDataGridViewTextBoxColumn.DataPropertyName = "EffectiveTime";
            this.effectiveTimeDataGridViewTextBoxColumn.FillWeight = 67.87527F;
            this.effectiveTimeDataGridViewTextBoxColumn.HeaderText = "EffectiveTime";
            this.effectiveTimeDataGridViewTextBoxColumn.Name = "effectiveTimeDataGridViewTextBoxColumn";
            this.effectiveTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.FillWeight = 67.87527F;
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // passCriteriaDataGridViewTextBoxColumn
            // 
            this.passCriteriaDataGridViewTextBoxColumn.DataPropertyName = "PassCriteria";
            this.passCriteriaDataGridViewTextBoxColumn.FillWeight = 67.87527F;
            this.passCriteriaDataGridViewTextBoxColumn.HeaderText = "PassCriteria";
            this.passCriteriaDataGridViewTextBoxColumn.Name = "passCriteriaDataGridViewTextBoxColumn";
            // 
            // examSocreDataGridViewTextBoxColumn
            // 
            this.examSocreDataGridViewTextBoxColumn.DataPropertyName = "ExamSocre";
            this.examSocreDataGridViewTextBoxColumn.FillWeight = 67.87527F;
            this.examSocreDataGridViewTextBoxColumn.HeaderText = "ExamSocre";
            this.examSocreDataGridViewTextBoxColumn.Name = "examSocreDataGridViewTextBoxColumn";
            // 
            // operationDataGridViewTextBoxColumn
            // 
            this.operationDataGridViewTextBoxColumn.DataPropertyName = "Operation";
            this.operationDataGridViewTextBoxColumn.FillWeight = 67.87527F;
            this.operationDataGridViewTextBoxColumn.HeaderText = "Operation";
            this.operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            this.operationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // studentExamListBindingSource
            // 
            this.studentExamListBindingSource.DataMember = "StudentExamList";
            this.studentExamListBindingSource.DataSource = typeof(Client.DataProcess.StudentExamListDataSet);
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
            this.paginatorBar.Location = new System.Drawing.Point(312, 448);
            this.paginatorBar.Name = "paginatorBar";
            this.paginatorBar.Size = new System.Drawing.Size(380, 36);
            this.paginatorBar.TabIndex = 12;
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
            // MyExamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.paginatorBar);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.sortGroup);
            this.Controls.Add(this.panel1);
            this.Name = "MyExamList";
            this.Size = new System.Drawing.Size(980, 640);
            this.panel1.ResumeLayout(false);
            this.sortGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentExamListBindingSource)).EndInit();
            this.paginatorBar.ResumeLayout(false);
            this.paginatorBar.PerformLayout();
            this.includePage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label unFinishedExam;
        private System.Windows.Forms.Label finishedExam;
        private System.Windows.Forms.Label allExam;
        private System.Windows.Forms.Panel sortGroup;
        private System.Windows.Forms.Label sortEffectiveTime;
        private System.Windows.Forms.Label sortOperation;
        private System.Windows.Forms.Label sortId;
        private System.Windows.Forms.Label nameSort;
        private System.Windows.Forms.Label sortExamScore;
        private System.Windows.Forms.Label sortPassCriteria;
        private System.Windows.Forms.Label sortDuration;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Panel paginatorBar;
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
        private System.Windows.Forms.BindingSource studentExamListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectiveTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passCriteriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examSocreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private Custom.RadiusBorder go;
        private System.Windows.Forms.ComboBox pageSize;
    }
}
