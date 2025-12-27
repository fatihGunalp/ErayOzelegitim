var builder = WebApplication.CreateBuilder(args);
//Services
builder.Services.AddControllersWithViews();


//application (pipeline)
var app = builder.Build();

//Routing
app.UseRouting(); //URL'de yapacaðýmýz istekleri temsil eder.

app.UseStaticFiles();//wwwroot URL'den ulaþýlmasýný saðlar.

app.UseEndpoints(endpoint =>
{
    endpoint.MapDefaultControllerRoute();
});


app.Run();
