namespace Client.Student
{
    partial class AfterTest
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
            this.head = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.windowClose = new System.Windows.Forms.Label();
            this.windowMin = new System.Windows.Forms.Label();
            this.windowStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmpLogo = new System.Windows.Forms.Label();
            this.finishTimeOut = new Client.Student.FinishTimeOut();
            this.finishTimeIn = new Client.Student.FinishTimeIn();
            this.head.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.head.TabIndex = 4;
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
            // finishTimeOut
            // 
            this.finishTimeOut.BackColor = System.Drawing.Color.White;
            this.finishTimeOut.Location = new System.Drawing.Point(563, 101);
            this.finishTimeOut.Name = "finishTimeOut";
            this.finishTimeOut.Size = new System.Drawing.Size(284, 328);
            this.finishTimeOut.TabIndex = 6;
            this.finishTimeOut.Visible = false;
            // 
            // finishTimeIn
            // 
            this.finishTimeIn.BackColor = System.Drawing.Color.White;
            this.finishTimeIn.Location = new System.Drawing.Point(32, 185);
            this.finishTimeIn.Name = "finishTimeIn";
            this.finishTimeIn.Size = new System.Drawing.Size(352, 301);
            this.finishTimeIn.TabIndex = 5;
            this.finishTimeIn.Visible = false;
            // 
            // AfterTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.finishTimeOut);
            this.Controls.Add(this.finishTimeIn);
            this.Controls.Add(this.head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AfterTest";
            this.Text = "AfterTest";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private FinishTimeIn finishTimeIn;
        private FinishTimeOut finishTimeOut;
    }
}