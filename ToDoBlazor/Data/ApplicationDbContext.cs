using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ToDoBlazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ToDoItem>()
                .HasData(
                new ToDoItem { Id = 1, DisplayLabel = "Vider la poubelle", CreateDate = new DateTime(2024, 02, 10) },
                new ToDoItem { Id = 2, DisplayLabel = "Ranger la chambre ", CreateDate = new DateTime(2024, 02, 10) }
                );

            base.OnModelCreating(builder);
        }
    }
}
