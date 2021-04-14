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
        // This code will need to be updated in the future using linked lists - TEMP CODE
        public static int base2ToBase10(int numToConvert)
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
        // input: hexadecimal number (string) | returns: base 2 number
        // This code will need to be updated in the future using linked lists - TEMP CODE
        public static int hexToBase2(string numToConvert)
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
        public static int hexToBase10(string numToConvert)
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
        public static int hexadecimalToDecimal(String hexVal)
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
        // input: dotted octet number (IP Address) | returns: base 2 number
        public static string dotOctetToBase2(string numToConvert)
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
