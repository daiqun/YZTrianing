using System.Windows.Forms;
using Logic.StudentServiceReference;
namespace Client.Student
{
    partial class StudentHome
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
        /// InitNotice
        /// </summary>
        public void InitNotice()
        {
            StudentExam stuExam = new StudentExam();
            stuExam.UserId = Login.userOverall.Id;
            stuExam.Operation = 0;
            Exam[] noticeExams = studentExam.StudentExamNotice(stuExam);

            for (int i = 0; i < noticeExams.Length; i++)
            {
                FlowLayoutPanel notice01 = new System.Windows.Forms.FlowLayoutPanel();
                Label notcieCM1 = new System.Windows.Forms.Label();
                LinkLabel notcieCM2 = new System.Windows.Forms.LinkLabel();
                Label notcieCM3 = new System.Windows.Forms.Label();
                notice01.SuspendLayout();
                notice01.ResumeLayout(false);
                notice01.PerformLayout();

                // 
                // notice01
                // 
                notice01.Controls.Add(notcieCM1);
                notice01.Controls.Add(notcieCM2);
                notice01.Controls.Add(notcieCM3);
                notice01.Location = new System.Drawing.Point(3, 3);
                notice01.Name = "notice01";
                notice01.Size = new System.Drawing.Size(480, 30);
                notice01.TabIndex = 0;
                // 
                // notcieCM1
                // 
                notcieCM1.AutoSize = true;
                notcieCM1.ForeColor = System.Drawing.Color.Black;
                notcieCM1.Location = new System.Drawing.Point(3, 0);
                notcieCM1.Name = "notcieCM1";
                notcieCM1.Size = new System.Drawing.Size(135, 16);
                notcieCM1.TabIndex = 0;
                notcieCM1.Text = "1.Please attend the ";
                // 
                // notcieCM2
                // 
                notcieCM2.AutoSize = true;
                notcieCM2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
                notcieCM2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
                notcieCM2.Location = new System.Drawing.Point(144, 0);
                notcieCM2.Name = "notcieCM2";
                notcieCM2.Size = new System.Drawing.Size(47, 16);
                notcieCM2.TabIndex = 1;
                notcieCM2.TabStop = true;
                notcieCM2.Text = "\"Java\"";
                // 
                // notcieCM3
                // 
                notcieCM3.AutoSize = true;
                notcieCM3.ForeColor = System.Drawing.Color.Black;
                notcieCM3.Location = new System.Drawing.Point(197, 0);
                notcieCM3.Name = "notcieCM3";
                notcieCM3.Size = new System.Drawing.Size(191, 16);
                notcieCM3.TabIndex = 2;
                notcieCM3.Text = "exam on 2017-10- 1 at 10:00";

                notcieCM1.Text = i + 1 + ".Please attend the ";
                notcieCM2.Text = "\"" + noticeExams[i].ExamName + "\"";
                notcieCM2.Tag = noticeExams[i].Id;
                notcieCM3.Text = "exam on " + noticeExams[i].EffectiveTime.ToShortDateString() + " at " + string.Format("{0:00}:{1:00}", noticeExams[i].EffectiveTime.Hour, noticeExams[i].EffectiveTime.Minute);

                noticeContent.Controls.Add(notice01);
                notcieCM2.Click += new System.EventHandler(ToTakeExam);
            }
        }

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.notcieAndAbout = new System.Windows.Forms.Panel();
            this.aboutContent = new System.Windows.Forms.Panel();
            this.aboutChoiceContent = new System.Windows.Forms.Label();
            this.aboutInclude = new System.Windows.Forms.Label();
            this.systemInformation = new Client.Custom.RadiusBorder();
            this.contactUs = new Client.Custom.RadiusBorder();
            this.examnationRules = new Client.Custom.RadiusBorder();
            this.noticeContent = new System.Windows.Forms.FlowLayoutPanel();
            this.about = new Client.Custom.RadiusBorder();
            this.notice = new Client.Custom.RadiusBorder();
            this.notcieAndAbout.SuspendLayout();
            this.aboutContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(980, 640);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 349;
            this.lineShape2.X2 = 932;
            this.lineShape2.Y1 = 27;
            this.lineShape2.Y2 = 27;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 206;
            this.lineShape1.X2 = 206;
            this.lineShape1.Y1 = -5;
            this.lineShape1.Y2 = 636;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(266, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Notice";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notcieAndAbout
            // 
            this.notcieAndAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.notcieAndAbout.Controls.Add(this.aboutContent);
            this.notcieAndAbout.Controls.Add(this.noticeContent);
            this.notcieAndAbout.Location = new System.Drawing.Point(269, 57);
            this.notcieAndAbout.Name = "notcieAndAbout";
            this.notcieAndAbout.Size = new System.Drawing.Size(664, 580);
            this.notcieAndAbout.TabIndex = 5;
            // 
            // aboutContent
            // 
            this.aboutContent.Controls.Add(this.aboutChoiceContent);
            this.aboutContent.Controls.Add(this.aboutInclude);
            this.aboutContent.Controls.Add(this.systemInformation);
            this.aboutContent.Controls.Add(this.contactUs);
            this.aboutContent.Controls.Add(this.examnationRules);
            this.aboutContent.Location = new System.Drawing.Point(21, 297);
            this.aboutContent.Name = "aboutContent";
            this.aboutContent.Size = new System.Drawing.Size(618, 269);
            this.aboutContent.TabIndex = 1;
            this.aboutContent.Visible = false;
            // 
            // aboutChoiceContent
            // 
            this.aboutChoiceContent.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutChoiceContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.aboutChoiceContent.Location = new System.Drawing.Point(22, 124);
            this.aboutChoiceContent.Name = "aboutChoiceContent";
            this.aboutChoiceContent.Size = new System.Drawing.Size(576, 123);
            this.aboutChoiceContent.TabIndex = 15;
            this.aboutChoiceContent.Text = "Examination rules";
            // 
            // aboutInclude
            // 
            this.aboutInclude.AutoSize = true;
            this.aboutInclude.Font = new System.Drawing.Font("Arial", 13.5F);
            this.aboutInclude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.aboutInclude.Location = new System.Drawing.Point(233, 75);
            this.aboutInclude.Name = "aboutInclude";
            this.aboutInclude.Size = new System.Drawing.Size(151, 21);
            this.aboutInclude.TabIndex = 14;
            this.aboutInclude.Text = "Examination rules";
            // 
            // systemInformation
            // 
            this.systemInformation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.systemInformation.BorderSize = 1F;
            this.systemInformation.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.systemInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.systemInformation.Location = new System.Drawing.Point(233, 7);
            this.systemInformation.Margin = new System.Windows.Forms.Padding(4);
            this.systemInformation.Name = "systemInformation";
            this.systemInformation.Radius = 3F;
            this.systemInformation.Size = new System.Drawing.Size(140, 18);
            this.systemInformation.TabIndex = 13;
            this.systemInformation.Text = "System Information";
            // 
            // contactUs
            // 
            this.contactUs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.contactUs.BorderSize = 1F;
            this.contactUs.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.contactUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.contactUs.Location = new System.Drawing.Point(458, 7);
            this.contactUs.Margin = new System.Windows.Forms.Padding(4);
            this.contactUs.Name = "contactUs";
            this.contactUs.Radius = 3F;
            this.contactUs.Size = new System.Drawing.Size(140, 18);
            this.contactUs.TabIndex = 12;
            this.contactUs.Text = "Contact Us";
            // 
            // examnationRules
            // 
            this.examnationRules.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.examnationRules.BorderSize = 1F;
            this.examnationRules.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.examnationRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.examnationRules.Location = new System.Drawing.Point(22, 7);
            this.examnationRules.Margin = new System.Windows.Forms.Padding(4);
            this.examnationRules.Name = "examnationRules";
            this.examnationRules.Radius = 3F;
            this.examnationRules.Size = new System.Drawing.Size(140, 18);
            this.examnationRules.TabIndex = 11;
            this.examnationRules.Text = "Examnation Rules";
            // 
            // noticeContent
            // 
            this.noticeContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.noticeContent.AutoScroll = true;
            this.noticeContent.AutoSize = true;
            this.noticeContent.Location = new System.Drawing.Point(21, 44);
            this.noticeContent.Name = "noticeContent";
            this.noticeContent.Size = new System.Drawing.Size(618, 156);
            this.noticeContent.TabIndex = 0;
            this.noticeContent.Visible = false;
            // 
            // about
            // 
            this.about.BorderColor = System.Drawing.Color.Empty;
            this.about.BorderSize = 0F;
            this.about.FontColor = System.Drawing.Color.Empty;
            this.about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.about.Location = new System.Drawing.Point(0, 68);
            this.about.Margin = new System.Windows.Forms.Padding(4);
            this.about.Name = "about";
            this.about.Radius = 3F;
            this.about.Size = new System.Drawing.Size(180, 30);
            this.about.TabIndex = 1;
            this.about.Text = "About";
            // 
            // notice
            // 
            this.notice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.notice.BorderColor = System.Drawing.Color.Empty;
            this.notice.BorderSize = 0F;
            this.notice.FontColor = System.Drawing.Color.Empty;
            this.notice.ForeColor = System.Drawing.Color.White;
            this.notice.Location = new System.Drawing.Point(0, 38);
            this.notice.Margin = new System.Windows.Forms.Padding(4);
            this.notice.Name = "notice";
            this.notice.Radius = 3F;
            this.notice.Size = new System.Drawing.Size(180, 30);
            this.notice.TabIndex = 0;
            this.notice.Text = "notice";
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.notcieAndAbout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.about);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentHome";
            this.Size = new System.Drawing.Size(980, 640);
            this.notcieAndAbout.ResumeLayout(false);
            this.notcieAndAbout.PerformLayout();
            this.aboutContent.ResumeLayout(false);
            this.aboutContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.RadiusBorder notice;
        private Custom.RadiusBorder about;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Panel notcieAndAbout;
        private System.Windows.Forms.FlowLayoutPanel noticeContent;
        private System.Windows.Forms.Panel aboutContent;
        private Custom.RadiusBorder systemInformation;
        private Custom.RadiusBorder contactUs;
        private Custom.RadiusBorder examnationRules;
        private Label aboutInclude;
        private Label aboutChoiceContent;
    }
}
