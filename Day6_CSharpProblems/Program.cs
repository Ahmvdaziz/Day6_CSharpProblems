using System;

namespace Day6_CSharpProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's a perfect number:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number > 0)
            {
                int sum = 0;

                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == number)
                {
                    Console.WriteLine($"{number} is a perfect number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a perfect number.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }

            //--------

            Console.WriteLine("Enter the First Number");
            string n1 = Console.ReadLine();
            Console.WriteLine("Enter the operation (+, -, *, /)");
            string Operator = Console.ReadLine();
            Console.WriteLine("Enter the Second Number");
            string n2 = Console.ReadLine();

            if (int.TryParse(n1, out int N1) && int.TryParse(n2, out int N2))
            {
                switch (Operator)
                {
                    case "+":
                        Console.WriteLine($"Sum of 2 numbers is {N1 + N2}");
                        break;
                    case "-":
                        Console.WriteLine($"Difference of 2 numbers is {N1 - N2}");
                        break;
                    case "*":
                        Console.WriteLine($"Multiplication of 2 numbers is {N1 * N2}");
                        break;
                    case "/":
                        if (N2 != 0)
                        {
                            Console.WriteLine($"Division of 2 numbers is {N1 / N2}");
                        }
                        else
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter valid integers for both numbers.");
            }
        }
    }
}
