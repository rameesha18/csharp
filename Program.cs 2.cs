using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
             Q1)
            Console.WriteLine("Enter number1");
            string input1 = Console.ReadLine();
            int num1 = int.Parse(input1);
            Console.WriteLine("Enter number2");
            string input2 = Console.ReadLine();
            int num2 = int.Parse(input2);
            Console.WriteLine("The sum of the two numbers is:" + (num1 + num2));
            */
            /*

             Q2) for (int i = 1; i <= 100; i++)
             {
                 if (i %2 == 0)
                 {
                     Console.WriteLine(i);
                         }
             } */

            //Q3) Console.WriteLine("Enter the year");
            //string input = Console.ReadLine();
            //int year = Int32.Parse(input);

            //if (year % 400 == 0)
            //{
            //    Console.WriteLine("The year is a leap year");
            //}
            //if (year % 100 == 0)
            //{
            //    Console.WriteLine("The year is not a leap year");
            //}
            //if (year % 4 == 0)
            //{
            //    Console.WriteLine("This year is a leap year");
            //}
            //else
            //{
            //    Console.WriteLine("This is not a leap year");
            //}

            //Console.Writeline("Enter the number");
            //string input = Console.Readline();
            //int num = int.Parse(input);
            //Console.Writeline(num * 0.621371);

            //Q4)  Console.WriteLine("Enter the number in kilometers per hour");
            //  string input1 = Console.ReadLine();
            //  int num1 = int.Parse(input1);

            //  Console.WriteLine("Enter the number to be multiplied with");
            //  string input2 = Console.ReadLine();
            //  double num2 = double.Parse(input2);

            //  Console.WriteLine("The conversion is:" + (num1 * num2));



            //Q5) if (num % 7 == 0 || num % 10 == 7)
            //{
            //    Console.WriteLine("The number is a buzz number");
            //}

            //else
            //{
            //    Console.WriteLine("The number is not a buzz number");
            //}


            //Q6) Console.WriteLine("Enter the number");
            //string input = Console.ReadLine();
            //int number = int.Parse(input);

            //for (int i = 1; i <= 10; i++) 
            //{
            //    Console.WriteLine($"{number} * {i} = {number * i}");
            //}

            //Q7) int num = 6;
            //long factorial = 1;

            //for (int i = 1; i <= num; i++)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine($"The factorial of {num} is {factorial}");

            //Q8) nsole.WriteLine("Enter the number");
            //  String input = Console.ReadLine();
            //  int num = int.Parse(input);

            //  bool isPrime = true;

            //  for (int i = 2; i <= num - 1; i++)
            //  {
            //      if (num % i == 0)
            //      {
            //          isPrime = false;
            //          break;
            //      }
            //  }
            //      if (isPrime)
            //      {
            //          Console.WriteLine("The number is a prime number");
            //      }
            //      else
            //      {
            //          Console.WriteLine("The number is not a prime number");
            //      }

            //Q9) sole.WriteLine("Enter the number");
            //  string input1= Console.ReadLine();
            //  int length1 = int.Parse(input1);

            //Console.WriteLine("Enter the number");
            //string input2 = Console.ReadLine();
            //int length2 = int.Parse(input2);

            //Console.WriteLine("Enter the number");
            //string input3 = Console.ReadLine();
            //int length3 = int.Parse(input3);

            //if (length1 != length2 && length2 != length3 && length3 != length1)
            //{
            //    Console.WriteLine("The triangle is scalene");
            //}
            //else
            //{
            //    Console.WriteLine("The  triangle is not scalene");
            //}

            //Q9b)
            //   Console.WriteLine("Enter the number");
            //   string input1 = Console.ReadLine();
            //    int length1 = int.Parse(input1);

            // Console.WriteLine("Enter the number");
            //string input2 = Console.ReadLine();
            // int length2 = int.Parse(input2);

            //  Console.WriteLine("Enter the number");
            //   string input3 = Console.ReadLine();
            //   int length3 = int.Parse(input3);

            //   if (length1 == length2 || length2 == length3 || length3 == length1)
            //   {
            //       Console.WriteLine("The triangle is isosceles");
            //   }

            //   else
            //   {
            //       Console.WriteLine("The triangle is not isosceles");
            //   }

            //Q9c)
            //Console.WriteLine("Enter the number");
            //string input1 = Console.ReadLine();
            //int length1 = int.Parse(input1);

            //Console.WriteLine("Enter the number");
            //string input2 = Console.ReadLine();
            //int length2 = int.Parse(input2);

            //Console.WriteLine("Enter the number");
            //string input3 = Console.ReadLine();
            //int length3 = int.Parse(input3);

            //if (length1 == length2 && length2 == length3 && length1 == length3)
            //{
            //    Console.WriteLine("The triangle is an equilateral triangle");
            //}
            //else
            //{
            //    Console.WriteLine("The triangle is not an equilateral triangle");
            //}

            //Q10
            //Console.WriteLine("*");
            //Console.WriteLine("**");
            //Console.WriteLine("***");
            //Console.WriteLine("****");
            //Console.WriteLine("*****");

            //Through LOOP


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.WriteLine("*");
            //    }
            //    Console.WriteLine();
            //}

            //Bonus Question
            Console.WriteLine("Enter the number");
            string original = Console.ReadLine();
            
            string reversed = reversed(original);

            if (original = reversed)
            {
                Console.WriteLine("The number is a palindrome");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome");
            }



        }

    }
}        
