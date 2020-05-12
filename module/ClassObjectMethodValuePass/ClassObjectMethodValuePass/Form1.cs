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
        calculation obj = new calculation();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
         // int result= calculation.   
            int result =  obj.add(int.Parse(firstTB.Text), int.Parse(secondTB.Text));
           // string result = obj.add(firstTB, secondTB);
            resultTB.Text = result.ToString();
            
        }

       
    }
}
