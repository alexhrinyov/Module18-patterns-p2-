using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload.Commands
{
    internal class DescriptionCommand:IYouTubeCommand
    {
        Receiver Receiver;

        public DescriptionCommand(Receiver receiver)
        {
            Receiver = receiver;
        }

        public async Task Run(VideoInfo videoItem, string URL)
        {
           await Receiver.GetDescription(videoItem, URL);
        }

        public Task RunDownload(VideoInfo videoItem, string outputPath)
        {
            throw new NotImplementedException();
        }
    }
}
