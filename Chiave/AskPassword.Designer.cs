namespace Chiave
{
    partial class AskPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskPassword));
            this.PicMsgClose = new System.Windows.Forms.PictureBox();
            this.PicStrip = new System.Windows.Forms.PictureBox();
            this.MsgLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.No = new Meadows.UI.Metro.MetroToolbarButton();
            this.Yes = new Meadows.UI.Metro.MetroToolbarButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkShowPassword = new System.Windows.Forms.CheckBox();
            this.TxtPassword_2 = new System.Windows.Forms.TextBox();
            this.TxtPassword_1 = new System.Windows.Forms.TextBox();
            this.EncPanel = new System.Windows.Forms.Panel();
            this.PrgPwStren = new Meadows.UI.Metro.MetroProgress();
            this.ChkOverWrite = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicMsgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStrip)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.EncPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicMsgClose
            // 
            this.PicMsgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMsgClose.BackColor = System.Drawing.Color.Transparent;
            this.PicMsgClose.BackgroundImage = global::Chiave.Properties.Resources.CloseNormal;
            this.PicMsgClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicMsgClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PicMsgClose.Location = new System.Drawing.Point(402, 6);
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
            this.PicStrip.Location = new System.Drawing.Point(-4, 12);
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
            this.MsgLbl.Location = new System.Drawing.Point(38, 45);
            this.MsgLbl.Name = "MsgLbl";
            this.MsgLbl.Size = new System.Drawing.Size(0, 23);
            this.MsgLbl.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 19.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(20, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Enter Password";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.No);
            this.flowLayoutPanel1.Controls.Add(this.Yes);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(330, 165);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(92, 54);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // No
            // 
            this.No.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.No.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Cancel;
            this.No.DialogResult = System.Windows.Forms.DialogResult.No;
            this.No.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.Image = ((System.Drawing.Bitmap)(resources.GetObject("No.Image")));
            this.No.Location = new System.Drawing.Point(49, 3);
            this.No.Name = "No";
            this.No.ShowOuterCircle = true;
            this.No.Size = new System.Drawing.Size(40, 40);
            this.No.TabIndex = 8;
            // 
            // Yes
            // 
            this.Yes.ButtonColor = Meadows.UI.Metro.MetroToolbarButton.ButtonColorBase.Black;
            this.Yes.ButtonImage = Meadows.UI.Metro.MetroToolbarButton.ButtonImages.Check;
            this.Yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Yes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes.Image = ((System.Drawing.Bitmap)(resources.GetObject("Yes.Image")));
            this.Yes.Location = new System.Drawing.Point(3, 3);
            this.Yes.Name = "Yes";
            this.Yes.ShowOuterCircle = true;
            this.Yes.Size = new System.Drawing.Size(40, 40);
            this.Yes.TabIndex = 7;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "password:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "re-enter:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Password Strength: ";
            // 
            // ChkShowPassword
            // 
            this.ChkShowPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChkShowPassword.AutoSize = true;
            this.ChkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.ChkShowPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkShowPassword.Location = new System.Drawing.Point(80, 36);
            this.ChkShowPassword.Name = "ChkShowPassword";
            this.ChkShowPassword.Size = new System.Drawing.Size(107, 17);
            this.ChkShowPassword.TabIndex = 3;
            this.ChkShowPassword.Text = "Show Password";
            this.ChkShowPassword.UseVisualStyleBackColor = false;
            this.ChkShowPassword.CheckedChanged += new System.EventHandler(this.ChkShowPassword_CheckedChanged);
            // 
            // TxtPassword_2
            // 
            this.TxtPassword_2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtPassword_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword_2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtPassword_2.Location = new System.Drawing.Point(80, 3);
            this.TxtPassword_2.Name = "TxtPassword_2";
            this.TxtPassword_2.Size = new System.Drawing.Size(321, 25);
            this.TxtPassword_2.TabIndex = 2;
            this.TxtPassword_2.UseSystemPasswordChar = true;
            this.TxtPassword_2.TextChanged += new System.EventHandler(this.TxtPassword_2_TextChanged);
            // 
            // TxtPassword_1
            // 
            this.TxtPassword_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtPassword_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword_1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtPassword_1.Location = new System.Drawing.Point(84, 55);
            this.TxtPassword_1.Name = "TxtPassword_1";
            this.TxtPassword_1.Size = new System.Drawing.Size(321, 25);
            this.TxtPassword_1.TabIndex = 1;
            this.TxtPassword_1.UseSystemPasswordChar = true;
            this.TxtPassword_1.TextChanged += new System.EventHandler(this.TxtPassword_1_TextChanged);
            // 
            // EncPanel
            // 
            this.EncPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EncPanel.BackColor = System.Drawing.Color.Transparent;
            this.EncPanel.Controls.Add(this.label4);
            this.EncPanel.Controls.Add(this.label2);
            this.EncPanel.Controls.Add(this.ChkShowPassword);
            this.EncPanel.Controls.Add(this.TxtPassword_2);
            this.EncPanel.Location = new System.Drawing.Point(4, 87);
            this.EncPanel.Name = "EncPanel";
            this.EncPanel.Size = new System.Drawing.Size(412, 66);
            this.EncPanel.TabIndex = 37;
            // 
            // PrgPwStren
            // 
            this.PrgPwStren.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrgPwStren.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrgPwStren.BorderSize = 1;
            this.PrgPwStren.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrgPwStren.ForeColor = System.Drawing.Color.Red;
            this.PrgPwStren.Location = new System.Drawing.Point(92, 73);
            this.PrgPwStren.MaximumValue = 100F;
            this.PrgPwStren.MinimumValue = 0F;
            this.PrgPwStren.Name = "PrgPwStren";
            this.PrgPwStren.Orientation = Meadows.UI.Metro.MetroProgress.Orientations.Horizontal;
            this.PrgPwStren.PostText = null;
            this.PrgPwStren.PreText = null;
            this.PrgPwStren.ProgressStyle = Meadows.UI.Metro.MetroProgress.ProgressStyles.ProgressBar;
            this.PrgPwStren.Size = new System.Drawing.Size(321, 10);
            this.PrgPwStren.TabIndex = 39;
            this.PrgPwStren.Value = 0F;
            this.PrgPwStren.Visible = false;
            // 
            // ChkOverWrite
            // 
            this.ChkOverWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChkOverWrite.AutoSize = true;
            this.ChkOverWrite.BackColor = System.Drawing.Color.Transparent;
            this.ChkOverWrite.Checked = true;
            this.ChkOverWrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkOverWrite.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.ChkOverWrite.Location = new System.Drawing.Point(10, 181);
            this.ChkOverWrite.Name = "ChkOverWrite";
            this.ChkOverWrite.Size = new System.Drawing.Size(152, 19);
            this.ChkOverWrite.TabIndex = 6;
            this.ChkOverWrite.Text = "Delete the Original Files";
            this.ChkOverWrite.UseVisualStyleBackColor = false;
            this.ChkOverWrite.CheckedChanged += new System.EventHandler(this.ChkOverWrite_CheckedChanged);
            // 
            // AskPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 210);
            this.ControlBox = false;
            this.Controls.Add(this.ChkOverWrite);
            this.Controls.Add(this.EncPanel);
            this.Controls.Add(this.TxtPassword_1);
            this.Controls.Add(this.PrgPwStren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MsgLbl);
            this.Controls.Add(this.PicMsgClose);
            this.Controls.Add(this.PicStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(444, 345);
            this.Name = "AskPassword";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AskPassword";
            this.Activated += new System.EventHandler(this.AskPassword_Activated);
            this.Load += new System.EventHandler(this.AskPassword_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AskPassword_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PicMsgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStrip)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.EncPanel.ResumeLayout(false);
            this.EncPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicMsgClose;
        private System.Windows.Forms.PictureBox PicStrip;
        private System.Windows.Forms.Label MsgLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkShowPassword;
        private System.Windows.Forms.TextBox TxtPassword_2;
        private System.Windows.Forms.TextBox TxtPassword_1;
        private System.Windows.Forms.Panel EncPanel;
        private System.Windows.Forms.CheckBox ChkOverWrite;
        private Meadows.UI.Metro.MetroToolbarButton No;
        private Meadows.UI.Metro.MetroToolbarButton Yes;
        private Meadows.UI.Metro.MetroProgress PrgPwStren;
    }
}