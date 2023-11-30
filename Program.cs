using DotNetGrpc.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

app.MapGet("/", () => "live");

// BeforeFilter
app.Use(async (context, next) =>
{
    
    await next(context);
});

// Configure the HTTP request pipeline.
app.MapGrpcService<LoginService>();

// AfterFilter
app.Use(async (context, next) =>
{
    
    await next(context);
});

app.Run();
