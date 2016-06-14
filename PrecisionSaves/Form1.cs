﻿using System;
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
        public int game_id = 0;
        public string[] files;
        public bool saveloaded = false;
        public string filetoload = "";

        //Cheat vars

        int Project_Mirai_DX_MaxMP = 0x0008;
        int Project_Mirai_DX_AgentMoose = 0x98;
        int Project_Mirai_DX_deathwilldie = 0x20;
        int Project_Mirai_DX_SpankrPoodle = 0x60;
        int[] Project_Mirai_DX_Songs =
        {
            0x2750, 0x2848, 0x2940, 0x2A38, 0x2B30, 0x2C28, 0x2D20, 0x2E18, 0x2F10, 0x3008, 0x3100, 0x31F8, 0x32F0, 0x33E8,
            0x34E0, 0x35D8, 0x36D0, 0x37C8, 0x38C0, 0x39B8, 0x3AB0, 0x3BA8, 0x3CA0, 0x3D98, 0x3E90, 0x3F88, 0x4080, 0x4178,
            0x4270, 0x4368, 0x4460, 0x4558, 0x4650, 0x4748, 0x4840, 0x4938, 0x4A30, 0x4B28, 0x4C20, 0x4D18, 0x4E10, 0x4F08,
            0x5000, 0x50F8, 0x51F0, 0x52E8, 0x53E0, 0x54D8, 0x55D0
        };
        int[][] Project_Mirai_DX_SmallItems =
{
            new int[] { 0x6a28, 0x6a40, 0x6a48, 0x6a58, 0x6a60, 0x6a78, 0x6a88, 0x6a90, 0x6ac8, 0x6ad0, 0x6ad8, 0x6af0, 0x6af8 },

            new int[] { 0x69c0, 0x69c8, 0x69d0, 0x69d8, 0x69e0, 0x69e8, 0x69f0, 0x69f8, 0x6a00, 0x6a08, 0x6a10, 0x6a18, 0x6a20,
                        0x6a28, 0x6a30, 0x6a38, 0x6a40, 0x6a48, 0x6a50, 0x6a58, 0x6a60, 0x6a68, 0x6a70, 0x6a78, 0x6a80, 0x6a88,
                        0x6a90, 0x6a98, 0x6aa0, 0x6aa8, 0x6ab0, 0x6ab8, 0x6ac0, 0x6ac8, 0x6ad0, 0x6ad8, 0x6ae0, 0x6ae8, 0x6af0,
                        0x6af8, 0x6b00 }
        };

        int[][] Project_Mirai_DX_MediumItems =
        {
            new int[] { 0x6bd8, 0x6c10, 0x6c80 },
            new int[] { 0x6b50, 0x6B58, 0x6B60, 0x6B68, 0x6B70, 0x6B78, 0x6B80, 0x6B88, 0x6B88,
                        0x6B98, 0x6BA0, 0x6BA8, 0x6BB0, 0x6BB8, 0x6BC0, 0x6BC8, 0x6BD0, 0x6BD8,
                        0x6BE0, 0x6BE8, 0x6BF0, 0x6BF8, 0x6C00, 0x6C08, 0x6C10, 0x6C18, 0x6C20,
                        0x6C28, 0x6C30, 0x6C38, 0x6C40, 0x6C48, 0x6C50, 0x6C58, 0x6C60, 0x6C68,
                        0x6C70, 0x6C78, 0x6c80 }
        };

        int[][] Project_Mirai_DX_LargeItems =
        {
            new int[] { 0x6d38 },

            new int[] { 0x6CE0, 0x6CE8, 0x6CF0, 0x6CF8, 0x6D00, 0x6D08, 0x6D10, 0x6D18, 0x6D20, 0x6D28, 0x6D30, 0x6D38 }
        };

        int[] Project_Mirai_DX_WallItems =
        {
            0x6D80, 0x6D88, 0x6D90, 0x6D98, 0x6DA0, 0x6DA8, 0x6DB0, 0x6DB8, 0x6DC0,
            0x6DC8, 0x6DD0, 0x6DD8, 0x6DE0, 0x6DE8, 0x6DF0, 0x6DF8, 0x6E00, 0x6E08, 0x6E10
        };

        int[][] Project_Mirai_DX_AirItems =
        {
            new int[] { 0x6e90 },
            new int[] { 0x6e70, 0x6e78, 0x6e80, 0x6e88, 0x6e90 }
        };

        int[] Project_Mirai_DX_PoolItems =
        {
            0x6EC0, 0x6EC8, 0x6ED0, 0x6ED8
        };


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
                game_id = 0;
            }
            else
            {
                if (Properties.Settings.Default.gametitle == "Hatsune Miku: Project Mirai DX (EUR/US)")
                {
                    game_title = "Hatsune_Miku_Project_Mirai_DX";
                    game_id = 1;
                }
                    
                else
                {
                    if (Properties.Settings.Default.gametitle == "Pokémon: Alpha Sapphire (EUR/US)")
                    {
                        game_title = "Pokemon_Alpha_Sapphire";
                        game_id = 2;
                    }                    
                    else
                    {

                    }
                }
                savedata_dir = savedata_path + "\\" + game_title;
                makedir(savedata_dir);
                if (oldtitle != game_title)
                {
                    refreshbackuplist();
                    loadCheatList(game_id);
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
                    MessageBox.Show("Error locating saveDataBackup.", "PrecisionSaves");
                }

            }
            else
            {
                MessageBox.Show("Please select the game first.", "PrecisionSaves");
            }

        }
        private void refreshbackuplist()
        {
            savedata_listbox.Items.Clear();
            PopulateListBox(savedata_listbox, savedata_dir);
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
                MessageBox.Show("Exception: {0}", e.Message);
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
                MessageBox.Show("Please select the game and load a save first.", "PrecisionSaves");
            }

        }
        private void autobackup()
        {
            backuptozip("AUTO-BACKUP", loadsavepath, savedata_dir);
        }

        private void restore_save_button_Click(object sender, EventArgs e)
        {
            restorefromzip(savedata_listbox.GetItemText(savedata_listbox.SelectedItem), loadsavepath);
            MessageBox.Show("Restore completed. Please restore the save to the system using " + Environment.NewLine + "save_manager through HBL.", "PrecisionSaves");
        }


        //Cheats and stuff

        private void loadCheatList(int title)
        {
            cheat_listbox.Items.Clear();
            if (title == 0)
            {
                filetoload = "";
            }
            if (title == 1)
            {
                filetoload = "bk_m2r.bin";
                cheat_listbox.Items.Add("Max MP");
                cheat_listbox.Items.Add("Unlock All Songs");
                cheat_listbox.Items.Add("Unlock All Hard/Super Hard Songs");
                cheat_listbox.Items.Add("Unlock All Items");
                cheat_listbox.Items.Add("Unlock Small Items");
                cheat_listbox.Items.Add("Unlock Medium Items");
                cheat_listbox.Items.Add("Unlock Large Items");
                cheat_listbox.Items.Add("Unlock Air items");
            }
        }

        private void MiraiDxUnlock(int offset, byte[] value)
        {
            FileStream miraiFS = new FileStream(save_file_original, FileMode.Open);
            BinaryWriter miraiBR = new BinaryWriter(miraiFS);
            miraiFS.Position = offset;
            miraiBR.Write(value);
            miraiFS.Close();
        }

        private void writecheat_button_Click(object sender, EventArgs e)
        {
            string selectedcheat = cheat_listbox.GetItemText(cheat_listbox.SelectedItem);
            autobackup();
            refreshbackuplist();
            if (game_id == 1)
            {
                save_file_original = loadsavepath + "\\" + filetoload;
                if (selectedcheat == "Max MP")
                {
                    
                    byte[] value = { 0xF4, 0x23, 0x0F, 0x00 };
                    MiraiDxUnlock(Project_Mirai_DX_MaxMP, value);
                    MessageBox.Show("MP Set to 992244!", "PrecisionSaves");
                }
                if (selectedcheat == "Unlock All Songs")
                {
                    byte[] value = { 0xA0 };
                    foreach (var Song_offset in Project_Mirai_DX_Songs)
                    {
                        MiraiDxUnlock(Song_offset + Project_Mirai_DX_AgentMoose, value);
                    }
                    MessageBox.Show("All Songs Unlocked!", "PrecisionSaves");
                }
                if (selectedcheat == "Unlock All Hard/Super Hard Songs")
                {
                    byte[] value = { 0x01 };
                    foreach (var Song_offset in Project_Mirai_DX_Songs)
                    {
                        //Unlock Hard Button
                        MiraiDxUnlock(Song_offset + Project_Mirai_DX_deathwilldie, value);
                    }
                    foreach (var Song_offset in Project_Mirai_DX_Songs)
                    {
                        //Unlock Hard Touch
                        MiraiDxUnlock(Song_offset + Project_Mirai_DX_SpankrPoodle, value);
                    }
                    MessageBox.Show("All Hard/Super Hard Difficulties Unlocked!", "PrecisionSaves");
                }
                if (selectedcheat == "Unlock All Items")
                {
                    byte[] value = { 0x03 };
                    foreach (var items in Project_Mirai_DX_SmallItems[0])
                    {
                        MiraiDxUnlock(items, value);
                    }
                    foreach (var items in Project_Mirai_DX_MediumItems[0])
                    {
                        MiraiDxUnlock(items, value);
                    }
                    foreach (var items in Project_Mirai_DX_LargeItems[0])
                    {
                        MiraiDxUnlock(items, value);
                    }
                    foreach (var items in Project_Mirai_DX_AirItems[0])
                    {
                        MiraiDxUnlock(items, value);
                    }
                    MessageBox.Show("Unlocked All Items!", "PrecisionSaves");
                }
                if (selectedcheat == "Unlock Small Items")
                {
                    byte[] value = { 0x03 };
                    foreach (var items in Project_Mirai_DX_SmallItems[0])
                    {
                        MiraiDxUnlock(items, value);
                    }
                    MessageBox.Show("Unlocked All Small Items!", "PrecisionSaves");
                }
                if (selectedcheat == "Unlock Medium Items")
                {
                    byte[] value = { 0x03 };
                    foreach (var items in Project_Mirai_DX_MediumItems[0])
                    {
                        MiraiDxUnlock(items, value);
                    }
                    MessageBox.Show("Unlocked All Medium Items!", "PrecisionSaves");
                }
                if (selectedcheat == "Unlock Large Items")
                {
                    byte[] value = { 0x03 };
                    foreach (var items in Project_Mirai_DX_LargeItems[0])
                    {
                        MiraiDxUnlock(items, value);
                    }
                    MessageBox.Show("Unlocked All Large Items!", "PrecisionSaves");
                }
                if (selectedcheat == "Unlock Air Items")
                {
                    byte[] value = { 0x03 };
                    foreach (var items in Project_Mirai_DX_AirItems[0])
                    {
                        MiraiDxUnlock(items, value);
                        MessageBox.Show("Unlocked All Air Items!", "PrecisionSaves");
                    }
                }
            }
        }
    }

}
