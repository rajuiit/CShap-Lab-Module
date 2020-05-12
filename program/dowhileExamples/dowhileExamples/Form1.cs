using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dowhileExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(sumTB.Text);
            int i = 1, sum = 0;
            do
            {
                sum = sum + i;
                i++;
            }
            while (i <= n);
            MessageBox.Show("The sum is:" + sum);

        } 
        
    }
    }

