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
            
            return 0;
        }

        // This method subtracts two base 2 numbers and returns the answer in base 2.
        // this is the format of the inputs: (num1 - num2)
        public int base2Subtraction(int num1, int num2)
        {
            return 0;
        }

        // This method multiplies two base 2 numbers together and returns the answer in base 2.
        // this is the format of the inputs: (num1 * num2)
        public int base2Multiplication(int num1, int num2)
        {
            LinkedList testclass = new LinkedList();
            return 0;
        }

        // This method divides two base 2 numbers together and returns the answer in base 2.
        // this is the format of the inputs: (num1 / num2)
        public int base2Division(int num1, int num2)
        {
            return 0;
        }

        // This method converts a base 2 number into a base 10 number.
        // input: base 2 number | returns base 10 number
        // This code will need to be updated in the future using linked lists - TEMP CODE
        public int base2ToBase10(int numToConvert)
        {
            int num, binVal, decVal = 0, baseVal = 1, rem; //converts binary and spits out decimal
            num = 101; //make this the input
            binVal = num;
            while (num > 0)
            {
                rem = num % 10;
                decVal = decVal + rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 2;
            }
            Console.Write("Binary Number: " + binVal);
            Console.Write("\nDecimal: " + decVal);
            Console.ReadLine();
            return 0;
        }

        // This method converts a base 10 number into a base 2 number.
        // input: base 10 number | returns: base 2 number
        // This code will need to be updated in the future using linked lists - TEMP CODE

        public int base10ToBase2(int numToConvert)
        {
            //this code takes in a decimal and spits out the binary
            Console.Write("Decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary:  {0}", result);
            return 0;
        }

        // This method converts a hexadecimal number into a base 2 number.
        // input: hexadecimal number (string) | returns: base 2 number
        // This code will need to be updated in the future using linked lists - TEMP CODE
        public int hexToBase2(string numToConvert)
        {
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
        public int dotOctetToBase2(string numToConvert)
        {
            return 0;
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
    public Node(Node nodeBefore, int payload, Node nodeAfter)
    {
        this.nodeBefore = nodeBefore;
        this.payload = payload;
        this.nodeAfter = nodeAfter;
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
