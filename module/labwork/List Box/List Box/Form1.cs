﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace List_Box
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

      

        private void deptLB_Click(object sender, EventArgs e)
        {
            int i = 1;
            string dept = "";
            showDeptL.Text = "";
            foreach (Object obj in deptLB.SelectedItems)
            {
                dept = dept + i + ". " + obj.ToString() + "\n";
                i++;
            }


            showDeptL.Text = dept;
        }
    }
}
