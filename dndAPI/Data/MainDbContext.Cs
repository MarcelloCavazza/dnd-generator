using dndAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace dndAPI.Data;

public class MainDbContext : DbContext
{
    public MainDbContext(DbContextOptions<MainDbContext> context): base(context)
    {
        
    }
    public DbSet<User> User { get; set; }
}