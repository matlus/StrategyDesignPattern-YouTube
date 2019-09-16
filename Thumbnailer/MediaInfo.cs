using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Thumbnailer
{
    public class MediaInfo
    {
        public string FileName { get; private set; }
        public string MimeType { get; private set; }
        public Stream FileStream { get; private set; }

        public MediaInfo(string fileName, string mimeType, Stream fileStream)
        {
            FileName = fileName;
            MimeType = mimeType;
            FileStream = fileStream;
        }
    }
}
