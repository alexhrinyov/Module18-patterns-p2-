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

        public void Cancel()
        {
            
        }

        public async Task Run(VideoInfo item, string URL)
        {
           await Receiver.GetDescription(item, URL);
        }

        public Task RunDownload(VideoInfo item, string outputPath)
        {
            throw new NotImplementedException();
        }
    }
}
