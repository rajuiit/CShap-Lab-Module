using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Age_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            birthdayDTP.MaxDate = DateTime.Today;


        }

        private void bithdayDTP_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = birthdayDTP.Value;
            DateTime PresentYear = DateTime.Now;
            TimeSpan ts = PresentYear - dob;
            DateTime Age = DateTime.MinValue.AddDays(ts.Days);

            showAgeL.Text = string.Format(" {0} Years {1} Month {2} Days", Age.Year - 1, Age.Month - 1, Age.Day - 1);
        }

       
    }
}
