namespace Client.Student
{
    partial class ExamResult
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
        /// InitQuestion
        /// </summary>
        public void InitQuestion()
        {
            this.choiceCPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.contentChoiceC = new System.Windows.Forms.Label();
            this.letterC = new System.Windows.Forms.Label();
            this.choiceCPic = new System.Windows.Forms.Label();
            this.choiceAPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.contentChoiceA = new System.Windows.Forms.Label();
            this.letterA = new System.Windows.Forms.Label();
            this.choiceAPic = new System.Windows.Forms.Label();
            this.choiceDPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.contentChoiceD = new System.Windows.Forms.Label();
            this.letterD = new System.Windows.Forms.Label();
            this.choiceDPic = new System.Windows.Forms.Label();
            this.questionTitle = new System.Windows.Forms.Label();
            this.questionNum = new Client.Custom.RadiusBorder();
            this.isTrueIcon = new System.Windows.Forms.Label();
            this.choiceBPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.contentChoiceB = new System.Windows.Forms.Label();
            this.letterB = new System.Windows.Forms.Label();
            this.choiceBPic = new System.Windows.Forms.Label();
            this.questionContent = new System.Windows.Forms.Panel();

            // 
            // choiceCPanel
            // 
            this.choiceCPanel.AutoSize = true;
            this.choiceCPanel.Controls.Add(this.choiceCPic);
            this.choiceCPanel.Controls.Add(this.letterC);
            this.choiceCPanel.Controls.Add(this.contentChoiceC);
            this.choiceCPanel.Location = new System.Drawing.Point(130, 143);
            this.choiceCPanel.Name = "choiceCPanel";
            this.choiceCPanel.Size = new System.Drawing.Size(214, 20);
            this.choiceCPanel.TabIndex = 26;
            // 
            // contentChoiceC
            // 
            this.contentChoiceC.AutoSize = true;
            this.contentChoiceC.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentChoiceC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.contentChoiceC.Location = new System.Drawing.Point(55, 3);
            this.contentChoiceC.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.contentChoiceC.Name = "contentChoiceC";
            this.contentChoiceC.Size = new System.Drawing.Size(25, 16);
            this.contentChoiceC.TabIndex = 7;
            this.contentChoiceC.Text = "1) ";
            // 
            // letterC
            // 
            this.letterC.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.letterC.Location = new System.Drawing.Point(29, 0);
            this.letterC.Name = "letterC";
            this.letterC.Size = new System.Drawing.Size(20, 20);
            this.letterC.TabIndex = 12;
            this.letterC.Text = "A";
            this.letterC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choiceCPic
            // 
            this.choiceCPic.Image = global::Client.Properties.Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceCPic.Location = new System.Drawing.Point(3, 0);
            this.choiceCPic.Name = "choiceCPic";
            this.choiceCPic.Size = new System.Drawing.Size(20, 20);
            this.choiceCPic.TabIndex = 11;
            // 
            // choiceAPanel
            // 
            this.choiceAPanel.AutoSize = true;
            this.choiceAPanel.Controls.Add(this.choiceAPic);
            this.choiceAPanel.Controls.Add(this.letterA);
            this.choiceAPanel.Controls.Add(this.contentChoiceA);
            this.choiceAPanel.Location = new System.Drawing.Point(130, 64);
            this.choiceAPanel.Name = "choiceAPanel";
            this.choiceAPanel.Size = new System.Drawing.Size(214, 20);
            this.choiceAPanel.TabIndex = 25;
            // 
            // contentChoiceA
            // 
            this.contentChoiceA.AutoSize = true;
            this.contentChoiceA.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentChoiceA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.contentChoiceA.Location = new System.Drawing.Point(55, 3);
            this.contentChoiceA.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.contentChoiceA.Name = "contentChoiceA";
            this.contentChoiceA.Size = new System.Drawing.Size(25, 16);
            this.contentChoiceA.TabIndex = 7;
            this.contentChoiceA.Text = "1) ";
            // 
            // letterA
            // 
            this.letterA.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.letterA.Location = new System.Drawing.Point(29, 0);
            this.letterA.Name = "letterA";
            this.letterA.Size = new System.Drawing.Size(20, 20);
            this.letterA.TabIndex = 12;
            this.letterA.Text = "A";
            this.letterA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choiceAPic
            // 
            this.choiceAPic.Image = global::Client.Properties.Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceAPic.Location = new System.Drawing.Point(3, 0);
            this.choiceAPic.Name = "choiceAPic";
            this.choiceAPic.Size = new System.Drawing.Size(20, 20);
            this.choiceAPic.TabIndex = 11;
            // 
            // choiceDPanel
            // 
            this.choiceDPanel.AutoSize = true;
            this.choiceDPanel.Controls.Add(this.choiceDPic);
            this.choiceDPanel.Controls.Add(this.letterD);
            this.choiceDPanel.Controls.Add(this.contentChoiceD);
            this.choiceDPanel.Location = new System.Drawing.Point(130, 184);
            this.choiceDPanel.Name = "choiceDPanel";
            this.choiceDPanel.Size = new System.Drawing.Size(214, 20);
            this.choiceDPanel.TabIndex = 24;
            // 
            // contentChoiceD
            // 
            this.contentChoiceD.AutoSize = true;
            this.contentChoiceD.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentChoiceD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.contentChoiceD.Location = new System.Drawing.Point(55, 3);
            this.contentChoiceD.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.contentChoiceD.Name = "contentChoiceD";
            this.contentChoiceD.Size = new System.Drawing.Size(25, 16);
            this.contentChoiceD.TabIndex = 7;
            this.contentChoiceD.Text = "1) ";
            // 
            // letterD
            // 
            this.letterD.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.letterD.Location = new System.Drawing.Point(29, 0);
            this.letterD.Name = "letterD";
            this.letterD.Size = new System.Drawing.Size(20, 20);
            this.letterD.TabIndex = 12;
            this.letterD.Text = "A";
            this.letterD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choiceDPic
            // 
            this.choiceDPic.Image = global::Client.Properties.Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceDPic.Location = new System.Drawing.Point(3, 0);
            this.choiceDPic.Name = "choiceDPic";
            this.choiceDPic.Size = new System.Drawing.Size(20, 20);
            this.choiceDPic.TabIndex = 11;
            // 
            // questionTitle
            // 
            this.questionTitle.AutoSize = true;
            this.questionTitle.Font = new System.Drawing.Font("Arial", 13F);
            this.questionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.questionTitle.Location = new System.Drawing.Point(126, 16);
            this.questionTitle.Name = "questionTitle";
            this.questionTitle.Size = new System.Drawing.Size(445, 21);
            this.questionTitle.TabIndex = 23;
            this.questionTitle.Text = "You score is 90 points, you got 22 question in this test.";
            // 
            // questionNum
            // 
            this.questionNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.questionNum.BorderSize = 1F;
            this.questionNum.Font = new System.Drawing.Font("Arial", 13.5F);
            this.questionNum.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.questionNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.questionNum.Location = new System.Drawing.Point(69, 12);
            this.questionNum.Name = "questionNum";
            this.questionNum.Radius = 10F;
            this.questionNum.Size = new System.Drawing.Size(30, 30);
            this.questionNum.TabIndex = 22;
            this.questionNum.Text = "1";
            // 
            // isTrueIcon
            // 
            this.isTrueIcon.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isTrueIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.isTrueIcon.Image = global::Client.Properties.Resources.ICN_Right_15x15;
            this.isTrueIcon.Location = new System.Drawing.Point(6, 8);
            this.isTrueIcon.Name = "isTrueIcon";
            this.isTrueIcon.Size = new System.Drawing.Size(34, 34);
            this.isTrueIcon.TabIndex = 21;
            // 
            // choiceBPanel
            // 
            this.choiceBPanel.AutoSize = true;
            this.choiceBPanel.Controls.Add(this.choiceBPic);
            this.choiceBPanel.Controls.Add(this.letterB);
            this.choiceBPanel.Controls.Add(this.contentChoiceB);
            this.choiceBPanel.Location = new System.Drawing.Point(130, 103);
            this.choiceBPanel.Name = "choiceBPanel";
            this.choiceBPanel.Size = new System.Drawing.Size(214, 20);
            this.choiceBPanel.TabIndex = 27;
            // 
            // contentChoiceB
            // 
            this.contentChoiceB.AutoSize = true;
            this.contentChoiceB.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentChoiceB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.contentChoiceB.Location = new System.Drawing.Point(55, 3);
            this.contentChoiceB.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.contentChoiceB.Name = "contentChoiceB";
            this.contentChoiceB.Size = new System.Drawing.Size(25, 16);
            this.contentChoiceB.TabIndex = 7;
            this.contentChoiceB.Text = "1) ";
            // 
            // letterB
            // 
            this.letterB.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.letterB.Location = new System.Drawing.Point(29, 0);
            this.letterB.Name = "letterB";
            this.letterB.Size = new System.Drawing.Size(20, 20);
            this.letterB.TabIndex = 12;
            this.letterB.Text = "A";
            this.letterB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choiceBPic
            // 
            this.choiceBPic.Image = global::Client.Properties.Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceBPic.Location = new System.Drawing.Point(3, 0);
            this.choiceBPic.Name = "choiceBPic";
            this.choiceBPic.Size = new System.Drawing.Size(20, 20);
            this.choiceBPic.TabIndex = 11;
            // 
            // questionContent
            // 
            this.questionContent.Controls.Add(this.choiceBPanel);
            this.questionContent.Controls.Add(this.isTrueIcon);
            this.questionContent.Controls.Add(this.questionNum);
            this.questionContent.Controls.Add(this.questionTitle);
            this.questionContent.Controls.Add(this.choiceDPanel);
            this.questionContent.Controls.Add(this.choiceAPanel);
            this.questionContent.Controls.Add(this.choiceCPanel);
            this.questionContent.Location = new System.Drawing.Point(0, 0);
            this.questionContent.Name = "questionContent";
            this.questionContent.Size = new System.Drawing.Size(832, 228);
            this.questionContent.TabIndex = 28;

            this.choiceCPanel.SuspendLayout();
            this.choiceAPanel.SuspendLayout();
            this.choiceDPanel.SuspendLayout();
            this.choiceBPanel.SuspendLayout();
            this.questionContent.SuspendLayout();

            this.choiceCPanel.ResumeLayout(false);
            this.choiceCPanel.PerformLayout();
            this.choiceAPanel.ResumeLayout(false);
            this.choiceAPanel.PerformLayout();
            this.choiceDPanel.ResumeLayout(false);
            this.choiceDPanel.PerformLayout();
            this.choiceBPanel.ResumeLayout(false);
            this.choiceBPanel.PerformLayout();
            this.questionContent.ResumeLayout(false);
            this.questionContent.PerformLayout();

            this.allQuestionContent.Controls.Add(this.questionContent);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.head = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.windowClose = new System.Windows.Forms.Label();
            this.windowMin = new System.Windows.Forms.Label();
            this.windowStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmpLogo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.examGetScore = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.trueQuestionCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.questionCountShow = new System.Windows.Forms.Label();
            this.examDurationShow = new System.Windows.Forms.Label();
            this.effectiveTimeShow = new System.Windows.Forms.Label();
            this.examNameShow = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.examGetScoreShow = new System.Windows.Forms.Label();
            this.examTotalScore = new System.Windows.Forms.Label();
            this.examIdShow = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.examResultPaper = new Client.Custom.RadiusBorder();
            this.allQuestionContent = new System.Windows.Forms.FlowLayoutPanel();
            this.head.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.head.TabIndex = 3;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label7.Location = new System.Drawing.Point(52, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Exam Result";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(626, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Exam Score:";
            // 
            // examGetScore
            // 
            this.examGetScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.examGetScore.AutoSize = true;
            this.examGetScore.Font = new System.Drawing.Font("Arial", 27F);
            this.examGetScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.examGetScore.Location = new System.Drawing.Point(711, 49);
            this.examGetScore.Name = "examGetScore";
            this.examGetScore.Size = new System.Drawing.Size(58, 41);
            this.examGetScore.TabIndex = 14;
            this.examGetScore.Text = "88";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1024, 912);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 55;
            this.lineShape1.X2 = 960;
            this.lineShape1.Y1 = 93;
            this.lineShape1.Y2 = 93;
            // 
            // trueQuestionCount
            // 
            this.trueQuestionCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trueQuestionCount.AutoSize = true;
            this.trueQuestionCount.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trueQuestionCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.trueQuestionCount.Location = new System.Drawing.Point(791, 63);
            this.trueQuestionCount.Name = "trueQuestionCount";
            this.trueQuestionCount.Size = new System.Drawing.Size(208, 16);
            this.trueQuestionCount.TabIndex = 16;
            this.trueQuestionCount.Text = "There are 26 questions correct.";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.questionCountShow);
            this.panel1.Controls.Add(this.examDurationShow);
            this.panel1.Controls.Add(this.effectiveTimeShow);
            this.panel1.Controls.Add(this.examNameShow);
            this.panel1.Location = new System.Drawing.Point(55, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 115);
            this.panel1.TabIndex = 17;
            // 
            // questionCountShow
            // 
            this.questionCountShow.AutoSize = true;
            this.questionCountShow.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionCountShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.questionCountShow.Location = new System.Drawing.Point(3, 90);
            this.questionCountShow.Name = "questionCountShow";
            this.questionCountShow.Size = new System.Drawing.Size(73, 16);
            this.questionCountShow.TabIndex = 6;
            this.questionCountShow.Text = "Question: ";
            // 
            // examDurationShow
            // 
            this.examDurationShow.AutoSize = true;
            this.examDurationShow.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examDurationShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examDurationShow.Location = new System.Drawing.Point(3, 61);
            this.examDurationShow.Name = "examDurationShow";
            this.examDurationShow.Size = new System.Drawing.Size(70, 16);
            this.examDurationShow.TabIndex = 5;
            this.examDurationShow.Text = "Duration: ";
            // 
            // effectiveTimeShow
            // 
            this.effectiveTimeShow.AutoSize = true;
            this.effectiveTimeShow.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectiveTimeShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.effectiveTimeShow.Location = new System.Drawing.Point(3, 32);
            this.effectiveTimeShow.Name = "effectiveTimeShow";
            this.effectiveTimeShow.Size = new System.Drawing.Size(105, 16);
            this.effectiveTimeShow.TabIndex = 4;
            this.effectiveTimeShow.Text = "Effective Time: ";
            // 
            // examNameShow
            // 
            this.examNameShow.AutoSize = true;
            this.examNameShow.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examNameShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examNameShow.Location = new System.Drawing.Point(3, 3);
            this.examNameShow.Name = "examNameShow";
            this.examNameShow.Size = new System.Drawing.Size(52, 16);
            this.examNameShow.TabIndex = 3;
            this.examNameShow.Text = "Name: ";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.examGetScoreShow);
            this.panel3.Controls.Add(this.examTotalScore);
            this.panel3.Controls.Add(this.examIdShow);
            this.panel3.Location = new System.Drawing.Point(354, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 115);
            this.panel3.TabIndex = 18;
            // 
            // examGetScoreShow
            // 
            this.examGetScoreShow.AutoSize = true;
            this.examGetScoreShow.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examGetScoreShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examGetScoreShow.Location = new System.Drawing.Point(3, 61);
            this.examGetScoreShow.Name = "examGetScoreShow";
            this.examGetScoreShow.Size = new System.Drawing.Size(91, 16);
            this.examGetScoreShow.TabIndex = 5;
            this.examGetScoreShow.Text = "Exam Score: ";
            // 
            // examTotalScore
            // 
            this.examTotalScore.AutoSize = true;
            this.examTotalScore.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examTotalScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examTotalScore.Location = new System.Drawing.Point(3, 32);
            this.examTotalScore.Name = "examTotalScore";
            this.examTotalScore.Size = new System.Drawing.Size(89, 16);
            this.examTotalScore.TabIndex = 4;
            this.examTotalScore.Text = "Total Score: ";
            // 
            // examIdShow
            // 
            this.examIdShow.AutoSize = true;
            this.examIdShow.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIdShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examIdShow.Location = new System.Drawing.Point(3, 3);
            this.examIdShow.Name = "examIdShow";
            this.examIdShow.Size = new System.Drawing.Size(29, 16);
            this.examIdShow.TabIndex = 3;
            this.examIdShow.Text = "ID: ";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.panel4.Location = new System.Drawing.Point(189, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(811, 30);
            this.panel4.TabIndex = 19;
            // 
            // examResultPaper
            // 
            this.examResultPaper.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.examResultPaper.BorderSize = 1F;
            this.examResultPaper.Font = new System.Drawing.Font("Arial", 13.5F);
            this.examResultPaper.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examResultPaper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examResultPaper.Location = new System.Drawing.Point(57, 276);
            this.examResultPaper.Name = "examResultPaper";
            this.examResultPaper.Radius = 10F;
            this.examResultPaper.Size = new System.Drawing.Size(107, 30);
            this.examResultPaper.TabIndex = 20;
            this.examResultPaper.Text = "The key:";
            // 
            // allQuestionContent
            // 
            this.allQuestionContent.AutoScroll = true;
            this.allQuestionContent.Location = new System.Drawing.Point(130, 343);
            this.allQuestionContent.Name = "allQuestionContent";
            this.allQuestionContent.Size = new System.Drawing.Size(870, 525);
            this.allQuestionContent.TabIndex = 30;
            // 
            // ExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 912);
            this.Controls.Add(this.allQuestionContent);
            this.Controls.Add(this.examResultPaper);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trueQuestionCount);
            this.Controls.Add(this.examGetScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.head);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamResult";
            this.Text = "ExamResult";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label windowClose;
        private System.Windows.Forms.Label windowMin;
        private System.Windows.Forms.Label windowStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cmpLogo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label examGetScore;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label trueQuestionCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label questionCountShow;
        private System.Windows.Forms.Label examDurationShow;
        private System.Windows.Forms.Label effectiveTimeShow;
        private System.Windows.Forms.Label examNameShow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label examGetScoreShow;
        private System.Windows.Forms.Label examTotalScore;
        private System.Windows.Forms.Label examIdShow;
        private System.Windows.Forms.Panel panel4;
        public Custom.RadiusBorder examResultPaper;
        private System.Windows.Forms.FlowLayoutPanel allQuestionContent;
        private System.Windows.Forms.Panel questionContent;
        private System.Windows.Forms.FlowLayoutPanel choiceBPanel;
        private System.Windows.Forms.Label choiceBPic;
        private System.Windows.Forms.Label letterB;
        private System.Windows.Forms.Label contentChoiceB;
        private System.Windows.Forms.Label isTrueIcon;
        public Custom.RadiusBorder questionNum;
        public System.Windows.Forms.Label questionTitle;
        private System.Windows.Forms.FlowLayoutPanel choiceDPanel;
        private System.Windows.Forms.Label choiceDPic;
        private System.Windows.Forms.Label letterD;
        private System.Windows.Forms.Label contentChoiceD;
        private System.Windows.Forms.FlowLayoutPanel choiceAPanel;
        private System.Windows.Forms.Label choiceAPic;
        private System.Windows.Forms.Label letterA;
        private System.Windows.Forms.Label contentChoiceA;
        private System.Windows.Forms.FlowLayoutPanel choiceCPanel;
        private System.Windows.Forms.Label choiceCPic;
        private System.Windows.Forms.Label letterC;
        private System.Windows.Forms.Label contentChoiceC;
    }
}