namespace Picture_Box
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
            this.PassportSizePB = new System.Windows.Forms.PictureBox();
            this.stampSizePB = new System.Windows.Forms.PictureBox();
            this.browseB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSIzeL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PassportSizePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stampSizePB)).BeginInit();
            this.SuspendLayout();
            // 
            // PassportSizePB
            // 
            this.PassportSizePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassportSizePB.Location = new System.Drawing.Point(57, 69);
            this.PassportSizePB.Name = "PassportSizePB";
            this.PassportSizePB.Size = new System.Drawing.Size(180, 220);
            this.PassportSizePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PassportSizePB.TabIndex = 0;
            this.PassportSizePB.TabStop = false;
            // 
            // stampSizePB
            // 
            this.stampSizePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stampSizePB.Location = new System.Drawing.Point(326, 69);
            this.stampSizePB.Name = "stampSizePB";
            this.stampSizePB.Size = new System.Drawing.Size(100, 100);
            this.stampSizePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stampSizePB.TabIndex = 1;
            this.stampSizePB.TabStop = false;
            // 
            // browseB
            // 
            this.browseB.Location = new System.Drawing.Point(326, 333);
            this.browseB.Name = "browseB";
            this.browseB.Size = new System.Drawing.Size(75, 23);
            this.browseB.TabIndex = 2;
            this.browseB.Text = "Browse";
            this.browseB.UseVisualStyleBackColor = true;
            this.browseB.Click += new System.EventHandler(this.browseB_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSIzeL
            // 
            this.fileSIzeL.AutoSize = true;
            this.fileSIzeL.Location = new System.Drawing.Point(112, 333);
            this.fileSIzeL.Name = "fileSIzeL";
            this.fileSIzeL.Size = new System.Drawing.Size(0, 13);
            this.fileSIzeL.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Size :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stamp Size: 2 inch * 3 inch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Passport Size: 3.5 inch * 4.5 inch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 471);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileSIzeL);
            this.Controls.Add(this.browseB);
            this.Controls.Add(this.stampSizePB);
            this.Controls.Add(this.PassportSizePB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PassportSizePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stampSizePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PassportSizePB;
        private System.Windows.Forms.PictureBox stampSizePB;
        private System.Windows.Forms.Button browseB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label fileSIzeL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

