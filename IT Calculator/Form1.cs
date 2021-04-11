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
                operationAnswerInt = base2Addition(firstInt, secondInt);
                //update the error bool value
                error = false;
            }
            else if (operationComboBox.Text == "Subtraction")
            {
                // call the binaryAddition method & store the answer
                operationAnswerInt = base2Subtraction(firstInt, secondInt);
                //update the error bool value
                error = false;
            }
            else if (operationComboBox.Text == "Multiplication")
            {
                // call the binaryAddition method & store the answer
                operationAnswerInt = base2Multiplication(firstInt, secondInt);
                //update the error bool value
                error = false;
            }
            else if (operationComboBox.Text == "Division")
            {
                // call the binaryAddition method & store the answer
                operationAnswerInt = base2Division(firstInt, secondInt);
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
                    MessageBox.Show("here");
                    // call binary to decimal
                    textBox2.Text = (base2ToBase10(int.Parse(baseToConvert))).ToString();
                }
                else if (comboBox1.Text == "Hexadecimal")
                {
                    // call binary to hex
                    // there is currently no method for this
                }
                else if (comboBox1.Text == "IP Address")
                {
                    // call binary to doted octet
                    // there is currently no method for this
                }
                else if (comboBox1.Text == "Mac Address")
                {
                    // call binary to hex (modified)
                    // there is currently no method for this
                }
            }
            // input decimal checks
            else if (comboBox2.Text == "Decimal")
            {
                if (comboBox1.Text == "Bianry")
                {
                    // call decimal to binary
                    textBox2.Text = (base10ToBase2(int.Parse(baseToConvert))).ToString();
                }
                else if (comboBox1.Text == "Hexadecimal")
                {
                    // call decimal to hex
                    // there is currently no method for this
                }
                else if (comboBox1.Text == "IP Address")
                {
                    // call decimal to doted octet
                    // there is currently no method for this
                }
                else if (comboBox1.Text == "Mac Address")
                {
                    // call decimal to hex (modified)
                    // there is currently no method for this
                }
            }
            // input hex checks
            else if (comboBox2.Text == "Hexadecimal")
            {
                if (comboBox1.Text == "Bianry")
                {
                    // call hex to binary
                    textBox2.Text = (base10ToBase2(int.Parse(baseToConvert))).ToString();
                }
                else if (comboBox1.Text == "Decimal")
                {
                    // call hex to decimal
                    textBox2.Text = (hexToBase10(baseToConvert)).ToString();
                }
                else if (comboBox1.Text == "IP Address")
                {
                    // call hex to doted octet
                    // there is currently no method for this
                }
                else if (comboBox1.Text == "Mac Address")
                {
                    // call hex to hex (modified)
                    // there is currently no method for this
                }
            }
            // input ip checks
            else if (comboBox2.Text == "IP Address")
            {
                if (comboBox1.Text == "Bianry")
                {
                    // call IP Address to binary
                    textBox2.Text = dotOctetToBase2(baseToConvert);
                }
                else if (comboBox1.Text == "Decimal")
                {
                    // call IP Address to decimal
                    // there is currently no method for this
                }
                else if (comboBox1.Text == "Hexadecimal")
                {
                    // call IP Address to doted octet
                    // there is currently no method for this
                }
                else if (comboBox1.Text == "Mac Address")
                {
                    // call IP Address to hex (modified)
                    // there is currently no method for this
                }
            }
            // input mac address checks
            else if (comboBox2.Text == "Mac Address")
            {
                if (comboBox1.Text == "Bianry")
                {
                    // call Mac Address (modified hex) to binary\
                    // there is currently no method for this
                }
                else if (comboBox1.Text == "Decimal")
                {
                    // call Mac Address (modified hex) to decimal
                    // there is currently no method for this
                }
                else if (comboBox1.Text == "Hexadecimal")
                {
                    // call Mac Address (modified hex) to doted octet
                    // there is currently no method for this
                }
                else if (comboBox1.Text == "IP Address")
                {
                    // call Mac Address (modified hex) to hex (modified)
                    // there is currently no method for this
                }
            }
            else
            {
                // alert the user of an error
            }
        }





        /* 
         * ======================================
         *           CALLABLE METHODS
         * ======================================
         * 
         * This section of code contains all of the functions that are callable.
         * These methods are simple and can be paired together.
         * All methods have the appropriate commenting.
         * Some of these methods use eachother, it is important to note which methods
         * use other methods to complete. 
         * 
         */




        // This method adds two base 2 numbers together and returns the answer in base 2.
        // this is the format of the inputs: (num1 + num2)
        public int base2Addition(int num1, int num2)
        {
            // convert both numbers in to decimal
            int num1Base10 = base2ToBase10(num1);
            int num2Base10 = base2ToBase10(num2);

            // complete the operation (addition)
            int operationAnswer = num1Base10 + num2Base10;

            // convert the answer back to binary, store into a returnable binary ouput
            int base2ToReturn = base10ToBase2(operationAnswer);

            // return the answer (in binary)
            return base2ToReturn;
        }

        // This method subtracts two base 2 numbers and returns the answer in base 2.
        // this is the format of the inputs: (num1 - num2)
        public int base2Subtraction(int num1, int num2)
        {
            // convert both numbers in to decimal
            int num1Base10 = base2ToBase10(num1);
            int num2Base10 = base2ToBase10(num2);

            // complete the operation (subtraction)
            int operationAnswer = num1Base10 - num2Base10;

            // convert the answer back to binary, store into a returnable binary ouput
            int base2ToReturn = base10ToBase2(operationAnswer);

            // return the answer (in binary)
            return base2ToReturn;
        }

        // This method multiplies two base 2 numbers together and returns the answer in base 2.
        // this is the format of the inputs: (num1 * num2)
        public int base2Multiplication(int num1, int num2)
        {
            // convert both numbers in to decimal
            int num1Base10 = base2ToBase10(num1);
            int num2Base10 = base2ToBase10(num2);

            // complete the operation (multiplication)
            int operationAnswer = num1Base10 * num2Base10;

            // convert the answer back to binary, store into a returnable binary ouput
            int base2ToReturn = base10ToBase2(operationAnswer);

            // return the answer (in binary)
            return base2ToReturn;
        }

        // This method divides two base 2 numbers together and returns the answer in base 2.
        // this is the format of the inputs: (num1 / num2)
        public int base2Division(int num1, int num2)
        {
            // convert both numbers in to decimal
            int num1Base10 = base2ToBase10(num1);
            int num2Base10 = base2ToBase10(num2);

            // complete the operation (division)
            int operationAnswer = num1Base10 / num2Base10;

            // convert the answer back to binary, store into a returnable binary ouput
            int base2ToReturn = base10ToBase2(operationAnswer);

            // return the answer (in binary)
            return base2ToReturn;
        }

        // This method converts a base 2 number into a base 10 number.
        // input: base 2 number | returns base 10 number
        // This code will need to be updated in the future using linked lists - TEMP CODE
        public int base2ToBase10(int numToConvert)
        {
            int decVal = 0, baseVal = 1, rem; //converts binary and spits out decimal
            while (numToConvert > 0)
            {
                rem = numToConvert % 10;
                decVal = decVal + rem * baseVal;
                numToConvert = numToConvert / 10;
                baseVal = baseVal * 2;
            }
            // return the base2 result
            return baseVal;
        }

        // This method converts a base 10 number into a base 2 number.
        // input: base 10 number | returns: base 2 number
        // This code will need to be updated in the future using linked lists - TEMP CODE

        public int base10ToBase2(int numToConvert)
        {
            // store numToConvert in hold variable
            int workingConv = numToConvert;

            // new linked list that will hold the converted numbers
            LinkedList remainders = new LinkedList();

            // loop to create a linked list & work with original number
            while (workingConv >= 1)
            {
                // store the remainder
                int remainder = workingConv % 2;
                // create a new node & add the node to the linked list
                Node newLLNode = new Node(remainder);
                remainders.addNode(newLLNode);
                // update the working value
                workingConv /= 2;
            }

            // convert the linked list to returnable output & return it
            return remainders.contentsToInt(true);
        }

        // This method converts a hexadecimal number into a base 2 number.
        // input: hexadecimal number (string) | returns: base 2 number
        // This code will need to be updated in the future using linked lists - TEMP CODE
        public int hexToBase2(string numToConvert)
        {
            // general plan for the new code
            // convert the numToConvert (hex) into base10
            // convert the returned base10 value into base2
            // return the base2 value

            String s = "1A"; //should be 1011

            char[] hexDec = new char[100];
            hexDec = s.ToCharArray();
            HexToBin(hexDec);
            return 0;
        }
        static void HexToBin(char[] hexdec) //converts hex to binary
        {
            int i = 0;

            while (hexdec[i] != '\u0000')
            {

                switch (hexdec[i])
                {
                    case '0':
                        System.Console.Write("0000");
                        break;
                    case '1':
                        System.Console.Write("0001");
                        break;
                    case '2':
                        System.Console.Write("0010");
                        break;
                    case '3':
                        System.Console.Write("0011");
                        break;
                    case '4':
                        System.Console.Write("0100");
                        break;
                    case '5':
                        System.Console.Write("0101");
                        break;
                    case '6':
                        System.Console.Write("0110");
                        break;
                    case '7':
                        System.Console.Write("0111");
                        break;
                    case '8':
                        System.Console.Write("1000");
                        break;
                    case '9':
                        System.Console.Write("1001");
                        break;
                    case 'A':
                    case 'a':
                        System.Console.Write("1010");
                        break;
                    case 'B':
                    case 'b':
                        System.Console.Write("1011");
                        break;
                    case 'C':
                    case 'c':
                        System.Console.Write("1100");
                        break;
                    case 'D':
                    case 'd':
                        System.Console.Write("1101");
                        break;
                    case 'E':
                    case 'e':
                        System.Console.Write("1110");
                        break;
                    case 'F':
                    case 'f':
                        System.Console.Write("1111");
                        break;
                    default:
                        System.Console.Write("\nInvalid hexadecimal digit " +
                        hexdec[i]);
                        break;
                }
                i++;
            }
        }

        // This method converts a hexadecimal number into a base 10 number.
        // input: hexadecimal number (string) | returns: base 10 number
        // This code will need to be updated in the future using linked lists - TEMP CODE
        public int hexToBase10(string numToConvert)
        {
            // general plan for the new code
            // convert numToConvert (hex) to base10 - using arrays with appropriate values 
            // make all char values in the numToConvert capitolized
            // array example:
            // hex:     [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E, F]
            // base10:  [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16]
            // simply compare and return values accordinly
            
            //this is the code for hex to dec to base 10--just need for it to be implied better with the public int.
            String hexNum = "1A"; //26
            hexadecimalToDecimal(hexNum);

            return 0;
        }
        //this is for the code above
        int hexadecimalToDecimal(String hexVal)
        {
            int len = hexVal.Length;

            // Initializing base1 value
            // to 1, i.e 16^0
            int base1 = 1;

            int dec_val = 0;

            // Extracting characters as
            // digits from last character
            for (int i = len - 1; i >= 0; i--)
            {
                // if character lies in '0'-'9',
                // converting it to integral 0-9
                // by subtracting 48 from ASCII value
                if (hexVal[i] >= '0' && hexVal[i] <= '9')
                {
                    dec_val += (hexVal[i] - 48) * base1;

                    // incrementing base1 by power
                    base1 = base1 * 16;
                }

                // if character lies in 'A'-'F' ,
                // converting it to integral
                // 10 - 15 by subtracting 55
                // from ASCII value
                else if (hexVal[i] >= 'A' && hexVal[i] <= 'F')
                {
                    dec_val += (hexVal[i] - 55) * base1;

                    // incrementing base1 by power
                    base1 = base1 * 16;
                }
            }
            return dec_val;
        }

        // This method converts a dotted octet number into a base 10 number.
        // input: dotted octet number | returns: base 2 number
        public string dotOctetToBase2(string numToConvert)
        {
            // return the final string
            return OctToBin(numToConvert.ToCharArray());
        }
        static string OctToBin(char[] OctNum) //converts hex to binary
        {
            int i = 0;
            string binary = "";

            while (i < OctNum.Length)
            {
                char c = OctNum[i];
                switch (c)    //all of the "System.Consol.Write will be the line that prints into textboxs
                {
                    case '0':
                        binary += "000";
                        break;
                    case '1':
                        binary += "001";
                        break;
                    case '2':
                        binary += "010";
                        break;
                    case '3':
                        binary += "011";
                        break;
                    case '4':
                        binary += "100";
                        break;
                    case '5':
                        binary += "101";
                        break;
                    case '6':
                        binary += "110";
                        break;
                    case '7':
                        binary += "111";
                        break;
                    default:
                        //print invalid OctNum
                        System.Console.WriteLine("Invalid Octal Number: " + OctNum);
                        break;
                }
                i++;
            }
            return binary;
        }
    }
}




