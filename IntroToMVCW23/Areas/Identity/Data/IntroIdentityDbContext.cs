using IntroToMVCW23.Areas.Identity.Data;
using IntroToMVCW23.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IntroToMVCW23.Data;


// One user class is available
public class IntroIdentityDbContext : IdentityDbContext<AppUser>
{
    public IntroIdentityDbContext(DbContextOptions<IntroIdentityDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<TodoItem> TodoItem { get; set; } = default!;
    public DbSet<TodoList> TodoLists { get; set; } = default!;
}
