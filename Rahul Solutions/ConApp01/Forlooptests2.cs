using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConApp01
{
    internal class Forlooptests2
    {
        static void Main()
        {
            Console.WriteLine("Enter the number to finf the factorial");
            int n = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= n; i++)
                f *= i;
            {
                Console.WriteLine($"factorial of {n} of {f}");
                
            }
        }
    }
}
