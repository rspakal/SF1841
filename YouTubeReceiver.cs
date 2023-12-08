using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;

namespace SF1841
{
    internal class YouTubeReceiver
    //"https://www.youtube.com/watch?v=u8uYeHy10ZY";
    {
        string _url;
        string _filePath = "C:\\Users\\rupakal\\Desktop";
        YoutubeClient _youtube = new YoutubeClient();
        public YouTubeReceiver(string url)
        {
            _url = url;
        }

        public async void RetrieveMetadata()
        {
            var _video = await _youtube.Videos.GetAsync(_url);
            Console.WriteLine(_video.Duration);
        }
        public async void DownloadVideo()
        {
            Console.WriteLine("Downloading started");
             await _youtube.Videos.DownloadAsync(_url, _filePath, builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine("Video downloaded");
        }
    }
}
 