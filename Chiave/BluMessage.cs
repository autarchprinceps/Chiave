using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Chiave
{
    public partial class BluMessage : Form
    {
        #region Form Handle Code

        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        internal const int WM_NCHITTEST = 0x84;
        internal const int HTCLIENT = 1;
        internal const int HTCAPTION = 2;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST 
              && m.Result.ToInt32() == HTCLIENT 
              && true)
            {
                m.Result = new IntPtr(HTCAPTION); 
            }
        }

        #endregion

        #region Enums
        public enum MessageBoxIcon
        {
            Error,
            Warning,
            Information,
            Successful,
            Question,
        }

        #endregion        

        #region Constuctor

        public BluMessage(string Message, MessageBoxIcon Icon, bool NoButton, bool CheckBox)
        {
            InitializeComponent();
            this.TopMost = true;

            this.MsgLbl.Text = Message;
            if (Icon == MessageBoxIcon.Error)
            {
                PicStrip.BackColor = Color.Red;
            }

            if (Icon == MessageBoxIcon.Information)
            {
                PicStrip.BackColor = Color.DeepSkyBlue;
            }

            if (Icon == MessageBoxIcon.Question)
            {
                PicStrip.BackColor = Color.DeepSkyBlue;
            }

            if (Icon == MessageBoxIcon.Successful)
            {
                PicStrip.BackColor = Color.SeaGreen;
            }

            if (Icon == MessageBoxIcon.Warning)
            {
                PicStrip.BackColor = Color.Yellow;
            }

            if (CheckBox)
            {
                ChkAll.Show();
            }

            if (NoButton)
            {
                No.Show();
            }
            else
            {
                No.Hide();
            }
        }
        #endregion

        #region Control Events
        private void PicMsgClose_Click(object sender, EventArgs e)
        {
            DNo.PerformClick();
        } 

        private void Yes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DNo.PerformClick();
            }
        }

        private void No_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DNo.PerformClick();
            }
        }

        private void PicMsgClose_MouseEnter(object sender, EventArgs e)
        {
            PicMsgClose.BackgroundImage = Chiave.Properties.Resources.CloseHover;
        }

        private void PicMsgClose_MouseLeave(object sender, EventArgs e)
        {
            PicMsgClose.BackgroundImage = Chiave.Properties.Resources.CloseNormal;
        }
        #endregion

        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAll.Checked)
            {
                ProcessPanel.Ins.ChangeStatus(true);
            }
            else
            {
                ProcessPanel.Ins.ChangeStatus(false);
            }
        }
    }
}
