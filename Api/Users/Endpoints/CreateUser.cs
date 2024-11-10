using Microsoft.AspNetCore.Http.HttpResults;
using SecretFriend.Migrations.Database;
using SecretFriend.Migrations.Models;

namespace SecretFriend.Api.Users.Endpoints;

internal static class CreateUser
{
    internal static void MapCreateUser(this IEndpointRouteBuilder app) => app
        .MapPost("/create", Handle)
        .WithSummary("Creates a new user");

    private static async Task<Ok<Response>> Handle(Request request, AppDbContext dbContext, CancellationToken ct)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            Name = request.Name
        };

        await dbContext.Users.AddAsync(user, ct);
        await dbContext.SaveChangesAsync(ct);

        var response = new Response(user.Id);

        return TypedResults.Ok(response);
    }

    internal record Request(string Name);
    internal record Response(Guid Id);

    // TODO: Use Fluent Validation for the User name.
}
