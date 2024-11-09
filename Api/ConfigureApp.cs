using Scalar.AspNetCore;

namespace Api;

internal static class ConfigureApp
{
    internal static void Configure(this WebApplication app)
    {
        app.UseDevelopmentOpenApi();
        app.UseHttpsRedirection();
        app.MapEndpoints();
    }

    private static void UseDevelopmentOpenApi(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.MapScalarApiReference(options =>
            {
                options
                    .WithTitle("My Secret Friend API");
            });
        }
    }
}