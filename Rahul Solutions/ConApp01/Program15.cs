namespace ConApp01
{

    class Program15
    {
        static void Main()
        {
            Console.Write("Enter value for direction[1/2/3/4]: ");
            int direction = Convert.ToInt32(Console.ReadLine());
            switch (direction)
            {
                case 1:
                    Console.WriteLine("North");
                    break;
                case 2:
                    Console.WriteLine("East");
                    break;
                case 3:
                    Console.WriteLine("West");
                    break;
                case 4:
                    Console.WriteLine("South");
                    break;
                default:
                    Console.WriteLine("Invalid direciton");
                    break;
            }
        }
    }
}
