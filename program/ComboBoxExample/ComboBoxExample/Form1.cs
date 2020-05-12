using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dnameCB.Items.Add("IIT");
            dnameCB.Items.Add("CSE");
            dnameCB.Items.Add("URP");
            dnameCB.Items.Add("MATH");
            dnameCB.Items.Add("PHARMACY");
            dnameCB.Items.Add("PHYSICS");
            dnameCB.Items.Add("STATISTICS");
            dnameCB.SelectedIndex = dnameCB.FindStringExact("IIT");

        }


        private void show_button_Click(object sender, EventArgs e)
        {
            string dname = dnameCB.Text;
            MessageBox.Show(dname);

        }

       
    }
}
