using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload.Commands
{
    public interface IYouTubeCommand
    {
        /// <summary>
        /// Запуск команды получения описания
        /// </summary>
        /// <param name="video"></param>
        /// <param name="URL"></param>
        /// <returns></returns>
        public  Task Run(VideoInfo video, string URL);
        /// <summary>
        /// Запуск загрузки
        /// </summary>
        /// <param name="video"></param>
        /// <param name="outputPath"></param>
        /// <returns></returns>
        public Task RunDownload(VideoInfo video, string outputPath);
        
    }
}
