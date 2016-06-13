using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Compression;


namespace PrecisionSaves
{
    public partial class mainform : Form
    {
        //Vars
        public string game_title;
        public string save_file_original;
        //
        public mainform()
        {
            InitializeComponent();
        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setgameform setform = new setgameform();
            setform.Show();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.gametitle = "";
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            createdirectories();
        }

        private void savedataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (game_title != "NULL")
            {
                FolderBrowserDialog selectdirdialog = new FolderBrowserDialog();
                selectdirdialog.Description = "TEST";
                selectdirdialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select the game first.");
            }
        }

        private void timer_checker_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.gametitle == "")
            {
                game_title = "NULL";
            }
            else
            {
                if (Properties.Settings.Default.gametitle == "Hatsune Miku: Project Mirai DX (EUR/US)")
                    game_title = "Hatsune_Miku_Project_Mirai_DX";
                else
                {

                }
                loadCheatList(game_title);
            }
        }

        private void loadCheatList(string title)
        {

        }
        private void MiraiDxUnlock(int offset, byte[] value)
        {
            FileStream miraiFS = new FileStream(save_file_original, FileMode.Open);
            BinaryWriter miraiBR = new BinaryWriter(miraiFS);
            miraiFS.Position = offset;
            miraiBR.Write(value);
            miraiFS.Close();
        }
        private void createdirectories()
        {
            if (!Directory.Exists("savedata"))
                Directory.CreateDirectory("savedata");
        }
        private void backuptozip(string backupname, string savepath, string backuppath)
        {
            if (String.IsNullOrWhiteSpace(backupname))
            {
                backupname = "PSBackup";
            }
            string zipname = game_title + "_" + DateTime.Now.ToString("MM_dd_yyyy_hh_mm_ss") + "_" + backupname + ".zip";
            ZipFile.CreateFromDirectory(savepath, backuppath + "\\" + zipname);
        }
    }

}
