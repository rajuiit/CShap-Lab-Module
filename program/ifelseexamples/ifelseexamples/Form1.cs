using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ifelseexamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            float marks = float.Parse(marksTB.Text);
            
            if (marks>=80 )
            { 
                MessageBox.Show("You got A+");
            }
            else if (marks >= 75)
            {
                MessageBox.Show("You got A");
            }
            else if (marks >= 70)
            {
                MessageBox.Show("You got A-");
            }
            else if (marks >= 65)
            {
                MessageBox.Show("You got B+");
            }
            else if (marks >=60)
            {
                MessageBox.Show("You got B");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
