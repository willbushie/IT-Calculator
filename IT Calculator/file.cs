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
         * This method will create the file structure necessary if it does not already exist in the
         * Documents folder. 
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
         * The method will allow the user to select a file of their chosing
         * and have it be stored as the active file in the application.
         */
        public static void chooseFile()
        {

        }

        /*
         * This method write the operation compelted and results into a log file. 
         */
        public static void writeToLogFileConversion()
        {

        }

        /*
         * This method writes the operation completed and results into the log file.
         * This log file, for simplicity is created and stored in the documents folder. 
         * This file is maintained on a session basis, if the session is ended, the file
         * will not be cleared. If the sessions is created, the file will then be cleared.
         * This is done to prevent clearing of data on the log file if the application crashes.
         * Very useful resource for this method:
         * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-create-a-file-or-folder
         * This method is only used for the writing of the log file.
         *  
         */
        public static void writeToLogFileArithmetic() //v num1, string num2, string operation
        {
            // temp values that will be used as parameters (needed for quick testing)
            String num1 = "1010"; 
            String num2 = "1011";
            String operation = "Addition";


            // specify the documnts folder as the top level folder and "IT-Calculator Logs" as the main file path
            string logFilePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "IT-Calculator Logs");

            // specify the "Session" sub folder in the "IT-Calculator Logs" file path 
            string sessionsFilePath = System.IO.Path.Combine(logFilePath, "Sessions");

            // specify "Previous Session Log.txt" file path
            string prevSessionLog = System.IO.Path.Combine(logFilePath, "Previous Session Log.txt");

            // call the creation method to ensure the file structure exists
            createFileStructure();


           
            // write the necessary information to the previous session log file
            using (System.IO.StreamWriter stream = new System.IO.StreamWriter(prevSessionLog))
            {
                stream.Write("test");
            }

            // create a new file and write the same information to this sessions file



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
