using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YouTubeDownload
{

    public class Receiver
    {
        private YoutubeClient youtubeClient = new YoutubeClient();
        string videoUrl = YouTubeDownload.YouTubeList[0].ToString();
        string outputFilePath = "";
        public string GetDescription()
        {
            return youtubeClient.Videos.GetAsync(videoUrl).ToString();    
        }

        public void Download()
        {
            youtubeClient.Videos.DownloadAsync (videoUrl, outputFilePath)
        }
    }
}
