using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TechElevator.Classes
{
    public class Company
    {


        public string Name { get; set; }

        public int NumberOfEmployees { get; set; }

        public decimal Revenue { get; set; }

        public decimal Expenses { get; set; }
        public string GetCompanySize()
        {
            if (NumberOfEmployees < 50)
            {
                return "small";
            }
            if (NumberOfEmployees > 250)
            {
                return "large";
            }
            else
            {
                return "medium";
            }

        }
        public decimal GetProfit()
        {
            decimal profit = Revenue - Expenses;
            return profit;
        }

        public Company()
        {

        }


    }
   
}

        



    
   
  


   
   
 



