using LSMinimalApi.Contracts.Constants;
using LSMinimalApi.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration
    .AddJsonFile(Constants.General.AppSettings, optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();
    
builder.Services.RegisterDatabase(builder.Configuration);
var app = builder.Build();
app.Run();