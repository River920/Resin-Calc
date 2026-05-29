var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/show-users", BackEndpoints.ShowHTMLforIndex);

app.Run("http://localhost:4000");


static class BackEndpoints
{
    public static async Task<IResult> ShowHTMLforIndex()
    {
        var html = await File.ReadAllTextAsync("index.html");
        return Results.Content(html, "text/html");
    }
}