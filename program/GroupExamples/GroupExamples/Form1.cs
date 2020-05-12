using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GroupExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void favourite_button_Click(object sender, EventArgs e)
        {
            string favolanguage = "";
            if (radioButton1.Checked)
            {
                favolanguage = radioButton1.Text;
            }
            else  if (radioButton2.Checked)
            {
                favolanguage = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                favolanguage = radioButton3.Text;
            }
            else
            {
                favolanguage = radioButton4.Text;
            }
            MessageBox.Show("Your favourite language is:"+ favolanguage);

        }

        private void selected_button_Click(object sender, EventArgs e)
        {
            string language = "";
            //if (checkBox1.Checked)
            //{
            //    language = language + checkBox1.Text + "\n";
            //}
            //if (checkBox2.Checked)
            //{
            //    language = language + checkBox2.Text + "\n";
            //}
            //if (checkBox3.Checked)
            //{
            //    language = language + checkBox3.Text + "\n";
            //}
            //if (checkBox4.Checked)
            //{
            //    language = language + checkBox4.Text + "\n";
            //}
            CheckBox[] cb = { checkBox1,checkBox2,checkBox3,checkBox4};
            int i = 0;
            while (i < cb.Length) {
                if (cb[i].Checked)
                {
                    language = language + cb[i].Text + "\n";
                }
                i++;
            }



            MessageBox.Show(language);
        }

       
    }
}
