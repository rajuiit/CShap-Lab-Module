namespace testing
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelName1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelName3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ShowStringConvert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Location = new System.Drawing.Point(149, 181);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(35, 13);
            this.labelName1.TabIndex = 2;
            this.labelName1.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Result:";
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Location = new System.Drawing.Point(149, 203);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(35, 13);
            this.labelName2.TabIndex = 4;
            this.labelName2.Text = "label2";
            // 
            // labelName3
            // 
            this.labelName3.AutoSize = true;
            this.labelName3.Location = new System.Drawing.Point(149, 227);
            this.labelName3.Name = "labelName3";
            this.labelName3.Size = new System.Drawing.Size(35, 13);
            this.labelName3.TabIndex = 5;
            this.labelName3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 315);
            this.Controls.Add(this.labelName3);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelName3;
    }
}

