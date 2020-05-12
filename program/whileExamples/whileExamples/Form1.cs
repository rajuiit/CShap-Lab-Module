using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace whileExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            int n = int.Parse(sumTB.Text);
            int i=1,sum=0;
            while ( i <= n)
            {
            sum = sum + i;
            i++;
            }
          
            MessageBox.Show("The sum is:"+sum);
            } 
        }
    }

