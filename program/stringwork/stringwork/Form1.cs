﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace stringwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = "My String";
            MessageBox.Show(x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            MessageBox.Show(x);
        }
    }
}
