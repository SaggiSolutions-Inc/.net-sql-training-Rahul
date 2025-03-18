using System.Runtime.Intrinsics;

namespace ConApp01
{

    class Car1
    {
        public string Brand;   // Field to store the brand
        public int Speed;      // Field to store the speed
        public string Color;

        public Car1() //Default Constructor
        {
            Brand = "Car";
            Speed = 1;
            Color = "red";
        }
       
        public Car1(string brand, int speed,string color) //Parameterized Constructor
       {
            Brand = brand;  // Set the initial value of Brand
            Speed = speed;  // Set the initial value of Speed
            Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
        public void Showcolor()
        {
            Console.WriteLine( $"Color: {Color}");
        }
    }

    class car1program
    {
        static void Main()
        {
            // Create an object of the Car class using the constructor
            Car1 myCar = new Car1("Toyota",120,"grey");  // Pass values for Brand and Speed
            Car1 mycar2 = new Car1("Benz", 180,"Red");
            Car1 mycar3 = new Car1("Audi", 200, "Black");
            Car1 mycar4 = new Car1("BMW", 300,"Beige");
            Car1 mycar5 = new Car1();
            myCar.ShowDetails();  // Output: Brand: Toyota, Speed: 120 km/h
            myCar.Showcolor();

            mycar2.ShowDetails();
            mycar2.Showcolor();

            mycar3.ShowDetails();
            mycar3.Showcolor();  
                }
    }












}
