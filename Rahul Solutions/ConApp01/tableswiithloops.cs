namespace ConApp01
{

    class Tableswithloops
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of n:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=10; i++)
                Console.WriteLine($"{n} X {i} = {n*i}");
        }
    }
}
