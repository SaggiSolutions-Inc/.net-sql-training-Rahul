using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EfcoreCodeFirstApproach.Data;
namespace EfcoreCodeFirstApproach
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<EFCodeFirstDb>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("EFCodeFirstDb") ?? throw new InvalidOperationException("Connection string 'EFCodeFirstDb' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
