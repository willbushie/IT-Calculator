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
         * This method returns a string of the path chosen by the user for which file they want to read in. 
         */
        public static string chooseFile()
        {
            string fileLocation = "";
            
            System.Windows.Forms.OpenFileDialog openDialog = new System.Windows.Forms.OpenFileDialog();
            openDialog.Title = "Select A File";
            openDialog.Filter = "Text Files (*.txt)|*.txt" + "|" +
                                "All Files (*.*)|*.*";
            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileLocation = openDialog.FileName;
            }
            return fileLocation;
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
        public static void storeForLogFileArithmetic(LinkedListStrings LL, string num1, string num2, string operation, string answer) 
        {
            // build the string from the inputs
            string writeString = $"arth {num1} {operation} {num2} = {answer}";

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

                    // loop to write each item of arithmeticLL
                    for (int location = 0; location < arithmeticLL.length; location++)
                    {
                        prevSession.WriteLine(arithmeticLL.contentsAtIndex(location));
                    }
                }

                // conversion operations
                if (conversionLL.length != 0)
                {
                    // write conversions on the first line
                    prevSession.WriteLine("Conversion Operations");

                    // loop to write each item of conversionLL
                    for (int location = 0; location < conversionLL.length; location++)
                    {
                        prevSession.WriteLine(conversionLL.contentsAtIndex(location));
                    }
                }
                prevSession.Close();
            }

            // create new file 
            string fileName = "session_" + DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss") + ".txt";
            string currSessionsFilePath = System.IO.Path.Combine(sessionsFilePath, fileName);
            var createdFile = System.IO.File.Create(currSessionsFilePath);
            // close the new file in order to write to it
            createdFile.Close();

            // open stream writer to write to new session file (in sessions subfolder)
            using (System.IO.StreamWriter thisSessionFile = new System.IO.StreamWriter(currSessionsFilePath))
            {
                // write the date & time on the first line of the text file
                thisSessionFile.WriteLine(DateTime.Now.ToString("MM/dd/yyyy | HH:mm:ss"));

                // arithmetic operations
                if (arithmeticLL.length != 0)
                {
                    // write binary arithmetic on the first line
                    thisSessionFile.WriteLine("Bianry Arithmetic Operations");

                    // loop to write each item of arithmeticLL
                    for (int location = 0; location < arithmeticLL.length; location++)
                    {
                        thisSessionFile.WriteLine(arithmeticLL.contentsAtIndex(location));
                    }
                }

                // conversion operations
                if (conversionLL.length != 0)
                {
                    // write conversions on the first line
                    thisSessionFile.WriteLine("Conversion Operations");

                    // loop to write each item of conversionLL
                    for (int location = 0; location < conversionLL.length; location++)
                    {
                        thisSessionFile.WriteLine(conversionLL.contentsAtIndex(location));
                    }
                }
                thisSessionFile.Close();
            }
        }

        /*
         * This method reads in a file from the user and completes the operations requested.
         * This method reads the file in question, and rewrites the file based on the operations.
         * Each operation is completed and then stored into a linked list object. This is done to 
         * allow easier rewrite of the file when all operations are complete.
         */
        public static void operateOnFile()
        {
            // call to choose the user file to operate on
            string fileLocation = chooseFile();
            
            // creation of LinkedListString object to keep track of line outputs (both arth and conv)
            LinkedListStrings lineOutputs = new LinkedListStrings();
            
            // reassign fileLocation for testing puproses
            //string logFiles = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "IT-Calculator Logs");
            //string fileLocation = System.IO.Path.Combine(logFiles, "testReadFile.txt");
            // read in the file
            using (System.IO.StreamReader stream = System.IO.File.OpenText(fileLocation))
            {
                // temp string value to hold the line contents
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    // char[] to allow for easier interaction on the line input
                    char[] lineChars = line.ToCharArray();

                    // determine if arth or conv (build the first chars into a string)
                    string operation = "";
                    for (int location = 0; location < 4; location++)
                    {
                        operation += lineChars[location];
                    }
                    // conditionals for arth
                    if (operation == "arth")
                    {
                        // go to location 5 to begin sorting correctly
                        string num1 = "";
                        string binOperation = "";
                        string num2 = "";

                        // int value to keep track of where in the char array currently are
                        int currLocation = 5;
                        
                        // build num1
                        while (lineChars[currLocation].ToString() != " ")
                        {
                            // add to num1
                            num1 += lineChars[currLocation].ToString();
                            // advance currLocation
                            currLocation++;
                        }
                        // advance currLocation
                        currLocation++;

                        // build binOperation
                        while (lineChars[currLocation].ToString() != " ")
                        {
                            // add to binOperation
                            binOperation += lineChars[currLocation].ToString();
                            // advance currLocation
                            currLocation++;
                        }
                        // advance currLocation
                        currLocation++;

                        // build num2
                        while (currLocation < lineChars.Length)
                        {
                            if (lineChars[currLocation].ToString() != " ")
                            {
                                // add to num2
                                num2 += lineChars[currLocation].ToString();
                                // advance currLocation
                                currLocation++;
                            }
                            else
                            {
                                currLocation = lineChars.Length;
                            }
                        }

                        // create binaryOperation object to operate on and recieve an output
                        binaryOperation arithmeticOperation = new binaryOperation(num1, num2);
                        // store the output in a temp string value
                        string answer = arithmeticOperation.operate(binOperation);

                        // build the string to store inside of the linked list
                        string stringToStore = $"{operation} {num1} {binOperation} {num2} = {answer}";

                        // create node to store
                        NodeString nodeToAdd = new NodeString(stringToStore);
                        // add the node to the list
                        lineOutputs.addNode(nodeToAdd);
                    }
                    // conditionals for conv
                    else if (operation == "conv")
                    {
                        // go to location 5 to begin sorting correctly
                        string inputBase = "";
                        string outputBase = "";
                        string numtoConvert = "";

                        // int value to keep track of where in the char array currently are
                        int currLocation = 5;

                        // build inputBase
                        while (lineChars[currLocation].ToString() != " ")
                        {
                            // add to inputBase
                            inputBase += lineChars[currLocation].ToString();
                            // advance currLocation
                            currLocation++;
                        }
                        // advance currLocation
                        currLocation += 4;

                        // build outputBase
                        while (lineChars[currLocation].ToString() != " ")
                        {
                            // add to outputBase
                            outputBase += lineChars[currLocation].ToString();
                            // advance currLocation
                            currLocation++;
                        }
                        // advance currLocation
                        currLocation++;

                        // build numToConvert
                        while (currLocation < lineChars.Length)
                        {
                            if (lineChars[currLocation].ToString() != " ")
                            {
                                // add to numToConvert
                                numtoConvert += lineChars[currLocation].ToString();
                                // advance currLocation
                                currLocation++;
                            }
                            else
                            {
                                currLocation = lineChars.Length;
                            }
                        }

                        // create conversionOperation instance
                        conversionOperation convertOperation = new conversionOperation(inputBase, outputBase, numtoConvert);

                        // opreate on that instance
                        string answer = convertOperation.operate();

                        // build the string to store inside of the linked list
                        string stringToStore = $"{operation} {inputBase} to {outputBase} {numtoConvert} = {answer}";
                        // create node to store
                        NodeString nodeToAdd = new NodeString(stringToStore);
                        // add the node to the list
                        lineOutputs.addNode(nodeToAdd);
                    }
                    else
                    {
                        string errorString = $"{line} = Label was incorrect on the line. Operation not complete.";
                        NodeString nodeToAdd = new NodeString(errorString);
                        // add the node to the list
                        lineOutputs.addNode(nodeToAdd);
                    }
                }
                // close stream once loop is completed
                stream.Close();
            }

            // overwrite the file with the new information
            using (System.IO.StreamWriter stream = new System.IO.StreamWriter(fileLocation))
            {
                for (int location = 0; location < lineOutputs.length; location++)
                {
                    stream.WriteLine(lineOutputs.contentsAtIndex(location));
                }
                stream.Close();
            }
        }
    }
}
