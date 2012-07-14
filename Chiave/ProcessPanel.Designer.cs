namespace Chiave
{
    partial class ProcessPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessPanel));
            this.LblProgress = new System.Windows.Forms.Label();
            this.LblFileName = new System.Windows.Forms.Label();
            this.LblRemaining = new System.Windows.Forms.Label();
            this.PnlCtrls = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnPause = new Meadows.UI.Metro.MetroToolbarButton();
            this.MbtnCancel = new Meadows.UI.Metro.MetroToolbarButton();
            this.PbIcon = new System.Windows.Forms.PictureBox();
            this.PicBack = new System.Windows.Forms.PictureBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.ProcessWorker = new System.ComponentModel.BackgroundWorker();
            this.LnkSummary = new System.Windows.Forms.LinkLabel();
            this.PrgCurrent = new Meadows.UI.Metro.MetroProgress();
            this.BtnOk = new Meadows.UI.Metro.MetroToolbarButton();
            this.FileList = new Chiave.MetroView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlCtrls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProgress
            // 
            this.LblProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblProgress.AutoSize = true;
            this.LblProgress.BackColor = System.Drawing.Color.Transparent;
            this.LblProgress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblProgress.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProgress.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LblProgress.Location = new System.Drawing.Point(257, 400);
            this.LblProgress.Name = "LblProgress";
            this.LblProgress.Size = new System.Drawing.Size(222, 40);
            this.LblProgress.TabIndex = 46;
            this.LblProgress.Text = "Completed 00%";
            // 
            // LblFileName
            // 
            this.LblFileName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblFileName.AutoSize = true;
            this.LblFileName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFileName.Location = new System.Drawing.Point(247, 116);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(240, 20);
            this.LblFileName.TabIndex = 48;
            this.LblFileName.Text = "E:\\Gone\\Sathya\\Wind\\Chiave 2.exe";
            // 
            // LblRemaining
            // 
            this.LblRemaining.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblRemaining.AutoSize = true;
            this.LblRemaining.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRemaining.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LblRemaining.Location = new System.Drawing.Point(269, 375);
            this.LblRemaining.Name = "LblRemaining";
            this.LblRemaining.Size = new System.Drawing.Size(199, 25);
            this.LblRemaining.TabIndex = 51;
            this.LblRemaining.Text = "Encrypted 00 of 00 files";
            // 
            // PnlCtrls
            // 
            this.PnlCtrls.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PnlCtrls.Controls.Add(this.BtnPause);
            this.PnlCtrls.Controls.Add(this.MbtnCancel);
            this.PnlCtrls.Location = new System.Drawing.Point(322, 195);
            this.PnlCtrls.Name = "PnlCtrls";
            this.PnlCtrls.Size = new System.Drawing.Size(93, 44);
            this.PnlCtrls.TabIndex = 54;
            // 
            // BtnPause
            // 
            this.BtnPause.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.BtnPause.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Pause;
            this.BtnPause.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPause.Image = ((System.Drawing.Bitmap)(resources.GetObject("BtnPause.Image")));
            this.BtnPause.Location = new System.Drawing.Point(3, 3);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.ShowOuterCircle = true;
            this.BtnPause.Size = new System.Drawing.Size(40, 40);
            this.BtnPause.TabIndex = 60;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // MbtnCancel
            // 
            this.MbtnCancel.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.MbtnCancel.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Cancel;
            this.MbtnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MbtnCancel.Image = ((System.Drawing.Bitmap)(resources.GetObject("MbtnCancel.Image")));
            this.MbtnCancel.Location = new System.Drawing.Point(49, 3);
            this.MbtnCancel.Name = "MbtnCancel";
            this.MbtnCancel.ShowOuterCircle = true;
            this.MbtnCancel.Size = new System.Drawing.Size(40, 40);
            this.MbtnCancel.TabIndex = 61;
            this.MbtnCancel.Click += new System.EventHandler(this.MbtnCancel_Click);
            // 
            // PbIcon
            // 
            this.PbIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PbIcon.BackColor = System.Drawing.Color.Transparent;
            this.PbIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbIcon.BackgroundImage")));
            this.PbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbIcon.Location = new System.Drawing.Point(205, 108);
            this.PbIcon.Name = "PbIcon";
            this.PbIcon.Size = new System.Drawing.Size(36, 38);
            this.PbIcon.TabIndex = 49;
            this.PbIcon.TabStop = false;
            // 
            // PicBack
            // 
            this.PicBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PicBack.BackColor = System.Drawing.Color.Transparent;
            this.PicBack.BackgroundImage = global::Chiave.Properties.Resources.Pic_Lock;
            this.PicBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBack.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PicBack.Location = new System.Drawing.Point(330, 5);
            this.PicBack.Name = "PicBack";
            this.PicBack.Size = new System.Drawing.Size(77, 86);
            this.PicBack.TabIndex = 47;
            this.PicBack.TabStop = false;
            // 
            // LblStatus
            // 
            this.LblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblStatus.AutoSize = true;
            this.LblStatus.BackColor = System.Drawing.Color.Transparent;
            this.LblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblStatus.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.LblStatus.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LblStatus.Location = new System.Drawing.Point(275, 115);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(186, 32);
            this.LblStatus.TabIndex = 55;
            this.LblStatus.Text = "Completed 00%";
            this.LblStatus.Visible = false;
            // 
            // ProcessWorker
            // 
            this.ProcessWorker.WorkerReportsProgress = true;
            this.ProcessWorker.WorkerSupportsCancellation = true;
            this.ProcessWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ProcessWorker_DoWork);
            this.ProcessWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ProcessWorker_ProgressChanged);
            this.ProcessWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ProcessWorker_RunWorkerCompleted);
            // 
            // LnkSummary
            // 
            this.LnkSummary.ActiveLinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LnkSummary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LnkSummary.AutoSize = true;
            this.LnkSummary.BackColor = System.Drawing.Color.Transparent;
            this.LnkSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkSummary.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LnkSummary.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkSummary.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LnkSummary.Location = new System.Drawing.Point(311, 158);
            this.LnkSummary.Name = "LnkSummary";
            this.LnkSummary.Size = new System.Drawing.Size(111, 20);
            this.LnkSummary.TabIndex = 56;
            this.LnkSummary.TabStop = true;
            this.LnkSummary.Text = "Show Summary";
            this.LnkSummary.Visible = false;
            this.LnkSummary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSummary_LinkClicked);
            // 
            // PrgCurrent
            // 
            this.PrgCurrent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PrgCurrent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrgCurrent.BorderColor = System.Drawing.Color.FloralWhite;
            this.PrgCurrent.BorderSize = 1;
            this.PrgCurrent.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrgCurrent.ForeColor = System.Drawing.Color.Firebrick;
            this.PrgCurrent.Location = new System.Drawing.Point(243, 167);
            this.PrgCurrent.MaximumValue = 100F;
            this.PrgCurrent.MinimumValue = 0F;
            this.PrgCurrent.Name = "PrgCurrent";
            this.PrgCurrent.Orientation = Meadows.UI.Metro.MetroProgress.Orientations.Horizontal;
            this.PrgCurrent.PostText = null;
            this.PrgCurrent.PreText = null;
            this.PrgCurrent.ProgressStyle = Meadows.UI.Metro.MetroProgress.ProgressStyles.ProgressBar;
            this.PrgCurrent.Size = new System.Drawing.Size(250, 10);
            this.PrgCurrent.TabIndex = 58;
            this.PrgCurrent.Value = 0F;
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnOk.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.BtnOk.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Check;
            this.BtnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.Image = ((System.Drawing.Bitmap)(resources.GetObject("BtnOk.Image")));
            this.BtnOk.Location = new System.Drawing.Point(348, 383);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.ShowOuterCircle = true;
            this.BtnOk.Size = new System.Drawing.Size(40, 40);
            this.BtnOk.TabIndex = 62;
            this.BtnOk.Visible = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FileList
            // 
            this.FileList.AllowDrop = true;
            this.FileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.FileList.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FileList.FullRowSelect = true;
            this.FileList.Location = new System.Drawing.Point(87, 254);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(562, 130);
            this.FileList.TabIndex = 57;
            this.FileList.UseCompatibleStateImageBehavior = false;
            this.FileList.View = System.Windows.Forms.View.Details;
            this.FileList.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File Name";
            this.columnHeader2.Width = 427;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Result";
            this.columnHeader3.Width = 102;
            // 
            // ProcessPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.PrgCurrent);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.LnkSummary);
            this.Controls.Add(this.PnlCtrls);
            this.Controls.Add(this.LblRemaining);
            this.Controls.Add(this.PbIcon);
            this.Controls.Add(this.LblFileName);
            this.Controls.Add(this.PicBack);
            this.Controls.Add(this.LblProgress);
            this.Controls.Add(this.LblStatus);
            this.Name = "ProcessPanel";
            this.Size = new System.Drawing.Size(736, 450);
            this.Load += new System.EventHandler(this.ProcessPanel_Load);
            this.PnlCtrls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProgress;
        private System.Windows.Forms.PictureBox PicBack;
        private System.Windows.Forms.Label LblFileName;
        private System.Windows.Forms.PictureBox PbIcon;
        private System.Windows.Forms.Label LblRemaining;
        private System.Windows.Forms.FlowLayoutPanel PnlCtrls;
        private System.Windows.Forms.Label LblStatus;
        private System.ComponentModel.BackgroundWorker ProcessWorker;
        private System.Windows.Forms.LinkLabel LnkSummary;
        private MetroView FileList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Meadows.UI.Metro.MetroProgress PrgCurrent;
        private Meadows.UI.Metro.MetroToolbarButton BtnPause;
        private Meadows.UI.Metro.MetroToolbarButton MbtnCancel;
        private Meadows.UI.Metro.MetroToolbarButton BtnOk;
    }
}
