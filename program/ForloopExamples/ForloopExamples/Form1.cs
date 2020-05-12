using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ForloopExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            int n = int.Parse(addTB.Text);
            int i,sum=0;
            for (i = 0; i <= n; i++)
            {
            sum = sum + i;
            }
            MessageBox.Show("The sum is:"+sum);
            }
    }
}
