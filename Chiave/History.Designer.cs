namespace Chiave
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.SplitHistory = new System.Windows.Forms.SplitContainer();
            this.BERemove = new Meadows.UI.Metro.MetroToolbarButton();
            this.BEOpen = new Meadows.UI.Metro.MetroToolbarButton();
            this.BEncClear = new Meadows.UI.Metro.MetroToolbarButton();
            this.MsgLblE = new System.Windows.Forms.Label();
            this.EList = new System.Windows.Forms.ListBox();
            this.LblEnc = new System.Windows.Forms.Label();
            this.BDRemove = new Meadows.UI.Metro.MetroToolbarButton();
            this.BDOpen = new Meadows.UI.Metro.MetroToolbarButton();
            this.BDecClear = new Meadows.UI.Metro.MetroToolbarButton();
            this.MsgLblD = new System.Windows.Forms.Label();
            this.DList = new System.Windows.Forms.ListBox();
            this.LblDec = new System.Windows.Forms.Label();
            this.ChkHistory = new System.Windows.Forms.CheckBox();
            this.MsgLbl = new System.Windows.Forms.Label();
            this.SplitHistory.Panel1.SuspendLayout();
            this.SplitHistory.Panel2.SuspendLayout();
            this.SplitHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitHistory
            // 
            this.SplitHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitHistory.Location = new System.Drawing.Point(12, 28);
            this.SplitHistory.Name = "SplitHistory";
            // 
            // SplitHistory.Panel1
            // 
            this.SplitHistory.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.SplitHistory.Panel1.Controls.Add(this.BERemove);
            this.SplitHistory.Panel1.Controls.Add(this.BEOpen);
            this.SplitHistory.Panel1.Controls.Add(this.BEncClear);
            this.SplitHistory.Panel1.Controls.Add(this.MsgLblE);
            this.SplitHistory.Panel1.Controls.Add(this.EList);
            this.SplitHistory.Panel1.Controls.Add(this.LblEnc);
            // 
            // SplitHistory.Panel2
            // 
            this.SplitHistory.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.SplitHistory.Panel2.Controls.Add(this.BDRemove);
            this.SplitHistory.Panel2.Controls.Add(this.BDOpen);
            this.SplitHistory.Panel2.Controls.Add(this.BDecClear);
            this.SplitHistory.Panel2.Controls.Add(this.MsgLblD);
            this.SplitHistory.Panel2.Controls.Add(this.DList);
            this.SplitHistory.Panel2.Controls.Add(this.LblDec);
            this.SplitHistory.Size = new System.Drawing.Size(745, 324);
            this.SplitHistory.SplitterDistance = 371;
            this.SplitHistory.TabIndex = 2;
            // 
            // BERemove
            // 
            this.BERemove.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.BERemove.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Remove;
            this.BERemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BERemove.Image = ((System.Drawing.Bitmap)(resources.GetObject("BERemove.Image")));
            this.BERemove.Location = new System.Drawing.Point(147, 5);
            this.BERemove.Name = "BERemove";
            this.BERemove.ShowOuterCircle = false;
            this.BERemove.Size = new System.Drawing.Size(32, 32);
            this.BERemove.TabIndex = 41;
            this.BERemove.Click += new System.EventHandler(this.BERemove_Click);
            // 
            // BEOpen
            // 
            this.BEOpen.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.BEOpen.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Folder;
            this.BEOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEOpen.Image = ((System.Drawing.Bitmap)(resources.GetObject("BEOpen.Image")));
            this.BEOpen.Location = new System.Drawing.Point(105, 5);
            this.BEOpen.Name = "BEOpen";
            this.BEOpen.ShowOuterCircle = false;
            this.BEOpen.Size = new System.Drawing.Size(32, 32);
            this.BEOpen.TabIndex = 40;
            this.BEOpen.Click += new System.EventHandler(this.BEOpen_Click);
            // 
            // BEncClear
            // 
            this.BEncClear.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.BEncClear.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Delete;
            this.BEncClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEncClear.Image = ((System.Drawing.Bitmap)(resources.GetObject("BEncClear.Image")));
            this.BEncClear.Location = new System.Drawing.Point(3, 41);
            this.BEncClear.Name = "BEncClear";
            this.BEncClear.ShowOuterCircle = true;
            this.BEncClear.Size = new System.Drawing.Size(36, 36);
            this.BEncClear.TabIndex = 39;
            this.BEncClear.Click += new System.EventHandler(this.BEncClear_Click);
            // 
            // MsgLblE
            // 
            this.MsgLblE.AutoSize = true;
            this.MsgLblE.BackColor = System.Drawing.Color.Transparent;
            this.MsgLblE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgLblE.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MsgLblE.Location = new System.Drawing.Point(5, 26);
            this.MsgLblE.Name = "MsgLblE";
            this.MsgLblE.Size = new System.Drawing.Size(94, 15);
            this.MsgLblE.TabIndex = 26;
            this.MsgLblE.Text = "(No Recent Files)";
            // 
            // EList
            // 
            this.EList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EList.FormattingEnabled = true;
            this.EList.ItemHeight = 20;
            this.EList.Location = new System.Drawing.Point(40, 41);
            this.EList.Name = "EList";
            this.EList.Size = new System.Drawing.Size(328, 280);
            this.EList.TabIndex = 4;
            this.EList.DoubleClick += new System.EventHandler(this.EList_DoubleClick);
            // 
            // LblEnc
            // 
            this.LblEnc.AutoSize = true;
            this.LblEnc.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnc.Location = new System.Drawing.Point(3, 0);
            this.LblEnc.Name = "LblEnc";
            this.LblEnc.Size = new System.Drawing.Size(96, 28);
            this.LblEnc.TabIndex = 3;
            this.LblEnc.Text = "encrypted";
            // 
            // BDRemove
            // 
            this.BDRemove.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.BDRemove.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Remove;
            this.BDRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDRemove.Image = ((System.Drawing.Bitmap)(resources.GetObject("BDRemove.Image")));
            this.BDRemove.Location = new System.Drawing.Point(147, 5);
            this.BDRemove.Name = "BDRemove";
            this.BDRemove.ShowOuterCircle = false;
            this.BDRemove.Size = new System.Drawing.Size(32, 32);
            this.BDRemove.TabIndex = 43;
            this.BDRemove.Click += new System.EventHandler(this.BDRemove_Click);
            // 
            // BDOpen
            // 
            this.BDOpen.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.BDOpen.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Folder;
            this.BDOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDOpen.Image = ((System.Drawing.Bitmap)(resources.GetObject("BDOpen.Image")));
            this.BDOpen.Location = new System.Drawing.Point(105, 5);
            this.BDOpen.Name = "BDOpen";
            this.BDOpen.ShowOuterCircle = false;
            this.BDOpen.Size = new System.Drawing.Size(32, 32);
            this.BDOpen.TabIndex = 42;
            this.BDOpen.Click += new System.EventHandler(this.BDOpen_Click);
            // 
            // BDecClear
            // 
            this.BDecClear.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.BDecClear.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Delete;
            this.BDecClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDecClear.Image = ((System.Drawing.Bitmap)(resources.GetObject("BDecClear.Image")));
            this.BDecClear.Location = new System.Drawing.Point(3, 44);
            this.BDecClear.Name = "BDecClear";
            this.BDecClear.ShowOuterCircle = true;
            this.BDecClear.Size = new System.Drawing.Size(36, 36);
            this.BDecClear.TabIndex = 40;
            this.BDecClear.Click += new System.EventHandler(this.BDecClear_Click);
            // 
            // MsgLblD
            // 
            this.MsgLblD.AutoSize = true;
            this.MsgLblD.BackColor = System.Drawing.Color.Transparent;
            this.MsgLblD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgLblD.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MsgLblD.Location = new System.Drawing.Point(5, 26);
            this.MsgLblD.Name = "MsgLblD";
            this.MsgLblD.Size = new System.Drawing.Size(94, 15);
            this.MsgLblD.TabIndex = 27;
            this.MsgLblD.Text = "(No Recent Files)";
            // 
            // DList
            // 
            this.DList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DList.FormattingEnabled = true;
            this.DList.ItemHeight = 20;
            this.DList.Location = new System.Drawing.Point(39, 41);
            this.DList.Name = "DList";
            this.DList.Size = new System.Drawing.Size(328, 280);
            this.DList.TabIndex = 5;
            this.DList.DoubleClick += new System.EventHandler(this.DList_DoubleClick);
            // 
            // LblDec
            // 
            this.LblDec.AutoSize = true;
            this.LblDec.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDec.Location = new System.Drawing.Point(3, 0);
            this.LblDec.Name = "LblDec";
            this.LblDec.Size = new System.Drawing.Size(96, 28);
            this.LblDec.TabIndex = 4;
            this.LblDec.Text = "decrypted";
            // 
            // ChkHistory
            // 
            this.ChkHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkHistory.AutoSize = true;
            this.ChkHistory.BackColor = System.Drawing.Color.Transparent;
            this.ChkHistory.Checked = true;
            this.ChkHistory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkHistory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChkHistory.Location = new System.Drawing.Point(666, 9);
            this.ChkHistory.Name = "ChkHistory";
            this.ChkHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkHistory.Size = new System.Drawing.Size(102, 21);
            this.ChkHistory.TabIndex = 3;
            this.ChkHistory.Text = "Keep History";
            this.ChkHistory.UseVisualStyleBackColor = false;
            this.ChkHistory.CheckedChanged += new System.EventHandler(this.ChkHistory_CheckedChanged);
            // 
            // MsgLbl
            // 
            this.MsgLbl.AutoSize = true;
            this.MsgLbl.BackColor = System.Drawing.Color.Transparent;
            this.MsgLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MsgLbl.Location = new System.Drawing.Point(17, 14);
            this.MsgLbl.Name = "MsgLbl";
            this.MsgLbl.Size = new System.Drawing.Size(102, 15);
            this.MsgLbl.TabIndex = 25;
            this.MsgLbl.Text = "(History Disabled)";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.MsgLbl);
            this.Controls.Add(this.ChkHistory);
            this.Controls.Add(this.SplitHistory);
            this.Name = "History";
            this.Size = new System.Drawing.Size(768, 508);
            this.Load += new System.EventHandler(this.History_Load);
            this.SplitHistory.Panel1.ResumeLayout(false);
            this.SplitHistory.Panel1.PerformLayout();
            this.SplitHistory.Panel2.ResumeLayout(false);
            this.SplitHistory.Panel2.PerformLayout();
            this.SplitHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitHistory;
        private System.Windows.Forms.Label LblDec;
        private System.Windows.Forms.ListBox EList;
        private System.Windows.Forms.Label LblEnc;
        private System.Windows.Forms.ListBox DList;
        private System.Windows.Forms.CheckBox ChkHistory;
        private System.Windows.Forms.Label MsgLblE;
        private System.Windows.Forms.Label MsgLblD;
        private System.Windows.Forms.Label MsgLbl;
        private Meadows.UI.Metro.MetroToolbarButton BEncClear;
        private Meadows.UI.Metro.MetroToolbarButton BDecClear;
        private Meadows.UI.Metro.MetroToolbarButton BERemove;
        private Meadows.UI.Metro.MetroToolbarButton BEOpen;
        private Meadows.UI.Metro.MetroToolbarButton BDRemove;
        private Meadows.UI.Metro.MetroToolbarButton BDOpen;
    }
}
