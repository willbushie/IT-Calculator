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
        public int base2ToBase10(int numToConvert)
        {
            
            return 0;
        }

        // This method converts a base 10 number into a base 2 number.
        // input: base 10 number | returns: base 2 number
        public int base10ToBase2(int numToConvert)
        {
            return 0;
        }

        // This method converts a hexadecimal number into a base 2 number.
        // input: hexadecimal number (string) | returns: base 2 number
        public int hexToBase2(string numToConvert)
        {
            return 0;
        }

        // This method converts a hexadecimal number into a base 10 number.
        // input: hexadecimal number (string) | returns: base 10 number
        public int hexToBase10(string numToConvert)
        {
            return 0;
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
            // set the tail to newNode
            this.tail = newNode;
            
            // update the list's length
            this.length++;
        }
    }

}

/*
 * This class is used to implement nodes which will be used inside of a linked list instance.
 * This file helps with the conversion of base 2 to base 10 numbers.
 */
public class Node
{
    public Node nodeBefore;
    public int payload;
    public Node nodeAfter;

    public Node(Node nodeBefore, int payload, Node nodeAfter)
    {
        this.nodeBefore = nodeBefore;
        this.payload = payload;
        this.nodeAfter = nodeAfter;
    }
}
