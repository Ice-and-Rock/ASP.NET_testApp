EF Context Review
In this lesson you learned how to build database models and connect your ASP.NET application to a working database:

Models are C# classes that define entity structure. They are defined in the Models/ folder.
The connection string is the link from the C# code to the physical database. It’s defined in appsettings.json.
Three packages are required to get Entity Framework (EF) running:
<code>
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
</code>

The context is a class that acts as a middle man. It has C# methods that you can call to ask the database to do something useful, like add a record or return all rows in a table. It relies on the connection string in appsettings.json to physically locate the database file. It is defined in the Data/ folder.
The EF context is added to the app by editing Startup.ConfigureServices() and adding new functionality in Program.cs (we did that by adding the CreateDBIfNotExists() method).
In Startup.cs:

<code>
public void ConfigureServices(IServiceCollection services)
{
  services.AddRazorPages();
          
  services.AddDbContext<CountryContext>(options => 
    options.UseSqlite(Configuration.GetConnectionString("CountryContext")));
}
</code>

In Program.cs:
<code>
private static void CreateDbIfNotExists(IHost host)
{
  using (var scope = host.Services.CreateScope())
  {
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<CountryContext>();
    context.Database.EnsureCreated();
  }
}
</code>
