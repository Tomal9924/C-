using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace AllInfo
{
    public partial class live : Form
    {
        MJPEGStream stream;
        public live()
        {
            InitializeComponent();
            stream = new MJPEGStream("http://192.168.0.100:4747/mjpegfeed?640x480");
            stream.NewFrame += stream_NewFrame;
        }
        void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bmp;

        }
        private void live_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            stream.Start();
        }
        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            stream.Stop();
            this.Close();
        }
    }
}
