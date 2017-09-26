namespace Client.Custom
{
    partial class QuestionTemplate
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
            this.questionContent = new System.Windows.Forms.Panel();
            this.choiceBPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.choiceBPic = new System.Windows.Forms.Label();
            this.letterB = new System.Windows.Forms.Label();
            this.contentChoiceB = new System.Windows.Forms.Label();
            this.isTrueIcon = new System.Windows.Forms.Label();
            this.questionNum = new Client.Custom.RadiusBorder();
            this.questionTitle = new System.Windows.Forms.Label();
            this.choiceDPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.choiceDPic = new System.Windows.Forms.Label();
            this.letterD = new System.Windows.Forms.Label();
            this.contentChoiceD = new System.Windows.Forms.Label();
            this.choiceAPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.choiceAPic = new System.Windows.Forms.Label();
            this.letterA = new System.Windows.Forms.Label();
            this.contentChoiceA = new System.Windows.Forms.Label();
            this.choiceCPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.choiceCPic = new System.Windows.Forms.Label();
            this.letterC = new System.Windows.Forms.Label();
            this.contentChoiceC = new System.Windows.Forms.Label();
            this.questionContent.SuspendLayout();
            this.choiceBPanel.SuspendLayout();
            this.choiceDPanel.SuspendLayout();
            this.choiceAPanel.SuspendLayout();
            this.choiceCPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.questionContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionContent.Location = new System.Drawing.Point(0, 0);
            this.questionContent.Name = "questionContent";
            this.questionContent.Size = new System.Drawing.Size(853, 228);
            this.questionContent.TabIndex = 29;
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
            // choiceBPic
            // 
            this.choiceBPic.Image = global::Client.Properties.Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceBPic.Location = new System.Drawing.Point(3, 0);
            this.choiceBPic.Name = "choiceBPic";
            this.choiceBPic.Size = new System.Drawing.Size(20, 20);
            this.choiceBPic.TabIndex = 11;
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
            // choiceDPic
            // 
            this.choiceDPic.Image = global::Client.Properties.Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceDPic.Location = new System.Drawing.Point(3, 0);
            this.choiceDPic.Name = "choiceDPic";
            this.choiceDPic.Size = new System.Drawing.Size(20, 20);
            this.choiceDPic.TabIndex = 11;
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
            // choiceAPic
            // 
            this.choiceAPic.Image = global::Client.Properties.Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceAPic.Location = new System.Drawing.Point(3, 0);
            this.choiceAPic.Name = "choiceAPic";
            this.choiceAPic.Size = new System.Drawing.Size(20, 20);
            this.choiceAPic.TabIndex = 11;
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
            // choiceCPic
            // 
            this.choiceCPic.Image = global::Client.Properties.Resources.BTN_Radio_Unselected_16x16_png;
            this.choiceCPic.Location = new System.Drawing.Point(3, 0);
            this.choiceCPic.Name = "choiceCPic";
            this.choiceCPic.Size = new System.Drawing.Size(20, 20);
            this.choiceCPic.TabIndex = 11;
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
            // QuestionTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.questionContent);
            this.Name = "QuestionTemplate";
            this.Size = new System.Drawing.Size(853, 228);
            this.questionContent.ResumeLayout(false);
            this.questionContent.PerformLayout();
            this.choiceBPanel.ResumeLayout(false);
            this.choiceBPanel.PerformLayout();
            this.choiceDPanel.ResumeLayout(false);
            this.choiceDPanel.PerformLayout();
            this.choiceAPanel.ResumeLayout(false);
            this.choiceAPanel.PerformLayout();
            this.choiceCPanel.ResumeLayout(false);
            this.choiceCPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel questionContent;
        private System.Windows.Forms.FlowLayoutPanel choiceBPanel;
        private System.Windows.Forms.Label choiceBPic;
        private System.Windows.Forms.Label letterB;
        private System.Windows.Forms.Label contentChoiceB;
        private System.Windows.Forms.Label isTrueIcon;
        public RadiusBorder questionNum;
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
