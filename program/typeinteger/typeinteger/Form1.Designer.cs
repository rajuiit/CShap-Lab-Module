namespace typeinteger
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
            this.integerTB = new System.Windows.Forms.TextBox();
            this.show_button = new System.Windows.Forms.Button();
            this.floatTB = new System.Windows.Forms.TextBox();
            this.doubleTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.integerLB = new System.Windows.Forms.Label();
            this.floatLB = new System.Windows.Forms.Label();
            this.doubleLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // integerTB
            // 
            this.integerTB.Location = new System.Drawing.Point(198, 61);
            this.integerTB.Name = "integerTB";
            this.integerTB.Size = new System.Drawing.Size(100, 20);
            this.integerTB.TabIndex = 0;
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(198, 199);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(100, 23);
            this.show_button.TabIndex = 1;
            this.show_button.Text = "ShowButton";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // floatTB
            // 
            this.floatTB.Location = new System.Drawing.Point(198, 106);
            this.floatTB.Name = "floatTB";
            this.floatTB.Size = new System.Drawing.Size(100, 20);
            this.floatTB.TabIndex = 2;
            // 
            // doubleTB
            // 
            this.doubleTB.Location = new System.Drawing.Point(198, 150);
            this.doubleTB.Name = "doubleTB";
            this.doubleTB.Size = new System.Drawing.Size(100, 20);
            this.doubleTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your integer value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter your float value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter your double value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Your integer result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Your floating result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Your double result";
            // 
            // integerLB
            // 
            this.integerLB.AutoSize = true;
            this.integerLB.Location = new System.Drawing.Point(198, 247);
            this.integerLB.Name = "integerLB";
            this.integerLB.Size = new System.Drawing.Size(35, 13);
            this.integerLB.TabIndex = 10;
            this.integerLB.Text = "label7";
            // 
            // floatLB
            // 
            this.floatLB.AutoSize = true;
            this.floatLB.Location = new System.Drawing.Point(198, 281);
            this.floatLB.Name = "floatLB";
            this.floatLB.Size = new System.Drawing.Size(35, 13);
            this.floatLB.TabIndex = 11;
            this.floatLB.Text = "label8";
            // 
            // doubleLB
            // 
            this.doubleLB.AutoSize = true;
            this.doubleLB.Location = new System.Drawing.Point(198, 307);
            this.doubleLB.Name = "doubleLB";
            this.doubleLB.Size = new System.Drawing.Size(35, 13);
            this.doubleLB.TabIndex = 12;
            this.doubleLB.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 351);
            this.Controls.Add(this.doubleLB);
            this.Controls.Add(this.floatLB);
            this.Controls.Add(this.integerLB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doubleTB);
            this.Controls.Add(this.floatTB);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.integerTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox integerTB;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.TextBox floatTB;
        private System.Windows.Forms.TextBox doubleTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label integerLB;
        private System.Windows.Forms.Label floatLB;
        private System.Windows.Forms.Label doubleLB;
    }
}

