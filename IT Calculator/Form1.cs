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

        // creation of linked lists used to store the operations made by the user
        public static LinkedListStrings APParithmeticLL = new LinkedListStrings();
        public static LinkedListStrings APPconversionLL = new LinkedListStrings();



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
            
            // execute the operation
            binaryArithm_AnswerTextBox.Text = operation.operate(operationComboBox.Text);
        }

        // button press event to convert the input base from textBox1 to the desired output base into textBox2
        // this method uses over 20 if statements, will look at streamlining this code in the future
        private void button1_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show("'Input Base --> Supported Output Bases'\nBinary --> Decimal, Hexadecimal, IPv4 Address*, Mac Address*\nDecimal --> Binary, Hexadecimal, IPv4 Address*\nHexadecimal --> Binary, Decimal, IPv4 Address*, Mac Address*\nIPv4 Address --> Binary, decimal, Hexadecimal\nMac Address --> Binary, Decimal, Hexadecimal\n\n'*' These outputs require specific input formats for the conversion operations to be completed. Please see 'Correct Input Formats' tab in the help menu for more information.", "Possible Conversions");
        }

        // On-Click for the Common Errors in the Help Menu
        private void commonErrorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Input Error' --> These errors refer to an incorrect input format for the conversion operation. This could mean a few things, the input was the incorrect length, the input does not have a required character(s) that interferes with the operation.\n\n'Operation Not Supported' --> If this error occurs, it simply means that the operation requested is not supported by the application.", "Common Errors");
        }

        // On-Click for the About IT-Calculator in the Help Menu
        private void aboutITCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application was created during CSC 370 - Software Engineering for Professor Locklair of the CS department. Development began on 3/24/2021 and the application was completed for 5/1/2021. It was a collaborative team project. The team members and their roles are:\nHannah Neymeyer - Team Lead\nCaden Flowers - Front End Developer\nNicholas Johnson - Architect/Designer\nWilliam Bushie - Programmer\n\nIF changes are to be made to the source code of the application, the GitHub respository is at this link: \nhttps://github.com/willbushie/IT-Calculator\n\n(c) 2021", "About IT-Calculator");
        }

        // On-Click for the User Guide in the Help Menu
        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a basic overview of the operations of the application. \n\nThe top portion of the application is meant to be used an arithmetic calculator for binary numbers. It supports the operations addition, subtraction, and multiplication. Division is not supported because those operations can result in decimal numbers. The calculator can handle negative numbers, in all operations, and input numbers with a length of 12 or less. The answer will be output with correct formatting (meaning the lngth of the output is evenly divisble by 4).\n\nThe lower portion of the application is used for number conversions. Please see 'Possible Conversions' tab in the help menu to see what conversions are supported.\n\nThe help menu is where the user can go for a quick explanation on the basic functionality of the application, any errors the user may receive, and creation information on the application.", "User Guide");
        }

        // this on click will provide information on the read and write abilities of the application.
        private void readWriteMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void correctInputFormatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This help tab shows the correct input formats for conversion operations.\n'Base to Base, Explanation. (Accepted Example Input)'\n\nBinary --> IPv4 Address, length of input NEEDS to be 32. (10000001000000010000000100000001)\nBinary --> Mac Address, length of input NEEDS to be 48. (001100000110010111101100011011111100010001011000)\nHexadecimal --> IPv4 Address, length of input NEEDS to be 8(ff181584)", "Correct Input Formats");
        }

        // this button event opens the file explorer for the user to chose a file to operate on
        private void operateOnChosenFile_Click(object sender, EventArgs e)
        {
            file.operateOnFile();
        }

        // this button event saves the session and its calculations in the prev sessions file
        // and the individual sessions file
        private void saveSessionFile_Click(object sender, EventArgs e)
        {
            file.writeLogFilesToStorage(APParithmeticLL, APPconversionLL);
        }

        // this button event simply clears all text boxes to being empty
        // just a simple easy thing for the user's benefit
        private void clearAllTextBoxes_Click(object sender, EventArgs e)
        {
            binaryArith_LeftTextBox.Text = "";
            operationComboBox.Text = "";
            binaryArith_RightTextBox.Text = "";
            binaryArithm_AnswerTextBox.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
