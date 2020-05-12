using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace typeinteger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(integerTB.Text);//
            float number2 = float.Parse(floatTB.Text);
            double number3 = double.Parse(doubleTB.Text);
            integerLB.Text = number1.ToString();
            floatLB.Text = number2.ToString();
            doubleLB.Text = number3.ToString();

            MessageBox.Show(number1.ToString());
            MessageBox.Show(number2.ToString());
            MessageBox.Show(number3.ToString());

        }
    }
}
