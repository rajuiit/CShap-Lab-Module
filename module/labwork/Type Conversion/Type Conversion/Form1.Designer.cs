namespace Type_Conversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNumberTB = new System.Windows.Forms.TextBox();
            this.secondNumberTB = new System.Windows.Forms.TextBox();
            this.addB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Second Number :";
            // 
            // firstNumberTB
            // 
            this.firstNumberTB.Location = new System.Drawing.Point(209, 56);
            this.firstNumberTB.Name = "firstNumberTB";
            this.firstNumberTB.Size = new System.Drawing.Size(128, 20);
            this.firstNumberTB.TabIndex = 2;
            // 
            // secondNumberTB
            // 
            this.secondNumberTB.Location = new System.Drawing.Point(209, 112);
            this.secondNumberTB.Name = "secondNumberTB";
            this.secondNumberTB.Size = new System.Drawing.Size(128, 20);
            this.secondNumberTB.TabIndex = 3;
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(262, 166);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(75, 23);
            this.addB.TabIndex = 4;
            this.addB.Text = "Add";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 235);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.secondNumberTB);
            this.Controls.Add(this.firstNumberTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNumberTB;
        private System.Windows.Forms.TextBox secondNumberTB;
        private System.Windows.Forms.Button addB;
    }
}

