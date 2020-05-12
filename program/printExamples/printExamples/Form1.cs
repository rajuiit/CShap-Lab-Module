using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace printExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadtext();
        }
        public void loadtext() { 
        
        
        
        
        
                  // Create an OpenFileDialog object.
               OpenFileDialog openFile1 = new OpenFileDialog();
 	           // Initialize the OpenFileDialog to look for text files.
	          // openFile1.Filter = "Text Files|*.txt";	
               openFile1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
	           // Check if the user selected a file from the OpenFileDialog.
              if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
 
               // Load the contents of the file into a RichTextBox control.
               richTextBox1.LoadFile(openFile1.FileName,
               RichTextBoxStreamType.PlainText);}
        private void print_button_Click(object sender, EventArgs e)
        {

            {
                // Create the print dialog object
                PrintDialog PrintDialog1 = new PrintDialog();
                // Declare the PrintDocument object.
                System.Drawing.Printing.PrintDocument docToPrint =
                   new System.Drawing.Printing.PrintDocument();
                // This method will set properties on the PrintDialog object and
                // then display the dialog.
                // Allow the user to choose the page range he or she would
                // like to print.
                PrintDialog1.AllowSomePages = true;

                // Show the help button.
                PrintDialog1.ShowHelp = true;

                // Set the Document property to the PrintDocument for 
                // which the PrintPage Event has been handled. To display the
                // dialog, either this property or the PrinterSettings property 
                // must be set 
                PrintDialog1.Document = docToPrint;

                DialogResult result = PrintDialog1.ShowDialog();

                // If the result is OK then print the document.
                if (result == DialogResult.OK)
                {
                    docToPrint.Print();
                }

            }
        }
    }
}
