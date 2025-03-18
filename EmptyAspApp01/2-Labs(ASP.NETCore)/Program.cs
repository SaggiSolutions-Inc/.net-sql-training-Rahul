var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseDefaultFiles();//This Middleware used to serve index.html or html or defult.html as landing pages
app.UseStaticFiles(); //This is Middleware used to server an UI content like html, css and javascript,etc.

app.Run();
        
    

