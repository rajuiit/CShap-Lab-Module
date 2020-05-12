using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace reportfirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text.ToString();

            List<ReportParameter> rptPara = new List<ReportParameter>();
            rptPara.Add(new ReportParameter("name", name));
            reportViewer1.LocalReport.SetParameters(rptPara);


            this.reportViewer1.RefreshReport();
        }
    }
}
