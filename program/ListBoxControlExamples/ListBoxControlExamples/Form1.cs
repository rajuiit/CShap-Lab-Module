using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBoxControlExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void show_button_Click(object sender, EventArgs e)
        {

            foreach (Object obj in dnameLB.SelectedItems)
            {
                MessageBox.Show(obj.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dnameLB.Items.Add("IIT");
            dnameLB.Items.Add("CSE");
            dnameLB.Items.Add("URP");
            dnameLB.Items.Add("MATH");
            dnameLB.Items.Add("PHARMACY");
            dnameLB.Items.Add("PHYSICS");
            dnameLB.Items.Add("STATISTICS");
            dnameLB.SelectionMode = SelectionMode.MultiSimple;
        }
    }
}
