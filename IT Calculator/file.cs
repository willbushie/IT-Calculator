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
 *           FILE INTERACTIONS
 * ======================================
 * 
 * This file is meant to contain all of the necessary code for file interaciton.
 * The goal is to allow the user to have the application interact with files
 * that they select. 
 * Another goal is to have the application (should it be selected by the user) store
 * all and any operations that the user makes. 
 * 
 * 
 */


using System;


namespace IT_Calculator
{
    internal class file
    {
        /*
         * This method checks if the necessary file structure exists. If it does, nothing is done. 
         * If the necessary file structure does not exist, the file structure is created to be interacted
         * with by the rest of the application. 
         */
        private static void createFileStructure()
        {
            // specify the documnts folder as the top level folder and "IT-Calculator Logs" as the main file path
            string logFilePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "IT-Calculator Logs");

            // check if the file path exists
            if (!System.IO.File.Exists(logFilePath))
            {
                // create the top folder
                System.IO.Directory.CreateDirectory(logFilePath);
                // specify the "Session" sub folder in the "IT-Calculator Logs" file path 
                string sessionsFilePath = System.IO.Path.Combine(logFilePath, "Sessions");
                // create the all session folder
                System.IO.Directory.CreateDirectory(sessionsFilePath);
                // specify "Previous Session Log.txt" file path
                string prevSessionLog = System.IO.Path.Combine(logFilePath, "Previous Session Log.txt");
                // create the previous session log file
                var createdFile = System.IO.File.Create(prevSessionLog);

                // close the created file to be able to write to it later on  
                createdFile.Close();
            }
        }


        /*
         * The method will allow the user to select a file of their chosing to be read in and be
         * operated on. 
         * This method is only used for the "read" abilities of the application. 
         */
        public static void chooseFile()
        {

        }

        /*
         * This method stores the operations compelted and results into temp linked list.
         * This linked list is then read in later by a different method to write the lines for the text file(s).
         * This is done to store all of the items into memory and once the session is exited or
         * the user decides to start a new session, the application will then write all the 
         * necessary components to the correct files. 
         * 
         * This method is specially for conversion operations. 
         */
        public static void storeForLogFileConversion(LinkedListStrings LL, string originalNum, string inputBase, string outputBase, string answer) 
        {
            // build the string from the inputs
            string writeString = $"conv {inputBase} to {outputBase} {originalNum} = {answer}";

            // create a new nodeToAdd 
            NodeString nodeToAdd = new NodeString(writeString);

            // place the writeString into the passed linked list
            LL.addNode(nodeToAdd);
        }

        /*
         * This method stores the opeartions completed and results into a temp linked list. 
         * This linked list is then read in later by a different method to write the lines to the text file(s).
         * This is done to store all of the items into memory and once the session is exited or the user
         * decides to start a new session, the application will then write all the necessary compnents to the correct files.
         * Great rescourse used heavily:
         * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-create-a-file-or-folder
         * 
         * This method is specifically for binary arithmetic operations.
         */
        public static void storeForLogFileArithmetic(LinkedListStrings LL, int num1, string num2, string operation, string answer) 
        {
            // build the string from the inputs
            string writeString = $"arth {num1} {num2} {operation} = {answer}";

            // create a new nodeToAdd 
            NodeString nodeToAdd = new NodeString(writeString);

            // place the writeString into the passed linked list
            LL.addNode(nodeToAdd);
        }

        /*
         * This method writes the information from both LinkedListString classes (arithmetic & conversion).
         * 
         */
        public static void writeLogFilesToStorage(LinkedListStrings arithmeticLL, LinkedListStrings conversionLL)
        {
            // file path to the main logs directory
            string logFilePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "IT-Calculator Logs");
            // file path to the sessions directory
            string sessionsFilePath = System.IO.Path.Combine(logFilePath, "Sessions");
            // file path to the previous sessions text file
            string prevSessionLog = System.IO.Path.Combine(logFilePath, "Previous Session Log.txt");


            // check that the file structure exists (call createFileStructrue)
            createFileStructure();

            // open stream writer to write to the prevSession file
            using (System.IO.StreamWriter prevSession = new System.IO.StreamWriter(prevSessionLog))
            {
                // write the date & time on the first line of the text file
                prevSession.WriteLine(DateTime.Now.ToString("MM/dd/yyyy | HH:mm:ss"));

                // arithmetic operations
                if (arithmeticLL.length != 0)
                {
                    // write binary arithmetic on the first line
                    prevSession.WriteLine("Bianry Arithmetic Operations");

                    // loop to write each item in arithmeticLL
                    for (int location = 0; location < arithmeticLL.length-1; location++)
                    {
                        prevSession.WriteLine(arithmeticLL.contentsAtIndex(location));
                    }
                }


            }

            // writing of any conversion operations
            if (conversionLL.length != 0)
            {
                // lable first line with conversion

            }
            
            
            /*/ write the necessary information to the previous session log file
            using (System.IO.StreamWriter stream = new System.IO.StreamWriter(prevSessionLog))
            {
                stream.Write("test");
            }

            // create a new file and write the same information to this sessions file
            */


            /*
            // check if the IT-Calculator log folder exists in documents
            if (!System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)))

            string fileName = "testfile.txt"; //DateTime.Now.ToString("MMddyyyy_HHmmss") + "_ShimTotals.txt";
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(documentPath, fileName)))
            {
                // write the header for the file
                outputFile.WriteLine(DateTime.Now.ToString("MM/dd/yyyy | HH:mm:ss"), "test");
            }*/

        }
    }
}