/* 
 * ======================================
 *           HELPFUL CLASSES
 * ======================================
 * 
 * This section of code contains all of the added classes that allow more
 * unique features for the application.
 * 
 */


/*
 * This class is used to implement a doubly linked list.
 * This file helps with the conversion of base 2 to base 10 numbers.
 */
public class LinkedList
{
    // declaration of LinkedList attributes
    public Node head;
    public Node tail;
    public int length;

    // initialzation of linked list - it begins empty
    public LinkedList()
    {
        this.head = null;
        this.tail = null;
        this.length = 0;
    }

    // this method adds a node to the linked list
    public void addNode(Node newNode)
    {
        // put the newNode at the front if the linked list is empty
        if (this.length == 0)
        {
            // set the head & tail to newNode
            this.head = newNode;
            this.tail = newNode;

            // update the list's length
            this.length++;
        }
        else if (this.length > 0)
        {
            // link the current tail to newNode - call setNodeAfter()
            this.tail.setNodeAfter(newNode);

            // link the newNode to current tail - call setNodeBefore()
            newNode.setNodeBefore(this.tail);

            // set the tail to newNode
            this.tail = newNode;

            // update the list's length
            this.length++;
        }
    }

    // this method takes a linked list contents and returns the list contents as a single int
    // this is useful when converting between bases - base2ToBase10() for example will use this method\
    // takes a bool "reverse" parameter - if the list needs to be reverse from the 
    public int contentsToInt(bool reverse)
    {
        // value to return once the process is complete
        String intToReturnString = "";

        // check if the return needs to reverse the linked list
        if (reverse == true)
        {
            // walk through the list starting from the tail
            // store the node currently being check
            Node currNode = this.tail;

            // walk through the list and update intToReturnString
            for (int count = 0; count < this.length; count++)
            {
                // update intToReturnString
                intToReturnString = intToReturnString + currNode.payload.ToString();
                // advance currNode
                currNode = currNode.nodeBefore;
            }
        }
        else if (reverse == false)
        {
            // walk through the list starting from the head
        }

        // convert and return the final value
        return int.Parse(intToReturnString);
    }

