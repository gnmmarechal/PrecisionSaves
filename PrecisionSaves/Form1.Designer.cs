namespace PrecisionSaves
{
    partial class mainform
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
            this.menu_strip = new System.Windows.Forms.MenuStrip();
            this.loadSavedataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savedataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintabcontrol = new System.Windows.Forms.TabControl();
            this.backups_page = new System.Windows.Forms.TabPage();
            this.editor_tab = new System.Windows.Forms.TabPage();
            this.cheat_listbox = new System.Windows.Forms.ListBox();
            this.timer_checker = new System.Windows.Forms.Timer(this.components);
            this.savedata_listbox = new System.Windows.Forms.ListBox();
            this.backup_savedata_button = new System.Windows.Forms.Button();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savemanagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installToSDCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wipeSavedataDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restore_save_button = new System.Windows.Forms.Button();
            this.menu_strip.SuspendLayout();
            this.maintabcontrol.SuspendLayout();
            this.backups_page.SuspendLayout();
            this.editor_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_strip
            // 
            this.menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSavedataToolStripMenuItem,
            this.setToolStripMenuItem,
            this.utilitiesToolStripMenuItem});
            this.menu_strip.Location = new System.Drawing.Point(0, 0);
            this.menu_strip.Name = "menu_strip";
            this.menu_strip.Size = new System.Drawing.Size(867, 24);
            this.menu_strip.TabIndex = 0;
            this.menu_strip.Text = "menuStrip1";
            // 
            // loadSavedataToolStripMenuItem
            // 
            this.loadSavedataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savedataToolStripMenuItem});
            this.loadSavedataToolStripMenuItem.Name = "loadSavedataToolStripMenuItem";
            this.loadSavedataToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadSavedataToolStripMenuItem.Text = "Load";
            // 
            // savedataToolStripMenuItem
            // 
            this.savedataToolStripMenuItem.Name = "savedataToolStripMenuItem";
            this.savedataToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.savedataToolStripMenuItem.Text = "Savedata";
            this.savedataToolStripMenuItem.Click += new System.EventHandler(this.savedataToolStripMenuItem_Click);
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.setToolStripMenuItem.Text = "Select Game";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.setToolStripMenuItem_Click);
            // 
            // maintabcontrol
            // 
            this.maintabcontrol.Controls.Add(this.backups_page);
            this.maintabcontrol.Controls.Add(this.editor_tab);
            this.maintabcontrol.Location = new System.Drawing.Point(12, 27);
            this.maintabcontrol.Name = "maintabcontrol";
            this.maintabcontrol.SelectedIndex = 0;
            this.maintabcontrol.Size = new System.Drawing.Size(843, 532);
            this.maintabcontrol.TabIndex = 1;
            // 
            // backups_page
            // 
            this.backups_page.Controls.Add(this.restore_save_button);
            this.backups_page.Controls.Add(this.backup_savedata_button);
            this.backups_page.Controls.Add(this.savedata_listbox);
            this.backups_page.Location = new System.Drawing.Point(4, 22);
            this.backups_page.Name = "backups_page";
            this.backups_page.Padding = new System.Windows.Forms.Padding(3);
            this.backups_page.Size = new System.Drawing.Size(835, 506);
            this.backups_page.TabIndex = 0;
            this.backups_page.Text = "Backup/Restore";
            this.backups_page.UseVisualStyleBackColor = true;
            // 
            // editor_tab
            // 
            this.editor_tab.Controls.Add(this.cheat_listbox);
            this.editor_tab.Location = new System.Drawing.Point(4, 22);
            this.editor_tab.Name = "editor_tab";
            this.editor_tab.Padding = new System.Windows.Forms.Padding(3);
            this.editor_tab.Size = new System.Drawing.Size(835, 506);
            this.editor_tab.TabIndex = 1;
            this.editor_tab.Text = "Save Editing";
            this.editor_tab.UseVisualStyleBackColor = true;
            // 
            // cheat_listbox
            // 
            this.cheat_listbox.FormattingEnabled = true;
            this.cheat_listbox.Location = new System.Drawing.Point(6, 6);
            this.cheat_listbox.Name = "cheat_listbox";
            this.cheat_listbox.Size = new System.Drawing.Size(823, 433);
            this.cheat_listbox.TabIndex = 0;
            // 
            // timer_checker
            // 
            this.timer_checker.Enabled = true;
            this.timer_checker.Interval = 10;
            this.timer_checker.Tick += new System.EventHandler(this.timer_checker_Tick);
            // 
            // savedata_listbox
            // 
            this.savedata_listbox.FormattingEnabled = true;
            this.savedata_listbox.Location = new System.Drawing.Point(6, 6);
            this.savedata_listbox.Name = "savedata_listbox";
            this.savedata_listbox.Size = new System.Drawing.Size(207, 485);
            this.savedata_listbox.TabIndex = 0;
            // 
            // backup_savedata_button
            // 
            this.backup_savedata_button.Location = new System.Drawing.Point(744, 468);
            this.backup_savedata_button.Name = "backup_savedata_button";
            this.backup_savedata_button.Size = new System.Drawing.Size(75, 23);
            this.backup_savedata_button.TabIndex = 1;
            this.backup_savedata_button.Text = "Backup";
            this.backup_savedata_button.UseVisualStyleBackColor = true;
            this.backup_savedata_button.Click += new System.EventHandler(this.backup_savedata_button_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savemanagerToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // savemanagerToolStripMenuItem
            // 
            this.savemanagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installToSDCardToolStripMenuItem,
            this.wipeSavedataDirectoryToolStripMenuItem});
            this.savemanagerToolStripMenuItem.Name = "savemanagerToolStripMenuItem";
            this.savemanagerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.savemanagerToolStripMenuItem.Text = "save_manager";
            // 
            // installToSDCardToolStripMenuItem
            // 
            this.installToSDCardToolStripMenuItem.Name = "installToSDCardToolStripMenuItem";
            this.installToSDCardToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.installToSDCardToolStripMenuItem.Text = "Install to SD Card";
            // 
            // wipeSavedataDirectoryToolStripMenuItem
            // 
            this.wipeSavedataDirectoryToolStripMenuItem.Name = "wipeSavedataDirectoryToolStripMenuItem";
            this.wipeSavedataDirectoryToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.wipeSavedataDirectoryToolStripMenuItem.Text = "Wipe Savedata Directory";
            // 
            // restore_save_button
            // 
            this.restore_save_button.Location = new System.Drawing.Point(663, 468);
            this.restore_save_button.Name = "restore_save_button";
            this.restore_save_button.Size = new System.Drawing.Size(75, 23);
            this.restore_save_button.TabIndex = 2;
            this.restore_save_button.Text = "Restore";
            this.restore_save_button.UseVisualStyleBackColor = true;
            this.restore_save_button.Click += new System.EventHandler(this.restore_save_button_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 571);
            this.Controls.Add(this.maintabcontrol);
            this.Controls.Add(this.menu_strip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu_strip;
            this.Name = "mainform";
            this.Text = "Not-Datel PrecisionSaves";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.menu_strip.ResumeLayout(false);
            this.menu_strip.PerformLayout();
            this.maintabcontrol.ResumeLayout(false);
            this.backups_page.ResumeLayout(false);
            this.editor_tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_strip;
        private System.Windows.Forms.ToolStripMenuItem loadSavedataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savedataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.TabControl maintabcontrol;
        private System.Windows.Forms.TabPage backups_page;
        private System.Windows.Forms.TabPage editor_tab;
        private System.Windows.Forms.ListBox cheat_listbox;
        private System.Windows.Forms.Timer timer_checker;
        private System.Windows.Forms.ListBox savedata_listbox;
        private System.Windows.Forms.Button backup_savedata_button;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savemanagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installToSDCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wipeSavedataDirectoryToolStripMenuItem;
        private System.Windows.Forms.Button restore_save_button;
    }
}

