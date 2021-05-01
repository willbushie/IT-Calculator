/*
 * CSC370 - Group Project - IT Calculator
 * 
 * Purpose: 
 *  This is an IT calculator to help aid in simple conversion
 *  between different bases, as well as allow easy base 2
 *  arithmatic. 
 * 
 * Developers on the project & roles:
 *      Hannah Neymeyer - Team Lead
 *      Caden Flowers - Front End Developer
 *      Nicholas Johnson - Architect/Designer
 *      William Bushie - Programmer
 * 
 * Start of Development:            3/24/2021
 * Completetion of Development:     NOT YET COMPLETED
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IT_Calculator
{
    public partial class Form1 : Form
    {
        // intialization of the form
        public Form1()
        {
            InitializeComponent();
        }


        /*
         * ======================================
         *            BUTTON EVENTS
         * ======================================
         * 
         * This section of code contains all of the button events & logic.
         * 
         */
        // button press event to operate on the binary given in binaryArith_LeftTextBox & binaryArith_RightTextBox
        // and output an answer to binaryArithm_AnswerTextBox
        // also takes into account the opeartion through operationComboBox
        private void binaryArithm_ProcessOperationButton_Click(object sender, EventArgs e)
        {
            // creation of binaryOpeartion object
            binaryOperation operation = new binaryOperation(binaryArith_LeftTextBox.Text, binaryArith_RightTextBox.Text);
            
            // error checking boolean value
            //bool error = true;

            // execute the operation
            binaryArithm_AnswerTextBox.Text = operation.operate(operationComboBox.Text);
        }

        // button press event to convert the input base from textBox1 to the desired output base into textBox2
        // this method uses over 20 if statements, will look at streamlining this code in the future
        private void button1_Click(object sender, EventArgs e)
        {
            // store the input given from the user from textBox1
            String baseToConvert = textBox1.Text;

            // create instance of converionOperation
            conversionOperation operation = new conversionOperation(comboBox2.Text, comboBox1.Text, textBox1.Text);
            // execute the operation
            textBox2.Text = operation.operate();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        // On-Click for the Possible Conversions in the Help Menu
        private void possibleConversionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Types of Conversions allowed: " + "\n" + "Base(2, 10, or 16) to Base(2, 10, or 16)" + "\n" + "Decimal IP Address to Binary IP Address" + "\n" + "Hexadecimal Mac Address to Binary & Decimal Mac Address", "Possible Conversions");
        }

        // On-Click for the Common Errors in the Help Menu
        private void commonErrorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Common Errors:" + "\n" + "Unable to go from a normal base # to a dotted octet." + "\n" + "Can't go from Dotted Octet to a normal base number.", "Common Errors");
        }

        // On-Click for the About IT-Calculator in the Help Menu
        private void aboutITCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IT-Calculator Application" + "\n" + "Version: Sprint 3" + "\n" + "Team: Team 2", "About IT-Calculator");
        }

        // On-Click for the User Guide in the Help Menu
        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct Format to Input Numbers:" + "\nblahblahblah" + "\n\nFormat For Output:" + "\nBlahBlahBlah", "User Guide");
            // Filled in text for the formatting just providing functionality for now. Will update with proper information later.
        }

        // testing button operation for file testing and things (temporary)
        private void fileWriteTestButton_Click(object sender, EventArgs e)
        {
            /*/ store test information in conversion and arithmetic operations
            // creation of linked lists
            LinkedListStrings arithmeticLL = new LinkedListStrings();
            LinkedListStrings conversionLL = new LinkedListStrings();

            // add arithmetic operations
            file.storeForLogFileArithmetic(arithmeticLL, "0001", "0001", "Addition", "0010");
            file.storeForLogFileArithmetic(arithmeticLL, "0101", "0001", "Addition", "0110");
            file.storeForLogFileArithmetic(arithmeticLL, "1111", "0000", "Addition", "1111");

            // add conversion operations
            file.storeForLogFileConversion(conversionLL, "0001", "Binary", "Decimal", "1");
            file.storeForLogFileConversion(conversionLL, "0010", "Binary", "Decimal", "2");
            file.storeForLogFileConversion(conversionLL, "1111", "Binary", "Hexadecimal", "f");

            // write to the files
            file.writeLogFilesToStorage(arithmeticLL, conversionLL);
            */
            file.operateOnFile("test");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit or no?",
                               "My First Application",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
