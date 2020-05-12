using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Picture_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseB_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp) | *.jpg; *.jpeg; *.gif; *.bmp";

            if (result == DialogResult.OK) {

                

                FileInfo fi = new FileInfo(openFileDialog1.FileName);
                long fileSize = fi.Length / 1000;//in KB
                fileSIzeL.Text = fileSize.ToString() + " KB";

                if (fileSize < 2000)
                {
                    PassportSizePB.Image = new Bitmap(openFileDialog1.FileName);
                    stampSizePB.Image = new Bitmap(openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("This FileSize is "+fileSize+" KB. Filesize should be less than 2 MB.");
                }
            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }
    }
}
