using System;

namespace GreaterNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(10,20,30));

            Console.ReadLine();
            /*
            Console.Write("Enter the First num: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Second num: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Third num: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            */
        }    
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
                //Console.WriteLine("The Grestest number is num1");
            }
            else if(num2>=num1 && num2>=num3)
            {
                result = num2;
                //Console.WriteLine("The Grestest number is num2");
            }
            else
            {
                result = num3;
                //Console.WriteLine("The Grestest number is num3");
            }
            //Console.ReadLine();
            return result;
        }
    }
}
