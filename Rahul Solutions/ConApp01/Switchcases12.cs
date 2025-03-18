namespace ConApp01
{

    class Switchcases123
    {
        static void Main()
        {
            Console.Write("Enter the value of a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select the operation to be performed \n 1.ADD \n 2.SUB \n 3.DIV \n 4.MULTI");

            Console.WriteLine("Enter the operation number");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"Addition  of {a} and {b} is {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Subtration of {a} and {b} is {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"Division  of {a} and {b} is {a / b}");
                    break;
                case 4:
                    Console.WriteLine($"Multiplication  of {a} and {b} is {a * b}");
                    break;
                default:
                    Console.WriteLine("The Given input is invalid");
                    break;
            }




            }
    }
}
