using Microsoft.EntityFrameworkCore;
using Migrations.Models;

namespace Migrations.Database;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public required DbSet<User> Users { get; set; }
}
