using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Chiave
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Save Sav = new Save(Application.StartupPath + "\\Config.ini");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length != 0)
            {
                #region Normal Arguments

                if (args[0] == "0")
                {
                    Application.Run(new MainWindow(MainWindow.Mode.None));
                }
                else if (args[0] == "1")
                {
                    Application.Run(new MainWindow(MainWindow.Mode.Encryption));
                }
                else if (args[0] == "2")
                {
                    Application.Run(new MainWindow(MainWindow.Mode.Decryption));
                }
                else if (args[0] == "4")
                {
                    Application.Run(new MainWindow(MainWindow.Mode.Options));
                }
                else if (args[0] == "5")
                {
                    Application.Run(new MainWindow(MainWindow.Mode.Wipe));
                }
                else if (args[0] == "6")
                {
                    List<string> List = new List<string>();
                    List<string> EList = new List<string>();
                    List<string> DList = new List<string>();
                    List = GetFilesFrom(args[1], List);
                    FileInfo NFile = null;
                    foreach (string SFile in List)
                    {
                        NFile = new FileInfo(SFile);
                        if (NFile.Extension == ".enf")
                        {
                            DList.Add(SFile);
                        }
                    }
                    Application.Run(new MainWindow(MainWindow.Mode.Decryption, DList, true));
                }


                #endregion


                else if (File.Exists(args[0])) // Receives from Context Menu
                {
                    #region Mutex
                    //[DllImport("user32.dll")]
                    //[return: MarshalAs(UnmanagedType.Bool)]
                    //static extern bool SetForegroundWindow(IntPtr hWnd);
                    //bool createdNew = true;
                    //using (Mutex mutex = new Mutex(true, "Chiave", out createdNew))
                    //{
                    //    if (createdNew)
                    //    {
                    //        Application.EnableVisualStyles();
                    //        Application.SetCompatibleTextRenderingDefault(false);
                    //    }
                    //    else
                    //    {
                    //        Process current = Process.GetCurrentProcess();
                    //        foreach (Process process in Process.GetProcessesByName(current.ProcessName))
                    //        {
                    //            if (process.Id != current.Id)
                    //            {
                    //                //SetForegroundWindow(process.MainWindowHandle);
                    //                break;
                    //            }
                    //        }
                    //    }
                    //}
                    #endregion

                    FileInfo Arg = new FileInfo(args[0]);
                    if (Arg.Extension == ".enf")
                    {
                        List<string> Dec = new List<string>();

                        foreach (string Filea in args)
                        {
                            Arg = new FileInfo(Filea);
                            Dec.Add(Arg.FullName);
                        }

                        Application.Run(new MainWindow(MainWindow.Mode.PasswordDialog, Dec, false));
                        Dec.Clear();
                    }
                    else
                    {
                        List<string> Enc = new List<string>();

                        foreach (string Fileb in args)
                        {
                            Enc.Add(Arg.FullName);
                        }

                        Application.Run(new MainWindow(MainWindow.Mode.Encryption, Enc, true));
                        Enc.Clear();
                    }

                }
                else if (Directory.Exists(args[0]))
                {
                    List<string> List = new List<string>();
                    List<string> EList = new List<string>();
                    List<string> DList = new List<string>();
                    List = GetFilesFrom(args[0], List);
                    FileInfo NFile = null;
                    foreach (string SFile in List)
                    {
                        NFile = new FileInfo(SFile);
                        if (NFile.Extension != ".enf")
                        {
                            EList.Add(SFile);
                        }
                        else
                        {
                            DList.Add(SFile);
                        }
                    }
                    if (EList.Count != 0)
                    {

                        Application.Run(new MainWindow(MainWindow.Mode.Encryption, EList, true));

                    }
                    if (DList.Count != 0)
                    {
                        Application.Run(new MainWindow(MainWindow.Mode.Decryption, DList, true));
                    }
                    List.Clear();
                    EList.Clear();
                    DList.Clear();
                }
            }
            else
            {
                Application.Run(new MainWindow(MainWindow.Mode.None));
            }


        }

        #region Internal Methods
        public static List<string> GetFilesFrom(string FolderName, List<string> List)
        {

            string[] Files = Directory.GetFiles(FolderName);
            foreach (string File in Files)
            {

                List.Add(File);
                Application.DoEvents();

            }

            string[] Folders = Directory.GetDirectories(FolderName);

            foreach (string Folder in Folders)
            {
                GetFilesFrom(Folder, List);
                Application.DoEvents();
            }

            return List;
        }
        #endregion

    }
}
