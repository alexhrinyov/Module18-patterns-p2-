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

        public async Task Run(VideoInfo videoItem, string URL)
        {
            throw new NotImplementedException();
        }

        public async Task RunDownload(VideoInfo videoItem, string outputPath)
        {
            await Receiver.DownloadVideo(videoItem, outputPath);
        }
    }
}
