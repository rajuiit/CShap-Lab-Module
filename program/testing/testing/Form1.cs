using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = "456";
            int i = int.Parse(x);
            float f = float.Parse(x);
            double d = double.Parse(x);
            //For OutPut
            labelName1.Text = i.ToString();//ToSting() Convert int to string
            labelName2.Text = f.ToString();//ToString() Convert float to string
            labelName3.Text = d.ToString();//ToSting Convert double to string
            MessageBox.Show(i.ToString());//ToSting() Convert int to string
            MessageBox.Show(f.ToString());//ToString() Convert float to string
            MessageBox.Show(d.ToString());//ToSting Convert double to string


        }
    }
}
