using System.Net.WebSockets;

/*namespace ConApp01
{

    class Loopifcases
    {
        static void Main()
        {
            int a = 5;
            if (a == 0)
            {
                Console.WriteLine("Input is zero");
            }
            else
            {
                Console.WriteLine($"{a} is not zero");
            }
        }
    }
}*/
namespace ConApp01
{
    class Ifloopcases2
    {
        static void Main()
        {
            Console.Write("Write Marks:");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 0 && marks <= 100)
            {
                Console.WriteLine("Marks are valid");
            }
            else
            {
                Console.WriteLine("Marks are not valid");
            }

        }
    }
}