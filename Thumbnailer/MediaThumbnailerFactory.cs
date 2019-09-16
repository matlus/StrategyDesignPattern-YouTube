using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thumbnailer
{
    static class MediaThumbnailerFactory
    {
        public static MediaThumbnailerBase CreateMediaThumbnailer(string mimeType)
        {
            switch (mimeType)
            {
                case "audio/mp3":
                    return new MediaThumbnailerAudio();
                case "video/mp4":
                case "video/flv":
                case "video/wmv":
                    return new MediaThumbnailerVideo();
                default:
                    throw new MimeTypeNotSupportedException($"The Mime Type: {mimeType}, is not supported");
            }
        }
    }
}
