namespace Practiceprograms
{
    public class Person  
    {
       public string? name;
       public  int age;

        public void Display()
        {
            Console.WriteLine($"Hello, My name is {name} and I am {age} years");
        }
    }

    class Person2
    {
        static void Main()
        {
            Person p = new Person();
            p.name = "Test";
            p.age = 5;
            p.Display();
        }
    }
}

       
  

