using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp01
    {
        class Subscriber
        {
            //Data members
            private string uname, pwd;

            //Methods ( member functions )
            public void SignUp()
            {
                Console.Write("Enter user name to register: ");
                uname = Console.ReadLine();

                Console.Write("Enter password to register: ");
                pwd = Console.ReadLine();

                Console.WriteLine("User registerd successfully...");
            }
            public void SignIn()
            {
                Console.Write("Enter uname to login: ");
                string uname = Console.ReadLine();

                Console.Write("Enter password: ");
                string pwd = Console.ReadLine();

                if (this.uname == uname && this.pwd == pwd)
                    Console.WriteLine("Login success...");
                else
                    Console.WriteLine("Login failed...");
            }
        }
        class Subscriber2
        {
            static void Main()
            {
                Subscriber s1 = new Subscriber();
                Subscriber s2 = new Subscriber();
                s1.SignUp();
                s2.SignUp();

                s1.SignIn();
                s2.SignIn();
            }
        }
    }

class BankAccount
{
    //data members
    private int amount, pin;
    private string cname;
    public void RegisterUser()
    {
        Console.Write("Enter uname: ");
        cname = Console.ReadLine();

        Console.Write("Enter initial deposit: ");
        amount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter pin for security");
        pin = Convert.ToInt32(Console.ReadLine());
    }
    public void CheckBalance()
    {
        Console.Write($"{cname}, Enter pin to check your balanace: ");
        int pin = Convert.ToInt32(Console.ReadLine());
        if (this.pin == pin)
            Console.WriteLine($"{cname} balance is: {amount}");
        else
            Console.WriteLine($"Invalid pin, amount cannot be revealed...");
    }
   
}
class Program25
{
    static void Main()
    {
        BankAccount c1 = new BankAccount();
        c1.RegisterUser();
        c1.CheckBalance();
        c1.CheckBalance();
    }
}



