namespace Chiave
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MsgTimer = new System.Windows.Forms.Timer(this.components);
            this.PMin = new System.Windows.Forms.PictureBox();
            this.PClose = new System.Windows.Forms.PictureBox();
            this.PMax = new System.Windows.Forms.PictureBox();
            this.LblAppTitle = new System.Windows.Forms.Label();
            this.Pb_His = new System.Windows.Forms.Label();
            this.Pb_Encry = new System.Windows.Forms.Label();
            this.Pb_Decry = new System.Windows.Forms.Label();
            this.Pb_Opts = new System.Windows.Forms.Label();
            this.PicStrip = new System.Windows.Forms.PictureBox();
            this.MsgPnl = new System.Windows.Forms.Panel();
            this.MsgLbl = new System.Windows.Forms.Label();
            this.AppLogo = new System.Windows.Forms.PictureBox();
            this.PicStrips = new System.Windows.Forms.PictureBox();
            this.PnlFloat = new System.Windows.Forms.Panel();
            this.BtnBack = new Meadows.UI.Metro.MetroToolbarButton();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlFloatBase = new System.Windows.Forms.Panel();
            this.Container = new System.Windows.Forms.Panel();
            this.PnlFiles = new System.Windows.Forms.Panel();
            this.Cmd_Start = new Meadows.UI.Aero.CommandLink();
            this.BckButtonFiles = new Meadows.UI.Metro.MetroToolbarButton();
            this.FileList = new Chiave.MetroView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.MBtnRem = new Meadows.UI.Metro.MetroToolbarButton();
            this.MBtnAdd = new Meadows.UI.Metro.MetroToolbarButton();
            this.MBtnRefresh = new Meadows.UI.Metro.MetroToolbarButton();
            this.MbtFold = new Meadows.UI.Metro.MetroToolbarButton();
            this.IconUpdater = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.PMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStrip)).BeginInit();
            this.MsgPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStrips)).BeginInit();
            this.PnlFloat.SuspendLayout();
            this.Container.SuspendLayout();
            this.PnlFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsgTimer
            // 
            this.MsgTimer.Tick += new System.EventHandler(this.MsgTimer_Tick);
            // 
            // PMin
            // 
            this.PMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PMin.BackColor = System.Drawing.Color.Transparent;
            this.PMin.BackgroundImage = global::Chiave.Properties.Resources.MinNormal;
            this.PMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PMin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PMin.Location = new System.Drawing.Point(783, 17);
            this.PMin.Name = "PMin";
            this.PMin.Size = new System.Drawing.Size(17, 14);
            this.PMin.TabIndex = 36;
            this.PMin.TabStop = false;
            this.PMin.Click += new System.EventHandler(this.PMin_Click);
            this.PMin.MouseEnter += new System.EventHandler(this.PMin_MouseEnter);
            this.PMin.MouseLeave += new System.EventHandler(this.PMin_MouseLeave);
            // 
            // PClose
            // 
            this.PClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PClose.BackColor = System.Drawing.Color.Transparent;
            this.PClose.BackgroundImage = global::Chiave.Properties.Resources.CloseNormal;
            this.PClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PClose.Location = new System.Drawing.Point(823, 12);
            this.PClose.Name = "PClose";
            this.PClose.Size = new System.Drawing.Size(15, 15);
            this.PClose.TabIndex = 35;
            this.PClose.TabStop = false;
            this.PClose.Click += new System.EventHandler(this.PClose_Click);
            this.PClose.MouseEnter += new System.EventHandler(this.PClose_MouseEnter);
            this.PClose.MouseLeave += new System.EventHandler(this.PClose_MouseLeave);
            // 
            // PMax
            // 
            this.PMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PMax.BackColor = System.Drawing.Color.Transparent;
            this.PMax.BackgroundImage = global::Chiave.Properties.Resources.MaxNormal;
            this.PMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PMax.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PMax.Location = new System.Drawing.Point(803, 13);
            this.PMax.Name = "PMax";
            this.PMax.Size = new System.Drawing.Size(15, 13);
            this.PMax.TabIndex = 37;
            this.PMax.TabStop = false;
            this.PMax.Click += new System.EventHandler(this.PMax_Click);
            this.PMax.MouseEnter += new System.EventHandler(this.PMax_MouseEnter);
            this.PMax.MouseLeave += new System.EventHandler(this.PMax_MouseLeave);
            // 
            // LblAppTitle
            // 
            this.LblAppTitle.AutoSize = true;
            this.LblAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblAppTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblAppTitle.Font = new System.Drawing.Font("Segoe UI Light", 19.5F);
            this.LblAppTitle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblAppTitle.Location = new System.Drawing.Point(6, 4);
            this.LblAppTitle.Name = "LblAppTitle";
            this.LblAppTitle.Size = new System.Drawing.Size(108, 36);
            this.LblAppTitle.TabIndex = 39;
            this.LblAppTitle.Text = "Chiave 2";
            // 
            // Pb_His
            // 
            this.Pb_His.AutoSize = true;
            this.Pb_His.BackColor = System.Drawing.Color.Transparent;
            this.Pb_His.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pb_His.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pb_His.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pb_His.Location = new System.Drawing.Point(22, 50);
            this.Pb_His.Name = "Pb_His";
            this.Pb_His.Size = new System.Drawing.Size(117, 23);
            this.Pb_His.TabIndex = 41;
            this.Pb_His.Text = "RECENT FILES";
            this.Pb_His.Click += new System.EventHandler(this.Pb_His_Click);
            this.Pb_His.MouseEnter += new System.EventHandler(this.Pb_His_MouseEnter);
            this.Pb_His.MouseLeave += new System.EventHandler(this.Pb_His_MouseLeave);
            // 
            // Pb_Encry
            // 
            this.Pb_Encry.AutoSize = true;
            this.Pb_Encry.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Encry.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pb_Encry.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pb_Encry.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Pb_Encry.Location = new System.Drawing.Point(145, 50);
            this.Pb_Encry.Name = "Pb_Encry";
            this.Pb_Encry.Size = new System.Drawing.Size(83, 23);
            this.Pb_Encry.TabIndex = 42;
            this.Pb_Encry.Text = "ENCRYPT";
            this.Pb_Encry.Click += new System.EventHandler(this.Pb_Encry_Click);
            this.Pb_Encry.MouseEnter += new System.EventHandler(this.Pb_Encry_MouseEnter);
            this.Pb_Encry.MouseLeave += new System.EventHandler(this.Pb_Encry_MouseLeave);
            // 
            // Pb_Decry
            // 
            this.Pb_Decry.AutoSize = true;
            this.Pb_Decry.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Decry.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pb_Decry.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pb_Decry.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Pb_Decry.Location = new System.Drawing.Point(234, 50);
            this.Pb_Decry.Name = "Pb_Decry";
            this.Pb_Decry.Size = new System.Drawing.Size(82, 23);
            this.Pb_Decry.TabIndex = 43;
            this.Pb_Decry.Text = "DECRYPT";
            this.Pb_Decry.Click += new System.EventHandler(this.Pb_Decry_Click);
            this.Pb_Decry.MouseEnter += new System.EventHandler(this.Pb_Decry_MouseEnter);
            this.Pb_Decry.MouseLeave += new System.EventHandler(this.Pb_Decry_MouseLeave);
            // 
            // Pb_Opts
            // 
            this.Pb_Opts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pb_Opts.AutoSize = true;
            this.Pb_Opts.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Opts.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pb_Opts.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pb_Opts.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Pb_Opts.Location = new System.Drawing.Point(762, 50);
            this.Pb_Opts.Name = "Pb_Opts";
            this.Pb_Opts.Size = new System.Drawing.Size(78, 13);
            this.Pb_Opts.TabIndex = 44;
            this.Pb_Opts.Text = "PREFERENCES";
            this.Pb_Opts.Click += new System.EventHandler(this.Pb_Opts_Click);
            this.Pb_Opts.MouseLeave += new System.EventHandler(this.Pb_Opts_MouseLeave_1);
            this.Pb_Opts.MouseHover += new System.EventHandler(this.Pb_Opts_MouseHover_1);
            // 
            // PicStrip
            // 
            this.PicStrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.PicStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicStrip.Location = new System.Drawing.Point(16, 1);
            this.PicStrip.Name = "PicStrip";
            this.PicStrip.Size = new System.Drawing.Size(86, 5);
            this.PicStrip.TabIndex = 38;
            this.PicStrip.TabStop = false;
            // 
            // MsgPnl
            // 
            this.MsgPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MsgPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MsgPnl.Controls.Add(this.MsgLbl);
            this.MsgPnl.Controls.Add(this.AppLogo);
            this.MsgPnl.Controls.Add(this.PicStrips);
            this.MsgPnl.Location = new System.Drawing.Point(502, 512);
            this.MsgPnl.Name = "MsgPnl";
            this.MsgPnl.Size = new System.Drawing.Size(342, 63);
            this.MsgPnl.TabIndex = 19;
            this.MsgPnl.Visible = false;
            // 
            // MsgLbl
            // 
            this.MsgLbl.AutoEllipsis = true;
            this.MsgLbl.AutoSize = true;
            this.MsgLbl.BackColor = System.Drawing.Color.Transparent;
            this.MsgLbl.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Italic);
            this.MsgLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MsgLbl.Location = new System.Drawing.Point(49, 21);
            this.MsgLbl.Name = "MsgLbl";
            this.MsgLbl.Size = new System.Drawing.Size(23, 21);
            this.MsgLbl.TabIndex = 20;
            this.MsgLbl.Text = "M";
            // 
            // AppLogo
            // 
            this.AppLogo.BackColor = System.Drawing.Color.Transparent;
            this.AppLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AppLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppLogo.ErrorImage = null;
            this.AppLogo.Location = new System.Drawing.Point(7, 11);
            this.AppLogo.Name = "AppLogo";
            this.AppLogo.Size = new System.Drawing.Size(36, 36);
            this.AppLogo.TabIndex = 19;
            this.AppLogo.TabStop = false;
            // 
            // PicStrips
            // 
            this.PicStrips.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PicStrips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicStrips.Location = new System.Drawing.Point(7, -6);
            this.PicStrips.Name = "PicStrips";
            this.PicStrips.Size = new System.Drawing.Size(64, 11);
            this.PicStrips.TabIndex = 11;
            this.PicStrips.TabStop = false;
            // 
            // PnlFloat
            // 
            this.PnlFloat.Controls.Add(this.BtnBack);
            this.PnlFloat.Controls.Add(this.LblTitle);
            this.PnlFloat.Controls.Add(this.PnlFloatBase);
            this.PnlFloat.Location = new System.Drawing.Point(690, 3);
            this.PnlFloat.Name = "PnlFloat";
            this.PnlFloat.Size = new System.Drawing.Size(37, 59);
            this.PnlFloat.TabIndex = 0;
            this.PnlFloat.Visible = false;
            // 
            // BtnBack
            // 
            this.BtnBack.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.BtnBack.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Previous;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Image = ((System.Drawing.Bitmap)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(0, 9);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.ShowOuterCircle = true;
            this.BtnBack.Size = new System.Drawing.Size(40, 40);
            this.BtnBack.TabIndex = 57;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Light", 19.5F);
            this.LblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTitle.Location = new System.Drawing.Point(46, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(108, 36);
            this.LblTitle.TabIndex = 45;
            this.LblTitle.Text = "Chiave 2";
            // 
            // PnlFloatBase
            // 
            this.PnlFloatBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlFloatBase.BackColor = System.Drawing.Color.Transparent;
            this.PnlFloatBase.Location = new System.Drawing.Point(1, 51);
            this.PnlFloatBase.Name = "PnlFloatBase";
            this.PnlFloatBase.Size = new System.Drawing.Size(34, 7);
            this.PnlFloatBase.TabIndex = 1;
            // 
            // Container
            // 
            this.Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Container.AutoScroll = true;
            this.Container.AutoSize = true;
            this.Container.BackColor = System.Drawing.Color.Transparent;
            this.Container.Controls.Add(this.PnlFiles);
            this.Container.Controls.Add(this.PnlFloat);
            this.Container.Location = new System.Drawing.Point(6, 75);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(837, 497);
            this.Container.TabIndex = 13;
            // 
            // PnlFiles
            // 
            this.PnlFiles.Controls.Add(this.Cmd_Start);
            this.PnlFiles.Controls.Add(this.BckButtonFiles);
            this.PnlFiles.Controls.Add(this.FileList);
            this.PnlFiles.Controls.Add(this.label5);
            this.PnlFiles.Controls.Add(this.MBtnRem);
            this.PnlFiles.Controls.Add(this.MBtnAdd);
            this.PnlFiles.Controls.Add(this.MBtnRefresh);
            this.PnlFiles.Controls.Add(this.MbtFold);
            this.PnlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFiles.Location = new System.Drawing.Point(0, 0);
            this.PnlFiles.Name = "PnlFiles";
            this.PnlFiles.Size = new System.Drawing.Size(837, 497);
            this.PnlFiles.TabIndex = 1;
            // 
            // Cmd_Start
            // 
            this.Cmd_Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmd_Start.CommandText = "Start Encryption";
            this.Cmd_Start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Start.ForeColor = System.Drawing.Color.Brown;
            this.Cmd_Start.Image = global::Chiave.Properties.Resources.Pic_Lock;
            this.Cmd_Start.ImageScalingSize = new System.Drawing.Size(23, 26);
            this.Cmd_Start.ImageVerticalAlign = Meadows.UI.Aero.CommandLink.VerticalAlign.Middle;
            this.Cmd_Start.Location = new System.Drawing.Point(102, 413);
            this.Cmd_Start.Name = "Cmd_Start";
            this.Cmd_Start.NoteText = "Add the File(s) and Click \'Start Encryption\' to proceed.";
            this.Cmd_Start.Size = new System.Drawing.Size(669, 80);
            this.Cmd_Start.TabIndex = 48;
            this.Cmd_Start.Click += new System.EventHandler(this.Cmd_Start_Click);
            // 
            // BckButtonFiles
            // 
            this.BckButtonFiles.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.BckButtonFiles.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Previous;
            this.BckButtonFiles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BckButtonFiles.Image = ((System.Drawing.Bitmap)(resources.GetObject("BckButtonFiles.Image")));
            this.BckButtonFiles.Location = new System.Drawing.Point(0, 9);
            this.BckButtonFiles.Name = "BckButtonFiles";
            this.BckButtonFiles.ShowOuterCircle = true;
            this.BckButtonFiles.Size = new System.Drawing.Size(40, 40);
            this.BckButtonFiles.TabIndex = 47;
            this.BckButtonFiles.Click += new System.EventHandler(this.BckButtonFiles_Click);
            // 
            // FileList
            // 
            this.FileList.AllowDrop = true;
            this.FileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.FileList.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FileList.FullRowSelect = true;
            this.FileList.Location = new System.Drawing.Point(102, 6);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(669, 400);
            this.FileList.TabIndex = 46;
            this.FileList.UseCompatibleStateImageBehavior = false;
            this.FileList.View = System.Windows.Forms.View.Details;
            this.FileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileList_DragDrop);
            this.FileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileList_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Path";
            this.columnHeader3.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "files:";
            // 
            // MBtnRem
            // 
            this.MBtnRem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MBtnRem.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.MBtnRem.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Remove;
            this.MBtnRem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBtnRem.Image = ((System.Drawing.Bitmap)(resources.GetObject("MBtnRem.Image")));
            this.MBtnRem.Location = new System.Drawing.Point(786, 324);
            this.MBtnRem.Name = "MBtnRem";
            this.MBtnRem.ShowOuterCircle = true;
            this.MBtnRem.Size = new System.Drawing.Size(38, 38);
            this.MBtnRem.TabIndex = 43;
            this.MBtnRem.Click += new System.EventHandler(this.MBtnRem_Click);
            // 
            // MBtnAdd
            // 
            this.MBtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MBtnAdd.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.MBtnAdd.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Add;
            this.MBtnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBtnAdd.Image = ((System.Drawing.Bitmap)(resources.GetObject("MBtnAdd.Image")));
            this.MBtnAdd.Location = new System.Drawing.Point(786, 6);
            this.MBtnAdd.Name = "MBtnAdd";
            this.MBtnAdd.ShowOuterCircle = true;
            this.MBtnAdd.Size = new System.Drawing.Size(38, 38);
            this.MBtnAdd.TabIndex = 40;
            this.MBtnAdd.Click += new System.EventHandler(this.MBtnAdd_Click);
            // 
            // MBtnRefresh
            // 
            this.MBtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MBtnRefresh.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.MBtnRefresh.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Refresh;
            this.MBtnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBtnRefresh.Image = ((System.Drawing.Bitmap)(resources.GetObject("MBtnRefresh.Image")));
            this.MBtnRefresh.Location = new System.Drawing.Point(786, 368);
            this.MBtnRefresh.Name = "MBtnRefresh";
            this.MBtnRefresh.ShowOuterCircle = true;
            this.MBtnRefresh.Size = new System.Drawing.Size(38, 38);
            this.MBtnRefresh.TabIndex = 42;
            this.MBtnRefresh.Click += new System.EventHandler(this.MBtnRefresh_Click);
            // 
            // MbtFold
            // 
            this.MbtFold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MbtFold.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.MbtFold.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Folder;
            this.MbtFold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MbtFold.Image = ((System.Drawing.Bitmap)(resources.GetObject("MbtFold.Image")));
            this.MbtFold.Location = new System.Drawing.Point(786, 50);
            this.MbtFold.Name = "MbtFold";
            this.MbtFold.ShowOuterCircle = true;
            this.MbtFold.Size = new System.Drawing.Size(38, 38);
            this.MbtFold.TabIndex = 41;
            this.MbtFold.Click += new System.EventHandler(this.MbtFold_Click);
            // 
            // IconUpdater
            // 
            this.IconUpdater.WorkerSupportsCancellation = true;
            this.IconUpdater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.IconUpdater_DoWork);
            this.IconUpdater.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.IconUpdater_RunWorkerCompleted);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(850, 580);
            this.ControlBox = false;
            this.Controls.Add(this.PicStrip);
            this.Controls.Add(this.Pb_Decry);
            this.Controls.Add(this.Pb_Encry);
            this.Controls.Add(this.Pb_His);
            this.Controls.Add(this.PMax);
            this.Controls.Add(this.PMin);
            this.Controls.Add(this.Pb_Opts);
            this.Controls.Add(this.PClose);
            this.Controls.Add(this.MsgPnl);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.LblAppTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 580);
            this.Name = "MainWindow";
            this.Text = "Chiave 2";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStrip)).EndInit();
            this.MsgPnl.ResumeLayout(false);
            this.MsgPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStrips)).EndInit();
            this.PnlFloat.ResumeLayout(false);
            this.PnlFloat.PerformLayout();
            this.Container.ResumeLayout(false);
            this.PnlFiles.ResumeLayout(false);
            this.PnlFiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MsgTimer;
        private System.Windows.Forms.PictureBox PMin;
        private System.Windows.Forms.PictureBox PClose;
        private System.Windows.Forms.PictureBox PMax;
        private System.Windows.Forms.Label LblAppTitle;
        private System.Windows.Forms.Label Pb_His;
        private System.Windows.Forms.Label Pb_Encry;
        private System.Windows.Forms.Label Pb_Decry;
        private System.Windows.Forms.Label Pb_Opts;
        private System.Windows.Forms.PictureBox PicStrip;
        private System.Windows.Forms.Panel MsgPnl;
        private System.Windows.Forms.Label MsgLbl;
        private System.Windows.Forms.PictureBox AppLogo;
        private System.Windows.Forms.PictureBox PicStrips;
        private System.Windows.Forms.Panel PnlFloat;
        private Meadows.UI.Metro.MetroToolbarButton BtnBack;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel PnlFloatBase;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel PnlFiles;
        private Meadows.UI.Aero.CommandLink Cmd_Start;
        private Meadows.UI.Metro.MetroToolbarButton BckButtonFiles;
        private MetroView FileList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private Meadows.UI.Metro.MetroToolbarButton MBtnRem;
        private Meadows.UI.Metro.MetroToolbarButton MBtnAdd;
        private Meadows.UI.Metro.MetroToolbarButton MBtnRefresh;
        private Meadows.UI.Metro.MetroToolbarButton MbtFold;
        private System.ComponentModel.BackgroundWorker IconUpdater;
    }
}