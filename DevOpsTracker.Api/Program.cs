var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => Results.Ok(new
{
    application = "DevOps Learning Tracker",
    version = "1.0.0",
    message = "Application is running"
}));

app.MapGet("/api/topics", () =>
{
    var topics = new[]
    {
        new { id = 1, name = "Linux", status = "Completed" },
        new { id = 2, name = "Git", status = "In Progress" },
        new { id = 3, name = "Docker", status = "Not Started" },
        new { id = 4, name = "Jenkins", status = "Not Started" },
        new { id = 5, name = "Kubernetes", status = "Not Started" }
    };

    return Results.Ok(topics);
});

app.MapGet("/health", () => Results.Ok(new
{
    status = "Healthy"
}));

app.Run();

public partial class Program { }