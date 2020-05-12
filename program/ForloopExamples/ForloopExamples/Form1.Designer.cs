namespace ForloopExamples
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
            this.showLB = new System.Windows.Forms.Label();
            this.show_button = new System.Windows.Forms.Button();
            this.addTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showLB
            // 
            this.showLB.AutoSize = true;
            this.showLB.Location = new System.Drawing.Point(12, 97);
            this.showLB.Name = "showLB";
            this.showLB.Size = new System.Drawing.Size(162, 13);
            this.showLB.TabIndex = 0;
            this.showLB.Text = "Enter how many number you add";
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(226, 144);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(75, 23);
            this.show_button.TabIndex = 1;
            this.show_button.Text = "ShowButton";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // addTB
            // 
            this.addTB.Location = new System.Drawing.Point(201, 97);
            this.addTB.Name = "addTB";
            this.addTB.Size = new System.Drawing.Size(100, 20);
            this.addTB.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 212);
            this.Controls.Add(this.addTB);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.showLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showLB;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.TextBox addTB;
    }
}

