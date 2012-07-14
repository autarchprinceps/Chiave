using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Meadows.UI.Native;


namespace Chiave
{
    public partial class AskPassword : Form
    {
        #region Metro UI

        #region Variables
        public const int BorderWidth = 5;

        private Dwm.MARGINS Margins;
        private bool IsMargin = false;

        private Win32.ResizeDirection _ResizeDirection = Win32.ResizeDirection.None;

        public static int LoWord(int dwValue)
        {
            return dwValue & 0xFFFF;
        }
        public static int HiWord(int dwValue)
        {
            return (dwValue >> 16) & 0xFFFF;
        }
        #endregion

        #region DrawImage
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Set style to WS_EX_COMPOSITED                
                return cp;
            }
        }

        #endregion

        #region Events
        private void AskPassword_Activated(object sender, EventArgs e)
        {
            Dwm.DwmExtendFrameIntoClientArea(this.Handle, ref Margins);
        }

        private void AskPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Win32.ReleaseCapture();
                Win32.SendMessage(this.Handle, Win32.WM_NCLBUTTONDOWN, Win32.HTCAPTION, 0);
            }

        }


        #endregion

        #region Methods and Overrides
        protected override void WndProc(ref Message message)
        {
            int WM_NCCALCSIZE = 0x83;
            int WM_NCHITTEST = 0x84;

            IntPtr result = IntPtr.Zero;

            int dwmHandled = Dwm.DwmDefWindowProc(message.HWnd, message.Msg, message.WParam, message.LParam, ref result);

            if (dwmHandled == 1)
            {
                message.Result = result;
                return;
            }

            if (message.Msg == WM_NCCALCSIZE && ((int)message.WParam) == 1)
            {

                Win32.NCCALCSIZE_PARAMS nccsp = (Win32.NCCALCSIZE_PARAMS)Marshal.PtrToStructure(message.LParam, typeof(Win32.NCCALCSIZE_PARAMS));

                nccsp.rect0.Top += 0;
                nccsp.rect0.Bottom += 0;
                nccsp.rect0.Left += 0;
                nccsp.rect0.Right += 0;

                if (!IsMargin)
                {
                    Margins.cyTopHeight = 3;
                    Margins.cxLeftWidth = 3;
                    Margins.cyBottomHeight = 3;
                    Margins.cxRightWidth = 3;
                    IsMargin = true;
                }

                Marshal.StructureToPtr(nccsp, message.LParam, false);

                message.Result = IntPtr.Zero;

            }
            else if (message.Msg == WM_NCHITTEST && ((int)message.Result) == 0)
            {
                message.Result = Hit(message.HWnd, message.WParam, message.LParam);
            }
            else
            {
                base.WndProc(ref message);
            }

        }

        private IntPtr Hit(IntPtr hwnd, IntPtr wparam, IntPtr lparam)
        {
            int HTNOWHERE = 0;
            int HTCLIENT = 1;
            int HTCAPTION = 2;
            int HTGROWBOX = 4;
            int HTSIZE = HTGROWBOX;
            int HTMINBUTTON = 8;
            int HTMAXBUTTON = 9;
            int HTLEFT = 10;
            int HTRIGHT = 11;
            int HTTOP = 12;
            int HTTOPLEFT = 13;
            int HTTOPRIGHT = 14;
            int HTBOTTOM = 15;
            int HTBOTTOMLEFT = 16;
            int HTBOTTOMRIGHT = 17;
            int HTREDUCE = HTMINBUTTON;
            int HTZOOM = HTMAXBUTTON;
            int HTSIZEFIRST = HTLEFT;
            int HTSIZELAST = HTBOTTOMRIGHT;

            Point p = new Point(LoWord((int)(lparam)), HiWord((int)(lparam)));

            Rectangle topleft = RectangleToScreen(new Rectangle(0, 0, Margins.cxLeftWidth, Margins.cxLeftWidth));

            if (topleft.Contains(p))
                return new IntPtr(HTTOPLEFT);

            Rectangle topright = RectangleToScreen(new Rectangle(Width - Margins.cxRightWidth, 0, Margins.cxRightWidth, Margins.cxRightWidth));

            if (topright.Contains(p))
                return new IntPtr(HTTOPRIGHT);

            Rectangle botleft = RectangleToScreen(new Rectangle(0, Height - Margins.cyBottomHeight, Margins.cxLeftWidth, Margins.cyBottomHeight));

            if (botleft.Contains(p))
                return new IntPtr(HTBOTTOMLEFT);

            Rectangle botright = RectangleToScreen(new Rectangle(Width - Margins.cxRightWidth, Height - Margins.cyBottomHeight, Margins.cxRightWidth, Margins.cyBottomHeight));

            if (botright.Contains(p))
                return new IntPtr(HTBOTTOMRIGHT);

            Rectangle top = RectangleToScreen(new Rectangle(0, 0, Width, Margins.cxLeftWidth));

            if (top.Contains(p))
                return new IntPtr(HTTOP);

            Rectangle cap = RectangleToScreen(new Rectangle(0, Margins.cxLeftWidth, Width, Margins.cyTopHeight - Margins.cxLeftWidth));

            if (cap.Contains(p))
                return new IntPtr(HTCAPTION);

            Rectangle left = RectangleToScreen(new Rectangle(0, 0, Margins.cxLeftWidth, Height));

            if (left.Contains(p))
                return new IntPtr(HTLEFT);

            Rectangle right = RectangleToScreen(new Rectangle(Width - Margins.cxRightWidth, 0, Margins.cxRightWidth, Height));

            if (right.Contains(p))
                return new IntPtr(HTRIGHT);

            Rectangle bottom = RectangleToScreen(new Rectangle(0, Height - Margins.cyBottomHeight, Width, Margins.cyBottomHeight));

            if (bottom.Contains(p))
                return new IntPtr(HTBOTTOM);

            return new IntPtr(HTCLIENT);
        }

        #endregion

        #endregion

        #region Internal Methods

        public int PasswordStrength(string Password)
        {
            int Strength = 0;
            char[] Password_1 = Password.ToCharArray();

            //Checking for Length
            if (Password_1.Length == 0 && Password_1.Length < 3) { Strength = 0; }
            else if (Password_1.Length < 6 && Password_1.Length >= 3) { Strength += 1; }
            else if (Password_1.Length >= 6 && Password_1.Length <= 8) { Strength += 2; }
            else if (Password_1.Length > 8 && Password_1.Length < 10) { Strength += 5; }
            else if (Password_1.Length >= 10 && Password_1.Length <= 13) { Strength += 6; }
            else if (Password_1.Length >= 14) { Strength += 10; }

            int NumCount = 0;
            int SymCount = 0;

            for (int i = 0; i <= Password_1.Length - 1; i++)
            {
                if (Char.IsDigit(Password_1[i])) { NumCount++; }
                if (Char.IsSymbol(Password_1[i])) { SymCount++; }
                if (Char.IsPunctuation(Password_1[i])) { SymCount++; }
            }

            //Checking For Numbers
            if (NumCount == 1 && Password_1.Length > 4) { Strength += 1; }
            else if (NumCount > 1 && NumCount <= 3 && Password_1.Length > 2) { Strength += 2; }
            else if (NumCount > 3 && Password_1.Length > 2) { Strength += 3; }

            //Checking For Symbols
            if (SymCount == 1 && Password_1.Length > 4) { Strength += 1; }
            else if (SymCount >= 1 && SymCount <= 3 && Password_1.Length > 2) { Strength += 2; }
            else if (SymCount > 3 && Password_1.Length > 2) { Strength += 3; }

            //Returning the Strength from Scale of 1-10
            if (Strength > 100)
                Strength = 10;
            return Strength;
        }

        #endregion

        #region Control Events

        MainWindow.Operation Actions;
        List<string> SrcFileList;

        public AskPassword(MainWindow.Operation Action, List<string> SrcFiles)
        {
            InitializeComponent();

            SrcFileList = SrcFiles;
            Actions = Action;       

            if (Action == MainWindow.Operation.Decrypt)
            {
                EncPanel.Hide();
                this.Height -= EncPanel.Height-5;
                this.PicStrip.BackColor = Color.SeaGreen;
                ChkShowPassword.Checked = true;
                PrgPwStren.BackColor = Color.SeaGreen;
                TxtPassword_1.ForeColor = Color.SeaGreen;
                TxtPassword_2.ForeColor = Color.SeaGreen;
            }
            else
            {
                ChkOverWrite.Checked = false;
                this.PicStrip.BackColor = Color.Red;
                PrgPwStren.BackColor = Color.Red;
                TxtPassword_1.ForeColor = Color.Red;
                TxtPassword_2.ForeColor = Color.Red;
            }
        }

       
        private void TxtPassword_1_TextChanged(object sender, EventArgs e)
        {
            if (Actions == MainWindow.Operation.Decrypt)
            {                
                if (TxtPassword_1.Text.Length >= 6)
                {
                    Yes.Enabled = true;
                }
                else
                {
                    Yes.Enabled = false;
                }
                //goto Exit;
            }

            if (TxtPassword_1.Text.Length >= 6)
            {
                TxtPassword_2.Enabled = true;

            }
            else
            {
                TxtPassword_2.Enabled = false;

            }
            try
            {
                if (Convert.ToInt16((Convert.ToDouble(PasswordStrength(TxtPassword_1.Text)) / 10) * 100) <= 100)
                {
                    PrgPwStren.Value = Convert.ToInt16((Convert.ToDouble(PasswordStrength(TxtPassword_1.Text)) / 10) * 100);
                }
                else
                {
                    PrgPwStren.Value = 100;
                }
            }
            catch { }

            if (ChkShowPassword.Checked && TxtPassword_1.Text.Length >= 6)
            {
                Yes.Enabled = true;
            }
            else
            {
                Yes.Enabled = false;
            }

        //Exit: this.AcceptButton = Yes;
        }

        private void TxtPassword_2_TextChanged(object sender, EventArgs e)
        {
            if (TxtPassword_1.Text == TxtPassword_2.Text)
            {
                Yes.Enabled = true;

            }
            else
            {
                Yes.Enabled = false;

            }
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (Actions != MainWindow.Operation.Decrypt)
            {
                if (ChkShowPassword.Checked)
                {
                    TxtPassword_1.UseSystemPasswordChar = false;
                    TxtPassword_2.UseSystemPasswordChar = false;
                    TxtPassword_2.Enabled = false;
                    if (TxtPassword_1.Text.Length >= 6)
                    {
                        Yes.Enabled = true;
                    }
                }
                else
                {
                    TxtPassword_1.UseSystemPasswordChar = true;
                    TxtPassword_2.UseSystemPasswordChar = true;
                    if (TxtPassword_1.Text.Length >= 6)
                    {
                        TxtPassword_2.Enabled = true;
                    }
                    else
                    {
                        TxtPassword_2.Enabled = false;
                    }

                    if (TxtPassword_1.Text == TxtPassword_2.Text && TxtPassword_1.Text != "") { Yes.Enabled = true; }
                    else { Yes.Enabled = false; }
                }
            }
        }
       

        private void Yes_EnabledChanged(object sender, EventArgs e)
        {
            if (Yes.Enabled)
            {
                Yes.BackColor = Color.Transparent;
            }
            else
            {
                Yes.BackColor = Color.Gray;
            }

        }

        private void CmdKey_Click(object sender, EventArgs e)
        {
            
        }

        private void PicMsgClose_MouseEnter(object sender, EventArgs e)
        {
            PicMsgClose.BackgroundImage = Chiave.Properties.Resources.CloseHover;
        }

        private void PicMsgClose_MouseLeave(object sender, EventArgs e)
        {
            PicMsgClose.BackgroundImage = Chiave.Properties.Resources.CloseNormal;
        }

        private void PicMsgClose_Click(object sender, EventArgs e)
        {
            No.PerformClick();
        }

        private void Yes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                No.PerformClick();
            }
        }

        private void No_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                No.PerformClick();
            }
        }        

        private void AskPassword_Load(object sender, EventArgs e)
        {
            TxtPassword_2.Enabled = false;
            Yes.Enabled = false;
            this.MaximumSize = this.MinimumSize = this.Size;

            //Remove Test Code
            //Yes.Enabled = false;
            //TxtPassword_1.Text = "123123";
        }

        private void ChkOverWrite_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkOverWrite.Checked)
            {
                BluMessage Msg = new BluMessage("Are you sure want to Delete the Orignal Files?", BluMessage.MessageBoxIcon.Warning, true,false);
                if (Msg.ShowDialog() == DialogResult.No)
                {
                    ChkOverWrite.Checked = false;
                }
                else
                {
                    ChkOverWrite.Checked = true;
                }
            }
        }

        #endregion

        private void Yes_Click(object sender, EventArgs e)
        {
            if (Actions == MainWindow.Operation.Encrypt)
            {
                MainWindow.Instance.StartProcessing(SrcFileList, TxtPassword_1.Text, ProcessPanel.Operation.Encrypt, ChkOverWrite.Checked);
            }
            else
            {
                MainWindow.Instance.StartProcessing(SrcFileList, TxtPassword_1.Text, ProcessPanel.Operation.Decrypt, ChkOverWrite.Checked);
            }
            this.Close();
        }


    }
}
