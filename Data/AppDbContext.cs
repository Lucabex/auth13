using Microsoft.EntityFrameworkCore;
using auth13.Models;

namespace auth13.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<User>User{get;set;}
}