using Microsoft.EntityFrameworkCore;
using SecretFriend.Migrations.Database;

namespace SecretFriend.Api;

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
