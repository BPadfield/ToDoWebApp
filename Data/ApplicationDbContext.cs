using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToDoWebApp.Models;
using todo.Models;
namespace ToDoWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ToDoUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<todo.Models.ToDo> ToDo { get; set; }
    }
}