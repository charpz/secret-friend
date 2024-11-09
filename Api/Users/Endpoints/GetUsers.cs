using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Migrations.Database;

namespace Api.Users.Endpoints;

internal static class GetUsers
{
    internal static void MapGetUsers(this IEndpointRouteBuilder app) => app
        .MapGet("/", Handle)
        .WithSummary("Gets all users");

    private static async Task<Ok<List<Response>>> Handle(AppDbContext dbContext, CancellationToken ct)
    {
        var response = await dbContext.Users.Select(s => new Response(s.Name)).ToListAsync(ct);

        return TypedResults.Ok(response);
    }

    internal record Response(string Name);
}