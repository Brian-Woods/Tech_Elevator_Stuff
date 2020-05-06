using System;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
                                                                                  
                Dictionary<string, int> words = new Dictionary<string, int>();

                //int numSentences = 0;

                int numWords = 0;

                int lineNumber = 0;

                Console.WriteLine("What word would you like to search for? ");

                string inputWordName = Console.ReadLine();

                Console.WriteLine("Should the word be case insensitive? y/n");

                string inputCaseInsensitve = Console.ReadLine();

                if (inputCaseInsensitve == "y" || inputCaseInsensitve == "Y")
                    {
                        inputCaseInsensitve = inputCaseInsensitve.ToLower();
                    }

            Console.WriteLine("Please give the path of the file you would like to count the number of words and sentences in:");

                string inputFilePath = Console.ReadLine();

                //string inputFilePath = @"C:\Users\Student\workspace\week-4-pair-exercises-c-team-3\17_FileIO_Reading_in\pair-exercise\dotnet\alices_adventures_in_wonderland.txt";

                //inputFilePath.Replace("\"","");  
                if (File.Exists(inputFilePath))
                {
                    using (StreamReader sr = new StreamReader(inputFilePath))
                    {
                        
                        while (!sr.EndOfStream)
                        {
                            lineNumber++;//increment before reading the line as the line number starts with 1
                            string line = sr.ReadLine();

                            if (inputCaseInsensitve == "y" || inputCaseInsensitve == "Y")
                                {
                                    line = line.ToLower();
                                }   
                            
                            if(line.Contains(inputWordName) )
                                {
                                    numWords++;
                                }


                        Console.WriteLine(inputWordName + " is on line: " + lineNumber);
                        
                        }
                    Console.WriteLine("The total number of occurences is: " + numWords);
                    }
                }
             
                //1. Ask the user for the search string 
                //2. Ask the user for the file path
                //3. Open the file
                //4. Loop through each line in the file
                //5. If the line contains the search string, print it out along with its line number
            }
        }


}
