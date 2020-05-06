using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using file_io_part1_exercises;

namespace file_io_part1_exercises.Classes
{
    public class QuizQuestion
    {
        public string questionString = "";
        public int correctAnswer = 0;
        public List<string> Answers = new List<string>();
       

        public QuizQuestion(string line)
        {
            string[] Questions = line.Split("|");

            questionString = Questions[0];

            for (int i = 1; i < Questions.Length; i++)
            {
                int answerIndex = i - 1;

                var answer = Questions[i];

               

                if (answer.EndsWith("*"))
                {
                    correctAnswer = answerIndex;

                    answer = answer.Substring(0, answer.Length - 1);
                        //Replace("*", " ");

                }
                Answers.Add(answer);
            }
        }
        
      

    }
}
