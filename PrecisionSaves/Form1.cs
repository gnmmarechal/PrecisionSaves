﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrecisionSaves
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setgameform setform = new setgameform();
            setform.Show();
        }
    }
}
