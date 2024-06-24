using Microsoft.EntityFrameworkCore;
using ApiRest.Models;

// llamdado al ORM

namespace ApiRest.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Person> Persons { get; set; }
    }
}
