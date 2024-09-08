using System.ComponentModel;
using LSCore.DependencyInjection.Extensions;
using MyProject.Contracts.Constants;
using LSCore.Framework.Middlewares;
using LSCore.Framework.Extensions;
using MyProject.Repository;

// Creating application builder
var builder = WebApplication.CreateBuilder(args);

// Load configuration from json file and environment variables
builder.Configuration
    .AddJsonFile(Constants.General.AppSettings, optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

builder.Services.AddSingleton<IConfigurationRoot>(builder.Configuration);

builder.AddLSCoreDependencyInjection((options) =>
{
    options.Scan.AssemblyAndExecutablesFromApplicationBaseDirectory(assembly => assembly?.GetName()?.Name?.StartsWith("MyProject") ?? false);
});

// Register database
builder.Services.RegisterDatabase(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.LSCoreAddLogging();

var app = builder.Build();

app.UseLSCoreDependencyInjection();

// Add exception handling middleware
// It is used to handle exceptions globally
app.UseMiddleware<LSCoreHandleExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();