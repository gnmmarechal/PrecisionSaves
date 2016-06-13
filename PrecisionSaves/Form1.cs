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
        public string savedata_path = "savedata";
        public string loadsavepath = "";
        public string savedata_dir;
        public string[] files;
        public bool saveloaded = false;
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
            Properties.Settings.Default.backupname = "";
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            createdirectories();
        }

        private void savedataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadsavedata();
        }

        private void timer_checker_Tick(object sender, EventArgs e)
        {
            if (savedata_listbox.SelectedIndex == -1)
                restore_save_button.Enabled = false;
            else
                restore_save_button.Enabled = true;
            string oldtitle = game_title;
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
                    if (Properties.Settings.Default.gametitle == "Pokémon: Alpha Sapphire (EUR/US)")
                        game_title = "Pokemon_Alpha_Sapphire";
                    else
                    {

                    }
                }
                savedata_dir = savedata_path + "\\" + game_title;
                loadCheatList(game_title);
                makedir(savedata_dir);
                if (oldtitle != game_title)
                {
                    refreshbackuplist();
                }
                //System.Diagnostics.Debug.WriteLine(game_title);
            }
        }
        private void loadsavedata()
        {
            if (game_title != "NULL")
            {
                FolderBrowserDialog selectdirdialog = new FolderBrowserDialog();
                selectdirdialog.Description = "Please select SD:\\saveDataBackup";
                DialogResult result = selectdirdialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    loadsavepath = selectdirdialog.SelectedPath;
                    saveloaded = true;
                    if (Directory.Exists(loadsavepath + "\\saveDataBackup"))
                        loadsavepath = loadsavepath + "\\saveDataBackup";

                }
                else
                {
                    MessageBox.Show("Error locating saveDataBackup.");
                }

            }
            else
            {
                MessageBox.Show("Please select the game first.");
            }

        }
        private void refreshbackuplist()
        {
            savedata_listbox.Items.Clear();
            PopulateListBox(savedata_listbox, savedata_dir);
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
            makedir(savedata_path);
        }
        private void makedir(string dire)
        {
            if (!Directory.Exists(dire))
                Directory.CreateDirectory(dire);
        }
        private void wipedir(string path)
        {
            Directory.Delete(path, true);
            Directory.CreateDirectory(path);
        }
        private void restorefromzip(string backupname,string savepath_original)
        {
            wipedir(savepath_original);
            ZipFile.ExtractToDirectory(savedata_dir + "\\" + backupname + ".zip", savepath_original);
        }
        private void backuptozip(string backupname, string savepath, string backuppath)
        {
            if (String.IsNullOrWhiteSpace(backupname))
            {
                backupname = "PSBackup";
            }
            //string zipname = game_title + "_" + DateTime.Now.ToString("MM_dd_yyyy_hh_mm_ss") + "_" + backupname + ".zip";
            string zipname = DateTime.Now.ToString("MM_dd_yyyy_hh_mm_ss") + "_" + backupname + ".zip";
            ZipFile.CreateFromDirectory(savepath, backuppath + "\\" + zipname);
        }
        private void PopulateListBox(ListBox lsb, string Folder)
        {

            try
            {
                files = Directory.GetFiles(Folder);
            }
            catch(Exception e)
            {
                files[0] = "No backups found";
            }


            foreach (string file in files)
            {
                lsb.Items.Add(Path.GetFileNameWithoutExtension(file));
            }


        }

        private void backup_savedata_button_Click(object sender, EventArgs e)
        {
            if (saveloaded & game_title != "NULL")
            {
                backupnameformcs BackupNameForm = new backupnameformcs();
                BackupNameForm.ShowDialog();
                if (String.IsNullOrWhiteSpace(Properties.Settings.Default.backupname))
                {
                    Properties.Settings.Default.backupname = "PSBackup";
                }
                backuptozip(Properties.Settings.Default.backupname, loadsavepath, savedata_dir );
                refreshbackuplist();
            }
            else
            {
                MessageBox.Show("Please select the game and load a save first.");
            }

        }

        private void restore_save_button_Click(object sender, EventArgs e)
        {
            restorefromzip(savedata_listbox.GetItemText(savedata_listbox.SelectedItem), loadsavepath);
        }
    }

}
