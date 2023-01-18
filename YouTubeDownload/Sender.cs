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

        public void Run(VideoInfo item, string URL)
        {
            Command.Run(item, URL);
        }
    }
}
