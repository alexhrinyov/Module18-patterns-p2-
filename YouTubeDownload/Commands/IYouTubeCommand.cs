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
        /// <param name="item"></param>
        /// <param name="URL"></param>
        /// <returns></returns>
        public  Task Run(VideoInfo item, string URL);
        /// <summary>
        /// Запуск загрузки
        /// </summary>
        /// <param name="item"></param>
        /// <param name="outputPath"></param>
        /// <returns></returns>
        public Task RunDownload(VideoInfo item, string outputPath);
        public void Cancel();
    }
}
