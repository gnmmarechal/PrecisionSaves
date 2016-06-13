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
            this.menu_strip = new System.Windows.Forms.MenuStrip();
            this.loadSavedataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savedataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintabcontrol = new System.Windows.Forms.TabControl();
            this.backups_page = new System.Windows.Forms.TabPage();
            this.editor_tab = new System.Windows.Forms.TabPage();
            this.menu_strip.SuspendLayout();
            this.maintabcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_strip
            // 
            this.menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSavedataToolStripMenuItem,
            this.setToolStripMenuItem});
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
            this.editor_tab.Location = new System.Drawing.Point(4, 22);
            this.editor_tab.Name = "editor_tab";
            this.editor_tab.Padding = new System.Windows.Forms.Padding(3);
            this.editor_tab.Size = new System.Drawing.Size(835, 506);
            this.editor_tab.TabIndex = 1;
            this.editor_tab.Text = "Save Editing";
            this.editor_tab.UseVisualStyleBackColor = true;
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
            this.menu_strip.ResumeLayout(false);
            this.menu_strip.PerformLayout();
            this.maintabcontrol.ResumeLayout(false);
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
    }
}

