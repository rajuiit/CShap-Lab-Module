using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace saveExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string save_file = "";
            saveFD.InitialDirectory = "C:";
            saveFD.Title = "";
            saveFD.FileName = "";
            saveFD.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFD.ShowDialog() !=DialogResult.Cancel)
            {
                save_file = saveFD.FileName;
                richTextBox1.SaveFile(save_file, RichTextBoxStreamType.PlainText);
            
            
            }

        }
    }
}
