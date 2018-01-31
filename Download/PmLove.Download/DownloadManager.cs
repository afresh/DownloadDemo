namespace PmLove.Download
{
    public class DownloadManager
    {
        private static IApi _api;

        public static IApi GetDownloader()
        {
            return _api ?? (_api = new Api());
        }
    }
}
