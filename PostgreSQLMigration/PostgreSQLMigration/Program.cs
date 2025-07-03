using Microsoft.EntityFrameworkCore;
using PostgreSQLMigration.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Entity Framework Core
// Connection string injection
builder.Services.AddDbContext<DBExampleContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("ExampleConnection"));
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
