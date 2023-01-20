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
        /// <param name="videoItem"></param>
        /// <param name="videoUrl"></param>
        /// <returns></returns>
        public async Task  GetDescription(VideoInfo videoItem ,string videoUrl)
        {
            var video = await youtube.Videos.GetAsync(videoItem.VideoUrl);
            videoItem.Video = video;
            videoItem.Title = video.Title;
            videoItem.Author = video.Author.ChannelTitle;
            videoItem.Duration = video.Duration;


        }

        /// <summary>
        /// Загрузить видео
        /// </summary>
        /// <param name="videoItem"></param>
        /// <param name="outputPath"></param>
        /// <returns></returns>
        public async Task DownloadVideo(VideoInfo videoItem, string outputPath)
        {
            videoItem.Video = await youtube.Videos.GetAsync(videoItem.VideoUrl);
            string videoUrl = videoItem.VideoUrl;
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);

            // Get highest quality muxed stream
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            // Download the stream to a file
            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"{outputPath}\\{videoItem.Video.Title}.{streamInfo.Container}");
        }
    }
}
