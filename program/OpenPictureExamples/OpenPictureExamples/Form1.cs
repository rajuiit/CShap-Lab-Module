using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OpenPictureExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"; 
            if (result == DialogResult.OK) // Test result.
            {
                pictureBox.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                // image file path
                filenameTB.Text = openFileDialog1.FileName;
                
            }
            MessageBox.Show("The result is :" + result); 

        }
    }
}
