namespace ConApp01
{

    class Program7

    {
        static void Main()
        {
            int a = 100, b = 200, c = 0;
            Console.WriteLine($" a = {a} and b = {b}");
            Console.WriteLine($"The datatype of a is {a.GetType()}");

            c = a + b;
            Console.WriteLine($"The Sum of a + b = {c}");
            Console.WriteLine($"The datatype of C is {c.GetType()}");
            
            c = a - b;
            Console.WriteLine($"The sub of a - b = {c}");

            c = a * b;
            Console.WriteLine($"Multiplication of a * b = {c}");
          

        }
    }
}
