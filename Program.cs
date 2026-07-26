var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/show-calculator", BackEndpoints.ShowHTMLforIndex);
app.MapGet("/show-tutorial", BackEndpoints.ShowHTMLforTutorial);
app.MapGet("/", BackEndpoints.ShowHTMLforDirectory);

app.Run("http://localhost:4000");


static class BackEndpoints
{
    public static async Task<IResult> ShowHTMLforIndex()
    {
        var html = await File.ReadAllTextAsync("index.html");
        return Results.Content(html, "text/html");
    }
        
    public static async Task<IResult> ShowHTMLforTutorial()
    {
        var html = await File.ReadAllTextAsync("tutorial.html");
        return Results.Content(html, "text/html");
    }

    public static async Task<IResult> ShowHTMLforDirectory()
    {
        var html = await File.ReadAllTextAsync("directory.html");
        return Results.Content(html, "text/html");
    }
}