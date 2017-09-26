namespace Client.Student
{
    partial class Testing
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
            this.label7 = new System.Windows.Forms.Label();
            this.examCareful = new System.Windows.Forms.Label();
            this.currentQuestion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.examRestTime = new System.Windows.Forms.Label();
            this.noticeCenter = new System.Windows.Forms.Panel();
            this.questionNum = new Client.Custom.RadiusBorder();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.choiceBCheck = new System.Windows.Forms.Label();
            this.choiceBIcon = new System.Windows.Forms.Label();
            this.choiceBContent = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.choiceCCheck = new System.Windows.Forms.Label();
            this.choiceCIcon = new System.Windows.Forms.Label();
            this.choiceCContent = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.choiceDCheck = new System.Windows.Forms.Label();
            this.choiceDIcon = new System.Windows.Forms.Label();
            this.choiceDContent = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.choiceACheck = new System.Windows.Forms.Label();
            this.choiceAIcon = new System.Windows.Forms.Label();
            this.choiceAContent = new System.Windows.Forms.Label();
            this.questionContent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nextQuesion = new Client.Custom.RadiusBorder();
            this.restTime = new Client.Custom.RadiusBorder();
            this.head.SuspendLayout();
            this.panel2.SuspendLayout();
            this.noticeCenter.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.label7.Location = new System.Drawing.Point(51, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Choice";
            // 
            // examCareful
            // 
            this.examCareful.AutoSize = true;
            this.examCareful.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examCareful.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examCareful.Location = new System.Drawing.Point(141, 105);
            this.examCareful.Name = "examCareful";
            this.examCareful.Size = new System.Drawing.Size(170, 16);
            this.examCareful.TabIndex = 10;
            this.examCareful.Text = "Only one correct anwser, ";
            // 
            // currentQuestion
            // 
            this.currentQuestion.AutoSize = true;
            this.currentQuestion.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.currentQuestion.Location = new System.Drawing.Point(500, 105);
            this.currentQuestion.Name = "currentQuestion";
            this.currentQuestion.Size = new System.Drawing.Size(0, 16);
            this.currentQuestion.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(729, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Timing";
            // 
            // examRestTime
            // 
            this.examRestTime.AutoSize = true;
            this.examRestTime.Font = new System.Drawing.Font("Arial", 22.5F);
            this.examRestTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.examRestTime.Location = new System.Drawing.Point(814, 95);
            this.examRestTime.Name = "examRestTime";
            this.examRestTime.Size = new System.Drawing.Size(133, 35);
            this.examRestTime.TabIndex = 13;
            this.examRestTime.Text = "00:30:00";
            // 
            // noticeCenter
            // 
            this.noticeCenter.AutoSize = true;
            this.noticeCenter.Controls.Add(this.questionNum);
            this.noticeCenter.Controls.Add(this.flowLayoutPanel4);
            this.noticeCenter.Controls.Add(this.flowLayoutPanel3);
            this.noticeCenter.Controls.Add(this.flowLayoutPanel2);
            this.noticeCenter.Controls.Add(this.flowLayoutPanel1);
            this.noticeCenter.Controls.Add(this.questionContent);
            this.noticeCenter.Location = new System.Drawing.Point(144, 210);
            this.noticeCenter.Name = "noticeCenter";
            this.noticeCenter.Size = new System.Drawing.Size(689, 207);
            this.noticeCenter.TabIndex = 14;
            // 
            // questionNum
            // 
            this.questionNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.questionNum.BorderSize = 1F;
            this.questionNum.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNum.FontColor = System.Drawing.Color.Empty;
            this.questionNum.Location = new System.Drawing.Point(9, 27);
            this.questionNum.Name = "questionNum";
            this.questionNum.Radius = 3F;
            this.questionNum.Size = new System.Drawing.Size(25, 25);
            this.questionNum.TabIndex = 16;
            this.questionNum.Text = "1";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.choiceBCheck);
            this.flowLayoutPanel4.Controls.Add(this.choiceBIcon);
            this.flowLayoutPanel4.Controls.Add(this.choiceBContent);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(6, 114);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(214, 20);
            this.flowLayoutPanel4.TabIndex = 13;
            // 
            // choiceBCheck
            // 
            this.choiceBCheck.Image = global::Client.Properties.Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceBCheck.Location = new System.Drawing.Point(3, 0);
            this.choiceBCheck.Name = "choiceBCheck";
            this.choiceBCheck.Size = new System.Drawing.Size(20, 20);
            this.choiceBCheck.TabIndex = 11;
            // 
            // choiceBIcon
            // 
            this.choiceBIcon.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choiceBIcon.Location = new System.Drawing.Point(29, 0);
            this.choiceBIcon.Name = "choiceBIcon";
            this.choiceBIcon.Size = new System.Drawing.Size(20, 20);
            this.choiceBIcon.TabIndex = 12;
            this.choiceBIcon.Text = "A";
            this.choiceBIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choiceBContent
            // 
            this.choiceBContent.AutoSize = true;
            this.choiceBContent.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceBContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.choiceBContent.Location = new System.Drawing.Point(55, 3);
            this.choiceBContent.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.choiceBContent.Name = "choiceBContent";
            this.choiceBContent.Size = new System.Drawing.Size(25, 16);
            this.choiceBContent.TabIndex = 7;
            this.choiceBContent.Text = "2) ";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.choiceCCheck);
            this.flowLayoutPanel3.Controls.Add(this.choiceCIcon);
            this.flowLayoutPanel3.Controls.Add(this.choiceCContent);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 150);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(214, 20);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // choiceCCheck
            // 
            this.choiceCCheck.Image = global::Client.Properties.Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceCCheck.Location = new System.Drawing.Point(3, 0);
            this.choiceCCheck.Name = "choiceCCheck";
            this.choiceCCheck.Size = new System.Drawing.Size(20, 20);
            this.choiceCCheck.TabIndex = 11;
            // 
            // choiceCIcon
            // 
            this.choiceCIcon.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choiceCIcon.Location = new System.Drawing.Point(29, 0);
            this.choiceCIcon.Name = "choiceCIcon";
            this.choiceCIcon.Size = new System.Drawing.Size(20, 20);
            this.choiceCIcon.TabIndex = 12;
            this.choiceCIcon.Text = "A";
            this.choiceCIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choiceCContent
            // 
            this.choiceCContent.AutoSize = true;
            this.choiceCContent.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceCContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.choiceCContent.Location = new System.Drawing.Point(55, 3);
            this.choiceCContent.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.choiceCContent.Name = "choiceCContent";
            this.choiceCContent.Size = new System.Drawing.Size(25, 16);
            this.choiceCContent.TabIndex = 7;
            this.choiceCContent.Text = "3) ";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.choiceDCheck);
            this.flowLayoutPanel2.Controls.Add(this.choiceDIcon);
            this.flowLayoutPanel2.Controls.Add(this.choiceDContent);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 184);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(214, 20);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // choiceDCheck
            // 
            this.choiceDCheck.Image = global::Client.Properties.Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceDCheck.Location = new System.Drawing.Point(3, 0);
            this.choiceDCheck.Name = "choiceDCheck";
            this.choiceDCheck.Size = new System.Drawing.Size(20, 20);
            this.choiceDCheck.TabIndex = 11;
            // 
            // choiceDIcon
            // 
            this.choiceDIcon.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choiceDIcon.Location = new System.Drawing.Point(29, 0);
            this.choiceDIcon.Name = "choiceDIcon";
            this.choiceDIcon.Size = new System.Drawing.Size(20, 20);
            this.choiceDIcon.TabIndex = 12;
            this.choiceDIcon.Text = "A";
            this.choiceDIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choiceDContent
            // 
            this.choiceDContent.AutoSize = true;
            this.choiceDContent.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceDContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.choiceDContent.Location = new System.Drawing.Point(55, 3);
            this.choiceDContent.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.choiceDContent.Name = "choiceDContent";
            this.choiceDContent.Size = new System.Drawing.Size(25, 16);
            this.choiceDContent.TabIndex = 7;
            this.choiceDContent.Text = "4) ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.choiceACheck);
            this.flowLayoutPanel1.Controls.Add(this.choiceAIcon);
            this.flowLayoutPanel1.Controls.Add(this.choiceAContent);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 20);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // choiceACheck
            // 
            this.choiceACheck.Image = global::Client.Properties.Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceACheck.Location = new System.Drawing.Point(3, 0);
            this.choiceACheck.Name = "choiceACheck";
            this.choiceACheck.Size = new System.Drawing.Size(20, 20);
            this.choiceACheck.TabIndex = 11;
            // 
            // choiceAIcon
            // 
            this.choiceAIcon.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choiceAIcon.Location = new System.Drawing.Point(29, 0);
            this.choiceAIcon.Name = "choiceAIcon";
            this.choiceAIcon.Size = new System.Drawing.Size(20, 20);
            this.choiceAIcon.TabIndex = 12;
            this.choiceAIcon.Text = "A";
            this.choiceAIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choiceAContent
            // 
            this.choiceAContent.AutoSize = true;
            this.choiceAContent.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceAContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.choiceAContent.Location = new System.Drawing.Point(55, 3);
            this.choiceAContent.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.choiceAContent.Name = "choiceAContent";
            this.choiceAContent.Size = new System.Drawing.Size(25, 16);
            this.choiceAContent.TabIndex = 7;
            this.choiceAContent.Text = "1) ";
            // 
            // questionContent
            // 
            this.questionContent.AutoSize = true;
            this.questionContent.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.questionContent.Location = new System.Drawing.Point(44, 31);
            this.questionContent.Name = "questionContent";
            this.questionContent.Size = new System.Drawing.Size(32, 16);
            this.questionContent.TabIndex = 4;
            this.questionContent.Text = "111";
            // 
            // nextQuesion
            // 
            this.nextQuesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.nextQuesion.BorderColor = System.Drawing.Color.Empty;
            this.nextQuesion.BorderSize = 0F;
            this.nextQuesion.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuesion.FontColor = System.Drawing.Color.White;
            this.nextQuesion.ForeColor = System.Drawing.Color.White;
            this.nextQuesion.Location = new System.Drawing.Point(439, 522);
            this.nextQuesion.Name = "nextQuesion";
            this.nextQuesion.Radius = 5F;
            this.nextQuesion.Size = new System.Drawing.Size(150, 30);
            this.nextQuesion.TabIndex = 15;
            this.nextQuesion.Text = "Next Question";
            // 
            // restTime
            // 
            this.restTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.restTime.BorderSize = 1F;
            this.restTime.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restTime.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.restTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.restTime.Location = new System.Drawing.Point(22, 89);
            this.restTime.Name = "restTime";
            this.restTime.Radius = 7F;
            this.restTime.Size = new System.Drawing.Size(950, 50);
            this.restTime.TabIndex = 8;
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.nextQuesion);
            this.Controls.Add(this.noticeCenter);
            this.Controls.Add(this.examRestTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentQuestion);
            this.Controls.Add(this.examCareful);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.restTime);
            this.Controls.Add(this.head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Testing";
            this.Text = "Testing";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.noticeCenter.ResumeLayout(false);
            this.noticeCenter.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private Custom.RadiusBorder restTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label examCareful;
        private System.Windows.Forms.Label currentQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label examRestTime;
        private System.Windows.Forms.Panel noticeCenter;
        private System.Windows.Forms.Label questionContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label choiceAContent;
        private System.Windows.Forms.Label choiceACheck;
        private System.Windows.Forms.Label choiceAIcon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label choiceBCheck;
        private System.Windows.Forms.Label choiceBIcon;
        private System.Windows.Forms.Label choiceBContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label choiceCCheck;
        private System.Windows.Forms.Label choiceCIcon;
        private System.Windows.Forms.Label choiceCContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label choiceDCheck;
        private System.Windows.Forms.Label choiceDIcon;
        private System.Windows.Forms.Label choiceDContent;
        private Custom.RadiusBorder nextQuesion;
        private Custom.RadiusBorder questionNum;
        private System.Windows.Forms.Timer timer1;
    }
}