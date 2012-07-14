namespace Chiave
{
    partial class DecryptionPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptionPanel));
            this.PanelCtrls = new System.Windows.Forms.Panel();
            this.BtnBack = new Meadows.UI.Metro.MetroToolbarButton();
            this.CmdStart = new Meadows.UI.Aero.CommandLink();
            this.FileList = new Chiave.MetroView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.MBtnClear = new Meadows.UI.Metro.MetroToolbarButton();
            this.MBtnRem = new Meadows.UI.Metro.MetroToolbarButton();
            this.MBtnAdd = new Meadows.UI.Metro.MetroToolbarButton();
            this.MBtnRefresh = new Meadows.UI.Metro.MetroToolbarButton();
            this.MbtFold = new Meadows.UI.Metro.MetroToolbarButton();
            this.IconUpdater = new System.ComponentModel.BackgroundWorker();
            this.PanelCtrls.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCtrls
            // 
            this.PanelCtrls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelCtrls.BackColor = System.Drawing.Color.Transparent;
            this.PanelCtrls.Controls.Add(this.BtnBack);
            this.PanelCtrls.Controls.Add(this.CmdStart);
            this.PanelCtrls.Controls.Add(this.FileList);
            this.PanelCtrls.Controls.Add(this.label5);
            this.PanelCtrls.Location = new System.Drawing.Point(0, 6);
            this.PanelCtrls.Name = "PanelCtrls";
            this.PanelCtrls.Size = new System.Drawing.Size(670, 497);
            this.PanelCtrls.TabIndex = 14;
            // 
            // BtnBack
            // 
            this.BtnBack.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.BtnBack.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Previous;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Image = ((System.Drawing.Bitmap)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(0, 0);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.ShowOuterCircle = true;
            this.BtnBack.Size = new System.Drawing.Size(40, 40);
            this.BtnBack.TabIndex = 34;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // CmdStart
            // 
            this.CmdStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdStart.CommandText = "Start Decryption";
            this.CmdStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStart.ForeColor = System.Drawing.Color.Green;
            this.CmdStart.Image = global::Chiave.Properties.Resources.Pic_UnLock;
            this.CmdStart.ImageScalingSize = new System.Drawing.Size(23, 26);
            this.CmdStart.ImageVerticalAlign = Meadows.UI.Aero.CommandLink.VerticalAlign.Middle;
            this.CmdStart.Location = new System.Drawing.Point(95, 409);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.NoteText = "Add the File(s) and Click \'Start Decryption\' to proceed.";
            this.CmdStart.Size = new System.Drawing.Size(563, 76);
            this.CmdStart.TabIndex = 33;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
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
            this.FileList.Location = new System.Drawing.Point(95, 3);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(563, 400);
            this.FileList.TabIndex = 19;
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
            this.label5.Location = new System.Drawing.Point(51, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "files:";
            // 
            // MBtnClear
            // 
            this.MBtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MBtnClear.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.MBtnClear.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Delete;
            this.MBtnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBtnClear.Image = ((System.Drawing.Bitmap)(resources.GetObject("MBtnClear.Image")));
            this.MBtnClear.Location = new System.Drawing.Point(689, 371);
            this.MBtnClear.Name = "MBtnClear";
            this.MBtnClear.ShowOuterCircle = true;
            this.MBtnClear.Size = new System.Drawing.Size(38, 38);
            this.MBtnClear.TabIndex = 43;
            this.MBtnClear.Click += new System.EventHandler(this.MBtnClear_Click);
            // 
            // MBtnRem
            // 
            this.MBtnRem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MBtnRem.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.MBtnRem.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Remove;
            this.MBtnRem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBtnRem.Image = ((System.Drawing.Bitmap)(resources.GetObject("MBtnRem.Image")));
            this.MBtnRem.Location = new System.Drawing.Point(689, 327);
            this.MBtnRem.Name = "MBtnRem";
            this.MBtnRem.ShowOuterCircle = true;
            this.MBtnRem.Size = new System.Drawing.Size(38, 38);
            this.MBtnRem.TabIndex = 42;
            this.MBtnRem.Click += new System.EventHandler(this.MBtnRem_Click);
            // 
            // MBtnAdd
            // 
            this.MBtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MBtnAdd.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.MBtnAdd.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Add;
            this.MBtnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBtnAdd.Image = ((System.Drawing.Bitmap)(resources.GetObject("MBtnAdd.Image")));
            this.MBtnAdd.Location = new System.Drawing.Point(689, 9);
            this.MBtnAdd.Name = "MBtnAdd";
            this.MBtnAdd.ShowOuterCircle = true;
            this.MBtnAdd.Size = new System.Drawing.Size(38, 38);
            this.MBtnAdd.TabIndex = 39;
            this.MBtnAdd.Click += new System.EventHandler(this.MBtnAdd_Click);
            // 
            // MBtnRefresh
            // 
            this.MBtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MBtnRefresh.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.MBtnRefresh.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Refresh;
            this.MBtnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBtnRefresh.Image = ((System.Drawing.Bitmap)(resources.GetObject("MBtnRefresh.Image")));
            this.MBtnRefresh.Location = new System.Drawing.Point(689, 97);
            this.MBtnRefresh.Name = "MBtnRefresh";
            this.MBtnRefresh.ShowOuterCircle = true;
            this.MBtnRefresh.Size = new System.Drawing.Size(38, 38);
            this.MBtnRefresh.TabIndex = 41;
            this.MBtnRefresh.Click += new System.EventHandler(this.MBtnRefresh_Click);
            // 
            // MbtFold
            // 
            this.MbtFold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MbtFold.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.MbtFold.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Folder;
            this.MbtFold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MbtFold.Image = ((System.Drawing.Bitmap)(resources.GetObject("MbtFold.Image")));
            this.MbtFold.Location = new System.Drawing.Point(689, 53);
            this.MbtFold.Name = "MbtFold";
            this.MbtFold.ShowOuterCircle = true;
            this.MbtFold.Size = new System.Drawing.Size(38, 38);
            this.MbtFold.TabIndex = 40;
            this.MbtFold.Click += new System.EventHandler(this.MbtFold_Click);
            // 
            // IconUpdater
            // 
            this.IconUpdater.WorkerSupportsCancellation = true;
            this.IconUpdater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.IconUpdater_DoWork);
            this.IconUpdater.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.IconUpdater_RunWorkerCompleted);
            // 
            // DecryptionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MBtnClear);
            this.Controls.Add(this.PanelCtrls);
            this.Controls.Add(this.MBtnRem);
            this.Controls.Add(this.MBtnAdd);
            this.Controls.Add(this.MbtFold);
            this.Controls.Add(this.MBtnRefresh);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DecryptionPanel";
            this.Size = new System.Drawing.Size(739, 506);
            this.PanelCtrls.ResumeLayout(false);
            this.PanelCtrls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCtrls;
        //private System.Windows.Forms.ListView FileList;
        private Chiave.MetroView FileList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private Meadows.UI.Aero.CommandLink CmdStart;
        private System.ComponentModel.BackgroundWorker IconUpdater;
        private Meadows.UI.Metro.MetroToolbarButton BtnBack;
        private Meadows.UI.Metro.MetroToolbarButton MBtnClear;
        private Meadows.UI.Metro.MetroToolbarButton MBtnRem;
        private Meadows.UI.Metro.MetroToolbarButton MBtnAdd;
        private Meadows.UI.Metro.MetroToolbarButton MBtnRefresh;
        private Meadows.UI.Metro.MetroToolbarButton MbtFold;
    }
}
