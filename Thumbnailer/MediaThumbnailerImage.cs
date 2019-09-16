using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thumbnailer
{
    internal sealed class MediaThumbnailerImage : MediaThumbnailerBase
    {
        protected override MediaMetadata ExtractMetadata(MediaInfo mediaInfo)
        {
            return new MediaMetadata(MediaType.Image, 400, 300, "image/png", 0, 16297984);
        }

        protected override Image GenerateThumbnail(MediaInfo mediaInfo, MediaMetadata mediaMetadata)
        {
            Bitmap bitmap = new Bitmap(@"..\..\IoTInThePalmOfYourHand.png");
            Graphics graphics = null;
            try
            {
                var requiredWith = mediaMetadata.Width;
                var requiredHeight = requiredWith * bitmap.Height / bitmap.Width;

                var thumbnail = new Bitmap(requiredWith, requiredHeight);
                graphics = Graphics.FromImage(thumbnail);
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(bitmap, 0, 0, requiredWith, requiredHeight);
                return thumbnail;
            }
            finally
            {
                graphics?.Dispose();
                bitmap.Dispose();
            }
        }
    }
}
