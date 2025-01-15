using LSCore.Contracts.Configurations;
using LSCore.DependencyInjection.Extensions;
using LSCore.Framework.Extensions;
using MyProject.Repository;

var builder = WebApplication.CreateBuilder(args);

// LSCore Logging setup
builder.LSCoreAddLogging();

// LSCore Dependency Injection setup
// Change "MyProject" to your project root  name (without .Api / .Domain / .Repository)
builder.AddLSCoreDependencyInjection("MyProject");

// Uncomment if you want to use LSCore Authorization.
// Pass valid configuration to AddLSCoreAuthorization
// builder.AddLSCoreAuthorization();

// Uncomment if you want to use LSCore Authorization with permissions.
// Can be used with other LSCore Authorization methods.
// Base builder.AddLSCoreAuthorization() is required.
// builder.AddLSCoreAuthorizationHasPermission<>();

// Uncomment if you want to use LSCore Authorization with roles.
// Can be used with other LSCore Authorization methods.
// Base builder.AddLSCoreAuthorization() is required.
// builder.AddLSCoreAuthorizationHasRole<>();

// Common
builder.Services.AddSingleton<IConfigurationRoot>(builder.Configuration);

// Database setup. Remove this line if you don't have a database
builder.Services.RegisterDatabase(builder.Configuration);

// Controllers setup. Remove if you want to map endpoints in this file
builder.Services.AddControllers();

#region Swagger // Remove this region if you don't want to use Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion

var app = builder.Build();

// Add exception handling middleware
// It is used to handle exceptions globally
app.UseLSCoreHandleException();

// Used to handle static methods accessing the service provider
// This is needed for Validators and other classes that need to access the Singleton objects in the service provider
app.UseLSCoreDependencyInjection();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Uncomment in pair with builder.AddLSCoreAuthorization();
// app.UseLSCoreAuthorization();

// Uncomment in pair with builder.AddLSCoreAuthorizationHasPermission<>();
// app.UseLSCoreAuthorizationHasPermission();

// Uncomment in pair with builder.AddLSCoreAuthorizationHasRole<>();
// app.UseLSCoreAuthorizationHasRole();

app.MapControllers();

app.Run();