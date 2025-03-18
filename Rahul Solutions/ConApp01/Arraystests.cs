using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp01
{
    internal class Arraystests
    {
        static void Main()
        {
            /* string[] names = new string[5];

             names[0] = "Rahul";
             names[1] = "Manikanta";
             names[2] = "Yadav";
             names[3] = "Boini";
             names[4] = "Manikanta Rahul Yadav Boini"; */

            /* Console.WriteLine(names[0]);
             Console.WriteLine(names[1]);
             Console.WriteLine(names[2]);
             Console.WriteLine(names[3]);
             Console.WriteLine(names[4]);*/

            /* for (int i = 0; i < names.Length; i++) // for loop
             {
                 Console.WriteLine(names[i]);
             } */
            /*
              int i = 0;
             while (i < names.Length) { Console.WriteLine(names[i++]); } // using while  */
            string[] names;
            names = new string[5];
            Console.WriteLine("Input  5 names ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"enter the names[{i}]: ");
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("Given names are");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"names[{i}] = {names[i]}");
            }




;
        }
    }
}
