namespace ConApp01
{
    class Runtimereadline
    {
        static void Main()
        {
            Console.WriteLine("Enter any number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" The Given Number is {n}");
            Console.WriteLine($"The next number of {n} is {n + 1}");
            Console.WriteLine($"Square root of {n} is {n * n}");


        }
    }
}
