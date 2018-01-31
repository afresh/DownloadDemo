using System.Threading.Tasks;

namespace PmLove.Download
{
    public interface IApi
    {
        Task DownloadFilesAsync(DFile dFile);
    }
}
