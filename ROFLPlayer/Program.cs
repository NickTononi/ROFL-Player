﻿using System;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using ROFLPlayer.Lib;

namespace ROFLPlayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static Mutex mutex = new Mutex(true, "{f847ab42-e13e-43ba-990a-1f781d5966e4}");

        [STAThread]
        static void Main(string[] args)
        {
            if(mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                // StartupMode, 0  = show detailed information, 1 = launch replay immediately
                if(args.Length == RoflSettings.Default.StartupMode)
                {
                    Application.Run(new SettingsForm());
                }
                else
                {
                    ReplayManager.StartReplay(args[0]);
                }
                //Application.Run(new Form1(args));
                mutex.ReleaseMutex();
            }
            else
            {
                if(args.Length == 1)
                {
                    string instance_path = AppDomain.CurrentDomain.BaseDirectory + "instance.tmp";
                    using (StreamWriter file = new StreamWriter(instance_path))
                    {
                        file.WriteLine(args[0]);
                    }
                }

                WinMethods.PostMessage(
                    (IntPtr)WinMethods.HWND_BROADCAST,
                    WinMethods.WM_SHOWME,
                    IntPtr.Zero,
                    IntPtr.Zero);
            }
        }
    }
}
