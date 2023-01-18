using AngleSharp.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeDownload.Commands;

namespace YouTubeDownload
{
    public class Sender
    {
        public IYouTubeCommand Command;
        public void SetCommand(IYouTubeCommand command)
        {
            Command = command;
        }

        public async Task RunDescription(VideoInfo item, string URL)
        {
            await Command.Run(item, URL);
        }
        public async Task RunDownload(VideoInfo item, string outputPath)
        {
            await Command.RunDownload(item, outputPath);
            
        }
    }
}
