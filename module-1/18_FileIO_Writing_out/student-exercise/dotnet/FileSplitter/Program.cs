using System;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;



namespace FileSplitter
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please give the path of the file you would like use for File Splitter:");

            string inputFilePath = Console.ReadLine();

            //prompt user for # of lines

            Console.WriteLine("How many lines would you like in each new file");

            int numLines = int.Parse(Console.ReadLine());

                    //open file for reading

            int fileNum = 0;
            string input = "";
            string line = "";

            using(StreamReader sr = new StreamReader(inputFilePath))
            {
                string outputFile = GenerateOutputFileName(input, fileNum);

                using(StreamWriter sw = new StreamWriter(outputFile)) 
                {
                    int linesWritten = 0;
                    // if the number of lines that I've written is less than 10
                    while (!sr.EndOfStream)
                    {
                        if (linesWritten<numLines)
                            {
                                //write and incriment
                                sw.WriteLine(line);
                                linesWritten++;
                            }// close if
                            //otherwise create a new file
                        else
                            {
                                sw.Close();//close existing
                                outputFile = GenerateOutputFileName(input, fileNum);
                                sw = new StreamWriter(outputFile);
                                sw.WriteLine(line);
                            }// close else

                       }// close while
                        
                    sw.Close();
                       
                    }// close using StreamWriter
                    


                }// close using StreamReader

               

        }//Close Main
        public static string GenerateOutputFileName(string data, int fileNum)
        {
            fileNum++;
            string newFileName = "";

            return newFileName;
        }


    }// CLose Class
    
}// close namespace


