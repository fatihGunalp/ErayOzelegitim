var builder = WebApplication.CreateBuilder(args);

//Services: MVC servisi eklmemiz gerekmektedir.
builder.Services.AddControllersWithViews();



var app = builder.Build();

//Pipeline

app.UseRouting(); //Rotanýn kullanýlmasý aktif hale getir

app.UseEndpoints(options =>
{
    options.MapDefaultControllerRoute(); //varsayýlan controller rotasýný kullan.

    //https://localhost:7141/Home/Index/id
});

app.Run();
