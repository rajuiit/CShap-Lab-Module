﻿namespace Age_Calculator
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
            this.showAgeL = new System.Windows.Forms.Label();
            this.birthdayDTP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your Birthday: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your Age is :";
            // 
            // showAgeL
            // 
            this.showAgeL.AutoSize = true;
            this.showAgeL.Location = new System.Drawing.Point(168, 176);
            this.showAgeL.Name = "showAgeL";
            this.showAgeL.Size = new System.Drawing.Size(0, 13);
            this.showAgeL.TabIndex = 3;
            // 
            // birthdayDTP
            // 
            this.birthdayDTP.Location = new System.Drawing.Point(171, 49);
            this.birthdayDTP.MaxDate = new System.DateTime(2014, 9, 1, 0, 0, 0, 0);
            this.birthdayDTP.MinDate = new System.DateTime(1971, 1, 1, 0, 0, 0, 0);
            this.birthdayDTP.Name = "birthdayDTP";
            this.birthdayDTP.Size = new System.Drawing.Size(200, 20);
            this.birthdayDTP.TabIndex = 4;
            this.birthdayDTP.Value = new System.DateTime(2013, 12, 31, 0, 0, 0, 0);
            this.birthdayDTP.ValueChanged += new System.EventHandler(this.bithdayDTP_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 344);
            this.Controls.Add(this.birthdayDTP);
            this.Controls.Add(this.showAgeL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label showAgeL;
        private System.Windows.Forms.DateTimePicker birthdayDTP;
    }
}

