using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            SubmitterName = submitterName;
            PossibleMarks = possibleMarks;

        }


        public int EarnedMarks { get; set; }
        public int PossibleMarks { get;  }
        public string SubmitterName { get;  }
        public string LetterGrade
        {
            get
            {
                double earned = (double)EarnedMarks / PossibleMarks * 100;

                if (earned >= 90)
                {
                    return "A";
                }

                else if (earned >= 80)
                {
                    return "B";
                }

                else if (earned >= 70)
                {
                    return "C";
                }

                else if (earned >= 60)
                {
                    return "D";
                }


                else
                {
                    return "F";
                }
                
            }


           

        }
        
        
     
    }
}

