using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrecisionSaves
{
    public partial class backupnameformcs : Form
    {
        public backupnameformcs()
        {
            InitializeComponent();
        }

        private void set_backup_name_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.backupname = backup_name_textbox.Text;
            if (String.IsNullOrWhiteSpace(Properties.Settings.Default.backupname))
            {
                Properties.Settings.Default.backupname = "PSBackup";
            }
            this.Close();
        }
    }
}
