using Microsoft.EntityFrameworkCore;

namespace MVC_Coffee.Context
{
    public class ProjectContext:DbContext
    {
        //Microsoft.EntityFrameworkCore.SqlServer 
        //Microsoft.EntityFrameworkCore.Tools

        private string fatihConnectionString = "server=DESKTOP-J4PTH70;database=CoffeeDb;uid=sa;pwd=123;TrustServerCertificate=True;";

        private string erayConnectionString = "";

        //veritabanına hangi nesneler tablo olarak gidecek.

    }
}
