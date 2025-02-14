var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.ConfigureServices(builder.Configuration);

var app = builder.Build();

// Configure middleware
app.ConfigureMiddleware();

app.Run();
