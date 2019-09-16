using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thumbnailer;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(new MimeTypeDisplay("Audio", "audio/mp3"));
            comboBox1.Items.Add(new MimeTypeDisplay("Video", "video/mp4"));
            comboBox1.Items.Add(new MimeTypeDisplay("Image", "image/png"));
            comboBox1.DisplayMember = "DisplayName";
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mediaInfo = new MediaInfo("Some media file name", ((MimeTypeDisplay)comboBox1.SelectedItem).MimeType, null);
            pictureBox1.Image = MediaThumbnailerContext.GenerateThumbnail(mediaInfo);
        }
    }

    public class MimeTypeDisplay
    {
        public string DisplayName { get; private set; }
        public string MimeType { get; private set; }

        public MimeTypeDisplay(string displayName, string mimeType)
        {
            DisplayName = displayName;
            MimeType = mimeType;
        }
    }

}
