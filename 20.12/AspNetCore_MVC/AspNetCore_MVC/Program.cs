//AspNetCore MiddleWare (Ara katman)
//Model View Controller: 
//Model: Proje içerisinde kullanýlmasý gereken model classlarý barýndýrýr.
//View: Oluþturulan modellerin tasarýmsal alanlarýný temsil eder.
//Controller: gönderilen istekleri ilk iþleyen mekanizmadýr.


//Services
var builder=WebApplication.CreateBuilder(args);

//Yukarýda tanýmlý olan webapplication içerisine ihtiyacýmýz olan servisleri bu satýr altýnda kullanacaðýz.


//App
var app = builder.Build();
//eklenen servisleri kullanýma nasýl alýnacaðýný bu satýr altýnda detaylandýracaðýz.

//Sayfa açýldýðýnda ziyaretçiye "Merhaba" yazan deðer gösterilsin.
app.MapGet("/", () =>
{
    return "Merhaba";
});

app.MapGet("/about", () =>
{
    return "Hakkýmýzda";
});
//https://localhost:7012/binding/query?content=%C3%B6rnek_de%C4%9Fer
app.MapGet("/binding/query", (string content) =>
{
    return $"Query: {content}";
});

app.MapGet("/binding/route/{id}", (int id) =>
{
    return $"Route id={id}";
});

//product/query
app.MapGet("/product/query", (int id, string productName) =>
{
    return $"Ürün Id: {id} Ürün Ad: {productName}";
});


app.Run();





//MiddleWare
//-Projeler ilk oluþturulduðunda her zaman core projesi olarak tanýmlanýr.
//Projeler içerisinde bir takým servisler kullanmamýz gerekebilir.
//-MVC
//-API
//-BackgroundService

