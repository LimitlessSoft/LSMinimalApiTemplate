var builder = WebApplication.CreateBuilder(args);

// Inject database configuration and use this project for migrations

var app = builder.Build();
app.Run();