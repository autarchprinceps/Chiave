namespace Chiave
{
    partial class BluMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BluMessage));
            this.PicMsgClose = new System.Windows.Forms.PictureBox();
            this.PicStrip = new System.Windows.Forms.PictureBox();
            this.MsgLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DNo = new System.Windows.Forms.Button();
            this.ChkAll = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.No = new Meadows.UI.Metro.MetroToolbarButton();
            this.Yes = new Meadows.UI.Metro.MetroToolbarButton();
            ((System.ComponentModel.ISupportInitialize)(this.PicMsgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStrip)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicMsgClose
            // 
            this.PicMsgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMsgClose.BackColor = System.Drawing.Color.Transparent;
            this.PicMsgClose.BackgroundImage = global::Chiave.Properties.Resources.CloseNormal;
            this.PicMsgClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicMsgClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PicMsgClose.Location = new System.Drawing.Point(443, 3);
            this.PicMsgClose.Name = "PicMsgClose";
            this.PicMsgClose.Size = new System.Drawing.Size(15, 15);
            this.PicMsgClose.TabIndex = 20;
            this.PicMsgClose.TabStop = false;
            this.PicMsgClose.Click += new System.EventHandler(this.PicMsgClose_Click);
            this.PicMsgClose.MouseEnter += new System.EventHandler(this.PicMsgClose_MouseEnter);
            this.PicMsgClose.MouseLeave += new System.EventHandler(this.PicMsgClose_MouseLeave);
            // 
            // PicStrip
            // 
            this.PicStrip.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PicStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicStrip.Location = new System.Drawing.Point(1, 12);
            this.PicStrip.Name = "PicStrip";
            this.PicStrip.Size = new System.Drawing.Size(11, 60);
            this.PicStrip.TabIndex = 19;
            this.PicStrip.TabStop = false;
            // 
            // MsgLbl
            // 
            this.MsgLbl.AutoEllipsis = true;
            this.MsgLbl.AutoSize = true;
            this.MsgLbl.BackColor = System.Drawing.Color.Transparent;
            this.MsgLbl.Font = new System.Drawing.Font("Segoe UI", 12.52F);
            this.MsgLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MsgLbl.Location = new System.Drawing.Point(38, 47);
            this.MsgLbl.Name = "MsgLbl";
            this.MsgLbl.Size = new System.Drawing.Size(76, 23);
            this.MsgLbl.TabIndex = 23;
            this.MsgLbl.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(15, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Chiave Message";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.No);
            this.flowLayoutPanel1.Controls.Add(this.Yes);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(367, 81);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(93, 43);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // DNo
            // 
            this.DNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.DNo.Location = new System.Drawing.Point(274, 147);
            this.DNo.Name = "DNo";
            this.DNo.Size = new System.Drawing.Size(55, 40);
            this.DNo.TabIndex = 26;
            this.DNo.Text = "Dummy";
            this.DNo.UseVisualStyleBackColor = true;
            // 
            // ChkAll
            // 
            this.ChkAll.AutoSize = true;
            this.ChkAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkAll.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChkAll.Location = new System.Drawing.Point(7, 103);
            this.ChkAll.Name = "ChkAll";
            this.ChkAll.Size = new System.Drawing.Size(195, 19);
            this.ChkAll.TabIndex = 27;
            this.ChkAll.Text = "Do the Same for Remaining files";
            this.ChkAll.UseVisualStyleBackColor = true;
            this.ChkAll.Visible = false;
            this.ChkAll.CheckedChanged += new System.EventHandler(this.ChkAll_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 126);
            this.panel1.TabIndex = 28;
            // 
            // No
            // 
            this.No.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.No.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Cancel;
            this.No.DialogResult = System.Windows.Forms.DialogResult.No;
            this.No.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.Image = ((System.Drawing.Bitmap)(resources.GetObject("No.Image")));
            this.No.Location = new System.Drawing.Point(50, 3);
            this.No.Name = "No";
            this.No.ShowOuterCircle = true;
            this.No.Size = new System.Drawing.Size(40, 40);
            this.No.TabIndex = 0;
            // 
            // Yes
            // 
            this.Yes.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.Yes.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Check;
            this.Yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Yes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes.Image = ((System.Drawing.Bitmap)(resources.GetObject("Yes.Image")));
            this.Yes.Location = new System.Drawing.Point(4, 3);
            this.Yes.Name = "Yes";
            this.Yes.ShowOuterCircle = true;
            this.Yes.Size = new System.Drawing.Size(40, 40);
            this.Yes.TabIndex = 1;
            // 
            // BluMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 126);
            this.Controls.Add(this.ChkAll);
            this.Controls.Add(this.DNo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.MsgLbl);
            this.Controls.Add(this.PicMsgClose);
            this.Controls.Add(this.PicStrip);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(462, 126);
            this.Name = "BluMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BluMessage";
            ((System.ComponentModel.ISupportInitialize)(this.PicMsgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStrip)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicMsgClose;
        private System.Windows.Forms.PictureBox PicStrip;
        private System.Windows.Forms.Label MsgLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button DNo;
        private System.Windows.Forms.CheckBox ChkAll;
        private System.Windows.Forms.Panel panel1;
        private Meadows.UI.Metro.MetroToolbarButton No;
        private Meadows.UI.Metro.MetroToolbarButton Yes;
    }
}