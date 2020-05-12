namespace RadioButtonExamples
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
            this.iitRB = new System.Windows.Forms.RadioButton();
            this.phyRB = new System.Windows.Forms.RadioButton();
            this.ecoRB = new System.Windows.Forms.RadioButton();
            this.show_button = new System.Windows.Forms.Button();
            this.mathRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // iitRB
            // 
            this.iitRB.AutoSize = true;
            this.iitRB.Location = new System.Drawing.Point(125, 71);
            this.iitRB.Name = "iitRB";
            this.iitRB.Size = new System.Drawing.Size(38, 17);
            this.iitRB.TabIndex = 0;
            this.iitRB.TabStop = true;
            this.iitRB.Text = "IIT";
            this.iitRB.UseVisualStyleBackColor = true;
            // 
            // phyRB
            // 
            this.phyRB.AutoSize = true;
            this.phyRB.Location = new System.Drawing.Point(125, 103);
            this.phyRB.Name = "phyRB";
            this.phyRB.Size = new System.Drawing.Size(61, 17);
            this.phyRB.TabIndex = 1;
            this.phyRB.TabStop = true;
            this.phyRB.Text = "Physics";
            this.phyRB.UseVisualStyleBackColor = true;
            // 
            // ecoRB
            // 
            this.ecoRB.AutoSize = true;
            this.ecoRB.Location = new System.Drawing.Point(125, 136);
            this.ecoRB.Name = "ecoRB";
            this.ecoRB.Size = new System.Drawing.Size(77, 17);
            this.ecoRB.TabIndex = 2;
            this.ecoRB.TabStop = true;
            this.ecoRB.Text = "Economics";
            this.ecoRB.UseVisualStyleBackColor = true;
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(125, 193);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(75, 23);
            this.show_button.TabIndex = 3;
            this.show_button.Text = "ShowButton";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // mathRB
            // 
            this.mathRB.AutoSize = true;
            this.mathRB.Location = new System.Drawing.Point(125, 160);
            this.mathRB.Name = "mathRB";
            this.mathRB.Size = new System.Drawing.Size(85, 17);
            this.mathRB.TabIndex = 4;
            this.mathRB.TabStop = true;
            this.mathRB.Text = "Mathematics";
            this.mathRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 296);
            this.Controls.Add(this.mathRB);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.ecoRB);
            this.Controls.Add(this.phyRB);
            this.Controls.Add(this.iitRB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton iitRB;
        private System.Windows.Forms.RadioButton phyRB;
        private System.Windows.Forms.RadioButton ecoRB;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.RadioButton mathRB;
    }
}

