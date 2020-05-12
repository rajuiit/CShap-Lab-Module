using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckedListBoxexamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            dnameCLB.Items.Add("IIT", CheckState.Checked);
            dnameCLB.Items.Add("CSE", CheckState.Unchecked);
            dnameCLB.Items.Add("URP", CheckState.Indeterminate);
            dnameCLB.Items.Add("MATH", CheckState.Checked);
            dnameCLB.Items.Add("PHARMACY", CheckState.Unchecked);
            dnameCLB.Items.Add("PHYSICS", CheckState.Indeterminate);
            dnameCLB.Items.Add("STATISTICS", CheckState.Indeterminate);
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dname="";
            foreach (Object obj in dnameCLB.CheckedItems)
            {
             dname = dname + obj.ToString()+"\n";
            }
            MessageBox.Show(dname);
        }



       
    }
}
