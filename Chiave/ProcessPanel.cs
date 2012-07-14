using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Chiave
{
    public partial class ProcessPanel : UserControl
    {
        #region Global Declarations

        #region Enumerations

        public enum Operation
        {
            Encrypt,
            Decrypt,
        }

        #endregion

        #region Variables

        List<string> SrcFileList = new List<string>();
        List<string> FilesTODelete = new List<string>();
        ImageList FileListIcons = new ImageList();

        string Password;
        byte[] Key;
        byte[] IV;

        Operation Mode;

        bool IsPaused = false;
        bool IsCancelled = false;
        bool IsOverWrite = false;
        bool IsErrorFound = false;

        Save Sav = new Save(Application.StartupPath + "\\Config.ini");        

        #endregion

        #endregion  
      
        #region Constructors

        public ProcessPanel(List<string> SrcFiles, string Passwrd, Operation Modes,bool Overwrite)
        {
            InitializeComponent();
            Ins = this;
            this.SrcFileList = SrcFiles;  
            this.Password = Passwrd;
            this.Key = CreateKey(Password);
            this.IV = CreateIV(Password);
            this.Mode = Modes;
            this.IsOverWrite = Overwrite;
            //PrgOverall.MaximumValue = SrcFileList.Count * 100;

            if (Mode == Operation.Encrypt)
            {                
                PicBack.BackgroundImage = Chiave.Properties.Resources.Pic_Lock;
                PrgCurrent.ForeColor = Color.Firebrick;
                //PrgOverall.ForeColor = Color.Firebrick;
                
            }
            else if (Mode == Operation.Decrypt)
            {               
                PicBack.BackgroundImage = Chiave.Properties.Resources.Pic_UnLock;
                PrgCurrent.ForeColor = Color.ForestGreen;
                //PrgOverall.ForeColor = Color.ForestGreen;
            }    
        }
        #endregion

        #region Internal Methods

        #region DoForAll
        public static ProcessPanel Ins;
        public void ChangeStatus(bool YesNo)
        {
            DoForAll = YesNo;
        }
        bool DoForAll;
        bool DoYesForAll;
        #endregion

        #region Perform Methods

        public void StartThread()
        {
            if (this.Mode == Operation.Encrypt)
            {
                LblRemaining.Text = "Encrypted " + "0" + " of " + SrcFileList.Count.ToString() + " files";
            }
            else
            {
                LblRemaining.Text = "Decrypted " + "0" + " of " + SrcFileList.Count.ToString() + " files";
            }
            ProcessWorker.RunWorkerAsync();            
        }

        public void EndThread()
        {
            if (IsCancelled)
            {
                DeleteNewFiles();
                MainWindow.Instance.TaskBarProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.NoProgress);
                MainWindow.Instance.PerformClose();
            }

            if (IsOverWrite)
            {
                if (IsCancelled == false)
                {
                    DeleteSrcFiles();
                }
            }
           
            LblFileName.Text = "";
            LblRemaining.Text = "";
            PbIcon.Hide();
            PnlCtrls.Hide();
            PrgCurrent.Hide();
            LblProgress.Hide();

            LblStatus.Show();
            BtnOk.Show();            
            if (IsErrorFound == true && IsCancelled != true)
            {
                LblStatus.Text = "Operation incomplete with errors";
            }
            else
            {
                LblStatus.Text = "Operation completed Successfully";
            }
            LblStatus.Location = new Point(this.Width / 2 - LblStatus.Width / 2, LblStatus.Location.Y);
            MainWindow.Instance.TaskBarProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.NoProgress);
            MainWindow.Instance.AllowExit();

            FileList.Location = new Point(FileList.Location.X, LnkSummary.Location.Y + 25);
            FileList.Size = new Size(FileList.Width, FileList.Height + 90);
            LnkSummary.Show();
        }

        Dictionary<string, string> Result = new Dictionary<string, string>();

        private void LnkSummary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LnkSummary.Text == "Show Summary")
            {
                LnkSummary.Text = "Hide Summary";
                FileList.Show();                
                this.Refresh();
            }
            else
            {
                LnkSummary.Text = "Show Summary";
                FileList.Hide();
            }
        }

        #endregion

        #region Modal Dialog
        public delegate bool ShowDialogDelegate();

        public bool ShowModalDialog()
        {
            BluMessage Msg = new BluMessage("File Already Exist, want to replace?", BluMessage.MessageBoxIcon.Question, true,true);
            if (Msg.ShowDialog() == DialogResult.Yes)
            {
                if (DoForAll)
                {
                    DoYesForAll = true;
                }
                return true;
            }
            else
            {
                if (DoForAll)
                {
                    DoYesForAll = false;
                }
                return false;
            }
        }
        #endregion

        #region Process

        private void ProcessWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            try
            {
                this.PrgCurrent.Value = e.ProgressPercentage;
                LblProgress.Text = "Completed " + ((CurrentVal+PrgCurrent.Value)/SrcFileList.Count).ToString() + "%";
                //PrgOverall.MaximumValue = SrcFileList.Count * 100;
                //PrgOverall.Value = Convert.ToInt32(CurrentVal+PrgCurrent.Value);                
                MainWindow.Instance.TaskBarProgressValue(Convert.ToInt32(CurrentVal+PrgCurrent.Value),SrcFileList.Count*100);
            }
            catch { }
            
        }

        int CurrentVal = 0;
        
        private void ProcessWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            FileInfo FileO;
            ListViewItem Lv;
            Image Image;
            FileList.SmallImageList = FileListIcons;
            

            foreach(string strInputFile in SrcFileList)
            {
                CurrentVal = SrcFileList.IndexOf(strInputFile)*100;
                string strOutputFile = null;

                if (Mode == Operation.Encrypt)
                {
                    strOutputFile = strInputFile + ".enf";
                }
                else
                {
                    strOutputFile = strInputFile.Replace(".enf", string.Empty);
                }

                FileO = new FileInfo(strOutputFile);                
                Image = Icon.ExtractAssociatedIcon(strInputFile).ToBitmap();
                Lv = FileList.Items.Add("",FileList.Items.Count);
                Lv.SubItems.Add(FileO.Name);

                FileListIcons.Images.Add(Image);

                if (FileO.Exists)
                {
                    if (DoForAll)
                    {
                        if (DoYesForAll)
                        {
                            FileO.Delete();
                        }
                        else
                        {
                            LblProgress.Text = "Completed " + ((CurrentVal / SrcFileList.Count).ToString()) + "%";
                            MainWindow.Instance.TaskBarProgressValue(CurrentVal, SrcFileList.Count * 100);
                            Lv.SubItems.Add("Skipped");
                            goto Exit;
                        }
                    }
                    else
                    {
                        MainWindow.Instance.TaskBarProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Error);
                        if (Convert.ToBoolean(this.Invoke(new ShowDialogDelegate(ShowModalDialog))))
                        {
                            FileO.Delete();
                        }
                        else
                        {
                            LblProgress.Text = "Completed " + ((CurrentVal / SrcFileList.Count).ToString()) + "%";
                            MainWindow.Instance.TaskBarProgressValue(CurrentVal, SrcFileList.Count * 100);
                            Lv.SubItems.Add("Skipped");
                            goto Exit;
                        }
                    }
                }
                MainWindow.Instance.TaskBarProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Normal);
                FileInfo FileI = new FileInfo(strInputFile);

                PbIcon.BackgroundImage = Icon.ExtractAssociatedIcon(strInputFile).ToBitmap();
                LblFileName.Text = FileI.Name;
                LblFileName.Location = new Point((this.Width / 2) - (LblFileName.Width / 2), LblFileName.Location.Y);
                PbIcon.Location = new Point(LblFileName.Location.X - (PbIcon.Width + 3), PbIcon.Location.Y);

                FileStream fsInput=null;
                FileStream fsOutput=null;
                CryptoStream csCryptoStream = default(CryptoStream);

                try
                {
                    fsInput = new FileStream(strInputFile, FileMode.Open, FileAccess.Read);
                    fsOutput = new FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
                    fsOutput.SetLength(0);

                    byte[] bytBuffer = new byte[4097];
                    long lngBytesProcessed = 0;
                    long lngFileLength = fsInput.Length;
                    int intBytesInCurrentBlock = 0;
                    

                    System.Security.Cryptography.RijndaelManaged cspRijndael = new System.Security.Cryptography.RijndaelManaged();

                    if (Mode == Operation.Encrypt)
                    {
                        csCryptoStream = new CryptoStream(fsOutput, cspRijndael.CreateEncryptor(this.Key, this.IV), CryptoStreamMode.Write);
                    }
                    else
                    {
                        csCryptoStream = new CryptoStream(fsOutput, cspRijndael.CreateDecryptor(this.Key, this.IV), CryptoStreamMode.Write);

                    }
                   
                    while (lngBytesProcessed < lngFileLength)
                    {
                        if (IsPaused != true)
                        {
                            if (IsCancelled == false)
                            {
                                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096);
                                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock);
                                lngBytesProcessed = lngBytesProcessed + Convert.ToInt64(intBytesInCurrentBlock);
                                ProcessWorker.ReportProgress(Convert.ToInt32(Convert.ToDouble((lngBytesProcessed) / Convert.ToDouble(lngFileLength)) * 100));
                            }
                            else
                            {
                                csCryptoStream.Close();
                                fsInput.Close();
                                fsOutput.Close();
                                FileInfo Del = new FileInfo(strOutputFile);
                                Del.Delete();
                                break;
                            }
                        }
                    }
                    try
                    {
                        csCryptoStream.Close();
                        fsInput.Close();
                        fsOutput.Close();
                        Lv.SubItems.Add("Done");
                        FilesTODelete.Add(strInputFile);
                    }
                    catch 
                    {
                        Lv.SubItems.Add("File Error or Wrong Password");
                        fsInput.Close();
                        fsOutput.Close();
                        IsErrorFound = true;
                    }
                }
                catch
                {
                    csCryptoStream.Close();
                    fsInput.Close();
                    fsOutput.Close();
                    IsErrorFound = true;                    
                    Lv.SubItems.Add("File Error");
                }

          Exit: if (Mode == Operation.Encrypt)
                {
                    LblRemaining.Text = "Encrypted " + (SrcFileList.IndexOf(strInputFile) + 1) + " of " + SrcFileList.Count.ToString() + " files";
                    Sav.SetValue("Enc", strOutputFile, "");
                }
                else
                {
                    LblRemaining.Text = "Decrypted " + (SrcFileList.IndexOf(strInputFile) + 1) + " of " + SrcFileList.Count.ToString() + " files";
                    Sav.SetValue("Enc", strOutputFile, "");
                }
            }
        }
    

        private void ProcessWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            EndThread();
        }
        #endregion

        #region Delete File Methods

        public void DeleteSrcFiles()
        {
            try
            {
                foreach (string File in FilesTODelete)
                {
                    FileInfo SrcFile = new FileInfo(File);
                    SrcFile.Delete();
                }
            }
            catch { }
        }

        public void DeleteNewFiles()
        {
            try
            {
                FileInfo NewFile = null;
                foreach (string File in SrcFileList)
                {
                    if (this.Mode == Operation.Encrypt)
                    {
                        NewFile = new FileInfo(File + ".enf");
                    }
                    else
                    {
                        NewFile = new FileInfo(File.Replace(".enf",string.Empty));
                    }
                    NewFile.Delete();
                }
                
            }

            catch { }
        }

        #endregion

        #region Key and IV

        private byte[] CreateKey(string strPassword)
        {
            
            char[] chrData = strPassword.ToCharArray();
            int intLength = chrData.GetUpperBound(0);
            byte[] bytDataToHash = new byte[intLength + 1];
            for (int i = 0; i <= chrData.GetUpperBound(0); i++)
            {
                bytDataToHash[i] = Convert.ToByte(chrData[i]);
            }

            
            System.Security.Cryptography.SHA512Managed SHA512 = new System.Security.Cryptography.SHA512Managed();
            byte[] bytResult = SHA512.ComputeHash(bytDataToHash);
            byte[] bytKey = new byte[32];

            for (int i = 0; i <= 31; i++)
            {
                bytKey[i] = bytResult[i];
            }

            return bytKey;
        }
        private byte[] CreateIV(string strPassword)
        {

            char[] chrData = strPassword.ToCharArray();
            int intLength = chrData.GetUpperBound(0);
            byte[] bytDataToHash = new byte[intLength + 1];

            for (int i = 0; i <= chrData.GetUpperBound(0); i++)
            {
                bytDataToHash[i] = Convert.ToByte(chrData[i]);
            }

            
            System.Security.Cryptography.SHA512Managed SHA512 = new System.Security.Cryptography.SHA512Managed();
            byte[] bytResult = SHA512.ComputeHash(bytDataToHash);
            byte[] bytIV = new byte[16];

            
            for (int i = 32; i <= 47; i++)
            {
                bytIV[i - 32] = bytResult[i];
            }
            return bytIV;
        }

        #endregion

        #region GetHash

        public byte[] GetHash(string Password)
        {
            char[] chrData = Password.ToCharArray();

            int intLength = chrData.GetUpperBound(0);
            byte[] bytDataToHash = new byte[intLength + 1];
            for (int i = 0; i <= chrData.GetUpperBound(0); i++)
            {
                bytDataToHash[i] = Convert.ToByte(chrData[i]);
            }

            System.Security.Cryptography.SHA512Managed SHA512 = new System.Security.Cryptography.SHA512Managed();
            byte[] Hash = SHA512.ComputeHash(bytDataToHash);

            return Hash;

        }
        #endregion              

        #endregion

        #region MainPanel Events

        private void ProcessPanel_SizeChanged(object sender, EventArgs e)
        {
            LblFileName.Location = new Point((this.Width / 2) - (LblFileName.Width / 2), LblFileName.Location.Y);
            PbIcon.Location = new Point(LblFileName.Location.X - (PbIcon.Width + 3), PbIcon.Location.Y);
        }
        private void ProcessPanel_Load(object sender, EventArgs e)
        {
            LblFileName.Text = "";
            LblProgress.Text = "";
            LblRemaining.Text = "";
            PbIcon.BackgroundImage = null;   
            StartThread();
         
        }
        #endregion

        #region Control Events
        private void MbtnCancel_Click(object sender, EventArgs e)
        {
            IsPaused = false;
            IsCancelled = true;
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (BtnPause.ButtonImage == Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Pause)
            {
                this.IsPaused = true;
                BtnPause.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Play;
                MainWindow.Instance.TaskBarProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Paused);
            }
            else if (BtnPause.ButtonImage == Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Play)
            {
                this.IsPaused = false;
                BtnPause.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Pause;
                MainWindow.Instance.TaskBarProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Normal);
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.PerformClose();
        }

        //private void BtnStart_Click(object sender, EventArgs e)
        //{
        //   if (BtnStart.Text == "Pause")
        //    {
        //        this.IsPaused = true;
        //        BtnStart.Text = "Resume";
        //        MainWindow.Instance.TaskBarProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Paused);
        //    }
        //    else if (BtnStart.Text == "Resume")
        //    {
        //        this.IsPaused = false;
        //        BtnStart.Text = "Pause";
        //        MainWindow.Instance.TaskBarProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Normal);
        //    }           
        //}
        #endregion        
    }
}
