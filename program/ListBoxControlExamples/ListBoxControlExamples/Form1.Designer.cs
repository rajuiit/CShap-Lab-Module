namespace ListBoxControlExamples
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
            this.dnameLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.show_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dnameLB
            // 
            this.dnameLB.FormattingEnabled = true;
            this.dnameLB.Location = new System.Drawing.Point(153, 53);
            this.dnameLB.Name = "dnameLB";
            this.dnameLB.Size = new System.Drawing.Size(104, 95);
            this.dnameLB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Department";
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(167, 154);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(90, 23);
            this.show_button.TabIndex = 2;
            this.show_button.Text = "ShowButton";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dnameLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dnameLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show_button;
    }
}

