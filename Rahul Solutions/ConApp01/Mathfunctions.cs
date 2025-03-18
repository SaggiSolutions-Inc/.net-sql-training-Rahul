using System.Reflection.Metadata;
using System.Runtime.Intrinsics;

namespace ConApp01
{

    class Mathfunctions    {
        static void Main()
        {
            int x = Math.Abs(-6);
            Console.WriteLine(x);

             double y = Math.Sqrt(25);
            Console.WriteLine(y);

             double d = Math.Pow(5, 3);
            Console.WriteLine(d);

            int z= Math.Min(5, 3);
            Console.WriteLine(z);
            
            int a = Math.Max(5, 3);
            Console.WriteLine(a);

            int b = Math.Sign(-20);
            Console.WriteLine(b);

            double c = Math.Ceiling(45.99);
            Console.WriteLine(c);

            double e = Math.Floor(45.99);
            Console.WriteLine(e);

            double f = Math.Round(45.46);
            Console.WriteLine(f);











        }
    }
}
