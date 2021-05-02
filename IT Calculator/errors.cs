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
 *           ERROR CHECKING
 * ======================================
 * 
 * This section of code is used as the error checking.
 * These methods are easily callable to reduce the amount of 
 * duplicate code. 
 * These error checking methods have to deal iwth formatting, input checking,
 * and output checking. These are meant to reduce the amount of extra code
 * in the methods.cs file. 
 * These methods can be called easily from any other .cs file to check
 * for any necessary errors. 
 * 
 */


using System;


namespace IT_Calculator
{
    internal class error
    {

        // internal error class variables to allow returning of multiple values
        public String errorString;
        public bool isError;


        // instance method for error class
        public error()
        {
            this.errorString = "";
            this.isError = false;
        }

        /* 
         * This method checks if the passed input string is of correct length
         * Inputs:
         *  String "stringToCheck" - the passed string to check the length
         *  int "correctLength" - the length being checked for
         *  bool "lengthEqual" - if the length has to be that exact number
         *  bool "lengthLessEqual" - if the length has to be that exact number or less
         * lengthEqual & lengthLessEqual cannot both be true or both be false. They need to be the inverse of eachother
         */
        public static error checkInputLength(String stringToCheck, int correctLength, bool lengthEqual, bool lengthLessEqual)
        {
            // check the parameter boolean values
            if (lengthEqual == true)
            {
                // check that the length is the exact length, else return an error
                if (stringToCheck.Length == correctLength)
                {
                    // create an error and return 
                    error errorToReturn = new error();
                    return errorToReturn;
                }
                else
                {
                    // create an error and return 
                    error errorToReturn = new error();
                    errorToReturn.errorString = ($"Input is incorrect length. Needs to be exactly {correctLength}. Input was of length {stringToCheck.Length}. Operation not completed.");
                    errorToReturn.isError = true;
                    return errorToReturn;
                }
            }
            else
            {
                // check that the length is the exact length or less, else return an error
                if (stringToCheck.Length <= correctLength)
                {
                    // create an error and return 
                    error errorToReturn = new error();
                    return errorToReturn;
                }
                else
                {
                    // create an error and return 
                    error errorToReturn = new error();
                    errorToReturn.errorString = ($"Input is incorrect length. Needs to {correctLength} or less. Input was of length {stringToCheck.Length}. Operation not completed.");
                    errorToReturn.isError = true;
                    return errorToReturn;
                }
            }
        }


        /*
         * This method displays a message box alerting the user that the operation request is not supported. 
         */
        public static void operationNotSupportedMessage()
        {
            System.Windows.Forms.MessageBox.Show("This operation is not supported by the application.\n" + "Please try a different operation.", "Operation Not Supported");
        }


        /*
         * This method checks the input for spelling mistakes.
         * This method deals only with binary arithmetic operations.
         */
        public static error checkArithmeticReadIn(string operation)
        {
            // error to return
            error errorToReturn = new error();

            // string array to hold the corresponding values
            string[] operationArray = { "Addition", "Subtraction", "Multiplication" };

            // bool value to keep track if there is an issue
            bool operationCorrect = false;

            // loop to check the passed operation string
            for (int count = 0; count < 3; count++)
            {
                if (operationArray[count] == operation)
                {
                    operationCorrect = true;
                }
            }

            // check if there was an issue
            if (operationCorrect == false)
            {
                errorToReturn.errorString = $"Typo in {operation}. Operation was not completed.";
                errorToReturn.isError = true;
            }

            return errorToReturn;
        }


        /*
         * This method checks the inputs for spelling mistakes. 
         * This is mostly used in the operating on a read in file.
         * This method deals only with conversion operations - there is a separate method for 
         * arithmetic operations input checking.
         */
        public static error checkConversionReadIn(string firstBase, string secondBase)
        {
            // error to return 
            error errorToReturn = new error();

            // string arrays that hold the corresponding values
            string[] firstBaseArray = { "Binary", "Decimal", "Hexadecimal", "Mac Address", "IP Address" };
            string[] secondBaseArray = { "Binary", "Decimal", "Hexadecimal", "Mac Address", "IP Address" };

            // bools to keep track which base is incorrect 
            bool firstCorrect = false;
            bool secondCorrect = false;

            // loop to check firstBase
            for (int count = 0; count < 5; count++)
            {
                if (firstBaseArray[count] == firstBase)
                {
                    firstCorrect = true;
                }
            }

            // loop to check secondBase
            for (int count = 0; count < 5; count++)
            {
                if (secondBaseArray[count] == secondBase)
                {
                    secondCorrect = true;
                }
            }

            // conditionals to return the correct ouput
            if (firstCorrect == false && secondCorrect == false)
            {
                errorToReturn.errorString = $"Typos in both {firstBase} and {secondBase}. Operation not completed.";
                errorToReturn.isError = true;
            }
            else if (firstCorrect == true && secondCorrect == false)
            {
                errorToReturn.errorString = $"Typo in {secondBase}. Operation not completed.";
                errorToReturn.isError = true;
            }
            else if (firstCorrect == false && secondCorrect == true)
            {
                errorToReturn.errorString = $"Typo in {firstBase}. Operation not completed.";
                errorToReturn.isError = true;
            }

            return errorToReturn;
        }


        /*
         * This method is used to check if an input only consists of 1's or 0's (or a "-" on the front).
         * This method is used in the binary arithmetic portion of the applicataion. This is done
         * to ensure that the input only includes binary numbers, no other outside numbers.
         * If there is an input error, there will be a message box displayed. 
         */
        public static bool checkBinaryInput(string input)
        {
            // char[] to hold the input string for easier interaciton 
            char[] inputCheck = input.ToCharArray();

            // loop to check each char of the input string
            for (int location = 0; location < inputCheck.Length - 1; location++)
            {
                // special conditionals if at the first location
                if (location == 0)
                {
                    // check if the current item is allowed
                    if (inputCheck[location].ToString() != "1" || inputCheck[location].ToString() != "0" || inputCheck[location].ToString() != "-")
                    {
                        // message box showing the entire input that was incorrect, and the character found
                        System.Windows.Forms.MessageBox.Show($"The input \"{input}\" is incorrect." + "\n" + $"The character \"{inputCheck[location]}\" was found.", "Error");
                        // return true to cancel the operation
                        return true;
                    }
                }
                else
                {
                    // check if the current item is allowed
                    if (inputCheck[location].ToString() != "1" || inputCheck[location].ToString() != "0")
                    {
                        // message box showing the entire input that was incorrect, and the character found
                        System.Windows.Forms.MessageBox.Show($"The input \"{input}\" is incorrect." + "\n" + $"The character \"{inputCheck[location]}\" was found.", "Error");
                        // return true to cancel the operation
                        return true;
                    }
                }
            }
            return false;
        }
    }
}