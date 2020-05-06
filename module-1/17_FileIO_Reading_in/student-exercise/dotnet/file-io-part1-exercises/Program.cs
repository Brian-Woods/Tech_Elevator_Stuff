using System;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using file_io_part1_exercises.Classes;


namespace file_io_part1_exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string inputFilePath = @"C:\Users\Student\workspace\week-4-pair-exercises-c-team-3\17_FileIO_Reading_in\pair-exercise\dotnet\quiz.txt";

            Console.WriteLine("Please give the path of the file you would like use for Quiz Maker:");

            string inputFilePath = Console.ReadLine();

          


            if (File.Exists(inputFilePath))
            {
                using (StreamReader sr = new StreamReader(inputFilePath))
                {
                    List<QuizQuestion> quizList= new List<QuizQuestion>();

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        quizList.Add(new QuizQuestion(line));
                                                
                    }
                    foreach(QuizQuestion question in quizList)
                    {
                        Console.WriteLine(question.questionString);

                        for (int i = 0; i < question.Answers.Count;i++) 
                        {
                            Console.WriteLine(i+1+": "+question.Answers[i]);
                        }
                        Console.WriteLine("Select answer");

                        int guess = int.Parse(Console.ReadLine());

                        if (guess-1 == question.correctAnswer)
                        {
                            Console.WriteLine("correct!!!");
                        }
                        else
                        {
                            Console.WriteLine("nope, fail!");
                        }


                    }






                }
            }
        }


        private static int GetAnswerIndex(List<QuizQuestion> possibleAnswers)
        {
            foreach(QuizQuestion answer in possibleAnswers)
            {
                if(answer.correctAnswer > 0)
                {
                    return answer.correctAnswer;
                }
            }
            return 0;
        }
    }
}
