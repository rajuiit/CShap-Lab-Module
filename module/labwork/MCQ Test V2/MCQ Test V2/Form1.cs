using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MCQ_Test_V2
{
    public partial class Form1 : Form
    {
        int panelsize=0;
        const int totalquestion = 3;
        private int i = 0;
        string[] question = { "Who are you?", "Who am I?", "how are you?" };
        string[,] choice = new string[totalquestion, 4] {
            {"reza","raju","hasnat","sohel"}, 
            {"reza","raju","hasnat","sohel"}, 
            {"reza","raju","hasnat","sohel"}  };

        int[] correct_answer = { 1, 2, 3 };
        int[] answer = new int[totalquestion];


        Panel[] panel = new Panel[totalquestion];
        Label[] label = new Label[totalquestion];
        RadioButton[] choiceRB1 = new RadioButton[totalquestion];
        RadioButton[] choiceRB2 = new RadioButton[totalquestion];
        RadioButton[] choiceRB3 = new RadioButton[totalquestion];
        RadioButton[] choiceRB4 = new RadioButton[totalquestion];
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < totalquestion; i++)
            {     panel[i] = new Panel();
            label[i] = new Label();
            choiceRB1[i] = new RadioButton();
            choiceRB2[i] = new RadioButton();
            choiceRB3[i] = new RadioButton();
            choiceRB4[i] = new RadioButton();
 
                
                panel[i].SuspendLayout();
                this.SuspendLayout();
                // 
                // label1
                // 
                label[i].AutoSize = true;
                label[i].Location = new System.Drawing.Point(4, 4);
                label[i].Name = "question"+i.ToString();
                label[i].Size = new System.Drawing.Size(35, 13);
                label[i].TabIndex = 0;
                label[i].Text = (i+1).ToString()+". "+question[i];

                int radio_size = 0;
                
                    
                    // 
                    // choiceRB1
                    // 
                    choiceRB1[i].AutoSize = true;
                    choiceRB1[i].Checked = true;
                    choiceRB1[i].Location = new System.Drawing.Point(100, 24+ radio_size);
                    choiceRB1[i].Name = "choiceRB1" + i.ToString();
                    choiceRB1[i].Size = new System.Drawing.Size(85, 17);
                    choiceRB1[i].TabIndex = 1;
                    
                    choiceRB1[i].TabStop = true;

                    choiceRB1[i].Text = choice[i, 0];
                    //choiceRB1[i].Text = choiceRB1[i].Name;
                    choiceRB1[i].UseVisualStyleBackColor = true;
                    radio_size = radio_size + choiceRB1[i].Height + 8;
                    

                    panel[i].Controls.Add(choiceRB1[i]);

                    // 
                    // choiceRB2
                    // 
                    choiceRB2[i].AutoSize = true;
                    choiceRB2[i].Checked = false;
                    choiceRB2[i].Location = new System.Drawing.Point(100, 24 + radio_size);
                    choiceRB2[i].Name = "choiceRB2" + i.ToString();
                    choiceRB2[i].Size = new System.Drawing.Size(85, 17);
                    choiceRB2[i].TabIndex = 1;

                    choiceRB2[i].TabStop = true;

                    choiceRB2[i].Text = choice[i, 1];
                    //choiceRB2[i].Text = choiceRB2[i].Name;
                    choiceRB2[i].UseVisualStyleBackColor = true;
                    radio_size = radio_size + choiceRB2[i].Height + 8;


                    panel[i].Controls.Add(choiceRB2[i]);

                    // 
                    // choiceRB3
                    // 
                    choiceRB3[i].AutoSize = true;
                    choiceRB3[i].Checked = false;
                    choiceRB3[i].Location = new System.Drawing.Point(100, 24 + radio_size);
                    choiceRB3[i].Name = "choiceRB3" + i.ToString();
                    choiceRB3[i].Size = new System.Drawing.Size(85, 17);
                    choiceRB3[i].TabIndex = 1;

                    choiceRB3[i].TabStop = true;

                    choiceRB3[i].Text = choice[i, 2];
                    //choiceRB3[i].Text = choiceRB3[i].Name;
                    choiceRB3[i].UseVisualStyleBackColor = true;
                    radio_size = radio_size + choiceRB3[i].Height + 8;


                    panel[i].Controls.Add(choiceRB3[i]);

                    // 
                    // choiceRB4
                    // 
                    choiceRB4[i].AutoSize = true;
                    choiceRB4[i].Checked = false;
                    choiceRB4[i].Location = new System.Drawing.Point(100, 24 + radio_size);
                    choiceRB4[i].Name = "choiceRB4" + i.ToString();
                    choiceRB4[i].Size = new System.Drawing.Size(85, 17);
                    choiceRB4[i].TabIndex = 1;

                    choiceRB4[i].TabStop = true;

                    choiceRB4[i].Text = choice[i, 3];
                    //choiceRB4[i].Text = choiceRB4[i].Name;
                    choiceRB4[i].UseVisualStyleBackColor = true;
                    radio_size = radio_size + choiceRB4[i].Height + 8;


                    panel[i].Controls.Add(choiceRB4[i]);
                

                // 
                // panel[i]1
                // 
                panel[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                panel[i].Controls.Add(label[i]);
                
                    
                panel[i].Location = new System.Drawing.Point(12, 13 + panelsize);
                panel[i].Name = "panel";
                panel[i].Size = new System.Drawing.Size(1300, 130);
                panel[i].TabIndex = 0;
                
                //form
                this.Controls.Add(panel[i]);
                panel[i].ResumeLayout(false);
                panel[i].PerformLayout();

                panelsize =panelsize+ panel[i].Height+8;
                    
            }
            Button finishB = new Button();
            // 
            // finishB
            // 
            finishB.Location = new System.Drawing.Point(100, panelsize+20);
            finishB.Name = "finishB";
            finishB.Size = new System.Drawing.Size(75, 23);
            finishB.TabIndex = 7;
            finishB.Text = "Finish";
            finishB.UseVisualStyleBackColor = true;
            finishB.Click += new System.EventHandler(this.finishB_Click);


            this.Controls.Add(finishB);
        }

       

        private void finishB_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < totalquestion; j++)
            { 
            
                if (choiceRB1[j].Checked == true)
                {
                    answer[j] = 1;
                }
                if (choiceRB2[j].Checked == true)
                {
                    answer[j] = 2;
                } if (choiceRB3[j].Checked == true)
                {
                    answer[j] = 3;
                } if (choiceRB4[j].Checked == true)
                {
                    answer[j] = 4;
                }
            
            }
            
            
            
            MessageBox.Show(score_count().ToString());
        }

        private int score_count()
        {
            int count = 0;
            for (int l = 0; l < correct_answer.Length; l++)
            {
                
                if (answer[l] == correct_answer[l])
                    count++;
            }
            return count;
        }

        
    }
}
