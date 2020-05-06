using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string readNum;
            
            int myNum;
            
            Console.WriteLine("Enter a number");
            
            readNum = Console.ReadLine();
            
            myNum = int.Parse(readNum);
           
            int temp1 = 1;
            
            int temp2 = 1;
            
            int fibNum;
            
            Console.Write(" 0 1 1 ");
            
            do
            {
            
                fibNum = temp1 + temp2;
             
                Console.Write(fibNum + " ");
                
                temp1 = temp2;
                
                fibNum = temp2;
            
            }while (fibNum <= myNum);

        }
    }
}
