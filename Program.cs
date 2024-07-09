using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Q1)
            Console.WriteLine("Enter number1");
            string input1 = Console.ReadLine();
            int num1 = int.Parse(input1);
            Console.WriteLine("Enter number2");
            string input2 = Console.ReadLine();
            int num2 = int.Parse(input2);
            Console.WriteLine($"The sum of the two numbers is:" + (num1 + num2));
            */
            /*

             Q2) for (int i = 1; i <= 100; i++)
             {
                 if (i %2 == 0)
                 {
                     Console.WriteLine(i);
                         }
             } */

            Console.WriteLine("Enter the year");
            string input = Console.ReadLine();
            int year = Int32.Parse(input);
          
            if (year %400 == 0)
            {
                Console.WriteLine("The year is a leap year");
            }
            if (year % 100 == 0)
            {
                Console.WriteLine("The year is not a leap year");
            }
            if (year %4 == 0)
            {
                Console.WriteLine("This year is a leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }
        }
    }
}
