using System;
using System.Windows.Forms;
using PmLove.Download;

namespace Demo
{
    public partial class FrmMain : Form
    {
        private readonly IApi _api = DownloadManager.GetDownloader();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            var frmNewTask = new FrmNewTask();
            var dialogResult = frmNewTask.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //todo: 下载
                _api.DownloadFilesAsync(null);
            }
        }

        private void BtnBatchDownload_Click(object sender, EventArgs e)
        {

        }
    }
}
