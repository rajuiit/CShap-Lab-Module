using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mdiExamples2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadMDi();
        }
        public void loadMDi() {


            IsMdiContainer = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            frm2.MdiParent = this;
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            frm3.MdiParent = this;
        }
    }
}
