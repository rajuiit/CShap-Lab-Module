namespace List_Box
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
            this.deptLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showDeptL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deptLB
            // 
            this.deptLB.FormattingEnabled = true;
            this.deptLB.Items.AddRange(new object[] {
            "IIT",
            "CSE",
            "Math",
            "Statistics",
            "Physics",
            "Chemistry"});
            this.deptLB.Location = new System.Drawing.Point(161, 32);
            this.deptLB.Name = "deptLB";
            this.deptLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.deptLB.Size = new System.Drawing.Size(120, 95);
            this.deptLB.TabIndex = 0;
            this.deptLB.Click += new System.EventHandler(this.deptLB_Click);
            this.deptLB.SelectedIndexChanged += new System.EventHandler(this.deptLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "You Choose:";
            // 
            // showDeptL
            // 
            this.showDeptL.AutoSize = true;
            this.showDeptL.Location = new System.Drawing.Point(161, 170);
            this.showDeptL.Name = "showDeptL";
            this.showDeptL.Size = new System.Drawing.Size(0, 13);
            this.showDeptL.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 293);
            this.Controls.Add(this.showDeptL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deptLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox deptLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label showDeptL;
    }
}

