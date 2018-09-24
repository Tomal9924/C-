using System;
using System.Collections.Generic;
using System.Threading;
using System.Net.Sockets;
using System.Linq;

using System.Windows.Forms;
using VirtualLibrary;
using System.Collections;
using System.Text;
using AllInfo;
using Allinfo;

namespace AllInfo
{
    static class Program
    {
        public static Hashtable clientsList = new Hashtable();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new live());
            //Application.Run(new Form2Student());
            //Application.Run(new FacultyHomepage());
            //Application.Run(new AdminHomepage());   
            //Application.Run(new Exam());
            Application.Run(new logform());

            //Client c = new Client();
            
            //Application.Run(new LiveChat());
           
            // Application.Run(new VL());
            //pplication.Run(new UploadGIF());
            //Application.Run(new uploadvideo());
            //Application.Run(new Book());
            //plication.Run(new GifForm());
            //Application.Run(new StudentSearch());
            //Application.Run(new AdminAddCourse());

            //Application.Run(new StudentHomepage());
            //  Application.Run(new quesadd());
            //Application.Run(new StudentHomepage());
            //  Application.Run(new courses());
            //Application.Run(new Exam());
            //Application.Run(new liveCam());


        }
    }
}
