using System.IO;
using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using AForge.Video.FFMPEG;

namespace camara
{
    class ScreenRecorder
    {
        Process process;

        public void Start(string FileName, int Framerate)
        {
            process = new System.Diagnostics.Process();
            process.StartInfo.FileName =Environment.CurrentDirectory + "ffmpeg.exe"; // Change the directory where ffmpeg.exe is.  
            process.EnableRaisingEvents = false;
            process.StartInfo.WorkingDirectory = Environment.CurrentDirectory; // The output directory  
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            Close();
        }

        public void Close()
        {
            process.Close();
        }
    }
}
