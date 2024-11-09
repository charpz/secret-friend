using System.ComponentModel.DataAnnotations;

namespace Migrations.Models;

public class User
{
    [Key]
    public required Guid Id { get; init; }

    public required string Name { get; set; }

    public Guid? UnsortGroupId { get; set; }

    public bool HasSecretFriend { get; set; }
}