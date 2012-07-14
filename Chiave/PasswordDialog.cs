using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Chiave
{
    public partial class PasswordDialog : UserControl
    {
        #region Constructor
        public bool IsOpen = false;
        List<string> SrcFileList = new List<string>();

        public PasswordDialog(List<string> SrcFiles)
        {
            InitializeComponent();
            SrcFileList = SrcFiles;
            foreach(string File in SrcFiles)
            {
                FileInfo F = new FileInfo(File);
                LblFileName.Text = F.Name;
            }
        }
        #endregion

        #region Events
        private void CmdLoadKey_Click(object sender, EventArgs e)
        {
            if (CmdLoadKey.CommandText == "Load Key")
            {
                TxtPassword_1.Clear();
                TxtPassword_1.Enabled = false;
                CmdLoadKey.CommandText = "UnLoad Key";
                CmdLoadKey.NoteText = "Use Password to Decrypt";
                if (TxtPassword_1.Text == "")
                {
                    TxtPassword_1.Clear();
                    TxtPassword_1.Enabled = true;
                    CmdLoadKey.CommandText = "Load Key";
                    CmdLoadKey.NoteText = "Use a Key File to Decrypt";
                }
            }
            else
            {
                TxtPassword_1.Clear();
                TxtPassword_1.Enabled = true;
                CmdLoadKey.CommandText = "Load Key";
                CmdLoadKey.NoteText = "Use a Key File to Decrypt";
            }
        }

        private void CmdOpen_Click(object sender, EventArgs e)
        {
            if (TxtPassword_1.Text.Length < 6)
            {
                BluMessage Msg = new BluMessage("Password should contain more than 6 characters", BluMessage.MessageBoxIcon.Error, false,false);
                Msg.ShowDialog();
            }
            else
            {
                MainWindow.Instance.StartProcessing(SrcFileList, TxtPassword_1.Text, ProcessPanel.Operation.Decrypt, ChkOverWrite.Checked);
                
                if (IsOpen)
                {
                    System.Diagnostics.Process.Start("explorer.exe", SrcFileList[0].Replace(".enf", string.Empty));
                }

                TxtPassword_1.SelectAll();
            }
        }

        private void CmdDecrypt_Click(object sender, EventArgs e)
        {
            if (TxtPassword_1.Text.Length < 6)
            {
                BluMessage Msg = new BluMessage("Password should contain more than 6 characters", BluMessage.MessageBoxIcon.Error, false,false);
                Msg.ShowDialog();
            }
            else
            {
                MainWindow.Instance.StartProcessing(SrcFileList, TxtPassword_1.Text, ProcessPanel.Operation.Decrypt, ChkOverWrite.Checked);
              
                TxtPassword_1.SelectAll();
            }
        }

        private void PasswordDialog_Load(object sender, EventArgs e)
        {
            //TxtPassword_1.SelectAll();
        }

        private void PasswordDialog_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Green);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen,27,203,365,203);
            myPen.Dispose();
            formGraphics.Dispose();
        }
      #endregion
    }
}
