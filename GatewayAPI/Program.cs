using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile(
        builder.Environment.IsDevelopment()
        ? "ocelot.Development.json"
        : "ocelot.json");
builder.Services.AddOcelot();

var app = builder.Build();

await app.UseOcelot();

app.Run();