namespace DatetimePickerExamples
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
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.show_button = new System.Windows.Forms.Button();
            this.dateLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTP
            // 
            this.dateTP.Location = new System.Drawing.Point(67, 59);
            this.dateTP.Name = "dateTP";
            this.dateTP.Size = new System.Drawing.Size(200, 20);
            this.dateTP.TabIndex = 0;
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(192, 111);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(75, 23);
            this.show_button.TabIndex = 2;
            this.show_button.Text = "ShowButton";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // dateLB
            // 
            this.dateLB.AutoSize = true;
            this.dateLB.Location = new System.Drawing.Point(170, 200);
            this.dateLB.Name = "dateLB";
            this.dateLB.Size = new System.Drawing.Size(35, 13);
            this.dateLB.TabIndex = 1;
            this.dateLB.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your selected date is:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.dateLB);
            this.Controls.Add(this.dateTP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTP;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Label dateLB;
        private System.Windows.Forms.Label label1;
    }
}

