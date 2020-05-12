using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SwitchExamples
{
    public partial class Form1 : Form
    {
        double total1 = 0;
        string theOperator;
        public Form1()
        {
            InitializeComponent();
            
        }


        private void equals_button_Click(object sender, EventArgs e)
        {
            double num2;
            double answer;

            num2 = double.Parse(displayTB.Text);

            switch (theOperator)
            {
                case "+":
                    answer = total1 + num2;
                    displayTB.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "-":
                    answer = total1 - num2;
                    displayTB.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "*":
                    answer = total1 * num2;
                    displayTB.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "/":
                    answer = total1 / num2;
                    displayTB.Text = answer.ToString();
                    total1 = 0;
                    break;
                default:
                    answer = 0;
                    break;
            }

        }

        private void one_button_Click(object sender, EventArgs e)
        {
            displayTB.Text = displayTB.Text + one_button.Text;
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(displayTB.Text);
            theOperator = "+";
            displayTB.Clear();
        }
    }
}
