using Microsoft.EntityFrameworkCore;

namespace SQLServerMigration.Models
{
    public class DBExampleContext : DbContext
    {
        public DBExampleContext(DbContextOptions<DBExampleContext> options) : base(options) { }
        
        public DbSet<User> Users { get; set; }
    }
}

//Install next dependecies
//https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/9.0.5
//https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/9.0.5
//https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/9.0.5

//Read documentation
//https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli#create-the-model
//https://learn.microsoft.com/en-us/ef/core/cli/dotnet
//https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli

//NET CLI
//dotnet list package => to check dependencies from your proyect
