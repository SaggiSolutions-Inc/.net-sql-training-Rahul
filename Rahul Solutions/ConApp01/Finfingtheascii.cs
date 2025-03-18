namespace ConApp01
{

    class Findingtheascii
    {
        static void Main()
        {
            Console.Write("Enter a letter: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 65 && ch <= 90)
                Console.WriteLine($"Input {ch} is capital letter alphabet...");
            else if (ch >= 97 && ch <= 122)
                Console.WriteLine($"Input {ch} is small letter alphabet...");
            else if (ch >= 48 && ch < 57)
                Console.WriteLine($"Input {ch} is digit...");
            else
                Console.WriteLine($"Input {ch} is special letter...");
        }
    }
}
