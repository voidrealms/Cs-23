﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void Do_Checked()
        {
            button1.Enabled = checkBox1.Checked;
        }
    }
}
