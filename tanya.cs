﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyou_Hobby_shop
{
    public partial class konfirmasi : Form
    {
        public konfirmasi()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelTanya_Click(object sender, EventArgs e)
        {

        }
    }
}
