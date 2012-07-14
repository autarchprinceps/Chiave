namespace Chiave
{
    partial class SettingsPanel
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
            this.ChkHistory = new System.Windows.Forms.CheckBox();
            this.CmdUnistall = new Meadows.UI.Aero.CommandLink();
            this.CmdInstall = new Meadows.UI.Aero.CommandLink();
            this.CmdStartUp = new Meadows.UI.Aero.CommandLink();
            this.CmdJump = new Meadows.UI.Aero.CommandLink();
            this.CmdContext = new Meadows.UI.Aero.CommandLink();
            this.CmdFileAssociations = new Meadows.UI.Aero.CommandLink();
            this.SuspendLayout();
            // 
            // ChkHistory
            // 
            this.ChkHistory.AutoSize = true;
            this.ChkHistory.BackColor = System.Drawing.Color.Transparent;
            this.ChkHistory.Checked = true;
            this.ChkHistory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkHistory.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkHistory.Location = new System.Drawing.Point(411, 81);
            this.ChkHistory.Name = "ChkHistory";
            this.ChkHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkHistory.Size = new System.Drawing.Size(153, 25);
            this.ChkHistory.TabIndex = 34;
            this.ChkHistory.Text = "Load History Panel";
            this.ChkHistory.UseVisualStyleBackColor = false;
            this.ChkHistory.CheckedChanged += new System.EventHandler(this.ChkHistory_CheckedChanged);
            // 
            // CmdUnistall
            // 
            this.CmdUnistall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdUnistall.CommandText = "Unistall Application entries";
            this.CmdUnistall.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdUnistall.ForeColor = System.Drawing.Color.Navy;
            this.CmdUnistall.Image = global::Meadows.UI.Properties.Resources.Black_delete;
            this.CmdUnistall.ImageVerticalAlign = Meadows.UI.Aero.CommandLink.VerticalAlign.Middle;
            this.CmdUnistall.Location = new System.Drawing.Point(32, 377);
            this.CmdUnistall.Name = "CmdUnistall";
            this.CmdUnistall.NoteText = "Removes the Registry entries and file associations.";
            this.CmdUnistall.Size = new System.Drawing.Size(396, 53);
            this.CmdUnistall.TabIndex = 40;
            this.CmdUnistall.Click += new System.EventHandler(this.CmdUnistall_Click);
            // 
            // CmdInstall
            // 
            this.CmdInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdInstall.CommandText = "Install or Repair Application entries";
            this.CmdInstall.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdInstall.ForeColor = System.Drawing.Color.Navy;            
            this.CmdInstall.Image = global::Meadows.UI.Properties.Resources.Black_refresh;
            this.CmdInstall.ImageVerticalAlign = Meadows.UI.Aero.CommandLink.VerticalAlign.Middle;
            this.CmdInstall.Location = new System.Drawing.Point(32, 318);
            this.CmdInstall.Name = "CmdInstall";
            this.CmdInstall.NoteText = "Installs or Refreshes the Registry entries.";
            this.CmdInstall.Size = new System.Drawing.Size(396, 53);
            this.CmdInstall.TabIndex = 39;
            this.CmdInstall.Click += new System.EventHandler(this.CmdInstall_Click);
            // 
            // CmdStartUp
            // 
            this.CmdStartUp.CommandText = "Add as Startup Object";
            this.CmdStartUp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStartUp.ForeColor = System.Drawing.Color.Navy;
            this.CmdStartUp.Image = global::Meadows.UI.Properties.Resources.Black_Add;
            this.CmdStartUp.ImageVerticalAlign = Meadows.UI.Aero.CommandLink.VerticalAlign.Middle;
            this.CmdStartUp.Location = new System.Drawing.Point(382, 5);
            this.CmdStartUp.Name = "CmdStartUp";
            this.CmdStartUp.NoteText = " Add as System Startup Object.";
            this.CmdStartUp.Size = new System.Drawing.Size(278, 53);
            this.CmdStartUp.TabIndex = 38;
            this.CmdStartUp.Click += new System.EventHandler(this.CmdStartUp_Click);
            // 
            // CmdJump
            // 
            this.CmdJump.CommandText = "Enable JumpList";
            this.CmdJump.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdJump.ForeColor = System.Drawing.Color.Navy;
            this.CmdJump.Image = global::Meadows.UI.Properties.Resources.Black_Add;
            this.CmdJump.Location = new System.Drawing.Point(32, 123);
            this.CmdJump.Name = "CmdJump";
            this.CmdJump.NoteText = "Creates easy shortcuts to the modes in the application.";
            this.CmdJump.Size = new System.Drawing.Size(344, 53);
            this.CmdJump.TabIndex = 37;
            this.CmdJump.Click += new System.EventHandler(this.CmdJump_Click);
            // 
            // CmdContext
            // 
            this.CmdContext.CommandText = "Enable Windows Explorer Context Menu";
            this.CmdContext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdContext.ForeColor = System.Drawing.Color.Navy;
            this.CmdContext.Image = global::Meadows.UI.Properties.Resources.Black_folder;
            this.CmdContext.ImageVerticalAlign = Meadows.UI.Aero.CommandLink.VerticalAlign.Middle;
            this.CmdContext.Location = new System.Drawing.Point(32, 64);
            this.CmdContext.Name = "CmdContext";
            this.CmdContext.NoteText = "Creates menu item in Windows Explorer Context menu.";
            this.CmdContext.Size = new System.Drawing.Size(344, 53);
            this.CmdContext.TabIndex = 36;
            this.CmdContext.Click += new System.EventHandler(this.CmdContext_Click);
            // 
            // CmdFileAssociations
            // 
            this.CmdFileAssociations.CommandText = "Create File Associations for Encrpted Files";
            this.CmdFileAssociations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdFileAssociations.ForeColor = System.Drawing.Color.Navy;
            this.CmdFileAssociations.Image = global::Meadows.UI.Properties.Resources.Black_folder;
            this.CmdFileAssociations.Location = new System.Drawing.Point(32, 5);
            this.CmdFileAssociations.Name = "CmdFileAssociations";
            this.CmdFileAssociations.NoteText = "Directly Launch Encrypted Files from Explorer.";
            this.CmdFileAssociations.Size = new System.Drawing.Size(344, 53);
            this.CmdFileAssociations.TabIndex = 35;
            this.CmdFileAssociations.Click += new System.EventHandler(this.CmdFileAssociations_Click);
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CmdUnistall);
            this.Controls.Add(this.CmdInstall);
            this.Controls.Add(this.CmdStartUp);
            this.Controls.Add(this.CmdJump);
            this.Controls.Add(this.CmdContext);
            this.Controls.Add(this.CmdFileAssociations);
            this.Controls.Add(this.ChkHistory);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(739, 466);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkHistory;
        private Meadows.UI.Aero.CommandLink CmdFileAssociations;
        private Meadows.UI.Aero.CommandLink CmdContext;
        private Meadows.UI.Aero.CommandLink CmdJump;
        private Meadows.UI.Aero.CommandLink CmdStartUp;
        private Meadows.UI.Aero.CommandLink CmdInstall;
        private Meadows.UI.Aero.CommandLink CmdUnistall;
    }
}
