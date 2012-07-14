using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using Microsoft.WindowsAPICodePack.Dialogs; 


namespace Chiave
{
    public partial class DecryptionPanel : UserControl
    {
        #region Constructors
        public DecryptionPanel(List<string> Files,bool IsInstant)
        {
            InitializeComponent();
            Instant = IsInstant;            
            try
            {
                Image Image = null;
                Image = Icon.ExtractAssociatedIcon(Files[0]).ToBitmap();
                FileListIcons.Images.Add(Image);
                IconUpdater.RunWorkerAsync(Files.ToArray());
            }
            catch { }
        }
        #endregion

        #region Global Declarations

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
            FileList.Items.Clear();
            FileListIcons.Images.Clear();
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

        private void MBtnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Multiselect = true;
            OpenFile.Filter = "Encrypted Files  (*.enf)|*.enf";
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                LoadFilesToList(OpenFile.FileNames);
                CmdStart.NoteText = "Enter Password and Click 'Start Decryption'";
            }
        }

        private void MBtnRefresh_Click(object sender, EventArgs e)
        {
            UIReset();
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

                LoadFilesToList(NewFileListFromFolders.ToArray());
                NewFileListFromFolders.Clear();

            }
        }

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
                if (N.Extension == ".enf")
                {
                    nFileList.Add(File);
                }
            }

            LoadFilesToList(nFileList.ToArray());

        }
       
        private void CmdStart_Click(object sender, EventArgs e)
        {
            RemoveDuplicates();
            UpdateFileList();
            if (FileList.Items.Count == 0)
            {
                BluMessage Msg = new BluMessage("No files added!", BluMessage.MessageBoxIcon.Error, false,false);
                Msg.ShowDialog();
            }
            else
            {
                AskPassword Ap = new AskPassword(MainWindow.Operation.Decrypt, SrcFileList);
                Ap.ShowDialog();
            }
        }
        #endregion       

        #region Internal Methods

        private void LoadFilesToList(string[] Files)
        {
            this.Enabled = false;
            FileListIcons.ImageSize = new Size(18, 18);

            

            FileInfo NewFile;
            ListViewItem ListViewItem;
            FileList.SmallImageList = FileListIcons;
            Image Image = null;
            try
            {
            foreach (string File in Files)
            {
                NewFile = new FileInfo(File);
                if (NewFile.Extension == ".enf")
                {
                    Image = Icon.ExtractAssociatedIcon(Files[0]).ToBitmap();
                    FileListIcons.Images.Add(Image);
                    break;
                }                
            }

            foreach (string File in Files)
            {
                NewFile = new FileInfo(File);
                if (NewFile.Extension == ".enf")
                {
                    ListViewItem = FileList.Items.Add("", 0);
                    ListViewItem.SubItems.Add(NewFile.Name);
                    ListViewItem.SubItems.Add(NewFile.FullName);
                    FileList.EnsureVisible(FileList.Items.Count-1);
                }
            }
            }
            catch { }
            this.Enabled = true;           
        }

        private void IconUpdater_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Enabled = true;
            if (Instant)
            {
                CmdStart.PerformClick();
            }
        }

        private void IconUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Enabled = false;
            FileListIcons.ImageSize = new Size(18, 18);            
            string[] Files = (string[])e.Argument;

            FileInfo NewFile;
            ListViewItem ListViewItem;
            FileList.SmallImageList = FileListIcons;            
            try
            {
                foreach (string File in Files)
                {
                    NewFile = new FileInfo(File);
                    if (NewFile.Extension == ".enf")
                    {
                        ListViewItem = FileList.Items.Add("", 0);
                        ListViewItem.SubItems.Add(NewFile.Name);
                        ListViewItem.SubItems.Add(NewFile.FullName);
                        FileList.EnsureVisible(FileList.Items.Count - 1);
                    }
                }
            }
            catch { }
        }
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
            for (int i = 0; i <= FileList.Items.Count - 1; i++)
            {
                SrcFileList.Add(FileList.Items[i].SubItems[2].Text);
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
