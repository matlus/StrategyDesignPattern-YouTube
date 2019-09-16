using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thumbnailer
{
    class MediaMetadata
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public MediaType MediaType { get; private set; }
        public string Codec { get; private set; }
        public int Bitrate { get; private set; }

        public long FileSize { get; private set; }

        public MediaMetadata(MediaType mediaType, int width, int height, string codec, int bitrate, long fileSize)
        {
            MediaType = mediaType;
            Width = width;
            Height = height;
            Codec = codec;
            Bitrate = bitrate;
            FileSize = fileSize;
        }
    }
}
