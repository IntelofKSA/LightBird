using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using GaonnuriAPIUtil;

namespace LightBird
{
    public partial class FrmMain : Form
    {
        private FrmList frmList = new FrmList();
        private bool isRunning = false;
        private bool isPrevSuccess = false;

        public FrmMain()
        {
            InitializeComponent();
        }

        private async void updateNotice()
        {
            isRunning = true;

            GaonnuriWebQuery query = new GaonnuriWebQuery();
            query.Add("akey", APIKeyChain.GetNoticeKey());
            query.Add("mode", "STRIP");

            string source = await Task<string>.Factory.StartNew(() => ServerConnection.PostData("/api/PNotice.php", query));
            bool isUpdated; bool success = ParseEngine.Parse(source, out isUpdated);

            this.Visible = !success;
            if (!success)
                lblDescription.Text = "인터넷에 접속할 수 없습니다.\r\n\r\n인터넷 연결 활성화 대기중입니다.";
            else if (isUpdated && isPrevSuccess)
                new FrmNotice(ParseEngine.Notices[0]).Show();

            if (frmList == null || frmList.IsDisposed)
                frmList = new FrmList();

            frmList.UpdateNotice();
            isPrevSuccess = success;
            isRunning = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timerGet.Start();
            updateNotice();
        }

        private void timerGet_Tick(object sender, EventArgs e)
        {
            if (!isRunning) updateNotice();
        }

        private void menuItemRefresh_Click(object sender, EventArgs e)
        {
            if (!isRunning) updateNotice();
        }

        private void menuItemSeeList_Click(object sender, EventArgs e)
        {
            frmList.Show();
        }

        private void menuItemGaonnuri_Click(object sender, EventArgs e)
        {
            Process.Start("http://gaonnuri.ksain.net/xe");
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}