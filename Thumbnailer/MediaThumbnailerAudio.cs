using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thumbnailer
{
    class MediaThumbnailerAudio : MediaThumbnailerBase
    {
        protected override Image GenerateThumbnail(MediaInfo mediaInfo, MediaMetadata mediaMetadata)
        {
            Console.WriteLine("MediaThumbnailerAudio.GenerateThumbnail");
            return CreateImage(300, 300, Color.DarkOliveGreen, Color.White, "I am an Audio Thumbnail");
        }

        protected override MediaMetadata ExtractMetadata(MediaInfo mediaInfo)
        {
            Console.WriteLine("MediaThumbnailerAudio.ExtractMetadata");
            return new MediaMetadata(MediaType.Audio, 0, 0, "audio/mp3", 320, 1024000);
        }
    }
}
