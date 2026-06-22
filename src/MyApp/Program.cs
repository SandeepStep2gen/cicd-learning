var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "CI/CD Learning App is running! 🚀");

app.MapGet("/health", () => Results.Ok(new
{
  status = "healthy",
  app = "CicdLearning"
}));

app.Run();