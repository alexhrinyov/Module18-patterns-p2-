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
        /// <summary>
        /// Метод, получающий описание видео
        /// </summary>
        /// <param name="VideoItem"></param>
        /// <param name="URL"></param>
        /// <returns></returns>
        public async Task RunDescription(VideoInfo VideoItem, string URL)
        {
            await Command.Run(VideoItem, URL);
        }
        /// <summary>
        /// Метод, запускающий загрузку видео
        /// </summary>
        /// <param name="videoItem"></param>
        /// <param name="outputPath"></param>
        /// <returns></returns>
        public async Task RunDownload(VideoInfo videoItem, string outputPath)
        {
            await Command.RunDownload(videoItem, outputPath);
            
        }
    }
}
