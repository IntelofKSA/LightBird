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
    public partial class FrmNotice : Form
    {
        private string noticeLink;

        public FrmNotice(NoticeObject noticeObj)
        {
            InitializeComponent();
            lblTitle.Text = noticeObj.title;
            lblInfo.Text = noticeObj.time + ", " + noticeObj.author;
            lblInfo.Left = 318 - lblInfo.Width;
            noticeLink = noticeObj.link;
        }

        private void FrmNotice_Load(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.WorkingArea.Width;
            this.Top = 50;
            timerIn.Enabled = true;
        }

        private void FrmNotice_MouseMove(object sender, MouseEventArgs e)
        {
            timerAutoClose.Stop();
            timerAutoClose.Interval = 5000;
            timerAutoClose.Start();
        }

        private void FrmNoticeControl_Click(object sender, EventArgs e)
        {
            Process.Start(noticeLink);
            this.Close();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            timerOut.Start();
        }

        private void timerAutoClose_Tick(object sender, EventArgs e)
        {
            timerOut.Start();
            timerAutoClose.Stop();
        }

        private void timerIn_Tick(object sender, EventArgs e)
        {
            this.Left -= 9;
            if (this.Left + this.Width - 9 < Screen.PrimaryScreen.Bounds.Width)
            {
                this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;
                timerIn.Stop();
            }
        }

        private void timerOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
                this.Close();
        }
    }
}
