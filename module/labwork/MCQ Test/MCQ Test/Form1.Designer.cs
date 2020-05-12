namespace MCQ_Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionL = new System.Windows.Forms.Label();
            this.choice1RB = new System.Windows.Forms.RadioButton();
            this.choice2RB = new System.Windows.Forms.RadioButton();
            this.choice3RB = new System.Windows.Forms.RadioButton();
            this.choice4RB = new System.Windows.Forms.RadioButton();
            this.nextB = new System.Windows.Forms.Button();
            this.previousB = new System.Windows.Forms.Button();
            this.finishB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionL
            // 
            this.questionL.AutoSize = true;
            this.questionL.Location = new System.Drawing.Point(43, 14);
            this.questionL.Name = "questionL";
            this.questionL.Size = new System.Drawing.Size(49, 13);
            this.questionL.TabIndex = 0;
            this.questionL.Text = "Question";
            // 
            // choice1RB
            // 
            this.choice1RB.AutoSize = true;
            this.choice1RB.Checked = true;
            this.choice1RB.Location = new System.Drawing.Point(46, 57);
            this.choice1RB.Name = "choice1RB";
            this.choice1RB.Size = new System.Drawing.Size(85, 17);
            this.choice1RB.TabIndex = 1;
            this.choice1RB.TabStop = true;
            this.choice1RB.Text = "radioButton1";
            this.choice1RB.UseVisualStyleBackColor = true;
            this.choice1RB.CheckedChanged += new System.EventHandler(this.choice1RB_CheckedChanged);
            // 
            // choice2RB
            // 
            this.choice2RB.AutoSize = true;
            this.choice2RB.Location = new System.Drawing.Point(46, 80);
            this.choice2RB.Name = "choice2RB";
            this.choice2RB.Size = new System.Drawing.Size(85, 17);
            this.choice2RB.TabIndex = 2;
            this.choice2RB.Text = "radioButton1";
            this.choice2RB.UseVisualStyleBackColor = true;
            // 
            // choice3RB
            // 
            this.choice3RB.AutoSize = true;
            this.choice3RB.Location = new System.Drawing.Point(46, 103);
            this.choice3RB.Name = "choice3RB";
            this.choice3RB.Size = new System.Drawing.Size(85, 17);
            this.choice3RB.TabIndex = 3;
            this.choice3RB.Text = "radioButton1";
            this.choice3RB.UseVisualStyleBackColor = true;
            // 
            // choice4RB
            // 
            this.choice4RB.AutoSize = true;
            this.choice4RB.Location = new System.Drawing.Point(46, 126);
            this.choice4RB.Name = "choice4RB";
            this.choice4RB.Size = new System.Drawing.Size(85, 17);
            this.choice4RB.TabIndex = 4;
            this.choice4RB.Text = "radioButton1";
            this.choice4RB.UseVisualStyleBackColor = true;
            // 
            // nextB
            // 
            this.nextB.Location = new System.Drawing.Point(273, 210);
            this.nextB.Name = "nextB";
            this.nextB.Size = new System.Drawing.Size(75, 23);
            this.nextB.TabIndex = 5;
            this.nextB.Text = "Next";
            this.nextB.UseVisualStyleBackColor = true;
            this.nextB.Click += new System.EventHandler(this.nextB_Click);
            // 
            // previousB
            // 
            this.previousB.Location = new System.Drawing.Point(183, 210);
            this.previousB.Name = "previousB";
            this.previousB.Size = new System.Drawing.Size(75, 23);
            this.previousB.TabIndex = 6;
            this.previousB.Text = "Previous";
            this.previousB.UseVisualStyleBackColor = true;
            this.previousB.Click += new System.EventHandler(this.previousB_Click);
            // 
            // finishB
            // 
            this.finishB.Location = new System.Drawing.Point(372, 210);
            this.finishB.Name = "finishB";
            this.finishB.Size = new System.Drawing.Size(75, 23);
            this.finishB.TabIndex = 7;
            this.finishB.Text = "Finish";
            this.finishB.UseVisualStyleBackColor = true;
            this.finishB.Click += new System.EventHandler(this.finishB_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.choice1RB);
            this.panel1.Controls.Add(this.questionL);
            this.panel1.Controls.Add(this.choice2RB);
            this.panel1.Controls.Add(this.choice3RB);
            this.panel1.Controls.Add(this.choice4RB);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 158);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.finishB);
            this.Controls.Add(this.previousB);
            this.Controls.Add(this.nextB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionL;
        private System.Windows.Forms.RadioButton choice1RB;
        private System.Windows.Forms.RadioButton choice2RB;
        private System.Windows.Forms.RadioButton choice3RB;
        private System.Windows.Forms.RadioButton choice4RB;
        private System.Windows.Forms.Button nextB;
        private System.Windows.Forms.Button previousB;
        private System.Windows.Forms.Button finishB;
        private System.Windows.Forms.Panel panel1;
    }
}

