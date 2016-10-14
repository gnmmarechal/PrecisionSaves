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
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savemanagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installToSDCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wipeSavedataDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintabcontrol = new System.Windows.Forms.TabControl();
            this.backups_page = new System.Windows.Forms.TabPage();
            this.delete_save_button = new System.Windows.Forms.Button();
            this.restore_save_button = new System.Windows.Forms.Button();
            this.backup_savedata_button = new System.Windows.Forms.Button();
            this.savedata_listbox = new System.Windows.Forms.ListBox();
            this.editor_tab = new System.Windows.Forms.TabPage();
            this.writecheat_button = new System.Windows.Forms.Button();
            this.cheat_listbox = new System.Windows.Forms.ListBox();
            this.timer_checker = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menu_strip.SuspendLayout();
            this.maintabcontrol.SuspendLayout();
            this.backups_page.SuspendLayout();
            this.editor_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_strip
            // 
            this.menu_strip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSavedataToolStripMenuItem,
            this.setToolStripMenuItem,
            this.utilitiesToolStripMenuItem});
            this.menu_strip.Location = new System.Drawing.Point(0, 0);
            this.menu_strip.Name = "menu_strip";
            this.menu_strip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menu_strip.Size = new System.Drawing.Size(1734, 44);
            this.menu_strip.TabIndex = 0;
            this.menu_strip.Text = "menuStrip1";
            // 
            // loadSavedataToolStripMenuItem
            // 
            this.loadSavedataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savedataToolStripMenuItem});
            this.loadSavedataToolStripMenuItem.Name = "loadSavedataToolStripMenuItem";
            this.loadSavedataToolStripMenuItem.Size = new System.Drawing.Size(78, 36);
            this.loadSavedataToolStripMenuItem.Text = "Load";
            // 
            // savedataToolStripMenuItem
            // 
            this.savedataToolStripMenuItem.Image = global::PrecisionSaves.Properties.Resources.savedataicon;
            this.savedataToolStripMenuItem.Name = "savedataToolStripMenuItem";
            this.savedataToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.savedataToolStripMenuItem.Text = "Savedata";
            this.savedataToolStripMenuItem.Click += new System.EventHandler(this.savedataToolStripMenuItem_Click);
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(160, 36);
            this.setToolStripMenuItem.Text = "Select Game";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.setToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savemanagerToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // savemanagerToolStripMenuItem
            // 
            this.savemanagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installToSDCardToolStripMenuItem,
            this.wipeSavedataDirectoryToolStripMenuItem});
            this.savemanagerToolStripMenuItem.Name = "savemanagerToolStripMenuItem";
            this.savemanagerToolStripMenuItem.Size = new System.Drawing.Size(266, 38);
            this.savemanagerToolStripMenuItem.Text = "save_manager";
            // 
            // installToSDCardToolStripMenuItem
            // 
            this.installToSDCardToolStripMenuItem.Name = "installToSDCardToolStripMenuItem";
            this.installToSDCardToolStripMenuItem.Size = new System.Drawing.Size(377, 38);
            this.installToSDCardToolStripMenuItem.Text = "Install to SD Card";
            // 
            // wipeSavedataDirectoryToolStripMenuItem
            // 
            this.wipeSavedataDirectoryToolStripMenuItem.Name = "wipeSavedataDirectoryToolStripMenuItem";
            this.wipeSavedataDirectoryToolStripMenuItem.Size = new System.Drawing.Size(377, 38);
            this.wipeSavedataDirectoryToolStripMenuItem.Text = "Wipe Savedata Directory";
            this.wipeSavedataDirectoryToolStripMenuItem.Click += new System.EventHandler(this.wipeSavedataDirectoryToolStripMenuItem_Click);
            // 
            // maintabcontrol
            // 
            this.maintabcontrol.Controls.Add(this.backups_page);
            this.maintabcontrol.Controls.Add(this.editor_tab);
            this.maintabcontrol.Location = new System.Drawing.Point(24, 52);
            this.maintabcontrol.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.maintabcontrol.Name = "maintabcontrol";
            this.maintabcontrol.SelectedIndex = 0;
            this.maintabcontrol.Size = new System.Drawing.Size(1686, 1023);
            this.maintabcontrol.TabIndex = 1;
            // 
            // backups_page
            // 
            this.backups_page.Controls.Add(this.delete_save_button);
            this.backups_page.Controls.Add(this.restore_save_button);
            this.backups_page.Controls.Add(this.backup_savedata_button);
            this.backups_page.Controls.Add(this.savedata_listbox);
            this.backups_page.Location = new System.Drawing.Point(8, 39);
            this.backups_page.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.backups_page.Name = "backups_page";
            this.backups_page.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.backups_page.Size = new System.Drawing.Size(1670, 976);
            this.backups_page.TabIndex = 0;
            this.backups_page.Text = "Backup/Restore";
            this.backups_page.UseVisualStyleBackColor = true;
            // 
            // delete_save_button
            // 
            this.delete_save_button.Location = new System.Drawing.Point(1164, 900);
            this.delete_save_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.delete_save_button.Name = "delete_save_button";
            this.delete_save_button.Size = new System.Drawing.Size(150, 44);
            this.delete_save_button.TabIndex = 3;
            this.delete_save_button.Text = "Delete";
            this.delete_save_button.UseVisualStyleBackColor = true;
            this.delete_save_button.Click += new System.EventHandler(this.delete_save_button_Click);
            // 
            // restore_save_button
            // 
            this.restore_save_button.Location = new System.Drawing.Point(1326, 900);
            this.restore_save_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.restore_save_button.Name = "restore_save_button";
            this.restore_save_button.Size = new System.Drawing.Size(150, 44);
            this.restore_save_button.TabIndex = 2;
            this.restore_save_button.Text = "Restore";
            this.restore_save_button.UseVisualStyleBackColor = true;
            this.restore_save_button.Click += new System.EventHandler(this.restore_save_button_Click);
            // 
            // backup_savedata_button
            // 
            this.backup_savedata_button.Location = new System.Drawing.Point(1488, 900);
            this.backup_savedata_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.backup_savedata_button.Name = "backup_savedata_button";
            this.backup_savedata_button.Size = new System.Drawing.Size(150, 44);
            this.backup_savedata_button.TabIndex = 1;
            this.backup_savedata_button.Text = "Backup";
            this.backup_savedata_button.UseVisualStyleBackColor = true;
            this.backup_savedata_button.Click += new System.EventHandler(this.backup_savedata_button_Click);
            // 
            // savedata_listbox
            // 
            this.savedata_listbox.FormattingEnabled = true;
            this.savedata_listbox.ItemHeight = 25;
            this.savedata_listbox.Location = new System.Drawing.Point(12, 12);
            this.savedata_listbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.savedata_listbox.Name = "savedata_listbox";
            this.savedata_listbox.Size = new System.Drawing.Size(410, 929);
            this.savedata_listbox.TabIndex = 0;
            // 
            // editor_tab
            // 
            this.editor_tab.Controls.Add(this.writecheat_button);
            this.editor_tab.Controls.Add(this.cheat_listbox);
            this.editor_tab.Location = new System.Drawing.Point(8, 39);
            this.editor_tab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.editor_tab.Name = "editor_tab";
            this.editor_tab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.editor_tab.Size = new System.Drawing.Size(1670, 976);
            this.editor_tab.TabIndex = 1;
            this.editor_tab.Text = "Save Editing";
            this.editor_tab.UseVisualStyleBackColor = true;
            // 
            // writecheat_button
            // 
            this.writecheat_button.Location = new System.Drawing.Point(1508, 856);
            this.writecheat_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.writecheat_button.Name = "writecheat_button";
            this.writecheat_button.Size = new System.Drawing.Size(150, 44);
            this.writecheat_button.TabIndex = 1;
            this.writecheat_button.Text = "Apply";
            this.writecheat_button.UseVisualStyleBackColor = true;
            this.writecheat_button.Click += new System.EventHandler(this.writecheat_button_Click);
            // 
            // cheat_listbox
            // 
            this.cheat_listbox.FormattingEnabled = true;
            this.cheat_listbox.ItemHeight = 25;
            this.cheat_listbox.Location = new System.Drawing.Point(12, 12);
            this.cheat_listbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cheat_listbox.Name = "cheat_listbox";
            this.cheat_listbox.Size = new System.Drawing.Size(1642, 829);
            this.cheat_listbox.TabIndex = 0;
            // 
            // timer_checker
            // 
            this.timer_checker.Enabled = true;
            this.timer_checker.Interval = 10;
            this.timer_checker.Tick += new System.EventHandler(this.timer_checker_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 1098);
            this.Controls.Add(this.maintabcontrol);
            this.Controls.Add(this.menu_strip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menu_strip;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Button writecheat_button;
        private System.Windows.Forms.Button delete_save_button;
        private System.Windows.Forms.Timer timer1;
    }
}

