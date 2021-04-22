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


using System;


namespace IT_Calculator
{
    internal class methods
    {
        // This method adds two base 2 numbers together and returns the answer in base 2.
        // this is the format of the inputs: (num1 + num2)
        public static int base2Addition(int num1, int num2)
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
        public static int base2Subtraction(int num1, int num2)
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
        public static int base2Multiplication(int num1, int num2)
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
        public static int base2Division(int num1, int num2)
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
        public static int base2ToBase10(int numToConvert)
        {
            // store the input as a string
            String numToConvertString = numToConvert.ToString();
            // numToConvertString to char[] for easier access in the conversion loop
            char[] base2CharArray = numToConvertString.ToCharArray();

            // int value to be returned after the conversion
            int returnInt = 0;
            // int value to display which place (base2) we are at in the loop
            int placeLocation = 1;
            // reverse loop to create the base 10 number
            for (int count = base2CharArray.Length-1; count >= 0; count--)
            {
                String currentString = base2CharArray[count].ToString();
                // check which place in the binary string we are at
                // check if at the ones place
                if (placeLocation == 1)
                {
                    // check if there is a number to add
                    if (currentString == "1")
                    {
                        // add the number to the returnInt (in this case, we are in the ones place, so add a 1)
                        returnInt = returnInt + 1;
                    }
                }
                else
                {
                    // check if there is a number to add
                    if (currentString == "1")
                    {
                        // add the number to the returnInt (add the curent placement value)
                        returnInt = returnInt + placeLocation;
                    }
                }
                // update placeLocation value (multiply by 2 to get the correct base 2 placement)
                placeLocation = placeLocation * 2;
            }
            // return the base2 result
            return returnInt;
        }

        // This method converts a base 10 number into a base 2 number.
        // input: base 10 number | returns: base 2 number
        // This code will need to be updated in the future using linked lists - TEMP CODE

        public static int base10ToBase2(int numToConvert)
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

            // conver the remainders into an int
            String returnValueString = remainders.contentsToInt(true).ToString();

            // check the length of the return int to ensure it is a correct length
            if ((returnValueString.Length % 4) != 0)
            {
                // find the amount of zeros to format correclty
                int zeros = returnValueString.Length % 4;
                // create a string with the correct num of zeros
                String zeroString = "";
                for (int count = 0; count < 4; count++)
                {
                    zeroString += "0";
                }
                // append the zeros to the front of the string
                returnValueString = zeroString + returnValueString;
            }

            // convert the returnValuestring and return
            return int.Parse(returnValueString);
        }

        // This method converts a hexadecimal number into a base 2 number.
        // input: hexadecimal number (string), macAddress (bool) | returns: base 2 number 
        // this method will also ouput take in a correctly formatted mac adress and remove the formatting
        // if the bool macAddress is true
        public static String hexToBase2(string numToConvert, bool macAddress)
        {
            // new string to build to be used for conversion
            String conversionString = "";
            // check for mac address value
            if (macAddress == true)
            {
                // temp char array to remove the sepeartors
                char[] macAddressCharArray = numToConvert.ToCharArray();
                // remove the seperators (assumed to be ":") remove all seperators
                for (int currLocation = 0; currLocation < macAddressCharArray.Length; currLocation++)
                {
                    // check if the current char is a seperator
                    if (macAddressCharArray[currLocation].ToString() != ":")
                    {
                        // add the currLocation value to conversionString
                        conversionString += macAddressCharArray[currLocation].ToString();
                    }
                }
            }
            // otherwise, reset the numToConver value to conversionString
            else
            {
                conversionString = numToConvert;
            }

            // String array for the hex values
            String[] hexValues = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f"};
            // string array for the binary values 
            String[] binaryValues = {"0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111"};

            // convert to char array
            char[] tempCharArray = numToConvert.ToCharArray();
            // convert to string array
            String[] stringArray = new string[tempCharArray.Length];
            // loop to make everything lowercase
            for (int count = 0; count < tempCharArray.Length; count++)
            {
                // update the string[] at count with tempCharArray & make that lowercase
                stringArray[count] = tempCharArray[count].ToString().ToLower();
            }
            // int array to store the corresponding locations for each hex location
            int[] hexLocations = new int[tempCharArray.Length];

            // loop to check each item in stringArray
            for (int count = 0; count <= stringArray.Length-1; count++)
            {
                // loop to find the corresponding hexValue array location for the current item
                for (int hexValueLocation = 0; hexValueLocation <= hexValues.Length-1; hexValueLocation++)
                {
                    // does the current value match the value from the hexValues array?
                    if (stringArray[count] == hexValues[hexValueLocation])
                    {
                        // add the value to the hexLocations array
                        hexLocations[count] = hexValueLocation;
                    }
                }
            }
            // String value to return 
            String returnString = "";
            // loop to create the final string to return in base 2
            for (int count = 0; count < hexLocations.Length; count++)
            {
                // add the correct binary number to the return String
                returnString = returnString + binaryValues[hexLocations[count]];
            }
            // return the final string
            return returnString;
        }

