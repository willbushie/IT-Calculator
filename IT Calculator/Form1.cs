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

            // check if the user has the same base for each comboBox (input base & output base)
            if (comboBox1.Text == comboBox2.Text)
            {
                // alert the user the bases are the same
            }

            // find the original base given by the user from comboBox2
            // input binary checks
            if (comboBox2.Text == "Binary")
            {
                if (comboBox1.Text == "Decimal")
                {
                    //MessageBox.Show("here");
                    // call binary to decimal
                    textBox2.Text = methods.base2ToBase10(baseToConvert);
                }
                else if (comboBox1.Text == "Hexadecimal")
                {
                    // call binary to hex
                    textBox2.Text = methods.base2ToHex(baseToConvert, false);
                }
                else if (comboBox1.Text == "IP Address")
                {
                    // call binary to doted octet
                    // there is currently no method for this
                    textBox2.Text = methods.base2ToDotOct(baseToConvert);
                }
                else if (comboBox1.Text == "Mac Address")
                {
                    // call binary to hex and call for macAddress functionality
                    textBox2.Text = methods.base2ToHex(baseToConvert, true);
                }
            }
            // input decimal checks
            else if (comboBox2.Text == "Decimal")
            {
                if (comboBox1.Text == "Binary")
                {
                    // call decimal to binary
                    // thie method needs more work
                    textBox2.Text = methods.base10ToBase2(int.Parse(baseToConvert)).ToString();
                }
                else if (comboBox1.Text == "Hexadecimal")
                {
                    // call decimal to hex
                    textBox2.Text = methods.base10ToHex(baseToConvert, false);
                }
                else if (comboBox1.Text == "IP Address")
                {
                    // call decimal to doted octet
                    // there is currently no method for this
                    textBox2.Text = methods.base10ToDotOct(baseToConvert);
                }
                else if (comboBox1.Text == "Mac Address")
                {
                    // call decimal to hex (modified)
                    // this method causes issues regarding the input - usually never correct
                    //textBox2.Text = methods.base10ToHex(baseToConvert, true);
                    textBox2.Text = "Operation Not Supported";
                }
            }
            // input hex checks
            else if (comboBox2.Text == "Hexadecimal")
            {
                if (comboBox1.Text == "Binary")
                {
                    // call hex to binary
                    textBox2.Text = methods.hexToBase2(baseToConvert, false);
                }
                else if (comboBox1.Text == "Decimal")
                {
                    // call hex to decimal
                    textBox2.Text = methods.hexToBase10(baseToConvert);
                }
                else if (comboBox1.Text == "IP Address")
                {
                    // call hex to doted octet
                    // there is currently no method for this
                    textBox2.Text = methods.hexToDotOctet(baseToConvert);
                }
                else if (comboBox1.Text == "Mac Address")
                {
                    // call hex to hex (modified)
                    textBox2.Text = methods.hexToHexMod(baseToConvert);
                }
            }
            // input ip checks
            else if (comboBox2.Text == "IP Address")
            {
                if (comboBox1.Text == "Binary")
                {
                    // call IP Address to binary
                    textBox2.Text = methods.dotOctetToBase2(baseToConvert);
                }
                else if (comboBox1.Text == "Decimal")
                {
                    // call IP Address to decimal
                    textBox2.Text = methods.dotOctetToBase10(baseToConvert);
                }
                else if (comboBox1.Text == "Hexadecimal")
                {
                    // call IP Address to doted octet
                    textBox2.Text = methods.dotOctetToHex(baseToConvert);
                }
                else if (comboBox1.Text == "Mac Address")
                {
                    // call IP Address to hex (modified)
                    // there is currently no method for this
                    textBox2.Text = "Operation Not Supported";
                }
            }
            // input mac address checks
            else if (comboBox2.Text == "Mac Address")
            {
                if (comboBox1.Text == "Binary")
                {
                    // call Mac Address (modified hex) to binary
                    textBox2.Text = methods.hexToBase2(baseToConvert, true);
                }
                else if (comboBox1.Text == "Decimal")
                {
                    // call Mac Address (modified hex) to decimal
                    textBox2.Text = methods.hexModToBase10(baseToConvert);
                }
                else if (comboBox1.Text == "Hexadecimal")
                {
                    // call Mac Address (modified hex) to doted octet
                    //textBox2.Text = methods.
                }
                else if (comboBox1.Text == "IP Address")
                {
                    // call Mac Address (modified hex) to hex (modified)
                    // there is currently no method for this
                    textBox2.Text = "Operation Not Supported";
                }
            }
            else
            {
                // alert the user of an error
            }
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
