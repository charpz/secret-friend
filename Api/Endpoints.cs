using Api.Users.Endpoints;

namespace Api;

internal static class Endpoints
{
    internal static void MapEndpoints(this WebApplication app)
    {
        var endpoints = app.MapGroup("");

        endpoints.MapUserEndpoints();
    }

    private static void MapUserEndpoints(this IEndpointRouteBuilder app)
    {
        var endpoints = app.MapGroup("/users")
            .WithTags("Users");

        endpoints.MapCreateUser();
        endpoints.MapGetUsers();
    }
}