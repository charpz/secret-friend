
namespace Api.Weather;

public static class WeatherForecast
{
    private static readonly string[] Summaries = { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

    public static WebApplication MapWeatherForecastEndpoint(this WebApplication app)
    {
        app.MapGet("/weatherforecast", Handle);
        return app;
    }

    private static Response[] Handle(HttpContext context)
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
        new Response
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            Summaries[Random.Shared.Next(Summaries.Length)]
        ))
        .ToArray();

        return forecast;
    }

}

internal record Response(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}