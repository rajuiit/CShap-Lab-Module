namespace stringVariabls
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
            this.show_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(173, 123);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(122, 23);
            this.show_button.TabIndex = 0;
            this.show_button.Text = "Get textBox Data";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Your Name";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(159, 68);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(136, 20);
            this.nameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Name is:";
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Location = new System.Drawing.Point(156, 198);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(35, 13);
            this.nameLB.TabIndex = 4;
            this.nameLB.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 287);
            this.Controls.Add(this.nameLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLB;
    }
}

