using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thumbnailer
{
    public static class MediaThumbnailerContext
    {
        public static Image GenerateThumbnail(MediaInfo mediaInfo)
        {
            MediaThumbnailerBase mediaThumbnailer = null;
            switch (mediaInfo.MimeType)
            {
                case "image/png":
                    mediaThumbnailer = new MediaThumbnailerImage();
                    break;
                case "audio/mp3":
                    mediaThumbnailer = new MediaThumbnailerAudio();
                    break;
                case "video/mp4":
                case "video/flv":
                case "video/wmv":
                    mediaThumbnailer = new MediaThumbnailerVideo();
                    break;
                default:
                    throw new MimeTypeNotSupportedException("Mime Type not supported");
            }

            return mediaThumbnailer.GenerateThumbnail(mediaInfo);
        }
    }
}
