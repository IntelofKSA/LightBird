namespace LightBird
{
    partial class FrmNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotice));
            this.timerIn = new System.Windows.Forms.Timer(this.components);
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.timerAutoClose = new System.Windows.Forms.Timer(this.components);
            this.timerOut = new System.Windows.Forms.Timer(this.components);
            this.butClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerIn
            // 
            this.timerIn.Interval = 3;
            this.timerIn.Tick += new System.EventHandler(this.timerIn_Tick);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 8);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(220, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "새 공지사항이 있습니다.";
            this.lblHeader.Click += new System.EventHandler(this.FrmNoticeControl_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "꺄르르 꺆꺆꺄>< 가온누리 사랑해요 ㅎㅎㅎㅎㅎㅎ";
            this.lblTitle.Click += new System.EventHandler(this.FrmNoticeControl_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoEllipsis = true;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(173, 72);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(135, 19);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "2013-11-30, 정보부";
            this.lblInfo.Click += new System.EventHandler(this.FrmNoticeControl_Click);
            // 
            // timerAutoClose
            // 
            this.timerAutoClose.Enabled = true;
            this.timerAutoClose.Interval = 10000;
            this.timerAutoClose.Tick += new System.EventHandler(this.timerAutoClose_Tick);
            // 
            // timerOut
            // 
            this.timerOut.Interval = 15;
            this.timerOut.Tick += new System.EventHandler(this.timerOut_Tick);
            // 
            // butClose
            // 
            this.butClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.butClose.FlatAppearance.BorderSize = 0;
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.butClose.ForeColor = System.Drawing.Color.Red;
            this.butClose.Location = new System.Drawing.Point(288, 0);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(32, 32);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "X";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // FrmNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(320, 100);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblHeader);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmNotice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "LightBird - 새 공지사항";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmNotice_Load);
            this.Click += new System.EventHandler(this.FrmNoticeControl_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmNotice_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerIn;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer timerAutoClose;
        private System.Windows.Forms.Timer timerOut;
        private System.Windows.Forms.Button butClose;
    }
}