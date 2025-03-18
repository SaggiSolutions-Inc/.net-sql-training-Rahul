namespace ConApp01
{

    class Program16
    {
        static void Main()
        {
            int i;
            Console.WriteLine("Generate 1 - 20 number using while loop");
            i = 1;

            while (i <= 20)
            {
                Console.Write($"{i}");
                i++;
            }
            Console.WriteLine("Generate 1 - 20 number using For loop");
            for (i = 1; i <= 20; i++)
            {
                Console.Write($"\n{i}");
            }
            Console.WriteLine("\nGenerate 1 - 20 number using Do while loop");
            i = 1;
            do
            {
                Console.Write($"\n{i}");
                i++;
            }while (i <= 20);



            

        }

    }
}
