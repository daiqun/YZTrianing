namespace Client.Student
{
    partial class FinishTimeOut
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
            this.examResultPaper = new Client.Custom.RadiusBorder();
            this.examReultOutTime = new System.Windows.Forms.Label();
            this.timeOutInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // examResultPaper
            // 
            this.examResultPaper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.examResultPaper.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.examResultPaper.BorderSize = 1F;
            this.examResultPaper.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examResultPaper.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examResultPaper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examResultPaper.Location = new System.Drawing.Point(410, 270);
            this.examResultPaper.Name = "examResultPaper";
            this.examResultPaper.Radius = 10F;
            this.examResultPaper.Size = new System.Drawing.Size(200, 30);
            this.examResultPaper.TabIndex = 17;
            this.examResultPaper.Text = "View the exam result detail";
            // 
            // examReultOutTime
            // 
            this.examReultOutTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.examReultOutTime.AutoSize = true;
            this.examReultOutTime.Font = new System.Drawing.Font("Arial", 14.5F);
            this.examReultOutTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examReultOutTime.Location = new System.Drawing.Point(208, 202);
            this.examReultOutTime.Name = "examReultOutTime";
            this.examReultOutTime.Size = new System.Drawing.Size(491, 23);
            this.examReultOutTime.TabIndex = 16;
            this.examReultOutTime.Text = "You score is 90 points, you got 22 question in this test.";
            // 
            // timeOutInfo
            // 
            this.timeOutInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeOutInfo.AutoSize = true;
            this.timeOutInfo.Font = new System.Drawing.Font("Arial", 14.5F);
            this.timeOutInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.timeOutInfo.Location = new System.Drawing.Point(208, 149);
            this.timeOutInfo.Name = "timeOutInfo";
            this.timeOutInfo.Size = new System.Drawing.Size(599, 23);
            this.timeOutInfo.TabIndex = 18;
            this.timeOutInfo.Text = "Your Time is up,the system has automatically submitted to the test.";
            // 
            // FinishTimeOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.timeOutInfo);
            this.Controls.Add(this.examResultPaper);
            this.Controls.Add(this.examReultOutTime);
            this.Name = "FinishTimeOut";
            this.Size = new System.Drawing.Size(1024, 730);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Custom.RadiusBorder examResultPaper;
        public System.Windows.Forms.Label examReultOutTime;
        private System.Windows.Forms.Label timeOutInfo;
    }
}
