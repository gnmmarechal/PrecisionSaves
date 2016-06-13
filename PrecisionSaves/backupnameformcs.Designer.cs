namespace PrecisionSaves
{
    partial class backupnameformcs
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
            this.backup_name_textbox = new System.Windows.Forms.TextBox();
            this.set_backup_name_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backup_name_textbox
            // 
            this.backup_name_textbox.Location = new System.Drawing.Point(12, 21);
            this.backup_name_textbox.Name = "backup_name_textbox";
            this.backup_name_textbox.Size = new System.Drawing.Size(234, 20);
            this.backup_name_textbox.TabIndex = 0;
            // 
            // set_backup_name_button
            // 
            this.set_backup_name_button.Location = new System.Drawing.Point(253, 21);
            this.set_backup_name_button.Name = "set_backup_name_button";
            this.set_backup_name_button.Size = new System.Drawing.Size(75, 20);
            this.set_backup_name_button.TabIndex = 1;
            this.set_backup_name_button.Text = "Set";
            this.set_backup_name_button.UseVisualStyleBackColor = true;
            this.set_backup_name_button.Click += new System.EventHandler(this.set_backup_name_button_Click);
            // 
            // backupnameformcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 52);
            this.Controls.Add(this.set_backup_name_button);
            this.Controls.Add(this.backup_name_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "backupnameformcs";
            this.Text = "Set Backup Name:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox backup_name_textbox;
        private System.Windows.Forms.Button set_backup_name_button;
    }
}