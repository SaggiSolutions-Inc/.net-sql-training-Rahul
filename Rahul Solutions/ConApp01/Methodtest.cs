

using System.Buffers;

namespace ConApp01
{
    class Methodtestss
    {
        static void Wishes()
        {
            int hour = DateTime.Now.Hour;
            if (hour > 12) Console.WriteLine("Good Morning");
            else if (hour <= 16) Console.WriteLine(" Good Afternoon");
            else Console.WriteLine("Good evening ");

        }
        static void Drawline()
        {
            string msg = "";
            for (int i = 0; i < 80; i++)
                msg += '_';
            Console.WriteLine(msg);
        }
        static void Display(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        static void Table(int n)
        { for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{n} X {i}= {n * i}");
        }
       

        static void Main()
        {
            Drawline();
            Wishes();
            Drawline();

            Display("Rahul Yadav");
            
            Drawline();

            Drawline();
            Table(3);
            Drawline();
            Drawline();
            Table(4);


            
         

        }
    

    }
    
}
