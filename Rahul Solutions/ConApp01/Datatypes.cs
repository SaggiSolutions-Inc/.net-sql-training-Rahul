namespace ConApp01
{

    class Datatypesprofile

    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your percentage: ");
            double percentage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your gender [m/f]: ");
            char gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Hello {name}");
            Console.WriteLine($"Your age is: {age}");
            Console.WriteLine($"Your percentage is: {percentage}");
            Console.WriteLine($"Your gender: {gender}");
        }
    }
}
