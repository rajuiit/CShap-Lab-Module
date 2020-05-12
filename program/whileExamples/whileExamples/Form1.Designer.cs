namespace whileExamples
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
            this.sumTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(206, 139);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(100, 23);
            this.show_button.TabIndex = 0;
            this.show_button.Text = "ShowButton";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter how many number you sum:";
            // 
            // sumTB
            // 
            this.sumTB.Location = new System.Drawing.Point(206, 95);
            this.sumTB.Name = "sumTB";
            this.sumTB.Size = new System.Drawing.Size(100, 20);
            this.sumTB.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 230);
            this.Controls.Add(this.sumTB);
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
        private System.Windows.Forms.TextBox sumTB;
    }
}

