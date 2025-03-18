using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConApp01
{
    internal class Forlooptests
    {
        static void Main()
        {
            /* for (int i = 1; i <= 10; i++) // Display 1 to 10
             {
                 Console.Write(i + " ");
             }
             for (int j=10; j>=1; j--) // Display 10 to 1
             {
                 Console.Write($"{j}");
             }*/
            /* for (int i = 65; i<=90; i++) // Display A to Z in capital letters 
              {
                  Console.Write($"{(char)i} ");
              } */
            Console.WriteLine("Enter the number for multiplication table"); // Display multiplication table
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }


        }

    }
}
