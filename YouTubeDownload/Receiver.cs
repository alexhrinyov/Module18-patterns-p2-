using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace YouTubeDownload
{

    public class Receiver
    {
        private YoutubeClient youtube = new YoutubeClient();  
        

        public async Task  GetDescription(VideoInfo item ,string videoUrl)
        {
            var video = await youtube.Videos.GetAsync(item.VideoUrl);
            item.Video = video;
            item.Title = video.Title;
            item.Author = video.Author.ChannelTitle;
            item.Duration = video.Duration;
            
        }

        public async Task DownloadVideo(VideoInfo video, string outputPath)
        {
            await youtube.Videos.DownloadAsync(video.VideoUrl, outputPath);
        }
    }
}
