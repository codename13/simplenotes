﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Simple_Notes_Updater
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Directory.CreateDirectory("C:\\simplenotes\\x86");
            Directory.CreateDirectory("C:\\simplenotes\\x64");
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://github.com/codename13/simplenotes/blob/master/release/simplenotes.exe?raw=true", "C:\\simplenotes\\simplenotes.exe");
            webClient.DownloadFile("https://github.com/codename13/simplenotes/blob/master/release/favicon.ico?raw=true", "C:\\simplenotes\\favicon.ico");
            webClient.DownloadFile("https://github.com/codename13/simplenotes/blob/master/release/System.Data.SQLite.dll?raw=true", "C:\\simplenotes\\System.Data.SQLite.dll");
            webClient.DownloadFile("https://github.com/codename13/simplenotes/blob/master/release/x64/SQLite.Interop.dll?raw=true", "C:\\simplenotes\\x64\\SQLite.Interop.dll");
            webClient.DownloadFile("https://github.com/codename13/simplenotes/blob/master/release/x86/SQLite.Interop.dll?raw=true", "C:\\simplenotes\\x86\\SQLite.Interop.dll");
            MessageBox.Show("Updated Simple Notes.");
            Process.Start("C:\\simplenotes\\simplenotes.exe");
            Application.Exit();
        }
    }
}
