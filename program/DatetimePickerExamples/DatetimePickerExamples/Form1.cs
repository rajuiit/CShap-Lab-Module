using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatetimePickerExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //dateTP.Format = DateTimePickerFormat.Custom;
            //dateTP.CustomFormat = "MMM dd, 'of the year' yyyy ";
            
            // Initialize picker to yesterday.
            dateTP.Format = DateTimePickerFormat.Short;
            dateTP.Value = DateTime.Today;
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            DateTime vdate = dateTP.Value;
            dateLB.Text = vdate.ToString();

           
        }
    }
}
