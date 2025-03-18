using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp01
{
    internal class Nestedloopstests
    {
        static void Main()

        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{j}  ");
                }
                Console.WriteLine();
            }
            int x = 256;
            int y = x % 2;
            Console.WriteLine($"{y} ");
            
        }
    }
}
