namespace ConApp01
{

    class Agecalculations
    {
        static void Main()
        {
            Console.Write("Enter you Date of Birth [mm/dd/yyyy]: ");
            DateTime DOB = Convert.ToDateTime(Console.ReadLine());

            DateTime Today = DateTime.Now;

            TimeSpan timespan = Today - DOB;
            double agedays = timespan.Days;

            Double Ageyears = agedays / 365;

            Console.WriteLine($"Your current age in days = {agedays}");
            Console.WriteLine($"Your current age in years = {Ageyears}");







        }
    }
}
