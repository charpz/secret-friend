using Microsoft.EntityFrameworkCore;
using Migrations.Database;

namespace Api;

internal static class ConfigureServices
{
    public static void AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApi();
        builder.AddDatabase();
    }

    private static void AddDatabase(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>(optionsBuilder =>
        {
            optionsBuilder.UseNpgsql(builder.Configuration.GetConnectionString("Default"));
        });
    }
}
