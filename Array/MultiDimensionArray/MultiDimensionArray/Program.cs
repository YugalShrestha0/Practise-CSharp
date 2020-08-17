using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] One = new int[2, 3] { { 1, 3, 5 }, { 11, 13, 15 } };

            for (int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.WriteLine(One[i, j]);
                }
            }

            Console.ReadLine();
        }
    }
}
