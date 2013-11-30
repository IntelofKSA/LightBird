namespace LightBird
{
    partial class FrmList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmList));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataNotice = new System.Windows.Forms.DataGridView();
            this.columnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butClose = new System.Windows.Forms.Button();
            this.timerIn = new System.Windows.Forms.Timer(this.components);
            this.timerOut = new System.Windows.Forms.Timer(this.components);
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRefreshTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 16F);
            this.lblTitle.Location = new System.Drawing.Point(178, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "공지사항 목록";
            // 
            // dataNotice
            // 
            this.dataNotice.AllowUserToAddRows = false;
            this.dataNotice.AllowUserToDeleteRows = false;
            this.dataNotice.AllowUserToResizeColumns = false;
            this.dataNotice.AllowUserToResizeRows = false;
            this.dataNotice.BackgroundColor = System.Drawing.Color.White;
            this.dataNotice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataNotice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNotice.ColumnHeadersVisible = false;
            this.dataNotice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnTitle,
            this.columnDate,
            this.columnAuthor,
            this.columnLink});
            this.dataNotice.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNotice.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataNotice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataNotice.EnableHeadersVisualStyles = false;
            this.dataNotice.Location = new System.Drawing.Point(12, 51);
            this.dataNotice.MultiSelect = false;
            this.dataNotice.Name = "dataNotice";
            this.dataNotice.ReadOnly = true;
            this.dataNotice.RowHeadersVisible = false;
            this.dataNotice.RowTemplate.Height = 23;
            this.dataNotice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataNotice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataNotice.Size = new System.Drawing.Size(476, 192);
            this.dataNotice.TabIndex = 2;
            this.dataNotice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNotice_CellDoubleClick);
            // 
            // columnTitle
            // 
            this.columnTitle.HeaderText = "Title";
            this.columnTitle.Name = "columnTitle";
            this.columnTitle.ReadOnly = true;
            this.columnTitle.Width = 300;
            // 
            // columnDate
            // 
            this.columnDate.HeaderText = "Date";
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            this.columnDate.Width = 85;
            // 
            // columnAuthor
            // 
            this.columnAuthor.HeaderText = "Author";
            this.columnAuthor.Name = "columnAuthor";
            this.columnAuthor.ReadOnly = true;
            this.columnAuthor.Width = 90;
            // 
            // columnLink
            // 
            this.columnLink.HeaderText = "Link";
            this.columnLink.Name = "columnLink";
            this.columnLink.ReadOnly = true;
            this.columnLink.Visible = false;
            // 
            // butClose
            // 
            this.butClose.BackColor = System.Drawing.Color.Transparent;
            this.butClose.FlatAppearance.BorderSize = 0;
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.butClose.ForeColor = System.Drawing.Color.Red;
            this.butClose.Location = new System.Drawing.Point(469, 0);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(32, 32);
            this.butClose.TabIndex = 4;
            this.butClose.Text = "X";
            this.butClose.UseVisualStyleBackColor = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // timerIn
            // 
            this.timerIn.Enabled = true;
            this.timerIn.Interval = 3;
            this.timerIn.Tick += new System.EventHandler(this.timerIn_Tick);
            // 
            // timerOut
            // 
            this.timerOut.Interval = 15;
            this.timerOut.Tick += new System.EventHandler(this.timerOut_Tick);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Location = new System.Drawing.Point(342, 249);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(146, 15);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "더블클릭하여 이동합니다.";
            // 
            // lblRefreshTime
            // 
            this.lblRefreshTime.AutoSize = true;
            this.lblRefreshTime.Location = new System.Drawing.Point(9, 249);
            this.lblRefreshTime.Name = "lblRefreshTime";
            this.lblRefreshTime.Size = new System.Drawing.Size(78, 15);
            this.lblRefreshTime.TabIndex = 6;
            this.lblRefreshTime.Text = "마지막 갱신: ";
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 270);
            this.Controls.Add(this.lblRefreshTime);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.dataNotice);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LightBird - 공지사항 리스트";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmList_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmList_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataNotice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataNotice;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Timer timerIn;
        private System.Windows.Forms.Timer timerOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLink;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRefreshTime;
    }
}