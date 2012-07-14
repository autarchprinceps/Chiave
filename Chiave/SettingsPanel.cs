using System;
using System.IO;
using System.Drawing;
using Microsoft.Win32;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Taskbar;


namespace Chiave
{
    public partial class SettingsPanel : UserControl
    {
        public SettingsPanel()
        {
            InitializeComponent();
            LoadPresets();

        }
        Save Sav = new Save(Application.StartupPath + "\\Config.ini");

        #region File Associations

        private void CmdFileAssociations_Click(object sender, EventArgs e)
        {
            Helper.Associate(".enf", "Chiave", "Chiave Encrypted File", null, Application.ExecutablePath);

            if (sender != null)
            {
                MainWindow.Instance.ShowMessage("File associations created Succesfully!", MainWindow.MessageBoxIcon.Successful,MainWindow.MessageIcon.Options,true,false, true);
          
            }
        }
        #endregion

        #region JumpLists
        
        private void CmdJump_Click(object sender, EventArgs e)
        {

            FileStream fsOutput;
            Icon Current = null;
            Helper H = new Helper();
            Directory.CreateDirectory(Application.StartupPath + "\\Ico\\");
            fsOutput = new FileStream(Application.StartupPath + "\\Ico\\Lock.ico", FileMode.OpenOrCreate, FileAccess.Write);
            Current = H.GetIcon(Chiave.Properties.Resources.Pic_Lock, 128, true);
            //Chiave.Properties.Resources.Lock.Save(fsOutput);
            Current.Save(fsOutput);
            fsOutput.Close();

            fsOutput = new FileStream(Application.StartupPath + "\\Ico\\UnLock.ico", FileMode.OpenOrCreate, FileAccess.Write);
            //Chiave.Properties.Resources.UnLock.Save(fsOutput);
            Current = H.GetIcon(Chiave.Properties.Resources.Pic_UnLock, 128, true);
            Current.Save(fsOutput);
            fsOutput.Close();
            
            fsOutput = new FileStream(Application.StartupPath + "\\Ico\\Options.ico", FileMode.OpenOrCreate, FileAccess.Write);
            //Chiave.Properties.Resources.Options.Save(fsOutput);
            Current = H.GetIcon(Chiave.Properties.Resources.Pic_Options, 128, true);
            Current.Save(fsOutput);
            fsOutput.Close();


            JumpList JumpList = JumpList.CreateJumpList();
            string EncryPath = System.IO.Path.Combine(Application.StartupPath, "chiave.exe");
            JumpListLink Encryption = new JumpListLink(EncryPath, "Encryption");
            Encryption.Arguments = "1";
            Encryption.IconReference = new IconReference(Application.StartupPath + "\\Ico\\Lock.ico", 0);

            string DecPath = System.IO.Path.Combine(Application.StartupPath, "chiave.exe");
            JumpListLink Decryption = new JumpListLink(DecPath, "Decryption");
            Decryption.Arguments = "2";
            Decryption.IconReference = new IconReference(Application.StartupPath + "\\Ico\\UnLock.ico", 0);

            JumpListSeparator Separator = new JumpListSeparator();

            string OptsPath = System.IO.Path.Combine(Application.StartupPath, "chiave.exe");
            JumpListLink Options = new JumpListLink(OptsPath, "Options");
            Options.Arguments = "4";
            Options.IconReference = new IconReference(Application.StartupPath + "\\Ico\\Options.ico", 0);


            JumpList.AddUserTasks(Encryption, Decryption, Separator, Options);
            JumpList.Refresh();
            if (sender != null)
            {
                MainWindow.Instance.ShowMessage("JumpList Updated Succesfully!", MainWindow.MessageBoxIcon.Successful, MainWindow.MessageIcon.Options, true, false, true);

            }
            CmdFileAssociations_Click(null, null);
            //Directory.Delete(Application.StartupPath + "\\Ico", true);
        }

        #endregion

        #region Registry Menu Creation

        #region Registry Keys Declaration
        private const string FolderMenuName = "Folder\\shell\\Chiave";
        private const string FolderCommand = "Folder\\shell\\Chiave\\command";

        private const string FileMenuName = "*\\shell\\Chiave";
        private const string FileCommand = "*\\shell\\Chiave\\command";
        #endregion

