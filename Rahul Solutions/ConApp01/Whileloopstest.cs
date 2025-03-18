
using System;

namespace ConApp01
{
    class Whileloopstest
    {
        static void Main()
        {
            //int i = 1;
            /* while (i <= 10)
             {
                 Console.WriteLine(i);
                 i++;


             }*/
            /*int i = 10;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }*/

            /*  int i = 2;
              while (i <= 8)
              {
                  Console.WriteLine(i);
                  i += 2;
              } */
            /* int i = 3;
             int n = 50;
             while (i <= n)
             {
                 Console.WriteLine(i);
                 i += 3;
             }*/

            /* int i = 10;
             while (i >= 4)
             {
                 Console.WriteLine(i);
                 i -= 2;
             }*/

            /*int i = 1;
            while (i <= 11)
            {
                Console.WriteLine($"{i}           {11-i}");
                i++;
            }*/

            /* Console.WriteLine("Enter the number to find the length");
             int n = Convert.ToInt32(Console.ReadLine());
             int no = n;
             int d = 0;

             while (n > 0)
             {

                 d++;
                 n /= 10;
             }
             Console.WriteLine($"The {no} number is of {d}");*/

            Console.WriteLine("Enter the number to find the no of zeros in it");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int num = n;
            while (n > 0)
            {
                int d = n % 10;
                if (d == 0)
                {
                    count++;

                }
                n /= 10;

            }
            Console.WriteLine($"{num} has {count} zeros");

        }
    }
}
