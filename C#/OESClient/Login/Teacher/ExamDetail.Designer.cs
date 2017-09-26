namespace Client.Teacher
{
    partial class ExamDetail
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

        #region Windows Form Designer generated code

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
            this.head = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.windowClose = new System.Windows.Forms.Label();
            this.windowMin = new System.Windows.Forms.Label();
            this.windowStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmpLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.examDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.tableHead = new System.Windows.Forms.Panel();
            this.passRateSort = new System.Windows.Forms.Label();
            this.effectiveTimeSort = new System.Windows.Forms.Label();
            this.avgScoreSort = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.keyWordBtn = new System.Windows.Forms.Label();
            this.keyWordBox = new Client.Custom.RadiusBorder();
            this.keyWordSelect = new System.Windows.Forms.TextBox();
            this.examNameSort = new System.Windows.Forms.Label();
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
            this.examJoinDetailTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rowNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passCriteriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.head.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examDetailDataGridView)).BeginInit();
            this.tableHead.SuspendLayout();
            this.panel3.SuspendLayout();
            this.paginatorBar.SuspendLayout();
            this.includePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examJoinDetailTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.head.Controls.Add(this.panel2);
            this.head.Controls.Add(this.label1);
            this.head.Controls.Add(this.cmpLogo);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1024, 38);
            this.head.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.windowClose);
            this.panel2.Controls.Add(this.windowMin);
            this.panel2.Controls.Add(this.windowStatus);
            this.panel2.Location = new System.Drawing.Point(888, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 25);
            this.panel2.TabIndex = 7;
            // 
            // windowClose
            // 
            this.windowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowClose.Image = global::Client.Properties.Resources.ICN_Client_Close_Program_21X21;
            this.windowClose.Location = new System.Drawing.Point(83, 0);
            this.windowClose.Name = "windowClose";
            this.windowClose.Size = new System.Drawing.Size(26, 23);
            this.windowClose.TabIndex = 5;
            // 
            // windowMin
            // 
            this.windowMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowMin.Image = global::Client.Properties.Resources.ICN_Client_Min_Program_22X22;
            this.windowMin.Location = new System.Drawing.Point(13, 1);
            this.windowMin.Name = "windowMin";
            this.windowMin.Size = new System.Drawing.Size(29, 22);
            this.windowMin.TabIndex = 4;
            // 
            // windowStatus
            // 
            this.windowStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowStatus.Image = global::Client.Properties.Resources.ICN_Client_Max_Or_Normal_Program_22X22;
            this.windowStatus.Location = new System.Drawing.Point(48, 1);
            this.windowStatus.Name = "windowStatus";
            this.windowStatus.Size = new System.Drawing.Size(29, 22);
            this.windowStatus.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Online Exam System Client";
            // 
            // cmpLogo
            // 
            this.cmpLogo.Image = global::Client.Properties.Resources.LOGO_Client_Titel_120x20;
            this.cmpLogo.Location = new System.Drawing.Point(20, 12);
            this.cmpLogo.Name = "cmpLogo";
            this.cmpLogo.Size = new System.Drawing.Size(136, 20);
            this.cmpLogo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.paginatorBar);
            this.panel1.Controls.Add(this.examDetailDataGridView);
            this.panel1.Controls.Add(this.tableHead);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(20, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 672);
            this.panel1.TabIndex = 6;
            // 
            // examDetailDataGridView
            // 
            this.examDetailDataGridView.AllowUserToAddRows = false;
            this.examDetailDataGridView.AllowUserToResizeColumns = false;
            this.examDetailDataGridView.AllowUserToResizeRows = false;
            this.examDetailDataGridView.AutoGenerateColumns = false;
            this.examDetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.examDetailDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.examDetailDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.examDetailDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.examDetailDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.examDetailDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.examDetailDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.examDetailDataGridView.ColumnHeadersHeight = 40;
            this.examDetailDataGridView.ColumnHeadersVisible = false;
            this.examDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNumberDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passCriteriaDataGridViewTextBoxColumn,
            this.examScoreDataGridViewTextBoxColumn,
            this.totalScoreDataGridViewTextBoxColumn,
            this.isPassDataGridViewTextBoxColumn});
            this.examDetailDataGridView.DataSource = this.examJoinDetailTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.examDetailDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.examDetailDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.examDetailDataGridView.EnableHeadersVisualStyles = false;
            this.examDetailDataGridView.GridColor = System.Drawing.Color.White;
            this.examDetailDataGridView.Location = new System.Drawing.Point(0, 110);
            this.examDetailDataGridView.Name = "examDetailDataGridView";
            this.examDetailDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.examDetailDataGridView.RowHeadersVisible = false;
            this.examDetailDataGridView.RowHeadersWidth = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            this.examDetailDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.examDetailDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.examDetailDataGridView.RowTemplate.Height = 30;
            this.examDetailDataGridView.RowTemplate.ReadOnly = true;
            this.examDetailDataGridView.Size = new System.Drawing.Size(980, 300);
            this.examDetailDataGridView.TabIndex = 18;
            // 
            // tableHead
            // 
            this.tableHead.AutoSize = true;
            this.tableHead.BackColor = System.Drawing.Color.White;
            this.tableHead.Controls.Add(this.passRateSort);
            this.tableHead.Controls.Add(this.effectiveTimeSort);
            this.tableHead.Controls.Add(this.avgScoreSort);
            this.tableHead.Controls.Add(this.examNameSort);
            this.tableHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableHead.Location = new System.Drawing.Point(0, 70);
            this.tableHead.Name = "tableHead";
            this.tableHead.Size = new System.Drawing.Size(980, 40);
            this.tableHead.TabIndex = 17;
            // 
            // passRateSort
            // 
            this.passRateSort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.passRateSort.BackColor = System.Drawing.Color.White;
            this.passRateSort.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passRateSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.passRateSort.Image = global::Client.Properties.Resources.ICN_Decrese_10x15_png;
            this.passRateSort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passRateSort.Location = new System.Drawing.Point(794, 6);
            this.passRateSort.Name = "passRateSort";
            this.passRateSort.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.passRateSort.Size = new System.Drawing.Size(67, 30);
            this.passRateSort.TabIndex = 6;
            this.passRateSort.Tag = "PassRate";
            this.passRateSort.Text = "Result";
            this.passRateSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // effectiveTimeSort
            // 
            this.effectiveTimeSort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.effectiveTimeSort.BackColor = System.Drawing.Color.White;
            this.effectiveTimeSort.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectiveTimeSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.effectiveTimeSort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.effectiveTimeSort.Location = new System.Drawing.Point(415, 6);
            this.effectiveTimeSort.Name = "effectiveTimeSort";
            this.effectiveTimeSort.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.effectiveTimeSort.Size = new System.Drawing.Size(102, 30);
            this.effectiveTimeSort.TabIndex = 2;
            this.effectiveTimeSort.Tag = "EffectiveTime";
            this.effectiveTimeSort.Text = "Pass criteria";
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
            this.avgScoreSort.Location = new System.Drawing.Point(588, 6);
            this.avgScoreSort.Name = "avgScoreSort";
            this.avgScoreSort.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.avgScoreSort.Size = new System.Drawing.Size(124, 30);
            this.avgScoreSort.TabIndex = 4;
            this.avgScoreSort.Tag = "AvgScore";
            this.avgScoreSort.Text = "Exam/Total Score";
            this.avgScoreSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.keyWordBtn);
            this.panel3.Controls.Add(this.keyWordBox);
            this.panel3.Controls.Add(this.keyWordSelect);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 70);
            this.panel3.TabIndex = 16;
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
            // examNameSort
            // 
            this.examNameSort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.examNameSort.BackColor = System.Drawing.Color.White;
            this.examNameSort.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examNameSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examNameSort.Image = global::Client.Properties.Resources.ICN_Decrese_10x15_png;
            this.examNameSort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.examNameSort.Location = new System.Drawing.Point(227, 6);
            this.examNameSort.Name = "examNameSort";
            this.examNameSort.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.examNameSort.Size = new System.Drawing.Size(92, 30);
            this.examNameSort.TabIndex = 0;
            this.examNameSort.Tag = "ExamName";
            this.examNameSort.Text = "Attendance";
            this.examNameSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.paginatorBar.Location = new System.Drawing.Point(307, 454);
            this.paginatorBar.Name = "paginatorBar";
            this.paginatorBar.Size = new System.Drawing.Size(380, 36);
            this.paginatorBar.TabIndex = 19;
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
            // examJoinDetailTableBindingSource
            // 
            this.examJoinDetailTableBindingSource.DataMember = "ExamJoinDetailTable";
            this.examJoinDetailTableBindingSource.DataSource = typeof(Client.DataProcess.ExamDetailDataSet);
            // 
            // rowNumberDataGridViewTextBoxColumn
            // 
            this.rowNumberDataGridViewTextBoxColumn.DataPropertyName = "RowNumber";
            this.rowNumberDataGridViewTextBoxColumn.HeaderText = "RowNumber";
            this.rowNumberDataGridViewTextBoxColumn.Name = "rowNumberDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // passCriteriaDataGridViewTextBoxColumn
            // 
            this.passCriteriaDataGridViewTextBoxColumn.DataPropertyName = "PassCriteria";
            this.passCriteriaDataGridViewTextBoxColumn.HeaderText = "PassCriteria";
            this.passCriteriaDataGridViewTextBoxColumn.Name = "passCriteriaDataGridViewTextBoxColumn";
            // 
            // examScoreDataGridViewTextBoxColumn
            // 
            this.examScoreDataGridViewTextBoxColumn.DataPropertyName = "ExamScore";
            this.examScoreDataGridViewTextBoxColumn.HeaderText = "ExamScore";
            this.examScoreDataGridViewTextBoxColumn.Name = "examScoreDataGridViewTextBoxColumn";
            // 
            // totalScoreDataGridViewTextBoxColumn
            // 
            this.totalScoreDataGridViewTextBoxColumn.DataPropertyName = "TotalScore";
            this.totalScoreDataGridViewTextBoxColumn.HeaderText = "TotalScore";
            this.totalScoreDataGridViewTextBoxColumn.Name = "totalScoreDataGridViewTextBoxColumn";
            // 
            // isPassDataGridViewTextBoxColumn
            // 
            this.isPassDataGridViewTextBoxColumn.DataPropertyName = "IsPass";
            this.isPassDataGridViewTextBoxColumn.HeaderText = "IsPass";
            this.isPassDataGridViewTextBoxColumn.Name = "isPassDataGridViewTextBoxColumn";
            // 
            // ExamDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamDetail";
            this.Text = "ExamDetail";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examDetailDataGridView)).EndInit();
            this.tableHead.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.paginatorBar.ResumeLayout(false);
            this.paginatorBar.PerformLayout();
            this.includePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examJoinDetailTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label windowClose;
        private System.Windows.Forms.Label windowMin;
        private System.Windows.Forms.Label windowStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cmpLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView examDetailDataGridView;
        private System.Windows.Forms.Panel tableHead;
        private System.Windows.Forms.Label passRateSort;
        private System.Windows.Forms.Label effectiveTimeSort;
        private System.Windows.Forms.Label avgScoreSort;
        private System.Windows.Forms.Label examNameSort;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label keyWordBtn;
        public Custom.RadiusBorder keyWordBox;
        private System.Windows.Forms.TextBox keyWordSelect;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passCriteriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource examJoinDetailTableBindingSource;
    }
}