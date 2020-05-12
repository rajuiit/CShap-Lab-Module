using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MCQ_Test
{
    public partial class Form1 : Form
    {
        private int i = 0;
        string[] question = {"Who are you?", "Who am I?","how are you?" };
            string[,] choice = new string[3, 4] {
            {"reza","raju","hasnat","sohel"}, 
            {"reza","raju","hasnat","sohel"}, 
            {"reza","raju","hasnat","sohel"}  };
           
            int[] correct_answer ={1,2,3};
            int[] answer;
                
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            answer = new int[correct_answer.Length];
            fill_up_question(0);
        }

        private void fill_up_question(int position)
        {
            questionL.Text = question[position];
            choice1RB.Text = choice[position,0];
            choice2RB.Text = choice[position,1];
            choice3RB.Text = choice[position,2];
            choice4RB.Text = choice[position,3];
            try
            {
                check_answer(answer[i]);
            }
            catch (Exception ex) {
                choice1RB.Checked = true;
            }
            check_first_last(i);
        }

        private void check_answer(int pos)
        {
            if (pos==1)
            {
                choice1RB.Checked = true;
            }
            else if (pos == 2)
            {
                choice2RB.Checked = true;
            }else if (pos == 3)
            {
                choice3RB.Checked = true;
            }
            else if (pos == 4)
            {
                choice4RB.Checked = true;
            }
            else {
                choice1RB.Checked = true;
            }
            
        }

        private void nextB_Click(object sender, EventArgs e)
        {

            answer[i] = found_answer();
            i++;
            fill_up_question(i);
            
        }

        private int found_answer()
        {
            int ans=1;
            if (choice1RB.Checked) {
                ans = 1;
            }
            if (choice2RB.Checked)
            {
                ans = 2;
            } if (choice3RB.Checked)
            {
                ans = 3;
            } if (choice4RB.Checked)
            {
                ans = 4;
            }
            return ans;
        }

        private void previousB_Click(object sender, EventArgs e)
        {

            answer[i] = found_answer();
            i--;
            
            fill_up_question(i);
           

        }

        private void check_first_last(int position)
        {
            if (i == 0) {
                previousB.Enabled = false;
                finishB.Enabled = false;
                
            }
            if (i == question.Length - 1)
            {
                nextB.Enabled = false;
                finishB.Enabled = true;
            }

            if(i!=0 && i!= question.Length-1){

                previousB.Enabled = true;
                nextB.Enabled = true;
                finishB.Enabled = false;
            }
            
           
        }

        private void finishB_Click(object sender, EventArgs e)
        {
            answer[i] = found_answer();
            MessageBox.Show(score_count().ToString());
        }

        private int score_count()
        {
            int count=0;
            for (int i=0; i < answer.Length; i++ )
            {
                if (answer[i] == correct_answer[i])
                    count++;
            }
            return count;
        }

        private void choice1RB_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        

       
        

        
        

        
    }
}
