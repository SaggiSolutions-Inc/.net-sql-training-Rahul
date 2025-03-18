namespace ConApp01
{

    class Datetimenow
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine($"The current date is {DateTime.Now}");

            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());

            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongDateString());

            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);

            Console.WriteLine(DateTime.Now.Day); 
        }
    }
}
