using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First Number: ");
            Double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter the second number: ");
            Double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            if(op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if(op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if(op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if(op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }

            Console.ReadLine();
        }
    }
}
