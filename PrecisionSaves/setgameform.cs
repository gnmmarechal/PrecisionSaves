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
    public partial class setgameform : Form
    {
        public setgameform()
        {
            InitializeComponent();
        }

        private void setgameform_Load(object sender, EventArgs e)
        {
            game_combobox.SelectedItem = game_combobox.Text = "Hatsune Miku: Project Mirai DX (EUR/US)";
        }

        private void selectgame_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.gametitle = game_combobox.Text;
            this.Close();
        }
    }
}
