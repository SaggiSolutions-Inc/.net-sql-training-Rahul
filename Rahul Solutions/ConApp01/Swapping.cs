namespace ConApp01
{

    class Swapping
    {
        static void Main()
        {
            /* int a = 100, b = 50;
             Console.WriteLine($"Before swap the values of a = {a} and b = {b}");

             int c = a;
             a = b;
             b = c;
             Console.WriteLine($"After swap the values of a = {a} and b = {b}");*/
            int a = 200, b = 100;
            Console.WriteLine($"Before Swap the values of a is {a} and b is {b}");

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After swap the values of a = {a} and b = {b}");
        }
    }
}
