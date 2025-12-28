using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MVC_CoffeeApplication.Models.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


string machineName = Environment.MachineName;
string connectionString=string.Empty;

switch (machineName)
{
    case "DESKTOP-J4PTH70":
        connectionString = builder.Configuration.GetConnectionString("FatihConnection");
        break;

    case "REVERAN\\SQLEXPRESS":
        connectionString = builder.Configuration.GetConnectionString("ErayConnection");
        break;
}



//CoffeeContext Servis içerisinde kullanýlmasý gerekiyor.
builder.Services.AddDbContext<CoffeeContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//Area Route
app.MapControllerRoute(
    name: "area",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
