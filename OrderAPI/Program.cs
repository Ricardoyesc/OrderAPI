using Entities.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using OrderAPI.Configuration;
using OrderAPI.Policies.Handlers;
using OrderAPI.Policies.Requirements;
using OrderAPI.Repositories;
using OrderAPI.Repositories.Interfaces;

var serverVersion = new MySqlServerVersion(new Version(8, 0, 3));
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    });


builder.Services.AddDbContext<DatabaseContext>(options => {
    options.UseMySql(builder.Configuration.GetConnectionString("MyConnection"), serverVersion, b => b.MigrationsAssembly("OrderAPI"));
                //.LogTo(Console.WriteLine, LogLevel.Trace)
                //.EnableSensitiveDataLogging()
                //.EnableDetailedErrors();
});

builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer("Bearer", options =>
    {
        options.Authority = "https://localhost:5001";
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = false
        };
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("DiDiHeaderSignaturePolicy", policy =>
    {
        policy.Requirements.Add(new DiDiHeaderSignatureRequirement(builder.Configuration.GetSection("DiDiConfiguration").Get<DiDiConfiguration>().AppSecret));
    });
    options.AddPolicy("RappiWebhookSignaturePolicy", policy =>
    {
        policy.Requirements.Add(new RappiWebhookSignatureRequirement(builder.Configuration.GetSection("RappiConfiguration").Get<RappiConfiguration>().ClientSecret));
    });
});

builder.Services.AddSingleton<IAuthorizationHandler, RappiWebhookSignatureHandler>();
builder.Services.AddSingleton<IAuthorizationHandler, DiDiHeaderSignatureHandler>();
builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();

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
