using System.Xml.Linq;

namespace ConApp01
{

class Substring
    {
        static void Main()
        {
            string name = "Rahul Yadav";
            Console.WriteLine(name.Substring(0, 5));
            Console.WriteLine(name.Substring(3, 1)); /* cannot exceed the length of the string */
            Console.WriteLine(name.IndexOf('a'));
            Console.WriteLine(name.LastIndexOf('a'));
            Console.WriteLine(name.Substring(0,name.Length-1));
            Console.WriteLine(name.Substring(0, name.Length ));
            Console.WriteLine(name.Substring(0,name.IndexOf(' ')));
            Console.WriteLine(name.Substring(0, name.LastIndexOf(' ')+1));
            Console.WriteLine(name.Substring(1));
        }
    }
}
