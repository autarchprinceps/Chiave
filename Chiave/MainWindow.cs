using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.WindowsAPICodePack.Taskbar;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Runtime.InteropServices;
using Meadows.UI.Native;

namespace Chiave
{
    public partial class MainWindow : Form
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

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            Graphics a = e.Graphics;
            a.DrawImage(CurrentImage, this.Width - 240, this.Height - 110, 240, 110);
        }
        #endregion

        #region Events
        private void MainWindow_Activated(object sender, EventArgs e)
        {
            Dwm.DwmExtendFrameIntoClientArea(this.Handle, ref Margins);
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Width - BorderWidth > e.Location.X && e.Location.X > BorderWidth && e.Location.Y > BorderWidth)
                {
                    Win32.ReleaseCapture();
                    Win32.SendMessage(this.Handle, Win32.WM_NCLBUTTONDOWN, Win32.HTCAPTION, 0);
                }
                else
                {
                    if (this.WindowState != FormWindowState.Maximized)
                    {
                        DirectionResize(ResizeDirection);
                    }
                }
            }

        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Location.X < BorderWidth && e.Location.Y < BorderWidth)
                ResizeDirection = Win32.ResizeDirection.TopLeft;
            else if (e.Location.X < BorderWidth && e.Location.Y > this.Height - BorderWidth)
                ResizeDirection = Win32.ResizeDirection.BottomLeft;
            else if (e.Location.X > this.Width - BorderWidth && e.Location.Y > this.Height - BorderWidth)
                ResizeDirection = Win32.ResizeDirection.BottomRight;
            else if (e.Location.X > this.Width - BorderWidth && e.Location.Y < BorderWidth)
                ResizeDirection = Win32.ResizeDirection.TopRight;
            else if (e.Location.X < BorderWidth)
                ResizeDirection = Win32.ResizeDirection.Left;
            else if (e.Location.X > this.Width - BorderWidth)
                ResizeDirection = Win32.ResizeDirection.Right;
            else if (e.Location.Y < BorderWidth)
                ResizeDirection = Win32.ResizeDirection.Top;
            else if (e.Location.Y > this.Height - BorderWidth)
                ResizeDirection = Win32.ResizeDirection.Bottom;
            else
                ResizeDirection = Win32.ResizeDirection.None;
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

        public Win32.ResizeDirection ResizeDirection
        {
            get
            {
                return _ResizeDirection;
            }
            set
            {
                _ResizeDirection = value;
                switch (value)
                {
                    case Win32.ResizeDirection.Left:
                        this.Cursor = Cursors.SizeWE;
                        break;
                    case Win32.ResizeDirection.Right:
                        this.Cursor = Cursors.SizeWE;
                        break;
                    case Win32.ResizeDirection.Top:
                        this.Cursor = Cursors.SizeNS;
                        break;
                    case Win32.ResizeDirection.Bottom:
                        this.Cursor = Cursors.SizeNS;
                        break;
                    case Win32.ResizeDirection.BottomLeft:
                        this.Cursor = Cursors.SizeNESW;
                        break;
                    case Win32.ResizeDirection.TopRight:
                        this.Cursor = Cursors.SizeNESW;
                        break;
                    case Win32.ResizeDirection.BottomRight:
                        this.Cursor = Cursors.SizeNWSE;
                        break;
                    case Win32.ResizeDirection.TopLeft:
                        this.Cursor = Cursors.SizeNWSE;
                        break;
                    default:
                        this.Cursor = Cursors.Default;
                        Container.Cursor = Cursors.Default;
                        PnlFloat.Cursor = Cursors.Default;
                        break;
                }
            }
        }

        public void DirectionResize(Win32.ResizeDirection direction)
        {

            int _direction = -1;

            switch (direction)
            {
                case Win32.ResizeDirection.Left:
                    _direction = Win32.HTLEFT;
                    break;
                case Win32.ResizeDirection.TopLeft:
                    _direction = Win32.HTTOPLEFT;
                    break;
                case Win32.ResizeDirection.Top:
                    _direction = Win32.HTTOP;
                    break;
                case Win32.ResizeDirection.TopRight:
                    _direction = Win32.HTTOPRIGHT;
                    break;
                case Win32.ResizeDirection.Right:
                    _direction = Win32.HTRIGHT;
                    break;
                case Win32.ResizeDirection.BottomRight:
                    _direction = Win32.HTBOTTOMRIGHT;
                    break;
                case Win32.ResizeDirection.Bottom:
                    _direction = Win32.HTBOTTOM;
                    break;
                case Win32.ResizeDirection.BottomLeft:
                    _direction = Win32.HTBOTTOMLEFT;
                    break;
            }

            if (_direction != -1)
            {
                Win32.ReleaseCapture();
                Win32.SendMessage(this.Handle, Win32.WM_NCLBUTTONDOWN, _direction, 0);
            }
        }
        #endregion

        #endregion

        #region Variables

        public static MainWindow Instance = null;
        public string[] Arg;
        public static int OperationsCount = 0;
        public Mode Current = Mode.None;
        public Image CurrentImage = Chiave.Properties.Resources.BluWave;

        Save Sav = new Save(Application.StartupPath + "\\Config.ini");
        bool IsMaximized = false;
        bool AllowClose = true;
        bool Instant = false;

        public enum Operation
        {
            Encrypt,
            Decrypt,
        }

        public enum Mode
        {
            Encryption,
            Decryption,
            Wipe,
            Options,
            None,
            PasswordDialog,
        }


        //ThumbnailToolbarButton ThumbHom;
        ThumbnailToolbarButton ThumbOpts;
        ThumbnailToolbarButton ThumbEnc;
        ThumbnailToolbarButton ThumbDec;
        #endregion

        #region Constructor
        public MainWindow(Mode Panel)
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            InitializeComponent();
            ListView.CheckForIllegalCrossThreadCalls = false;
            this.CenterToScreen();
            if (Panel == Mode.Encryption)
            {
                LoadEncryption(null);
            }
            else if (Panel == Mode.Decryption)
            {
                LoadDecryption(null);
            }

            else if (Panel == Mode.Options)
            {
                LoadHistory();
                LoadOptions();
            }
            else
            {
                LoadUserInterface();
            }
        }

        public MainWindow(Mode Panel, List<string> SrcList, bool IsInstant)
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            InitializeComponent();
            this.CenterToScreen();
            Instant = IsInstant;

            if (Panel == Mode.Encryption)
            {
                LoadEncryption(SrcList);
            }
            else if (Panel == Mode.Decryption)
            {
                LoadDecryption(SrcList);
            }
            else if (Panel == Mode.PasswordDialog)
            {
                PMax.Hide();

                this.MinimumSize = new Size(395, 445);
                this.Size = new Size(395, 445);
                PMin.Location = new Point(PMin.Location.X + 18, PMin.Location.Y);
                this.LblAppTitle.Text = "Chiave Encryted File";
                Container.BorderStyle = BorderStyle.None;
                CurrentImage = Chiave.Properties.Resources.GreenWave;

                Current = Mode.PasswordDialog;
                PicStrip.BackColor = Color.SeaGreen;
                Container.Location = new Point(0, 35);
                Container.BringToFront();
                Container.Controls.Clear();
                PasswordDialog EP = new PasswordDialog(SrcList);
                EP.BackColor = Color.Transparent;
                EP.Dock = DockStyle.Fill;
                Container.Controls.Add(EP);
                EP.SendToBack();
                EP.Show();
                this.CenterToScreen();
            }
            
        }
        #endregion

        #region Events

        #region MainWindows Events

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Instance = this;
            this.Size = new Size(930, 600);
            //MsgPnl.Width = this.ClientRectangle.Width/2+200;
            //System.Windows.Forms.ToolTip PbClose = new System.Windows.Forms.ToolTip();           
            //MsgPnl.Location = new Point((this.Width / 2) - (this.MsgPnl.Width / 2), this.ClientRectangle.Height - MsgPnl.Height);


            if (Current == Mode.PasswordDialog)
            {
                this.Size = this.MaximumSize = this.MinimumSize = new Size(395, 445);
            }
        }

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                PMax.BackgroundImage = Chiave.Properties.Resources.ResNormal;
                IsMaximized = true;
            }
            else
            {
                PMax.BackgroundImage = Chiave.Properties.Resources.MaxNormal;
                IsMaximized = false;
            }

            //MsgPnl.Width = this.ClientRectangle.Width / 2 + 200;
            //MsgPnl.Location = new Point((this.Width / 2) - (this.MsgPnl.Width / 2), this.ClientRectangle.Height - MsgPnl.Height);
            PnlFloat.Location = new Point(4, 40);
            PnlFloat.Size = new Size(this.Width - 8, this.Height - 45);
            PnlFloat.BringToFront();
        }

        private void MainWindow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
        }

        public List<string> GetFilesFrom(string FolderName, List<string> List)
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

        private void MainWindow_DragDrop(object sender, DragEventArgs e)
        {

            List<string> EncFiles = new List<string>();
            List<string> DecFiles = new List<string>();
            List<string> FileObj = new List<string>();

            #region FileDrop

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Application.DoEvents();
                FileInfo F = null;
                DirectoryInfo D = null;
                string[] Objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string File in Objects)
                {
                    D = new DirectoryInfo(File);
                    if (D.Exists)
                    {
                        FileObj = GetFilesFrom(File, FileObj);
                    }
                    else
                    {
                        FileObj.Add(File);
                    }
                }

                foreach (string File in FileObj)
                {
                    F = new FileInfo(File);
                    if (F.Extension != ".enf")
                    {
                        EncFiles.Add(File);
                    }
                    else
                    {
                        DecFiles.Add(File);
                    }
                }

            }

            #endregion

            if (EncFiles.Count != 0)
            {
                LoadEncryption(EncFiles);
            }

            if (DecFiles.Count != 0)
            {
                if (EncFiles.Count == 0)
                {
                    LoadDecryption(DecFiles);
                }
                else
                {
                    MainWindow New = new MainWindow(Mode.Decryption, DecFiles, false);
                    New.Show();
                }

            }

        }
        #endregion

        #region Form ControlsEvents
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowClose)
            {
                if (!IconUpdater.IsBusy)
                    IconUpdater.CancelAsync();
                e.Cancel = true;
            }
        }

        private void Pb_Encry_Click(object sender, EventArgs e)
        {
            if (Current != Mode.Encryption)
                LoadEncryption(null);
        }

        private void Pb_Decry_Click(object sender, EventArgs e)
        {
            if (Current != Mode.Decryption)
                LoadDecryption(null);
        }

        private void Pb_Opts_Click(object sender, EventArgs e)
        {
            SettingsPanel OP = new SettingsPanel();
            ShowFloatPanel(OP, "Preferences");
        }
        #endregion

        #region Thumbnail ToolBar
        private void MainWindow_Shown(object sender, EventArgs e)
        {
            Helper H = new Helper();
            ThumbEnc = new ThumbnailToolbarButton(H.GetIcon(Properties.Resources.Pic_Lock, 128, true), "Encrypt");
            ThumbEnc.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(ThumbEnc_Click);

            ThumbDec = new ThumbnailToolbarButton(H.GetIcon(Properties.Resources.Pic_UnLock, 128, true), "Decrypt");
            ThumbDec.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(ThumbDec_Click);

            TaskbarManager.Instance.ThumbnailToolbars.AddButtons(this.Handle, ThumbEnc, ThumbDec);

        }

        void ThumbEnc_Click(object sender, EventArgs e)
        {
            LoadEncryption(null);

        }
        void ThumbDec_Click(object sender, EventArgs e)
        {

            LoadDecryption(null);
        }

        #endregion

        #region TopPanel Events
        private void Pb_His_Click(object sender, EventArgs e)
        {
            if (Current != Mode.None)
                LoadHistory();
        }

        private void Pb_His_MouseEnter(object sender, EventArgs e)
        {
            if (Pb_His.ForeColor != SystemColors.ActiveCaptionText)
            {
                Pb_His.ForeColor = SystemColors.Highlight;
            }
        }

        private void Pb_His_MouseLeave(object sender, EventArgs e)
        {
            if (Pb_His.ForeColor == SystemColors.Highlight)
            {
                Pb_His.ForeColor = SystemColors.ControlDark;
            }
        }

        private void Pb_Decry_MouseEnter(object sender, EventArgs e)
        {
            if (Pb_Decry.ForeColor != SystemColors.ActiveCaptionText)
            {
                Pb_Decry.ForeColor = SystemColors.Highlight;
            }
        }

        private void Pb_Encry_MouseEnter(object sender, EventArgs e)
        {
            if (Pb_Encry.ForeColor != SystemColors.ActiveCaptionText)
            {
                Pb_Encry.ForeColor = SystemColors.Highlight;
            }
        }

        private void Pb_Encry_MouseLeave(object sender, EventArgs e)
        {
            if (Pb_Encry.ForeColor == SystemColors.Highlight)
            {
                Pb_Encry.ForeColor = SystemColors.ControlDark;
            }
        }


        private void Pb_Decry_MouseLeave(object sender, EventArgs e)
        {
            if (Pb_Decry.ForeColor == SystemColors.Highlight)
            {
                Pb_Decry.ForeColor = SystemColors.ControlDark;
            }
        }

        private void Pb_Opts_MouseHover_1(object sender, EventArgs e)
        {
            Pb_Opts.ForeColor = SystemColors.ControlText;
        }

        private void Pb_Opts_MouseLeave_1(object sender, EventArgs e)
        {
            Pb_Opts.ForeColor = SystemColors.ControlDark;
        }

        #endregion

        #region New UI Elements

        #endregion

        #region ControlBox
        private void PClose_MouseEnter(object sender, EventArgs e)
        {
            PClose.BackgroundImage = Chiave.Properties.Resources.CloseHover;
        }

        private void PClose_MouseLeave(object sender, EventArgs e)
        {
            PClose.BackgroundImage = Chiave.Properties.Resources.CloseNormal;
        }

        private void PMin_MouseEnter(object sender, EventArgs e)
        {
            PMin.BackgroundImage = Chiave.Properties.Resources.MinHover;
        }

        private void PMin_MouseLeave(object sender, EventArgs e)
        {
            PMin.BackgroundImage = Chiave.Properties.Resources.MinNormal;
        }

        private void PMax_MouseEnter(object sender, EventArgs e)
        {
            if (!IsMaximized)
            {
                PMax.BackgroundImage = Chiave.Properties.Resources.MaxHover;
            }
            else
            {
                PMax.BackgroundImage = Chiave.Properties.Resources.ResHover;
            }
        }

        private void PMax_MouseLeave(object sender, EventArgs e)
        {
            if (!IsMaximized)
            {
                PMax.BackgroundImage = Chiave.Properties.Resources.MaxNormal;
            }
            else
            {
                PMax.BackgroundImage = Chiave.Properties.Resources.ResNormal;
            }

        }

        private void PClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PMax_Click(object sender, EventArgs e)
        {
            if (!IsMaximized)
            {
                PMax.BackgroundImage = Chiave.Properties.Resources.ResNormal;
                this.WindowState = FormWindowState.Maximized;
                IsMaximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                PMax.BackgroundImage = Chiave.Properties.Resources.MaxHover;
                IsMaximized = false;

            }
        }
        #endregion

        #endregion

        #region Internal Methods

        #region Load Panels

        private void BtnBack_Click(object sender, EventArgs e)
        {
            PerformClose();
        }

        public void LoadHistory()
        {
            if (Sav.GetValue("UI", "History").ToString() == "1")
            {
                Current = Mode.None;
                CurrentImage = Chiave.Properties.Resources.BluWave;
                PicStrip.BackColor = Color.DeepSkyBlue;
                Pb_Encry.ForeColor = SystemColors.ControlDark;
                Pb_Decry.ForeColor = SystemColors.ControlDark;
                Pb_Opts.ForeColor = SystemColors.ControlDark;
                Pb_His.ForeColor = SystemColors.ActiveCaptionText;

                Container.Controls.Clear();
                History HP = new History();
                HP.BackColor = Color.Transparent;
                HP.Dock = DockStyle.Fill;
                Container.Controls.Add(HP);
                HP.SendToBack();
                HP.Show();
                this.Refresh();
            }
            else
            {
                Current = Mode.None;
                CurrentImage = Chiave.Properties.Resources.BluWave;
                PicStrip.BackColor = Color.DeepSkyBlue;
                Pb_Encry.ForeColor = SystemColors.ControlDark;
                Pb_Decry.ForeColor = SystemColors.ControlDark;
                Pb_Opts.ForeColor = SystemColors.ControlDark;
                Pb_His.ForeColor = SystemColors.ActiveCaptionText;

                Container.Controls.Clear();
                this.Refresh();
            }
        }

        private void LoadEncryption(List<string> SrcList)
        {
            //IconUpdater.CancelAsync();
            FileList.Items.Clear();
            FileListIcons.Images.Clear();
            SrcFileList.Clear();
            NewFileListFromFolders.Clear();   

            Current = Mode.Encryption;
            CurrentImage = Chiave.Properties.Resources.RedWave;
            PicStrip.BackColor = Color.Red;
            Pb_Encry.ForeColor = SystemColors.ActiveCaptionText;
            Pb_Decry.ForeColor = SystemColors.ControlDark;
            Pb_Opts.ForeColor = SystemColors.ControlDark;
            Pb_His.ForeColor = SystemColors.ControlDark;

            Container.Controls.Add(PnlFiles);
            Cmd_Start.Image = Chiave.Properties.Resources.Pic_Lock;
            Cmd_Start.CommandText = "Start Encryption";
            Cmd_Start.ForeColor = Color.Brown;
            PnlFiles.Show();
            PnlFiles.BringToFront();
            this.Refresh();
            UpdateFiles(SrcList);
        }

        private void LoadDecryption(List<string> SrcList)
        {
            //IconUpdater.CancelAsync();
            FileList.Items.Clear();
            FileListIcons.Images.Clear();
            SrcFileList.Clear();
            NewFileListFromFolders.Clear();   

            Current = Mode.Decryption;
            CurrentImage = Chiave.Properties.Resources.GreenWave;
            PicStrip.BackColor = Color.SeaGreen;
            Pb_Encry.ForeColor = SystemColors.ControlDark;
            Pb_Decry.ForeColor = SystemColors.ActiveCaptionText;
            Pb_Opts.ForeColor = SystemColors.ControlDark;
            Pb_His.ForeColor = SystemColors.ControlDark;

            Container.Controls.Add(PnlFiles);
            Cmd_Start.Image = Chiave.Properties.Resources.Pic_UnLock;
            Cmd_Start.CommandText = "Start Decryption";
            Cmd_Start.ForeColor = Color.Green;
            PnlFiles.Show();
            PnlFiles.BringToFront();
            this.Refresh();
            UpdateFiles(SrcList);
        }
        private void LoadOptions()
        {
            SettingsPanel OP = new SettingsPanel();
            ShowFloatPanel(OP, "Preferences");
            OP.BackColor = Color.Transparent;
        }

        public void AllowExit()
        {
            AllowClose = true;
        }
        public void PerformClose()
        {
            BtnBack.Show();
            PnlFloatBase.Controls.Clear();
            PnlFloat.Hide();
            AllowClose = true;
        }

        public void ShowFloatPanel(Control Panel, string Title)
        {
            if (Title == "Encrypting")
            {
                BtnBack.Hide();
                AllowClose = false;
            }
            else if (Title == "Decrypting")
            {
                BtnBack.Hide();
                AllowClose = false;
            }

            LblTitle.Text = Title;
            //PnlFloat.BackgroundImage = this.BackgroundImage;
            //PnlFloat.BackgroundImageLayout = ImageLayout.Stretch;
            PnlFloat.Show();
            PnlFloat.BackColor = Color.Transparent;

            this.Controls.Add(PnlFloat);
            PnlFloat.Location = new Point(6, 40);
            PnlFloat.Size = new Size(this.Width - 12, this.Height - 46);
            PnlFloat.BringToFront();

            Panel.BackColor = Color.Transparent;
            Panel.Dock = DockStyle.Fill;
            Panel.Show();
            PnlFloatBase.Controls.Add(Panel);
        }

        public void StartProcessing(List<string> SrcFiles, string Passwrd, Chiave.ProcessPanel.Operation Modes, bool Overwrite)
        {
            if (Modes == Chiave.ProcessPanel.Operation.Encrypt)
            {
                ProcessPanel PP = new ProcessPanel(SrcFiles, Passwrd, Modes, Overwrite);
                ShowFloatPanel(PP, "Encrypting");
            }
            else if (Modes == Chiave.ProcessPanel.Operation.Decrypt)
            {
                ProcessPanel PP = new ProcessPanel(SrcFiles, Passwrd, Modes, Overwrite);
                ShowFloatPanel(PP, "Decrypting");
            }
        }

        public void ClosePanel()
        {
            PicStrip.BackColor = Color.DeepSkyBlue;
            Container.Controls.Clear();

            LoadUserInterface();
        }
        #endregion

        #region Taskbar Progress Handling
        TaskbarManager WinTaskBar = TaskbarManager.Instance;
        public void TaskBarProgressValue(int Val, int Max)
        {
            try
            {
                TaskbarManager.Instance.SetProgressValue(Val, Max);
            }
            catch { }
        }

        public void TaskBarProgressState(TaskbarProgressBarState Status)
        {
            try
            {
                TaskbarManager.Instance.SetProgressState(Status);
            }
            catch { }
        }
        #endregion

        #endregion

        #region Internal MessageBox

        public enum MessageBoxIcon
        {
            Error,
            Warning,
            Information,
            Successful,
            Question,
        }

        public enum MessageIcon
        {
            Application,
            Encryption,
            Decryption,
            Options,
            Wipe,
        }

        int iTime = 0;
        private void MsgTimer_Tick(object sender, EventArgs e)
        {
            iTime++;
            if (iTime == 15)
            {
                MsgPnl.Hide();
                iTime = 0;
                MsgTimer.Stop();

            }
        }

        public void ShowMessage(string Message, MessageBoxIcon Icon, MessageIcon MIcon, bool IsTimerEnabled, bool IsAboutBox, bool CloseButton)
        {

            if (IsTimerEnabled)
            {
                MsgTimer.Start();
            }
            if (IsAboutBox)
            {
                MsgLbl.Hide();
                PicStrips.BackColor = Color.DeepSkyBlue;

            }
            else
            {
                MsgLbl.Show();
                MsgLbl.Text = Message;

                #region MessageBoxIcon
                if (Icon == MessageBoxIcon.Error)
                {
                    PicStrips.BackColor = Color.Red;
                }

                if (Icon == MessageBoxIcon.Information)
                {
                    PicStrips.BackColor = Color.DeepSkyBlue;
                }

                if (Icon == MessageBoxIcon.Question)
                {
                    PicStrips.BackColor = Color.DeepSkyBlue;
                }

                if (Icon == MessageBoxIcon.Successful)
                {
                    PicStrips.BackColor = Color.SeaGreen;
                }

                if (Icon == MessageBoxIcon.Warning)
                {
                    PicStrips.BackColor = Color.Yellow;
                }
                #endregion

                #region MessageIcon
                {

                    if (MIcon == MessageIcon.Decryption)
                    {
                        AppLogo.BackgroundImage = Chiave.Properties.Resources.Pic_UnLock;
                    }

                    if (MIcon == MessageIcon.Encryption)
                    {
                        AppLogo.BackgroundImage = Chiave.Properties.Resources.Pic_Lock;
                    }

                    if (MIcon == MessageIcon.Options)
                    {
                        AppLogo.BackgroundImage = Chiave.Properties.Resources.Pic_Options;
                    }

                    if (MIcon == MessageIcon.Wipe)
                    {
                        AppLogo.BackColor = Color.Yellow;
                    }
                }
            }

                #endregion

            MsgPnl.Show();
            MsgPnl.BringToFront();
        }

        public void HideMessage()
        {
            MsgPnl.Hide();
        }

        #endregion

        #region Loading Process

        private void LoadUserInterface()
        {
            #region HistoryPanel

            if (!File.Exists(Application.StartupPath + "\\Config.ini"))
            {
                FileStream fsOutput = new FileStream(Application.StartupPath + "\\Config.ini", FileMode.OpenOrCreate, FileAccess.Write);
                fsOutput.Close();
                Sav.SetValue("UI", "History", "1");
            }
            LoadHistory();

            #endregion
        }
        #endregion

        #region UIFiles

        #region Control Events
        private void BckButtonFiles_Click(object sender, EventArgs e)
        {
            PnlFiles.Hide();
            ClosePanel();
        }

        ImageList FileListIcons = new ImageList();
        List<string> NewFileListFromFolders = new List<string>();
        List<string> SrcFileList = new List<string>();

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
            }
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

        private void MBtnRefresh_Click(object sender, EventArgs e)
        {
            IconUpdater.CancelAsync();
            FileList.Items.Clear();
            FileListIcons.Images.Clear();
            SrcFileList.Clear();
            NewFileListFromFolders.Clear();            
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
                if (Current == Mode.Encryption)
                {
                    AskPassword Ap = new AskPassword(MainWindow.Operation.Encrypt, SrcFileList);
                    Ap.ShowDialog();
                }
                else if (Current == Mode.Decryption)
                {
                    AskPassword Ap = new AskPassword(MainWindow.Operation.Decrypt, SrcFileList);
                    Ap.ShowDialog();
                }
            }
        }

        private void IconUpdater_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //Disabling the Controls
            PnlFiles.Enabled = false;
            Pb_Decry.Enabled = Pb_Encry.Enabled = Pb_His.Enabled = false;

            string[] Files = (string[])e.Argument;
            FileInfo NewFile;
            ListViewItem ListViewItem;
            FileList.SmallImageList = FileListIcons;

            Image Image=null;
            
                
                if (Current == Mode.Encryption)
                {
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
                else if (Current == Mode.Decryption)
                {
                    foreach (string File in Files)
                    {
                        NewFile = new FileInfo(File);
                        if (NewFile.Extension == ".enf")
                        {
                            if (Image == null)
                            {
                                Image = Icon.ExtractAssociatedIcon(File).ToBitmap();
                            }
                            FileListIcons.Images.Add(Image);
                            ListViewItem = FileList.Items.Add("", FileList.Items.Count);
                            ListViewItem.SubItems.Add(NewFile.Name);
                            ListViewItem.SubItems.Add(NewFile.FullName);
                            FileList.EnsureVisible(FileList.Items.Count - 1);
                        }
                    }
                }
                PnlFiles.Enabled = true;
            }

        private void IconUpdater_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Pb_Decry.Enabled = Pb_Encry.Enabled = Pb_His.Enabled = true;
            if (Instant)
            {
                Instant = false;
                Cmd_Start.PerformClick();
            }
        }
        #endregion

        #region Internal Methods

        public void UpdateFiles(List<string> SrcList)
        {
            if (!IconUpdater.IsBusy)
            {
                try
                {
                    IconUpdater.RunWorkerAsync(SrcList.ToArray());
                }
                catch { }
            }
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

        #endregion

        #region FileList Events

        private void FileList_DragDrop(object sender, DragEventArgs e)
        {
            //FileInfo N = null;
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
               nFileList.Add(File);
            }

            if (!IconUpdater.IsBusy)
            {
                IconUpdater.RunWorkerAsync(nFileList.ToArray());
            }          

        }

        private void FileList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
        }

        #endregion

         #endregion
    }
}
