namespace ConApp01
{
class UserInputSubstring
    {
        static void Main()
        {
            Console.Write("Enter your full name:");
            string fullName = Console.ReadLine();
            string Firstname = fullName.Substring(0,fullName.IndexOf(' '));
            string LastName = fullName.Substring(fullName.LastIndexOf(' ') + 1);

            Console.WriteLine("Firstname is:"+Firstname);
            Console.WriteLine("LastName is :"+LastName);
            Console.WriteLine("Fullname is :" + fullName);

        }
    }
}
