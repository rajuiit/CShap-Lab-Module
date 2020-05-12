using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Type_Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addB_Click(object sender, EventArgs e)
        {

            
            double firstN = double.Parse(firstNumberTB.Text);
            double secondN = double.Parse(secondNumberTB.Text);
            double result = firstN + secondN;
            MessageBox.Show("The Add result as Integer : " + result.ToString());
        }
    }
}

