using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadioButtonExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            iitRB.Checked = true;// initial only iit checked

        }

        private void show_button_Click(object sender, EventArgs e)
        {
            if (iitRB.Checked == true)
            {
                MessageBox.Show("You are selected IIT");
                return;
            }
            else if (phyRB.Checked == true)
            {
                MessageBox.Show("You are selected Physics ");
                return;
            }
            else if (ecoRB.Checked == true)
            {
                MessageBox.Show("You are selected Economis ");
                return;
            }
            else
            {
                MessageBox.Show("You are selected Mathematics ");
                return;
            }

        }
    }
}
