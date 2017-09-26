namespace Client.Student
{
    partial class ToExam
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
            this.head = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.windowClose = new System.Windows.Forms.Label();
            this.windowMin = new System.Windows.Forms.Label();
            this.windowStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmpLogo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.examInfo01 = new System.Windows.Forms.Panel();
            this.questionCount = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.effectiveTime = new System.Windows.Forms.Label();
            this.examName = new System.Windows.Forms.Label();
            this.examInfo02 = new System.Windows.Forms.Panel();
            this.totalScore = new System.Windows.Forms.Label();
            this.examEndTime = new System.Windows.Forms.Label();
            this.examId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timeToStart = new System.Windows.Forms.Label();
            this.noticeCenter = new System.Windows.Forms.Panel();
            this.notcieContent = new System.Windows.Forms.Label();
            this.noticeTab = new System.Windows.Forms.Label();
            this.startTest = new Client.Custom.RadiusBorder();
            this.returnBtn = new Client.Custom.RadiusBorder();
            this.startTime = new Client.Custom.RadiusBorder();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.head.SuspendLayout();
            this.panel2.SuspendLayout();
            this.examInfo01.SuspendLayout();
            this.examInfo02.SuspendLayout();
            this.noticeCenter.SuspendLayout();
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
            this.head.TabIndex = 2;
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(425, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "The Exam Description";
            // 
            // examInfo01
            // 
            this.examInfo01.AutoSize = true;
            this.examInfo01.Controls.Add(this.questionCount);
            this.examInfo01.Controls.Add(this.duration);
            this.examInfo01.Controls.Add(this.effectiveTime);
            this.examInfo01.Controls.Add(this.examName);
            this.examInfo01.Location = new System.Drawing.Point(42, 199);
            this.examInfo01.Name = "examInfo01";
            this.examInfo01.Size = new System.Drawing.Size(200, 100);
            this.examInfo01.TabIndex = 4;
            // 
            // questionCount
            // 
            this.questionCount.AutoSize = true;
            this.questionCount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.questionCount.Location = new System.Drawing.Point(3, 75);
            this.questionCount.Name = "questionCount";
            this.questionCount.Size = new System.Drawing.Size(70, 15);
            this.questionCount.TabIndex = 6;
            this.questionCount.Text = "Questions: ";
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.duration.Location = new System.Drawing.Point(3, 51);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(60, 15);
            this.duration.TabIndex = 5;
            this.duration.Text = "Duration: ";
            // 
            // effectiveTime
            // 
            this.effectiveTime.AutoSize = true;
            this.effectiveTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectiveTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.effectiveTime.Location = new System.Drawing.Point(3, 27);
            this.effectiveTime.Name = "effectiveTime";
            this.effectiveTime.Size = new System.Drawing.Size(89, 15);
            this.effectiveTime.TabIndex = 4;
            this.effectiveTime.Text = "Effective Time: ";
            // 
            // examName
            // 
            this.examName.AutoSize = true;
            this.examName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.examName.Location = new System.Drawing.Point(3, 3);
            this.examName.Name = "examName";
            this.examName.Size = new System.Drawing.Size(47, 15);
            this.examName.TabIndex = 3;
            this.examName.Text = "Name: ";
            // 
            // examInfo02
            // 
            this.examInfo02.AutoSize = true;
            this.examInfo02.Controls.Add(this.totalScore);
            this.examInfo02.Controls.Add(this.examEndTime);
            this.examInfo02.Controls.Add(this.examId);
            this.examInfo02.Location = new System.Drawing.Point(352, 202);
            this.examInfo02.Name = "examInfo02";
            this.examInfo02.Size = new System.Drawing.Size(200, 100);
            this.examInfo02.TabIndex = 5;
            // 
            // totalScore
            // 
            this.totalScore.AutoSize = true;
            this.totalScore.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.totalScore.Location = new System.Drawing.Point(3, 51);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(40, 15);
            this.totalScore.TabIndex = 5;
            this.totalScore.Text = "Total: ";
            // 
            // examEndTime
            // 
            this.examEndTime.AutoSize = true;
            this.examEndTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.examEndTime.Location = new System.Drawing.Point(3, 27);
            this.examEndTime.Name = "examEndTime";
            this.examEndTime.Size = new System.Drawing.Size(66, 15);
            this.examEndTime.TabIndex = 4;
            this.examEndTime.Text = "End Time: ";
            // 
            // examId
            // 
            this.examId.AutoSize = true;
            this.examId.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.examId.Location = new System.Drawing.Point(3, 3);
            this.examId.Name = "examId";
            this.examId.Size = new System.Drawing.Size(25, 15);
            this.examId.TabIndex = 3;
            this.examId.Text = "ID: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label7.Location = new System.Drawing.Point(671, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Start The Exam";
            // 
            // timeToStart
            // 
            this.timeToStart.AutoSize = true;
            this.timeToStart.Font = new System.Drawing.Font("Arial", 22.5F);
            this.timeToStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.timeToStart.Location = new System.Drawing.Point(788, 232);
            this.timeToStart.Name = "timeToStart";
            this.timeToStart.Size = new System.Drawing.Size(91, 35);
            this.timeToStart.TabIndex = 7;
            this.timeToStart.Text = "00:00";
            // 
            // noticeCenter
            // 
            this.noticeCenter.AutoSize = true;
            this.noticeCenter.Controls.Add(this.notcieContent);
            this.noticeCenter.Controls.Add(this.noticeTab);
            this.noticeCenter.Location = new System.Drawing.Point(42, 355);
            this.noticeCenter.Name = "noticeCenter";
            this.noticeCenter.Size = new System.Drawing.Size(824, 206);
            this.noticeCenter.TabIndex = 8;
            // 
            // notcieContent
            // 
            this.notcieContent.AutoSize = true;
            this.notcieContent.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notcieContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.notcieContent.Location = new System.Drawing.Point(3, 33);
            this.notcieContent.Name = "notcieContent";
            this.notcieContent.Size = new System.Drawing.Size(0, 16);
            this.notcieContent.TabIndex = 4;
            // 
            // noticeTab
            // 
            this.noticeTab.AutoSize = true;
            this.noticeTab.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.noticeTab.Location = new System.Drawing.Point(3, 3);
            this.noticeTab.Name = "noticeTab";
            this.noticeTab.Size = new System.Drawing.Size(51, 16);
            this.noticeTab.TabIndex = 3;
            this.noticeTab.Text = "Notice:";
            // 
            // startTest
            // 
            this.startTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.startTest.BorderColor = System.Drawing.Color.Empty;
            this.startTest.BorderSize = 0F;
            this.startTest.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTest.FontColor = System.Drawing.Color.White;
            this.startTest.ForeColor = System.Drawing.Color.White;
            this.startTest.Location = new System.Drawing.Point(541, 642);
            this.startTest.Name = "startTest";
            this.startTest.Radius = 5F;
            this.startTest.Size = new System.Drawing.Size(150, 30);
            this.startTest.TabIndex = 9;
            this.startTest.Text = "Start Testing";
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.returnBtn.BorderColor = System.Drawing.Color.Empty;
            this.returnBtn.BorderSize = 0F;
            this.returnBtn.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.FontColor = System.Drawing.Color.White;
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(328, 642);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Radius = 5F;
            this.returnBtn.Size = new System.Drawing.Size(150, 30);
            this.returnBtn.TabIndex = 1;
            this.returnBtn.Text = "Return";
            // 
            // startTime
            // 
            this.startTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.startTime.BorderSize = 1F;
            this.startTime.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTime.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.startTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.startTime.Location = new System.Drawing.Point(654, 229);
            this.startTime.Name = "startTime";
            this.startTime.Radius = 10F;
            this.startTime.Size = new System.Drawing.Size(311, 40);
            this.startTime.TabIndex = 0;
            // 
            // ToExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.startTest);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.noticeCenter);
            this.Controls.Add(this.timeToStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.examInfo02);
            this.Controls.Add(this.examInfo01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToExam";
            this.Text = "ToExam";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.examInfo01.ResumeLayout(false);
            this.examInfo01.PerformLayout();
            this.examInfo02.ResumeLayout(false);
            this.examInfo02.PerformLayout();
            this.noticeCenter.ResumeLayout(false);
            this.noticeCenter.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel examInfo01;
        private System.Windows.Forms.Label examName;
        private System.Windows.Forms.Label questionCount;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Label effectiveTime;
        private System.Windows.Forms.Panel examInfo02;
        private System.Windows.Forms.Label totalScore;
        private System.Windows.Forms.Label examEndTime;
        private System.Windows.Forms.Label examId;
        private Custom.RadiusBorder startTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label timeToStart;
        private System.Windows.Forms.Panel noticeCenter;
        private System.Windows.Forms.Label noticeTab;
        private Custom.RadiusBorder returnBtn;
        private Custom.RadiusBorder startTest;
        private System.Windows.Forms.Label notcieContent;
        private System.Windows.Forms.Timer timer1;
    }
}