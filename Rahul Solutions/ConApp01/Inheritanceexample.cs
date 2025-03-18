using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp01
{
    
    

        class BaseClass
        {
            private int dm1 = 100;  //accessible within class only
            protected int dm2 = 200; //accessible within and all derived classes
            public int dm3 = 300;   //accessible everywhere
            public void DisplayBase()
            {
                Console.WriteLine($"dm1 = {dm1}, dm2 = {dm2}, dm3 = {dm3}");
            }
        }
        class DerivedClass : BaseClass
        {
            public void DisplayDervied()
            {
                //dm1 is inaccessible due to its procetion level
                Console.WriteLine($"dm2 = {dm2}, dm3 = {dm3}");
            }
        }
        class Inheritanceexample
        {
            static void Main()
            {
                DerivedClass o1 = new DerivedClass();
                o1.DisplayBase();
                o1.DisplayDervied();
                Console.WriteLine(o1.dm3);
            }
        }
    }

