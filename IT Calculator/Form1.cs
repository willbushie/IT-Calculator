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
            // store the input value from the first text box
            int firstInt = int.Parse(binaryArith_LeftTextBox.Text);
            // store the input value from the second text box
            int secondInt = int.Parse(binaryArith_RightTextBox.Text);

            // operation int value to later turn to a string
            int operationAnswerInt = 0;

            // error checking boolean value
            bool error = true;

            // check which operation is to requested & perform it
            if (operationComboBox.Text == "Addition")
            {
                // call the binaryAddition method & store the answer
                operationAnswerInt = methods.base2Addition(firstInt, secondInt);
                //update the error bool value
                error = false;
            }
            else if (operationComboBox.Text == "Subtraction")
            {
                // call the binaryAddition method & store the answer
                operationAnswerInt = methods.base2Subtraction(firstInt, secondInt);
                //update the error bool value
                error = false;
            }
            else if (operationComboBox.Text == "Multiplication")
            {
                // call the binaryAddition method & store the answer
                operationAnswerInt = methods.base2Multiplication(firstInt, secondInt);
                //update the error bool value
                error = false;
            }
            else if (operationComboBox.Text == "Division")
            {
                // call the binaryAddition method & store the answer
                operationAnswerInt = methods.base2Division(firstInt, secondInt);
                //update the error bool value
                error = false;
            }

            // ensure there was no error, else alert the user
            if (error == false)
            {
                // convert final answer from int to string & dispaly to the user in the answer text box
                binaryArithm_AnswerTextBox.Text = operationAnswerInt.ToString();
            }
            else
            {
                // error has occured, alert the user
            }
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
                    textBox2.Text = (methods.base2ToBase10(int.Parse(baseToConvert))).ToString();
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
                    //textBox2.Text = (methods.base10ToBase2(int.Parse(baseToConvert))).ToString();
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
                    textBox2.Text = methods.base10ToHex(baseToConvert, true);
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
                    textBox2.Text = (methods.hexToBase10(baseToConvert)).ToString();
                }
                else if (comboBox1.Text == "IP Address")
                {
                    // call hex to doted octet
                    // there is currently no method for this
                    textBox2.Text = "Unable to complete this method.";
                }
                else if (comboBox1.Text == "Mac Address")
                {
                    // call hex to hex (modified)
                    textBox2.Text = methods.hexToHexMod(baseToConvert).ToString();
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
                    // there is currently no method for this
                    textBox2.Text = "Unable to complete this method.";
                }
                else if (comboBox1.Text == "Hexadecimal")
                {
                    // call IP Address to doted octet
                    // there is currently no method for this
                    textBox2.Text = "Unable to complete this method.";
                }
                else if (comboBox1.Text == "Mac Address")
                {
                    // call IP Address to hex (modified)
                    // there is currently no method for this
                    textBox2.Text = "Unable to complete this method.";
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
                    // there is currently no method for this
                    textBox2.Text = "Unable to complete this method.";
                }
                else if (comboBox1.Text == "Hexadecimal")
                {
                    // call Mac Address (modified hex) to doted octet
                    // there is currently no method for this
                    textBox2.Text = "Unable to complete this method.";
                }
                else if (comboBox1.Text == "IP Address")
                {
                    // call Mac Address (modified hex) to hex (modified)
                    // there is currently no method for this
                    textBox2.Text = "Unable to complete this method.";
                }
            }
            else
            {
                // alert the user of an error
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Types of Conversions allowed:" + "\n" + "Base(2, 10, or 16) to Base(2, 10, or 16)" + "\n" + "Decimal IP Address to Binary IP Address" + "\n" + "Hexadecimal Mac Address to Binary & Decimal Mac Address" + "\n" + "\n" + "Common Errors:" + "\n" + "Unable to go from a normal base # to a dotted octet." + "\n" + "Can't go from Dotted Octet to a normal base number.", "Help");
        }
    }
}
