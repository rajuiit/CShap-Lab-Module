using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassObjectMethodValuePass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculation obj = new calculation();
            obj.add(int.Parse(firstTB.Text), int.Parse(secondTB.Text));

            
        }
    }
}
