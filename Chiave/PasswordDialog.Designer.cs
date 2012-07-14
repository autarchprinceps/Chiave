namespace Chiave
{
    partial class PasswordDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.LblFileName = new System.Windows.Forms.Label();
            this.ChkOverWrite = new System.Windows.Forms.CheckBox();
            this.TxtPassword_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdPreview = new Meadows.UI.Aero.CommandLink();
            this.CmdDecrypt = new Meadows.UI.Aero.CommandLink();
            this.CmdOpen = new Meadows.UI.Aero.CommandLink();
            this.CmdLoadKey = new Meadows.UI.Aero.CommandLink();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "enter password";
            // 
            // LblFileName
            // 
            this.LblFileName.AutoEllipsis = true;
            this.LblFileName.AutoSize = true;
            this.LblFileName.BackColor = System.Drawing.Color.Transparent;
            this.LblFileName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFileName.ForeColor = System.Drawing.Color.Black;
            this.LblFileName.Location = new System.Drawing.Point(34, 14);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblFileName.Size = new System.Drawing.Size(72, 20);
            this.LblFileName.TabIndex = 39;
            this.LblFileName.Text = "FileName";
            // 
            // ChkOverWrite
            // 
            this.ChkOverWrite.AutoSize = true;
            this.ChkOverWrite.BackColor = System.Drawing.Color.Transparent;
            this.ChkOverWrite.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkOverWrite.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ChkOverWrite.Location = new System.Drawing.Point(36, 176);
            this.ChkOverWrite.Name = "ChkOverWrite";
            this.ChkOverWrite.Size = new System.Drawing.Size(154, 17);
            this.ChkOverWrite.TabIndex = 2;
            this.ChkOverWrite.Text = "Delete the Encrypted File";
            this.ChkOverWrite.UseVisualStyleBackColor = false;
            // 
            // TxtPassword_1
            // 
            this.TxtPassword_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword_1.ForeColor = System.Drawing.Color.SeaGreen;
            this.TxtPassword_1.HideSelection = false;
            this.TxtPassword_1.Location = new System.Drawing.Point(27, 75);
            this.TxtPassword_1.Name = "TxtPassword_1";
            this.TxtPassword_1.PasswordChar = '●';
            this.TxtPassword_1.Size = new System.Drawing.Size(339, 25);
            this.TxtPassword_1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "or";
            // 
            // CmdPreview
            // 
            this.CmdPreview.CommandText = "Preview";
            this.CmdPreview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdPreview.ForeColor = System.Drawing.Color.Navy;
            this.CmdPreview.Image = ((System.Drawing.Bitmap)(resources.GetObject("CmdPreview.Image")));
            this.CmdPreview.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.CmdPreview.ImageVerticalAlign = Meadows.UI.Aero.CommandLink.VerticalAlign.Middle;
            this.CmdPreview.Location = new System.Drawing.Point(27, 309);
            this.CmdPreview.Name = "CmdPreview";
            this.CmdPreview.NoteText = "Creates an auto delete read-only file to preview.";
            this.CmdPreview.Size = new System.Drawing.Size(336, 43);
            this.CmdPreview.TabIndex = 47;
            this.CmdPreview.Visible = false;
            // 
            // CmdDecrypt
            // 
            this.CmdDecrypt.CommandText = "Decrypt";
            this.CmdDecrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDecrypt.ForeColor = System.Drawing.Color.Navy;
            this.CmdDecrypt.Image = ((System.Drawing.Bitmap)(resources.GetObject("CmdDecrypt.Image")));
            this.CmdDecrypt.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.CmdDecrypt.ImageVerticalAlign = Meadows.UI.Aero.CommandLink.VerticalAlign.Middle;
            this.CmdDecrypt.Location = new System.Drawing.Point(27, 260);
            this.CmdDecrypt.Name = "CmdDecrypt";
            this.CmdDecrypt.NoteText = "Start in Decryption mode.";
            this.CmdDecrypt.Size = new System.Drawing.Size(336, 43);
            this.CmdDecrypt.TabIndex = 4;
            this.CmdDecrypt.Click += new System.EventHandler(this.CmdDecrypt_Click);
            // 
            // CmdOpen
            // 
            this.CmdOpen.CommandText = "Open";
            this.CmdOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdOpen.ForeColor = System.Drawing.Color.Navy;
            this.CmdOpen.Image = ((System.Drawing.Bitmap)(resources.GetObject("CmdOpen.Image")));
            this.CmdOpen.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.CmdOpen.ImageVerticalAlign = Meadows.UI.Aero.CommandLink.VerticalAlign.Middle;
            this.CmdOpen.Location = new System.Drawing.Point(27, 211);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.NoteText = "Decrypts the File and Opens it.";
            this.CmdOpen.Size = new System.Drawing.Size(336, 43);
            this.CmdOpen.TabIndex = 3;
            this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // CmdLoadKey
            // 
            this.CmdLoadKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdLoadKey.CommandText = "Load Key";
            this.CmdLoadKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdLoadKey.ForeColor = System.Drawing.Color.Navy;
            this.CmdLoadKey.Image = ((System.Drawing.Bitmap)(resources.GetObject("CmdLoadKey.Image")));
            this.CmdLoadKey.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.CmdLoadKey.ImageVerticalAlign = Meadows.UI.Aero.CommandLink.VerticalAlign.Middle;
            this.CmdLoadKey.Location = new System.Drawing.Point(25, 127);
            this.CmdLoadKey.Name = "CmdLoadKey";
            this.CmdLoadKey.NoteText = "Use a Key File to Decrypt";
            this.CmdLoadKey.Size = new System.Drawing.Size(338, 43);
            this.CmdLoadKey.TabIndex = 1;
            this.CmdLoadKey.Click += new System.EventHandler(this.CmdLoadKey_Click);
            // 
            // PasswordDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChkOverWrite);
            this.Controls.Add(this.CmdPreview);
            this.Controls.Add(this.CmdDecrypt);
            this.Controls.Add(this.CmdOpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmdLoadKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblFileName);
            this.Controls.Add(this.TxtPassword_1);
            this.Name = "PasswordDialog";
            this.Size = new System.Drawing.Size(390, 313);
            this.Load += new System.EventHandler(this.PasswordDialog_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PasswordDialog_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFileName;
        private System.Windows.Forms.CheckBox ChkOverWrite;
        private System.Windows.Forms.TextBox TxtPassword_1;
        private Meadows.UI.Aero.CommandLink CmdLoadKey;
        private System.Windows.Forms.Label label3;
        private Meadows.UI.Aero.CommandLink CmdOpen;
        private Meadows.UI.Aero.CommandLink CmdDecrypt;
        private Meadows.UI.Aero.CommandLink CmdPreview;
    }
}
