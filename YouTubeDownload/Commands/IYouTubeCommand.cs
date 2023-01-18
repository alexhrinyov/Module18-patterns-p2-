using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload.Commands
{
    public interface IYouTubeCommand
    {
        public Task Run(VideoInfo item, string URL);
        public void Cancel();
    }
}
