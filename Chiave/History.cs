using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Chiave
{
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent(); 
        }
       
        Save Sav = new Save(Application.StartupPath + "\\Config.ini");
        bool IsLoaded = false;

        #region Form Events
        private void History_Load(object sender, EventArgs e)
        {
            SplitHistory.SplitterDistance = SplitHistory.Width / 2;
            

                EList.Items.Clear();
                if (Sav.GetValue("Settings", "History").ToString() == "1")
                {
                    ChkHistory.Checked = true;
                    LoadHistory();
                    MsgLbl.Hide();
                }
                else
                {
                    ChkHistory.Checked = false;
                    SplitHistory.Hide();
                    MsgLbl.Show();
                }
                IsLoaded = true;
            
        }

        #endregion

        #region Internal Methods

        List<string> EnList = new List<string>();
        List<string> DeList = new List<string>();
        private void LoadHistory()
        {
            
            FileInfo File;
            EList.Items.Clear();
            DList.Items.Clear();

            foreach (string S in Sav.GetEntryNames("Enc"))
            {
                try
                {
                    EnList.Add(S);
                    File = new FileInfo(S);
                    EList.Items.Add(File.Name);
                }
                catch { }
            }

            foreach (string S in Sav.GetEntryNames("Dec"))
            {
                try
                {
                    DeList.Add(S);
                    File = new FileInfo(S);
                    DList.Items.Add(File.Name);
                }
                catch { }
            }

            #region UI Hide
            if (EList.Items.Count == 0)
            {

                BEOpen.Hide();
                BEncClear.Hide();
                BERemove.Hide();
                MsgLblE.Show();
            }
            else
            {
                BEOpen.Show();
                BEncClear.Show();
                BERemove.Show();
                MsgLblE.Hide();
            }
            if (DList.Items.Count == 0)
            {
                BDOpen.Hide();
                BDecClear.Hide();
                BDRemove.Hide();
                MsgLblD.Show();
            }
            else
            {
                BDOpen.Show();
                BDecClear.Show();
                BDRemove.Show();
                MsgLblD.Hide();
            }
            #endregion

            //EnList.Clear();
            //DeList.Clear();
        }
        #endregion

        #region Control Events

        private void BDecClear_Click(object sender, EventArgs e)
        {
            Sav.RemoveSection("Dec");
            LoadHistory();
        }

        private void BEncClear_Click(object sender, EventArgs e)
        {
            Sav.RemoveSection("Enc");
            LoadHistory();
        }
       
        private void ChkHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                if (ChkHistory.Checked)
                {
                    Sav.SetValue("Settings", "History", "1");
                    SplitHistory.Show();
                    LoadHistory();
                    MsgLbl.Hide();
                }
                else
                {
                    BluMessage Msg = new BluMessage("Are you sure want to Delete the History?", BluMessage.MessageBoxIcon.Warning, true,false);
                    if (Msg.ShowDialog() == DialogResult.No)
                    {
                        ChkHistory.Checked = true;

                    }
                    else
                    {
                        Sav.SetValue("Settings", "History", "0");
                        BEncClear_Click(null, null);
                        BDecClear_Click(null, null);
                        LoadHistory();
                        SplitHistory.Hide();
                        MsgLbl.Show();
                    }

                }
            }
        }               

        private void EList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(EnList[EList.SelectedIndex]))
                {
                    System.Diagnostics.Process.Start("explorer.exe", EnList[EList.SelectedIndex]);
                }
                else
                {
                    BERemove_Click(null, null);
                    MainWindow.Instance.ShowMessage("The selected File Could not be found", MainWindow.MessageBoxIcon.Error, MainWindow.MessageIcon.Application, true, false, true);
                }
            }
            catch { }
        }

        private void DList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(DeList[DList.SelectedIndex]))
                {
                    System.Diagnostics.Process.Start("explorer.exe", DeList[DList.SelectedIndex]);
                }
                else
                {
                    BDRemove_Click(null, null);
                    MainWindow.Instance.ShowMessage("The selected File Could not be found", MainWindow.MessageBoxIcon.Error, MainWindow.MessageIcon.Application, true, false, true);
                }
            }
            catch { }
        }

        private void BERemove_Click(object sender, EventArgs e)
        {
            try
            {
                Sav.RemoveEntry("Enc", EnList[EList.SelectedIndex]);
                LoadHistory();
            }
            catch { }
        }

        private void BEOpen_Click(object sender, EventArgs e)
        {
            EList_DoubleClick(null, null);
        }

        private void BDRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Sav.RemoveEntry("Dec", EnList[EList.SelectedIndex]);
                LoadHistory();
            }
            catch { }
        }

        private void BDOpen_Click(object sender, EventArgs e)
        {
            EList_DoubleClick(null, null);
        }
        #endregion        
        
    }
}
