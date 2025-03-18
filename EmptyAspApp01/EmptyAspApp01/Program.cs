namespace EmptyAspApp01
{
    public class Program
    {
        public static string Wishes()
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12) return "Good Morning";
            else if (hour < 16) return "Good Afternoon";
            else return "Good Evening";

        }
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World");
            app.MapGet("/date",()  => DateTime.Now.ToLongDateString());
            app.MapGet("/time", () => DateTime.Now.ToLongTimeString());
            app.MapGet("/wishes",() => Wishes());


            app.Run();
        }
        
        
    }

}
