using Microsoft.EntityFrameworkCore;
using SecretFriend.Migrations.Models;

namespace SecretFriend.Migrations.Database;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public required DbSet<User> Users { get; set; }
}
