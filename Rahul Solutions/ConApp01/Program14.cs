namespace ConApp01
{

    class Program14
    {
        static void Main()
        {
            //Display wishes based on current time
            int hour = DateTime.Now.Hour;
            Console.WriteLine($"Time is: {DateTime.Now.ToLongTimeString()}");
            Console.WriteLine("========================================");

            if (hour < 12)
                Console.WriteLine("Good Morning!");
            else if (hour < 16)
                Console.WriteLine("Good Afternoon!");
            else
                Console.WriteLine("Good Evening!");
        }
    }
}
