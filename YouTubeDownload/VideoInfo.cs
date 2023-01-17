using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YouTubeDownload
{
    public class VideoInfo
    {
        
        public VideoInfo( string videoUrl)
        {
            VideoUrl = videoUrl;


        }
        
        public string VideoUrl { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public TimeSpan? Duration { get; set; }

        public  YoutubeExplode.Videos.Video Video { get; set; }

    }
}