        // This method converts a hexadecimal number into a base 10 number.
        // input: hexadecimal number (string) | returns: base 10 number
        public static String hexToBase10(string numToConvert)
        {
            // String array for the hex values
            String[] hexValues = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };
            // string array for the binary values 
            String[] decimalvalues = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };

            // convert numToConvert into a char array for easier interaciton in the conversion loops
            char[] hexCharArray = numToConvert.ToCharArray();

            // int build return of decimal values
            int returnInt = 0;
            
            // loop through the numToConvertString
            for (int count = 0; count < numToConvert.Length; count++)
            {
                // find the corresponding decimal value and build returnString
                for (int innerCount = 0; innerCount < 16; innerCount++)
                {
                    // check the current value being evaluated against the hex values array
                    if (hexCharArray[count].ToString() == hexValues[innerCount])
                    {
                        // update the returnString with the corresponding value from decimal values array
                        returnInt += int.Parse(decimalvalues[innerCount]);
                    }
                }
            }
            // return the final decimal string
            return returnInt.ToString();
        }

        // This method converts a decimal number (base10) to a hexadecimal number OR a formatted mac address
        // This method DOES NOT check for a correct mac address length input
        // input: base10 number (String), mac address (bool) | returns: hexadecimal number (String)
        public static String base10ToHex(String numToConvert, bool macAddress)
        {
            // String array for the hex values
            String[] hexValues = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };
            // string array for the binary values 
            String[] decimalvalues = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };

            // convert the numToConvert into an int value
            int numToConvertInt = int.Parse(numToConvert);

            // linked list to keep track of the remainders from the converting
            LinkedList remainders = new LinkedList();

            // int value to keep track of the current value being worked with
            int currentIntValue = numToConvertInt;

            // bool value to continue the creation of the linked list loop
            bool continueLinkedList = true;

            // creation of linked list process
            while (continueLinkedList == true)
            {
                // complete conversion operations and store the remainders accordingly
                if (numToConvertInt >= 16)
                {
                    // divide by 16, create new node and store remainder into linked list
                    int remainder1 = numToConvertInt % 16;
                    Node nodeToAdd1 = new Node(remainder1);
                    remainders.addNode(nodeToAdd1);
                    // update numToConvertInt
                    numToConvertInt /= 16;
                }
                else if (numToConvertInt < 16)
                {
                    // divide by 16, create new node and store remainder into linked list
                    int remainder = numToConvertInt % 16;
                    Node nodeToAdd = new Node(numToConvertInt);
                    remainders.addNode(nodeToAdd);
                    // update continueLinkedList bool
                    continueLinkedList = false;
                }
            }

            // returnable string of hex values
            String returnString = "";

            // loop to walk through the linked list and build the returnString
            for (int count = remainders.length - 1; count >= 0; count--)
            {
                // loop through the decimal values array to find the corresponding hex value
                for (int innerCount = 0; innerCount <= 15; innerCount++)
                {
                    // check if the current value matches the linked list value
                    if (remainders.getAtIndex(count).ToString() == decimalvalues[innerCount])
                    {
                        // build onto the return string the corresponding hex value
                        returnString += hexValues[innerCount];
                    }
                }
            }

            // return the final decimal string
            return returnString;
        }

        // this method convers a base 10 number into a correclty formatted ip address
        // this methods DOES NOT check for correct input length
        // this method more or less converts a decimal number to an octal number
        // input: base10 number (string) | output: ip address (string)
        public static String base10ToDotOct(String numToConvert)
        {
            // creation of the linked list that will be used to store the remainders of the conversion operations
            LinkedList remainders = new LinkedList();

            // int variable to keep track of the conversion operations being completed
            int numToOperate = int.Parse(numToConvert);

            // conversion loop of the original string
            while (numToOperate > 0)
            {
                // divide by 8, store the remainder into the linked list
                Node remainder = new Node(numToOperate % 8);
                // update the numToOperate
                numToOperate /= 8;
            }
            // MAY NEED TO UPDATE THIS OPERATION 

            // reverse the remainders linked list
            int octalNum = remainders.contentsToInt(true);

            // NEEDS TO BE FORMATTED FOR AN IP ADDRESS OUPUT
            // return the IP address
            return octalNum.ToString();

        }

        // This method converts a binary number to a dottet octet (IP Address)
        // input: base2 (String) | returns: dottect octet number (String)
        // this method DOES check for correct input length
        public static String base2ToDotOct(String numToConvert)
        {
            // check the input lenght 
            if (numToConvert.Length == 32)
            {
                // convert numToConvert to a char array for easier interaction 
                char[] tempCharArray = numToConvert.ToCharArray();
                
                // string array to hold the 4 sections of binary
                String[] binarySectionsArray = new String[4];

                // int variable to keep track of current location within the tempCharArray
                int charArrayLocation = 0;

                // loop to walk through the tempCharArray to build the 4 string sections for binarySectionsArray
                for (int sections = 0; sections < 4; sections ++)
                {
                    // temp section string holder that will be used to store a single section of 8 
                    String tempStringHolder = "";

                    // loop to build a single section of 8 characters
                    for (int single = 0; single < 8; single++)
                    {
                        // start at charArrayLocation & add to the tempStringHolder
                        tempStringHolder += tempCharArray[charArrayLocation].ToString();
                        // update charArrayLocation value
                        charArrayLocation++;
                    }
                    // add the tempStringHolder value to the current location in the binarySectionsArray
                    binarySectionsArray[sections] = tempStringHolder;
                }

                // once the string sections have been built, convert them to dotted octet
                //CURRENT LOCATION TO CONTINUE
            }
            else if (numToConvert.Length < 32 || numToConvert.Length > 32)
            {
                // return an error to the user
                return "error";
            }
            // return the final string
            return "final string return";
        }



        // This method converts a dotted octet number into a base 10 number.
        // input: dotted octet number (IP Address) | returns: base 2 number
        public static String dotOctetToBase2(string numToConvert)
        {
            // creation of a char[] to allow easy interaction with the numToConvert
            char[] interactiveNumToConvert = numToConvert.ToCharArray();

            // creation of the 4 sections to convert to binary
            String section1 = ""; // period only after
            String section2 = ""; // period before & after
            String section3 = ""; // period before & after
            String section4 = ""; // period only before

            // int value to keep track of which section we are currently working with inside of the loop
            int sectionCount = 1;
            // int value to keep track of where in the charArray there is a period (the current period)
            int loopLocation = 0;

            // update the String sections to match the period seperated values
            for (int count = 0; count < 4; count++)
            {
                // section1 updating
                if (sectionCount == 1)
                {
                    // continue looping starting at 0 in the char array until a seperator is found
                    while (interactiveNumToConvert[loopLocation].ToString() != ".")
                    {
                        // update the section string
                        section1 += interactiveNumToConvert[loopLocation];
                        // update the loopLocation
                        loopLocation++;
                    }
                }
                // section2 updating
                else if (sectionCount == 2)
                {
                    // advance loopLocation else it would be a period at that location
                    loopLocation++;
                    // continue looping starting at location after the seperator (period)
                    while (interactiveNumToConvert[loopLocation].ToString() != ".")
                    {
                        // update the section string
                        section2 += interactiveNumToConvert[loopLocation];
                        // update the loopLocation
                        loopLocation++;
                    }
                }
                // section3 updating
                else if (sectionCount == 3)
                {
                    // advance loopLocation else it would be a period at that location
                    loopLocation++;
                    // continue looping starting at location after the seperator (period) 
                    while (interactiveNumToConvert[loopLocation].ToString() != ".")
                    {
                        // update the section string
                        section3 += interactiveNumToConvert[loopLocation];
                        // update the loopLocation
                        loopLocation++;
                    }
                }
                // section4 updating
                else if (sectionCount ==4)
                {
                    // advance loopLocation else it would be a period at that location
                    loopLocation++;
                    // continue looping starting at location after the seperator (period)
                    // break when the end is found
                    while (loopLocation < interactiveNumToConvert.Length)
                    {
                        // update the section string
                        section4 += interactiveNumToConvert[loopLocation];
                        // update the loopLocation
                        loopLocation++;
                    }
                }
                // advance selection loop
                sectionCount++;
            }

            // convert all working sections into ints & store into an int[] for easy access when first converting to binary
            int section1Int = int.Parse(section1);
            int section2Int = int.Parse(section2);
            int section3Int = int.Parse(section3);
            int section4Int = int.Parse(section4);
            int[] sectionIntsToConvert = {section1Int, section2Int, section3Int, section4Int};

            // declare the strings to hold the converted values & store into a String[] for easy access inside the loop
            String section1String = "";
            String section2String = "";
            String section3String = "";
            String section4String = "";
            String[] sectionStringsConverted = {section1String, section2String, section3String, section4String};

            // int array to be used in the conversion for binary
            int[] octalToBinaryArray = {128, 64, 32, 16, 8, 4, 2, 1};

            // convert all working sections into binary using a loop
            for (int count = 0; count < 4; count++)
            {
                // variable for the currnent section int value being used in the loop
                int currSectionInt = sectionIntsToConvert[count];
                // convert to binary within a loop
                for (int innerCount = 0; innerCount < 8; innerCount++)
                {
                    // check if the current octalToBinary value is possible
                    if (octalToBinaryArray[innerCount] <= currSectionInt)
                    {
                        // place a 1 on the string
                        sectionStringsConverted[count] += "1";
                        // update the value of the sectionIntsToConvert
                        currSectionInt -= octalToBinaryArray[innerCount];
                    }
                    else
                    {
                        // place a 0 on the string
                        sectionStringsConverted[count] += "0";
                    }
                }
            }

            // ensure the returned are 8 bits long
            // section1 check
            if (sectionStringsConverted[0].Length < 8)
            {
                // find how many zeros are needed to correct the ouput
                int addZeros = 8 - sectionStringsConverted[0].Length;
                // create a string with the appropriate amount of zeros
                String zeros = "";
                for (int count = 0; count < addZeros; count++)
                {
                    zeros += "0";
                }
                // append zeros to the front of the string
                sectionStringsConverted[0] += zeros;
            }
            // section2 check
            if (sectionStringsConverted[1].Length < 8)
            {
                // find how many zeros are needed to correct the ouput
                int addZeros = 8 - sectionStringsConverted[1].Length;
                // create a string with the appropriate amount of zeros
                String zeros = "";
                for (int count = 0; count < addZeros; count++)
                {
                    zeros += "0";
                }
                // append zeros to the front of the string
                sectionStringsConverted[1] += zeros;
            }
            // section3 check
            if (sectionStringsConverted[2].Length < 8)
            {
                // find how many zeros are needed to correct the ouput
                int addZeros = 8 - sectionStringsConverted[2].Length;
                // create a string with the appropriate amount of zeros
                String zeros = "";
                for (int count = 0; count < addZeros; count++)
                {
                    zeros += "0";
                }
                // append zeros to the front of the string
                sectionStringsConverted[2] += zeros;
            }
            // section4 check
            if (sectionStringsConverted[3].Length < 8)
            {
                // find how many zeros are needed to correct the ouput
                int addZeros = 8 - sectionStringsConverted[3].Length;
                // create a string with the appropriate amount of zeros
                String zeros = "";
                for (int count = 0; count < addZeros; count++)
                {
                    zeros += "0";
                }
                // append zeros to the front of the string
                sectionStringsConverted[3] += zeros;
            }

            // place all of the section binary together into one string
            String returnString = "";
            returnString += sectionStringsConverted[0];
            returnString += sectionStringsConverted[1];
            returnString += sectionStringsConverted[2];
            returnString += sectionStringsConverted[3];

            // return the final string
            return returnString;
        }

        // this method converts binary input into hex format
        // this takes in a string of binary numbers and a bool for the mac address functionality
        // if this bool is false, it will simply return a hex string with no seperators.
        // if this bool is true, it will return a hex string in the format of a mac address
        // This method does not check the input for a correct macAddress length
        public static String base2ToHex(String inputString, bool macAddress)
        {
            // String array for the hex values
            String[] hexValues = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };
            // string array for the binary values 
            String[] binaryValues = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
            
            // ensure the input is formatted correclty (in base 2, add zeros to the front if necessary)
            if ((inputString.Length % 4) != 0)
            {

                // find the amount of zeros to format correclty
                int zeros = 4 - (inputString.Length % 4);
                // check if there are no zeros needed to be added
                if (zeros != 4)
                {
                    // create a string with the correct num of zeros
                    String zeroString = "";
                    for (int count = 0; count < zeros; count++)
                    {
                        zeroString += "0";
                    }
                    // append the zeros to the front of the string
                    inputString = zeroString + inputString;
                }
            }

            // find the number of 4 digit binary sections
            int sections = inputString.Length / 4;

            // string array to hold the 4 digit binary sections
            String[] binarySectionStrings = new string[sections];

            // convert the inputstring to a char array for easier interaction in the conversion loops
            char[] tempCharArray = inputString.ToCharArray();

            // variable to keep track of the location in the starting location of the inner loop
            int currentLoopLocation = 0;

            // convert the input string into a string array seperated into sections of 4 numbers each [0000, 0000, 0000,...]
            for (int count = 0; count < sections; count++)
            {
                // temp string to hold each section's values
                String tempBinaryString = "";
                // loop through tempCharArray to build one section, starting at currentLoopLocation
                for (int innerCount = 0; innerCount < 4; innerCount++)
                {
                    // add the piece to a running string
                    tempBinaryString += tempCharArray[currentLoopLocation].ToString();
                    // advance currentLoopLocation
                    currentLoopLocation++;
                }
                // update the binarySectionsString array
                binarySectionStrings[count] = tempBinaryString;
            }

            // string to return after conversion
            String hexReturnString = "";

            // loop to build the returnHexString
            for (int count = 0; count < binarySectionStrings.Length; count++)
            {
                // loop to find the corresponing hex value based on the current binary section
                for (int innerCount = 0; innerCount < 15; innerCount++)
                {
                    // check the current binary section against the binaryValues array
                    if (binarySectionStrings[count] == binaryValues[innerCount])
                    {
                        // update the hexReturnString getting the correct value from hexValues array
                        hexReturnString += hexValues[innerCount];

                        // check if this is not the end of the binarySectionString - in order to add a colen if not
                        // check if macAddress is true and the count + 1 is evently divisible by 2 - to place a colen every 2 characters
                        if (count != binarySectionStrings.Length - 1 && macAddress == true && (count+1) % 2 == 0)
                        {
                            hexReturnString = hexReturnString + ":";
                        }
                    }
                }
            }

            // return hexReturnString
            return hexReturnString;
        }


        // this method converts a hex input string into a formatted mac address
        public static String hexToHexMod(String inputString)
        {
            // input string into char array for easy interaction
            char[] interactionArray = inputString.ToCharArray();
            // string variable to return
            String returnString = "";
            // counter to track where in the inputstring the loop currently is
            int placementCounter = 0;
            // build the new string to return using a loop
            for (int count = 0; count < interactionArray.Length; count++)
            {
                // check the palcementCount build the returnString
                if (placementCounter < 2)

                {
                    // add to the string normally
                    returnString += interactionArray[count];
                    // advance placementCounter
                    placementCounter++;
                }
                else if (placementCounter == 2)
                {
                    // add ":" in addition to the next char in the string
                    returnString += ":";
                    returnString += interactionArray[count];
                    // reset placementCounter
                    placementCounter = 1;
                }
            }
            return returnString;
        }
    }
}
