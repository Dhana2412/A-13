using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            //task2:variable and user input
            /* Console.WriteLine("What's your name?");
             string name = Console.ReadLine();

             Console.WriteLine($"Hello, {name}!");*/
            //task3:basic arithmatic
            /* Console.WriteLine("Enter the first number:");
             int num1 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter the second number:");
             int num2 = Convert.ToInt32(Console.ReadLine());

             int sum = num1 + num2;
             int difference = num1 - num2;
             int product = num1 * num2;

             Console.WriteLine($"Sum: {sum}");
             Console.WriteLine($"Difference: {difference}");
             Console.WriteLine($"Product: {product}");

             if (num2 != 0)
             {
                 double division = (double)num1 / num2;
                 double modulus = num1 % num2;

                 Console.WriteLine($"Division: {division}");
                 Console.WriteLine($"Modulus: {modulus}");
             }
             else
             {
                 Console.WriteLine("Cannot divide by zero.");

             }*/
            //task4:control structures
            /*Console.WriteLine("Enter an integer:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }*/
            //task5:loops
            /* for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine(i);
             }*/
            //task6:arrays
            /*int[] numbers = { 5, 10, 15, 20, 25 };

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");*/
            //task7:Methods
            /* Console.WriteLine("Enter an integer to calculate its factorial:");
             int number = Convert.ToInt32(Console.ReadLine());

             long factorial = CalculateFactorial(number);

             Console.WriteLine($"Factorial of {number} is {factorial}");
         }

         static long CalculateFactorial(int n)
         {
             if (n == 0)
                 return 1;

             return n * CalculateFactorial(n - 1);*/
            //task8:Exception handling
            int age = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write("Please enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    if (age >= 0)
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Age cannot be negative.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age (an integer).");
                }
            }

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }
        }
    }   
    }

