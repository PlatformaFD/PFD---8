var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "PFD v8 API running");

app.MapGet("/api/health", () => new
{
    status = "ok",
    product = "PFD v8.0"
});

app.Run("http://localhost:5099");