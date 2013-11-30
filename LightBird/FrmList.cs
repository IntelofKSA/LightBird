using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LightBird
{
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }

        public void UpdateNotice()
        {
            dataNotice.Rows.Clear();
            foreach (NoticeObject noticeObj in ParseEngine.Notices)
                dataNotice.Rows.Add(noticeObj.title, noticeObj.time, noticeObj.author, noticeObj.link);
            lblRefreshTime.Text = "마지막 갱신: " + DateTime.Now.ToString("tt h:mm");
        }

        private void dataNotice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            Process.Start(dataNotice[3, e.RowIndex].Value.ToString());
        }

        private void FrmList_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmList_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.Top = Screen.PrimaryScreen.WorkingArea.Height;
                this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
                this.Opacity = 1;
            }
            else
                timerIn.Start();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            timerOut.Start();
        }

        private void timerIn_Tick(object sender, EventArgs e)
        {
            this.Top -= 6;
            if (this.Top + this.Height - 6 < Screen.PrimaryScreen.WorkingArea.Height)
            {
                this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
                timerIn.Stop();
            }
        }

        private void timerOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timerOut.Stop();
                this.Hide();
            }
        }
    }
}