        private void CmdContext_Click(object sender, EventArgs e)
        {
            RegistryKey regmenu = null;
            RegistryKey regcmd = null;
            try
            {
                regmenu = Registry.ClassesRoot.CreateSubKey(FileMenuName);
                if (regmenu != null)
                    regmenu.SetValue("", "Encrypt File");                  
                regcmd = Registry.ClassesRoot.CreateSubKey(FileCommand);
                if (regcmd != null)
                    regcmd.SetValue("", Application.ExecutablePath.ToString()+ " %1");
                

                regmenu = Registry.ClassesRoot.CreateSubKey(FolderMenuName);
                if (regmenu != null)
                    regmenu.SetValue("", "Encrypt Folder Contents");
                regcmd = Registry.ClassesRoot.CreateSubKey(FolderCommand);
                if (regcmd != null)
                    regcmd.SetValue("", Application.ExecutablePath.ToString() + " %1");
               
                if (sender != null)
                {
                    MainWindow.Instance.ShowMessage("Command Added!", MainWindow.MessageBoxIcon.Successful, MainWindow.MessageIcon.Options, true, false, true);                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
            finally
            {
                if (regmenu != null)
                    regmenu.Close();
                if (regcmd != null)
                    regcmd.Close();
            }           

        }
     
        #endregion

        #region Install/Unistall
        private void CmdInstall_Click(object sender, EventArgs e)
        {
            CmdFileAssociations_Click(null, null);
            CmdContext_Click(null, null);
            CmdJump_Click(null, null);
            CmdStartUp_Click(null, null);
            MainWindow.Instance.ShowMessage("Registry Values Refreshed!", MainWindow.MessageBoxIcon.Successful, MainWindow.MessageIcon.Options, true, false, true);
        }

        private void CmdUnistall_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.ClassesRoot.OpenSubKey(FolderCommand);
            if (reg != null)
            {
                reg.Close();
                Registry.ClassesRoot.DeleteSubKey(FolderCommand);
            }
            reg = Registry.ClassesRoot.OpenSubKey(FolderMenuName);
            if (reg != null)
            {
                reg.Close();
                Registry.ClassesRoot.DeleteSubKey(FolderMenuName);
            }

            RegistryKey reg1 = Registry.ClassesRoot.OpenSubKey(FileCommand);
            if (reg1 != null)
            {
                reg1.Close();
                Registry.ClassesRoot.DeleteSubKey(FileCommand);
            }
            reg1 = Registry.ClassesRoot.OpenSubKey(FileMenuName);
            if (reg1 != null)
            {
                reg1.Close();
                Registry.ClassesRoot.DeleteSubKey(FileMenuName);
            }

            string RunKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

            RegistryKey StartupKey = Registry.LocalMachine.OpenSubKey(RunKey);


                StartupKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(RunKey, true);
                StartupKey.DeleteValue("Chiave", false);
                StartupKey.Close();


                MainWindow.Instance.ShowMessage("Registry Values Removed!", MainWindow.MessageBoxIcon.Successful, MainWindow.MessageIcon.Options, true, false, true);

        }
        #endregion

        #region StartUp

        private void CmdStartUp_Click(object sender, EventArgs e)
        {
            string RunKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

            RegistryKey StartupKey = Registry.LocalMachine.OpenSubKey(RunKey);

                if (StartupKey.GetValue("Chiave") == null)
                {
                    StartupKey.Close();
                    StartupKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(RunKey, true);
                    // Add startup reg key
                    StartupKey.SetValue("Chiave", Application.ExecutablePath.ToString());
                    StartupKey.Close();
                    if (sender != null)
                    {
                        MainWindow.Instance.ShowMessage("Added to Startup!", MainWindow.MessageBoxIcon.Successful, MainWindow.MessageIcon.Options, true, false, true);                     
                    }

                }

        }
        #endregion

        private void LoadPresets()
        {
            if (Sav.GetValue("UI", "History").ToString() == "1")
            {
                ChkHistory.Checked = true;
            }
            else
            {
                ChkHistory.Checked = false;
            }
        }
        private void ChkHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkHistory.Checked)
            {
                Sav.SetValue("UI", "History", 1);
            }
            else
            {
                Sav.SetValue("UI", "History", 0);
            }
            MainWindow.Instance.LoadHistory();
        }

    }
}
