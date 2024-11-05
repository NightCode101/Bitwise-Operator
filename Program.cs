using System;
using System.Transactions;

namespace Bitwise_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start;
            Console.Clear();
            int a, b;
            char c;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Enter Your First Intiger Number  : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Second Intiger Number : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Remainder");

            Console.Write("Input Your Choice: ");
            c = Convert.ToChar(Console.ReadLine());

            Console.Clear();

            Console.ForegroundColor= ConsoleColor.Red;

            if (c == '1')
            {
                Console.WriteLine("The Sum of " + a + " and " + b + " is: " + (a + b));
            }
            else if (c == '2')
            {
                Console.WriteLine("The Difference of " + a + " and " + b + " is: " + (a - b));
            }
            else if (c == '3')
            {
                Console.WriteLine("The Product of " + a + " and " + b + " is: " + (a *b ));
            }
            else if (c == '4')
            {
                Console.WriteLine("The Quotient of " + a + " and " + b + " is: " + (a / b));
            }
            else if (c == '5')
            {
                Console.WriteLine("The Remainder of " + a + " and " + b + " is: " + (a % b));
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            goto start;
        }
    }
}
