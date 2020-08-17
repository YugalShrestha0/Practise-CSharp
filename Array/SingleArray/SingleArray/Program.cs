using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 3, 8, 9, 5, 2, 3, 10 };
            /*
            for(int i=0;i<6;i++)
            {
                Console.WriteLine(array[i]);
            }
            
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            */

            //To serach the number
            Console.Write("Enter the number you want to search: ");
            int a = int.Parse(Console.ReadLine());
            bool found = false;

            for (int i=0;i<array.Length;i++)
            {
                if(found)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("\nNumber found");
            }
            else
            {
                Console.WriteLine("\nNumber not found");
            }

            Console.ReadLine();
        }
    }
}
