using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace timerExamples
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
            loadtime();
        }
           public void loadtime(){
             //timer1.Interval = 1000;
             timer1.Start();
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLB.Text = DateTime.Now.ToString();

           
        }

       
    }
}
