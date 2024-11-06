using Api.Weather;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapWeatherForecastEndpoint();

app.Run();