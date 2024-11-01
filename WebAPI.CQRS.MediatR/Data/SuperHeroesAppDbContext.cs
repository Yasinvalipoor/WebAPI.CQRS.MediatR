using Microsoft.EntityFrameworkCore;
using WebAPI.CQRS.MediatR.Models;

namespace WebAPI.CQRS.MediatR.Data
{
    public class SuperHeroesAppDbContext : DbContext
    {
        public SuperHeroesAppDbContext(DbContextOptions options) : base(options){}

        public DbSet<SuperHeroes> SuperHeroes { get; set; }
    }
}
