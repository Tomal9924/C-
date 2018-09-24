using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height);
            Graphics gp = Graphics.FromImage(bm);
            gp.CopyFromScreen(0,0,0,0,bm.Size);
            pictureBox1.Image = bm;

        }
        void capture()
        {

            while (true)
            {

                Bitmap bm = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics gp = Graphics.FromImage(bm);
                gp.CopyFromScreen(0, 0, 0, 0, bm.Size);
                pictureBox1.Image = bm;
                Thread.Sleep(1000);

            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(capture);
            t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(capture);
            t.Abort();
        }
    }
}
