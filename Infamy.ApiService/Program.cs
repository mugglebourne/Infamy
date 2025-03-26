using Infamy.ApiService.DataModels;
using Microsoft.EntityFrameworkCore;
//using HotChocolate.AspNetCore.Com
using Infamy.ApiService.Types;
using Infamy.ServiceDefaults.Models;

var builder = WebApplication.CreateBuilder(args);
var CorsPolicy = "_corsPolicy";

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

builder.Services.AddDbContext<ApplicationDbContext>(
        options => options.UseNpgsql("Host=ep-square-dawn-a5jly8xh-pooler.us-east-2.aws.neon.tech;Username=neondb_owner;Password=npg_UvE9FMAYcW5z;Database=neondb"))
        .AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>().AddType<DeveloperType>().AddType<ToolType>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(CorsPolicy, builder =>
    {
        builder.WithOrigins("*")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

//builder.Services
//.AddQueryType<Queries>()
//.AddType<Developer>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

string[] summaries = ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.MapGraphQL();

app.MapDefaultEndpoints();

app.UseCors(CorsPolicy);

//app.Run();
await app.RunWithGraphQLCommandsAsync(args);

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
