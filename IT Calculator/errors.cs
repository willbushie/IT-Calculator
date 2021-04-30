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
        public error(String errorString, bool error)
        {
            this.errorString = errorString;
            this.isError = error;
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
        public static error checkLengthString(String stringToCheck, int correctLength, bool lengthEqual, bool lengthLessEqual)
        {
            // check the parameter boolean values
            if (lengthEqual == true)
            {
                // check that the length is the exact length, else return an error
                if (stringToCheck.Length == correctLength)
                {
                    // create an error and return 
                    error errorToReturn = new error("", false);
                    return errorToReturn;
                }
                else
                {
                    // create an error and return 
                    String errorString = ($"Input is incorrect length. Needs to be exactly {correctLength}. Input was of length {stringToCheck.Length}.");
                    error errorToReturn = new error(errorString, true);
                    return errorToReturn;
                }
            }
            else
            {
                // check that the length is the exact length or less, else return an error
                if (stringToCheck.Length <= correctLength)
                {
                    // create an error and return 
                    error errorToReturn = new error("", false);
                    return errorToReturn;
                }
                else
                {
                    // create an error and return 
                    String errorString = ($"Input is incorrect length. Needs to be exactly {correctLength}. Input was of length {stringToCheck.Length}.");
                    error errorToReturn = new error(errorString, true);
                    return errorToReturn;
                }
            }
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
            for (int location = 0; location < inputCheck.Length-1; location++)
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