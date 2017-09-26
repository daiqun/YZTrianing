namespace Client.Student
{
    partial class FinishTimeIn
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
            this.examResultInTime = new System.Windows.Forms.Label();
            this.examResultPaper = new Client.Custom.RadiusBorder();
            this.SuspendLayout();
            // 
            // examResultInTime
            // 
            this.examResultInTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.examResultInTime.AutoSize = true;
            this.examResultInTime.Font = new System.Drawing.Font("Arial", 14.5F);
            this.examResultInTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.examResultInTime.Location = new System.Drawing.Point(262, 180);
            this.examResultInTime.Name = "examResultInTime";
            this.examResultInTime.Size = new System.Drawing.Size(491, 23);
            this.examResultInTime.TabIndex = 14;
            this.examResultInTime.Text = "You score is 90 points, you got 22 question in this test.";
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
            this.examResultPaper.TabIndex = 15;
            this.examResultPaper.Text = "View the exam result detail";
            // 
            // FinishTimeIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.examResultPaper);
            this.Controls.Add(this.examResultInTime);
            this.Name = "FinishTimeIn";
            this.Size = new System.Drawing.Size(1024, 730);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label examResultInTime;
        public Custom.RadiusBorder examResultPaper;
    }
}
