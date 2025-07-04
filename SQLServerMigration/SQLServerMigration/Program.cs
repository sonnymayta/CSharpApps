using Microsoft.EntityFrameworkCore;
using SQLServerMigration.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Entity Framework Core SQL Server
// Connection string is assumed to be in appsettings.json
builder.Services.AddDbContext<DBExampleContext>(options =>
{
 options.UseSqlServer(builder.Configuration.GetConnectionString("ExampleConnection"));
});

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