    // this method empties a linked list - after it is done being used
    public void clearLinkedList(LinkedList list)
    {
        // loop through the linked list and remove all nodes starting at tail
        for (int count = 0; count < this.length; count++)
        {
            // reassign this.tail and clear the current tail node - call Node.removeNode()
            this.tail = this.tail.removeNode();
        }
    }
}

/*
 * This class is used to implement nodes which will be used inside of a linked list instance.
 * This file helps with the conversion of base 2 to base 10 numbers.
 */
public class Node
{
    // public node attributes
    public Node nodeBefore;
    public int payload;
    public Node nodeAfter;

    // instance method for a node
    public Node(int payload)
    {
        this.nodeBefore = null;
        this.payload = payload;
        this.nodeAfter = null;
    }

    // this method sets the nodeAfter of a node (to link the linked list together) (allowing singly LL)
    public void setNodeAfter(Node afterNode)
    {
        this.nodeAfter = afterNode;
    }

    // this method set the nodeBefore of a node (to link the linked list together) (allowing doubly LL)
    public void setNodeBefore(Node beforeNode)
    {
        this.nodeBefore = beforeNode;
    }

    // this method will be used in conjunction with LinkedList.clearLinkedList(LinkedList) - zero out a nodes payload
    // it will also return the nodeToRemove's nodeBefore for easy assignment of nodeToRemove to LinkedList.tail
    public Node removeNode()
    {
        // store nodeToRemove's nodeBefore to return for reassinging LinkedList.tail
        Node nodeToReturn = this.nodeBefore;
        
        // null out the node's payload
        this.payload = 0;

        // null out the node's beforeNode & afterNode
        this.nodeBefore = null;
        this.nodeAfter = null;

        // return nodeToRemove's nodeBefore
        return nodeToReturn;
    }
}
