using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload.Commands
{
    internal class DownloadCommand : IYouTubeCommand
    {
        Receiver Receiver;

        public DownloadCommand(Receiver receiver)
        {
            Receiver = receiver;
        }

        public void Cancel()
        {
            
        }

        public Task Run(VideoInfo item, string URL)
        {
            throw new NotImplementedException();
        }

        public async Task RunDownload(VideoInfo item, string outputPath)
        {
            await Receiver.DownloadVideo(item, outputPath);
        }
    }
}
