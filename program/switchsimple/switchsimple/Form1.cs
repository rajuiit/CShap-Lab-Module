using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace switchsimple
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
           int value =(int)marks/10; //Convert float to integer

            switch (value)
            {
                
                case 3:
                    MessageBox.Show("You have failed");
                    break;
                case 4:
                    MessageBox.Show("You have got B");
                    break;
                case 5:
                    MessageBox.Show("You have got B+");
                    break;
                case 6:
                    MessageBox.Show("You have got A-");
                    break;
                case 7:
                    MessageBox.Show("You have got A");
                    break;
                case 8:
                    MessageBox.Show("You have got A+");
                    break;

                default:
                    MessageBox.Show("Out of range !!");
                    break;
            }
        }

    }
}
