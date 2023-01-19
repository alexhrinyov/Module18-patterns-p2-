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
        
        /// <summary>
        /// Получить описания видео
        /// </summary>
        /// <param name="item"></param>
        /// <param name="videoUrl"></param>
        /// <returns></returns>
        public async Task  GetDescription(VideoInfo item ,string videoUrl)
        {
            var video = await youtube.Videos.GetAsync(item.VideoUrl);
            item.Video = video;
            item.Title = video.Title;
            item.Author = video.Author.ChannelTitle;
            item.Duration = video.Duration;


        }

        /// <summary>
        /// Загрузить видео
        /// </summary>
        /// <param name="video"></param>
        /// <param name="outputPath"></param>
        /// <returns></returns>
        public async Task DownloadVideo(VideoInfo video, string outputPath)
        {
            video.Video = await youtube.Videos.GetAsync(video.VideoUrl);
            string videoUrl = video.VideoUrl;
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);

            // Get highest quality muxed stream
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            // Download the stream to a file
            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"{outputPath}\\{video.Video.Title}.{streamInfo.Container}");
        }
    }
}
