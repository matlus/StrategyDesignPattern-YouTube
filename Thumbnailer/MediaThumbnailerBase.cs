using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thumbnailer
{
    abstract class MediaThumbnailerBase
    {
        public Image GenerateThumbnail(MediaInfo mediaInfo)
        {
            ValidateMediaInfo(mediaInfo);
            EnsureMimeTypeIsSupported(mediaInfo.MimeType);
            MediaMetadata mediaMetadata = ExtractMetadata(mediaInfo);
            return GenerateThumbnail(mediaInfo, mediaMetadata);
        }

        protected abstract Image GenerateThumbnail(MediaInfo mediaInfo, MediaMetadata mediaMetadata);

        protected abstract MediaMetadata ExtractMetadata(MediaInfo mediaInfo);

        private void EnsureMimeTypeIsSupported(string mimeType)
        {
            // Use a specialized Mime type validator
            // throw a specialized Exception if the mime type is not supported
        }

        private void ValidateMediaInfo(MediaInfo mediaInfo)
        {
            // Use a specialized Media info validator
            // throw a specialized Exception if the media info is not valid
        }

        protected Image CreateImage(int width, int height, Color backgroundColor, Color foregroundColor, string text)
        {
            var bitmap = new Bitmap(width, height);
            try
            {
                using (var graphics = Graphics.FromImage(bitmap))
                using (var backgroundBrush = new SolidBrush(backgroundColor))
                using (var paintBrush = new SolidBrush(foregroundColor))
                using (var font = new Font("Arial", 18f))
                {
                    graphics.FillRectangle(backgroundBrush, 0, 0, bitmap.Width, bitmap.Height);
                    graphics.DrawString(text, font, paintBrush, 10, 10);
                    return bitmap;
                }
            }
            catch (Exception)
            {
                bitmap.Dispose();
                throw;
            }
        }

    }
}
