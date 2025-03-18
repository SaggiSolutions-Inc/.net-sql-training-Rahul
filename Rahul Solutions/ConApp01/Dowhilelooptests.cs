using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp01
{
    internal class Dowhilelooptests
    {
        static void Main()

        {
            int i = 1;
            Console.WriteLine("Display the number from 1 to 10 using while loop");
            while (i <= 10)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.Write("\n======================================================================");

            Console.WriteLine("\nDisplay the number from 1 to 10 using do while loop");
            i = 1;
            do
            {
                Console.Write(i + " ");
                i++;
            }while(i <= 10);


            }
            


    }
}
