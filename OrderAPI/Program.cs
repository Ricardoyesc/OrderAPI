using Entities.Context;
using Microsoft.EntityFrameworkCore;

var serverVersion = new MySqlServerVersion(new Version(8, 0, 3));
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<DatabaseContext>(options => {
    options.UseMySql(builder.Configuration.GetConnectionString("MyConnection"), serverVersion, b => b.MigrationsAssembly("OrderAPI"));
                //.LogTo(Console.WriteLine, LogLevel.Trace)
                //.EnableSensitiveDataLogging()
                //.EnableDetailedErrors();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
