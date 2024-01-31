using JWT.APP.Back.Core.Domain;
using JWT.APP.Back.Persistance.Configurations;
using Microsoft.EntityFrameworkCore;

namespace JWT.APP.Back.Persistance.Context
{
    public class JwtContext : DbContext
    {
        public JwtContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers => this.Set<AppUser>();
        public DbSet<AppRole> AppRoles => this.Set<AppRole>();
        public DbSet<Product> Products => this.Set<Product>(); 
        public DbSet<Category> Categories => this.Set<Category>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
