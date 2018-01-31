using System.Threading.Tasks;
using System.Windows.Forms;

namespace PmLove.Download
{
    public class Api : IApi
    {
        public async Task DownloadFilesAsync(DFile dFile)
        {
            MessageBox.Show("下载成功！");
        }
    }
}
