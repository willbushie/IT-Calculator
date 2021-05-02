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
 *
 * 
 * 
 * ======================================
 *           HELPFUL CLASSES
 * ======================================
 * 
 * This section of code contains all of the added classes that allow more
 * unique features for the application.
 * 
 */


using System;


/*
 * This class is used to implement a doubly linked list.
 * This file helps with the conversion of base 2 to base 10 numbers.
 */
namespace IT_Calculator
{
    public class LinkedList
    {
        // LinkedList attributes
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
        public String contentsToInt(bool reverse)
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
                    intToReturnString += currNode.payload.ToString();
                    // advance currNode
                    currNode = currNode.nodeBefore;
                }
            }
            else if (reverse == false)
            {
                // walk through the list starting from the head
                // store the node currenlty being checked
                Node currNode = this.head;

                // walk through the list and update intToReturnString
                for (int count = 0; count < this.length; count++)
                {
                    // update intToReturnString
                    intToReturnString += currNode.payload.ToString();
                    // advance currNode
                    currNode = currNode.nodeAfter;
                }
            }

            // convert and return the final value 
            return intToReturnString;
        }

        // This method empties a linked list - after it is done being used
        public void clearLinkedList(LinkedList list)
        {
            // loop through the linked list and remove all nodes starting at tail
            for (int count = 0; count < this.length; count++)
            {
                // reassign this.tail and clear the current tail node - call Node.removeNode()
                this.tail = this.tail.removeNode();
            }
        }

        // This method finds the corresponding value at a passed index 
        public int getAtIndex(int index)
        {
            // int value to keep track of the current location
            int currentLocation = 0;
            // node value to denote the current node being checked
            Node currentNode = this.head;
            // loop through the linked list until the proper location is found
            while (currentLocation < index)
            {
                // advance the node until location is found
                currentNode = currentNode.nodeAfter;
                // advance currentLocation
                currentLocation++;
            }
            // return the value at that location as an int
            return currentNode.getPayload();
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
        
        // this method will return a nodes payload as an int
        public int getPayload()
        {
            // int value to hold the paylaod
            int payloadToReturn = 0;
            // assign the payload
            payloadToReturn = this.payload;
            // return the payload
            return payloadToReturn;
        }
    }


    /*
     * This class is a type of linked list that holds NodeStrings.
     * This class is used to build the strings that will be written to the log files
     * once the operations are concluded.
     */
    public class LinkedListStrings
    {
        // public LinkedListStrings attributes
        public NodeString head, tail;
        public int length;

        // instance method for a LinkedListStrings object - starts out empty
        public LinkedListStrings()
        {
            this.head = null;
            this.tail = null;
            this.length = 0;
        }

        // method to add a node to the LinkedListStrings 
        public void addNode(NodeString newNode)
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

        // this method returns the string contents of a node given an index
        public String contentsAtIndex(int index)
        {
            // int value to keep track of the current location
            int currLocation = 0;
            // node value to denote the current node being checked
            NodeString currNode = this.head;
            // loop through the linked list until the proper location is found
            while (currLocation < index)
            {
                // advance the node until location is found
                currNode = currNode.getNodeAfter();
                // advance currentLocation
                currLocation++;
            }
            // return the value at that location as an int
            return currNode.getContents();
        }
    }

   /*
    * This class is a type of node used spcifically to hold string variables. 
    * This class is used to build the string that will be printed to the log files
    * once the operations are concluded. 
    */
    public class NodeString
    {
        // public NodeString attributes
        public NodeString nodeBefore, nodeAfter;
        public string contents;

        // instance method for NodeString class
        public NodeString(string contents)
        {
            this.nodeBefore = null;
            this.nodeAfter = null;
            this.contents = contents;
        }

        // method to set the nodeAfter
        public void setNodeAfter(NodeString nodeAfter)
        {
            this.nodeAfter = nodeAfter;
        }

        // method to set the nodeAfter
        public void setNodeBefore(NodeString nodeBefore)
        {
            this.nodeBefore = nodeBefore;
        }

        // method to get the nodeAfter of a NodeString
        public NodeString getNodeAfter()
        {
            return this.nodeAfter;
        }

        // method to obtain the string contents of a NodeString
        public string getContents()
        {
            return this.contents;
        }
    }


    /*
     * This class is used for binary operations (specifically the arithmetic operations
     * of the application). This allows less duplicate code and easy access in other
     * areas of the application. 
     */
    public class binaryOperation
    {
        // class attributes
        public string firstString, secondString;
        public int firstInt, secondInt;
        public bool firstLarger, firstNumNegative, secondNumNegative;
        public char[] firstNumCharArray, secondNumCharArray;

        // instance method
        public binaryOperation(string firstString, string secondString)
        {
            // creation of the string values
            this.firstString = firstString;
            this.secondString = secondString;
            
            // creation of the char arrays
            this.firstNumCharArray = firstString.ToCharArray();
            this.secondNumCharArray = secondString.ToCharArray();

            int firstIntStartingLocation = 0;
            int secondIntStartingLocation = 0;

            // check if either nums are negative
            if (firstNumCharArray[0].ToString() == "-")
            {
                // assign firstNumNegative
                this.firstNumNegative = true;
                // update firstIntStartingLocation
                firstIntStartingLocation++;
            }
            if (secondNumCharArray[0].ToString() == "-")
            {
                // assign secondNumNegative
                this.secondNumNegative = true;
                // update secondIntStartingLocation
                secondIntStartingLocation++;
            }

            // build firstInt from firstNumCharArray
            // temp string to build the int from
            string tempString = "";
            // loop to build the tempString
            for (int count = firstIntStartingLocation; count < firstNumCharArray.Length; count++)
            {
                // add to tempString
                tempString += firstNumCharArray[count].ToString();
            }
            // assign firstInt
            this.firstInt = int.Parse(tempString);

            // build secondInt from secondIntCharArray
            // temp string to build the int from
            tempString = "";
            // loop to build the tempString
            for (int count = secondIntStartingLocation; count < secondNumCharArray.Length; count++)
            {
                // add to tempString
                tempString += secondNumCharArray[count].ToString();
            }
            // assign secondInt
            this.secondInt = int.Parse(tempString);
            
            // check if which value is larger
            if (firstInt > secondInt)
            {
                this.firstLarger = true;
            }
            else
            {
                this.firstLarger = false;
            }
        }

        // opreate method - this is where the binary arithmetic operations are executed
        public string operate(string operation)
        {
            // return string
            string operationAnswerString = "";

            // check the operation for typos
            if (error.checkArithmeticReadIn(operation).isError == true)
            {
                operationAnswerString = error.checkArithmeticReadIn(operation).errorString;
                file.storeForLogFileArithmetic(Form1.APParithmeticLL, this.firstString, this.secondString, operation, operationAnswerString);
                return operationAnswerString;
            }


            if (operation == "Addition")
            {
                if (this.firstLarger == true)
                {
                    if (this.firstNumNegative == true && this.secondNumNegative == false)
                    {
                        // call subtract firstInt from secondInt
                        operationAnswerString = methods.base2Subtraction(this.firstInt, this.secondInt);
                        // check the ouput string length
                        operationAnswerString = format(operationAnswerString);
                        // check if operationAnswerString is "0000"
                        operationAnswerString = placeNegativeOnFront(operationAnswerString);
                    }
                    else if (this.firstNumNegative == false && this.secondNumNegative == true)
                    {
                        // call subtraction firstInt from secondInt
                        operationAnswerString = methods.base2Subtraction(this.firstInt, this.secondInt);
                        // check the ouput string length
                        operationAnswerString = format(operationAnswerString);
                    }
                    else if (this.firstNumNegative == true && this.secondNumNegative == true)
                    {
                        // call addition firstInt and secondInt
                        operationAnswerString = methods.base2Addition(this.firstInt, this.secondInt);
                        // check the ouput string length
                        operationAnswerString = format(operationAnswerString);
                        // check if operationAnswerString is "0000"
                        operationAnswerString = placeNegativeOnFront(operationAnswerString);
                    }
                    else if (this.firstNumNegative == false && this.secondNumNegative == false)
                    {
                        // call addition firstInt and secondInt
                        operationAnswerString = methods.base2Addition(this.firstInt, this.secondInt);
                        // check the ouput string length
                        operationAnswerString = format(operationAnswerString);
                    }
                }
                else if (this.firstLarger == false)
                {
                    if (this.firstNumNegative == true && this.secondNumNegative == false)
                    {
                        // call subtract secondInt from firstInt
                        operationAnswerString = methods.base2Subtraction(this.secondInt, this.firstInt);
                        // check the ouput string length
                        operationAnswerString = format(operationAnswerString);
                    }
                    else if (this.firstNumNegative == false && this.secondNumNegative == true)
                    {
                        // call subtraction firstInt from secondInt
                        operationAnswerString = methods.base2Subtraction(this.secondInt, this.firstInt);
                        // check the ouput string length
                        operationAnswerString = format(operationAnswerString);
                        // check if operationAnswerString is "0000"
                        operationAnswerString = placeNegativeOnFront(operationAnswerString);
                    }
                    else if (this.firstNumNegative == true && this.secondNumNegative == true)
                    {
                        // call addition firstInt and secondInt
                        operationAnswerString = methods.base2Addition(this.firstInt, this.secondInt);
                        // check the ouput string length
                        operationAnswerString = format(operationAnswerString);
                        // check if operationAnswerString is "0000"
                        operationAnswerString = placeNegativeOnFront(operationAnswerString);
                    }
                    else if (this.firstNumNegative == false && this.secondNumNegative == false)
                    {
                        // call addition firstInt and secondInt
                        operationAnswerString = methods.base2Addition(this.firstInt, this.secondInt);
                        // check the ouput string length
                        operationAnswerString = format(operationAnswerString);
                    }
                }
            }
            else if (operation == "Subtraction")
            {
                if (this.firstLarger == true)
                {
                    if (this.firstNumNegative == true && this.secondNumNegative == false)
                    {
                        // call binary adition
                        operationAnswerString = methods.base2Addition(this.firstInt, this.secondInt);
                        // check the length of the string
                        operationAnswerString = format(operationAnswerString);
                        // check if operationAnswerString is "0000"
                        operationAnswerString = placeNegativeOnFront(operationAnswerString);
                    }
                    else if (this.firstNumNegative == false && this.secondNumNegative == true)
                    {
                        // call binary addition
                        operationAnswerString = methods.base2Addition(this.firstInt, this.secondInt);
                        // check the length of the string
                        operationAnswerString = format(operationAnswerString);
                    }
                    else if (this.firstNumNegative == true && this.secondNumNegative == true)
                    {
                        // call subtraction firstInt from secondInt
                        operationAnswerString = methods.base2Subtraction(this.firstInt, this.secondInt);
                        // check the length of the string
                        operationAnswerString = format(operationAnswerString);
                        // check if operationAnswerString is "0000"
                        operationAnswerString = placeNegativeOnFront(operationAnswerString);
                    }
                    else if (this.firstNumNegative == false && this.secondNumNegative == false)
                    {
                        // call subtraction firstInt from secondInt
                        operationAnswerString = methods.base2Subtraction(this.firstInt, this.secondInt);
                        // check the length of the string
                        operationAnswerString = format(operationAnswerString);
                    }
                }
                else if (this.firstLarger == false)
                {
                    if (this.firstNumNegative == true && this.secondNumNegative == false)
                    {
                        // call addition
                        operationAnswerString = methods.base2Addition(this.firstInt, this.secondInt);
                        // check the length of the string
                        operationAnswerString = format(operationAnswerString);
                        // check if operationAnswerString is "0000"
                        operationAnswerString = placeNegativeOnFront(operationAnswerString);
                    }
                    else if (this.firstNumNegative == false && this.secondNumNegative == true)
                    {
                        // call addition firstInt and secondInt
                        operationAnswerString = methods.base2Addition(this.firstInt, this.secondInt);
                        // check the length of the string
                        operationAnswerString = format(operationAnswerString);
                    }
                    else if (this.firstNumNegative == true && this.secondNumNegative == true)
                    {
                        // call subtraction secondInt from firstInt
                        operationAnswerString = methods.base2Subtraction(this.secondInt, this.firstInt);
                        // check the length of the string
                        operationAnswerString = format(operationAnswerString);
                    }
                    else if (this.firstNumNegative == false && this.secondNumNegative == false)
                    {
                        // call subtraction secondInt from firstInt
                        operationAnswerString = methods.base2Subtraction(this.secondInt, this.firstInt);
                        // check the length of the string
                        operationAnswerString = format(operationAnswerString);
                        // check if operationAnswerString is "0000"
                        operationAnswerString = placeNegativeOnFront(operationAnswerString);
                    }
                }
            }
            else if (operation == "Multiplication")
            {
                if ((this.firstNumNegative == true && this.secondNumNegative == false) || (this.firstNumNegative == false && this.secondNumNegative == true))
                {
                    // call the binaryAddition method & store the answer
                    operationAnswerString = methods.base2Multiplication(this.firstInt, this.secondInt);
                    // check the ouput string length
                    operationAnswerString = format(operationAnswerString);
                    // check if operationAnswerString is "0000"
                    operationAnswerString = placeNegativeOnFront(operationAnswerString);
                }
                else if ((this.firstNumNegative == true && this.secondNumNegative == true) || (this.firstNumNegative == false && this.secondNumNegative == false))
                {
                    // call the binaryAddition method & store the answer
                    operationAnswerString = methods.base2Multiplication(this.firstInt, this.secondInt);
                    // check the ouput string length
                    operationAnswerString = format(operationAnswerString);
                }
            }
            // store the file into the linked list to later be written
            file.storeForLogFileArithmetic(Form1.APParithmeticLL, this.firstString, this.secondString, operation, operationAnswerString);
            // return the operation anwer string
            return operationAnswerString;
        }

        // add a negative to the front of a string (prevents duplicate code)
        public static string placeNegativeOnFront(string operateString)
        {
            if (operateString != "0000")
            {
                return operateString = "-" + operateString;
            }
            return operateString;
        }

        // This method takes in a string of binary values, and outputs a string of the correct lenght
        // check the length of the output string and update it accordingly if needed (from "00" to "0000")
        // prevents duplicate code
        public static String format(String originalString)
        {
            // check the length of the return int to ensure it is a correct length
            if ((originalString.Length % 4) != 0)
            {
                // find the amount of zeros to format correclty
                int zeros = originalString.Length % 4;
                // create a string with the correct num of zeros
                String zeroString = "";
                for (int count = zeros; count < 4; count++)
                {
                    zeroString += "0";
                }
                // append the zeros to the front of the string
                originalString = zeroString + originalString;
            }
            // return the corrected string
            return originalString;
        }
    }

    /*
     * This class is used for all conversionOperations. This prevents duplicate
     * code and allows easier access for other areas of the application. 
     */
    public class conversionOperation
    {
        // class attributes
        public string inputBase, outputBase, numToConvert;

        // instance method
        public conversionOperation(string inputBase, string outputBase, string numToConvert)
        {
            this.inputBase = inputBase;
            this.outputBase = outputBase;
            this.numToConvert = numToConvert;
        }

        // operation method - the conversions occur
        public string operate()
        {
            // return string
            string operationAnswerString = "";

            // check the inputs for typos 
            if (error.checkConversionReadIn(this.inputBase, this.outputBase).isError == true)
            {
                operationAnswerString = error.checkConversionReadIn(this.inputBase, this.outputBase).errorString;
                file.storeForLogFileConversion(Form1.APPconversionLL, this.numToConvert, this.inputBase, this.outputBase, operationAnswerString);
                return operationAnswerString;
            }

            if (this.inputBase == "Binary")
            {
                if (this.outputBase == "Decimal")
                {
                    operationAnswerString = methods.base2ToBase10(this.numToConvert);
                }
                else if (this.outputBase == "Hexadecimal")
                {
                    operationAnswerString = methods.base2ToHex(this.numToConvert, false);
                }
                else if (this.outputBase == "Mac Address")
                {
                    operationAnswerString = methods.base2ToHex(this.numToConvert, true);
                }
                else if (this.outputBase == "IP Address")
                {
                    // check input length (max of 32 digits)
                    error lengthError = error.checkInputLength(this.numToConvert, 32, false, true);
                    if (lengthError.isError != true)
                    {
                        operationAnswerString = methods.base2ToDotOct(this.numToConvert);
                    }
                }
            }
            else if (this.inputBase == "Decimal")
            {
                if (this.outputBase == "Binary")
                {
                    operationAnswerString = methods.base10ToBase2(int.Parse(this.numToConvert)).ToString();
                }
                else if (this.outputBase == "Hexadecimal")
                {
                    operationAnswerString = methods.base10ToHex(this.numToConvert, false);
                }
                else if (this.outputBase == "Mac Address")
                {
                    error.operationNotSupportedMessage();
                }
                else if (this.outputBase == "IP Address")
                {
                    // check input length (max of 9 digits)
                    error lengthError = error.checkInputLength(this.numToConvert, 9, false, true);
                    if (lengthError.isError != true)
                    {
                        operationAnswerString = methods.base10ToDotOct(this.numToConvert);
                    }
                }
            }
            else if (this.inputBase == "Hexadecimal")
            {
                if (this.outputBase == "Binary")
                {
                    operationAnswerString = methods.hexToBase2(this.numToConvert, false);
                }
                else if (this.outputBase == "Decimal")
                {
                    operationAnswerString = methods.hexToBase10(this.numToConvert);
                }
                else if (this.outputBase == "Mac Address")
                {
                    operationAnswerString = methods.hexToHexMod(this.numToConvert);
                }
                else if (this.outputBase == "IP Address")
                {

                    operationAnswerString = methods.hexToDotOctet(this.numToConvert);
                }
            }
            else if (this.inputBase == "Mac Address")
            {
                if (this.outputBase == "Binary")
                {
                    operationAnswerString = methods.hexToBase2(this.numToConvert, true);
                }
                else if (this.outputBase == "Decimal")
                {
                    operationAnswerString = methods.hexModToBase10(this.numToConvert);
                }
                else if (this.outputBase == "Mac Address")
                {
                    operationAnswerString = methods.hexModToHex(this.numToConvert);
                }
                else if (this.outputBase == "IP Address")
                {
                    error.operationNotSupportedMessage();
                }
            }
            else if (this.inputBase == "IP Address")
            {
                if (this.outputBase == "Binary")
                {
                    operationAnswerString = methods.dotOctetToBase2(this.numToConvert);
                }
                else if (this.outputBase == "Decimal")
                {
                    operationAnswerString = methods.dotOctetToBase10(this.numToConvert);
                }
                else if (this.outputBase == "Hexadecimal")
                {
                    operationAnswerString = methods.dotOctetToHex(this.numToConvert);
                }
                else if (this.outputBase == "Mac Address")
                {
                    error.operationNotSupportedMessage();
                }
            }
            // store the information into the application linked list
            file.storeForLogFileConversion(Form1.APPconversionLL, this.numToConvert, this.inputBase, this.outputBase, operationAnswerString);
            // return the operation's answer
            return operationAnswerString;
        }
    }
}
