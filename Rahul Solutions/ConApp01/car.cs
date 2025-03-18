
namespace ConApp01
{
    class Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public int Year;

        public Car()
        {
            Brand = "unknown";
            Model = "Unknown";
            Color = "Unknown";
            Year = 0;
        }
        public Car(string brand, string model, string color, int year)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Year = year;
        }

        public void Display()
        {
            Console.WriteLine($"Car: {Brand} {Model} {Color},Year: {Year}");

        }
    }
    class Cardetails
    {
        static void Main()
        {
            {
                Car mycar = new Car();
               

                mycar.Display();

                Console.WriteLine("===================================================");

                Car mysecondcar = new Car("Toyota","Corolla","Grey",2011);
                

                mysecondcar.Display();


            }
        }
    }
}
