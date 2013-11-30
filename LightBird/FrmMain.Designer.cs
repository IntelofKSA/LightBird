namespace LightBird
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.timerGet = new System.Windows.Forms.Timer(this.components);
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSeeList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGaonnuri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDescription = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 16F);
            this.lblTitle.Location = new System.Drawing.Point(121, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LightBird";
            // 
            // timerGet
            // 
            this.timerGet.Interval = 20000;
            this.timerGet.Tick += new System.EventHandler(this.timerGet_Tick);
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.contextMenu;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "LightBird";
            this.notify.Visible = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRefresh,
            this.menuItemSeperator1,
            this.menuItemSeeList,
            this.menuItemGaonnuri,
            this.menuItemSeperator2,
            this.menuItemAbout,
            this.menuItemClose});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(167, 126);
            // 
            // menuItemRefresh
            // 
            this.menuItemRefresh.Name = "menuItemRefresh";
            this.menuItemRefresh.Size = new System.Drawing.Size(166, 22);
            this.menuItemRefresh.Text = "새로고침(&R)";
            this.menuItemRefresh.Click += new System.EventHandler(this.menuItemRefresh_Click);
            // 
            // menuItemSeperator1
            // 
            this.menuItemSeperator1.Name = "menuItemSeperator1";
            this.menuItemSeperator1.Size = new System.Drawing.Size(163, 6);
            // 
            // menuItemSeeList
            // 
            this.menuItemSeeList.Name = "menuItemSeeList";
            this.menuItemSeeList.Size = new System.Drawing.Size(166, 22);
            this.menuItemSeeList.Text = "공지사항 목록(&L)";
            this.menuItemSeeList.Click += new System.EventHandler(this.menuItemSeeList_Click);
            // 
            // menuItemGaonnuri
            // 
            this.menuItemGaonnuri.Name = "menuItemGaonnuri";
            this.menuItemGaonnuri.Size = new System.Drawing.Size(166, 22);
            this.menuItemGaonnuri.Text = "홈페이지 접속(&G)";
            this.menuItemGaonnuri.Click += new System.EventHandler(this.menuItemGaonnuri_Click);
            // 
            // menuItemSeperator2
            // 
            this.menuItemSeperator2.Name = "menuItemSeperator2";
            this.menuItemSeperator2.Size = new System.Drawing.Size(163, 6);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(166, 22);
            this.menuItemAbout.Text = "정보(&I)";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // menuItemClose
            // 
            this.menuItemClose.Name = "menuItemClose";
            this.menuItemClose.Size = new System.Drawing.Size(166, 22);
            this.menuItemClose.Text = "종료(&X)";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblDescription.Location = new System.Drawing.Point(0, 49);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(340, 70);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "*Gaonnuri 공지사항 알리미*\r\n\r\n연결상태를 확인하고 있습니다.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(29, 132);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(286, 19);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 169);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LightBird";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timerGet;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemSeeList;
        private System.Windows.Forms.ToolStripMenuItem menuItemGaonnuri;
        private System.Windows.Forms.ToolStripSeparator menuItemSeperator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem menuItemClose;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem menuItemRefresh;
        private System.Windows.Forms.ToolStripSeparator menuItemSeperator2;
    }
}

