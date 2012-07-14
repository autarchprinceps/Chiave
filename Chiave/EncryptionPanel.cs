using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.WindowsAPICodePack.Dialogs;
using Meadows.UI.Metro;
namespace Chiave
{
    public partial class EncryptionPanel : UserControl
    {
        #region Constructors
        public EncryptionPanel(List<string> Files, bool IsInstant)
        {
            ListView.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            Instant = IsInstant;
            if (!IconUpdater.IsBusy)
            {
                try
                {
                    IconUpdater.RunWorkerAsync(Files.ToArray());
                }
                catch { }
            }

        }
        #endregion

        #region Global Declaration

        List<string> SrcFileList = new List<string>();
        List<string> NewFileListFromFolders = new List<string>();
        ImageList FileListIcons = new ImageList();

        bool Instant = false;

        #endregion

        #region Control Event Handlers
        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.ClosePanel();
        }

        private void MBtnClear_Click(object sender, EventArgs e)
        {
          
        }

        private void MBtnRem_Click(object sender, EventArgs e)
        {
            try
            {
                while (FileList.SelectedItems.Count != 0)
                {
                    FileList.Items.Remove(FileList.SelectedItems[0]);
                }
            }
            catch { }
        }

        private void MBtnRefresh_Click(object sender, EventArgs e)
        {
            UIReset();
            IconUpdater.CancelAsync();
            MainWindow.Instance.HideMessage();
        }

        private void MbtFold_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog OpenFolder = new CommonOpenFileDialog();
            OpenFolder.Multiselect = true;
            OpenFolder.IsFolderPicker = true;
            if (OpenFolder.ShowDialog() == CommonFileDialogResult.OK)
            {
                foreach (string Folder in OpenFolder.FileNames)
                {
                    NewFileListFromFolders = GetFilesFrom(Folder, NewFileListFromFolders);

                }
                if (!IconUpdater.IsBusy)
                {
                    IconUpdater.RunWorkerAsync(NewFileListFromFolders.ToArray());
                }
                NewFileListFromFolders.Clear();
            }
        }

        private void MBtnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            FileListIcons.ImageSize = new Size(18, 18);

            OpenFile.Multiselect = true;
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                if (!IconUpdater.IsBusy)
                {
                    IconUpdater.RunWorkerAsync(OpenFile.FileNames);
                }
                Cmd_Start.NoteText = "Enter & Verify Password and Click 'Start Encryption'";
            }
        }

        #region Async

        private void IconUpdater_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            RemoveDuplicates();
            if (Instant)
            {
                Cmd_Start.PerformClick();
            }
            this.Enabled = true;
            Cmd_Start.Enabled = true;
        }
        private void IconUpdater_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            this.Enabled = false;
            string[] Files = (string[]) e.Argument;
            FileInfo NewFile;
            ListViewItem ListViewItem;
            FileList.SmallImageList = FileListIcons;

            Image Image;
            foreach (string File in Files)
            {
                NewFile = new FileInfo(File);
                if (NewFile.Extension != ".enf")
                {
                    Image = Icon.ExtractAssociatedIcon(File).ToBitmap();                    
                    FileListIcons.Images.Add(Image);
                    ListViewItem = FileList.Items.Add("", FileList.Items.Count);
                    ListViewItem.SubItems.Add(NewFile.Name);
                    ListViewItem.SubItems.Add(NewFile.FullName);
                    FileList.EnsureVisible(FileList.Items.Count - 1);
                }
            } 
        }
        #endregion
        
        private void FileList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
        }

        private void FileList_DragDrop(object sender, DragEventArgs e)
        {
            FileInfo N = null;
            DirectoryInfo D = null;
            List<string> nFileList = new List<string>();
            List<string> Temp = new List<string>();
            string[] Objects = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string File in Objects)
            {
                D = new DirectoryInfo(File);
                if (D.Exists)
                {
                    Temp = GetFilesFrom(File, Temp);
                }
                else
                {
                    Temp.Add(File);
                }
            }

            foreach (string File in Temp)
            {
                N = new FileInfo(File);
                if (N.Extension != ".enf")
                {
                    nFileList.Add(File);
                }
            }

            if (!IconUpdater.IsBusy)
            {
                IconUpdater.RunWorkerAsync(nFileList.ToArray());
            }          

        }

        private void Cmd_Start_Click(object sender, EventArgs e)
        {
            RemoveDuplicates();//Removing Duplicates
            UpdateFileList();//Updating the File list            

            if (FileList.Items.Count == 0)
            {
                BluMessage Msg = new BluMessage("No files added!", BluMessage.MessageBoxIcon.Error, false, false);
                Msg.ShowDialog();
            }
            else
            {
                AskPassword Ap = new AskPassword(MainWindow.Operation.Encrypt, SrcFileList);
                Ap.ShowDialog();
            }
        }

        #endregion

        #region Internal Methods
        
        public void UIReset()
        {
            FileList.Items.Clear();
            FileListIcons.Images.Clear();
            SrcFileList.Clear();
            NewFileListFromFolders.Clear();
        }
        
        public void RemoveDuplicates()
        {
            for (int i = 0; i <= FileList.Items.Count - 1; i++)
            {
                for (int j = 0; j <= FileList.Items.Count - 1; j++)
                {
                    if (i != j)
                    {
                        if (FileList.Items[i].SubItems[2].Text == FileList.Items[j].SubItems[2].Text)
                        {
                            FileList.Items.Remove(FileList.Items[j]);
                        }
                    }
                }
            }
        }

        public void UpdateFileList()
        {
            SrcFileList.Clear();
            for(int i =0;i<=FileList.Items.Count-1;i++)
            {
                SrcFileList.Add(FileList.Items[i].SubItems[2].Text );
            }
        }

        private List<string> GetFilesFrom(string FolderName, List<string> List)
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
