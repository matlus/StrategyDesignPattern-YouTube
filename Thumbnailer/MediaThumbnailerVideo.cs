using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thumbnailer
{
    class MediaThumbnailerVideo : MediaThumbnailerBase
    {
        protected override Image GenerateThumbnail(MediaInfo mediaInfo, MediaMetadata mediaMetadata)
        {
            Console.WriteLine("MediaThumbnailerVideo.GenerateThumbnail");
            return CreateImage(480, 270, Color.DarkBlue, Color.WhiteSmoke, "I am a Video Thumbnail");
        }

        protected override MediaMetadata ExtractMetadata(MediaInfo mediaInfo)
        {
            Console.WriteLine("MediaThumbnailerAudio.ExtractMetadata");
            return new MediaMetadata(MediaType.Video, 1920, 1080, "video/mp4", 3000, 4096000);
        }
    }
}
