using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QM.DataAccess.Mapping.Users;
using QM.Entities.Concrete.Users;

namespace QM.DataAccess.Concrete.EntityFrameworkCore.Context
{
    /// <summary>
    /// Veri tabanı işlemleri
    /// </summary>
    public class ArlentusBIContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=ArlentusBIQM;uid=sa;pwd=arlentus");
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new AppRoleMap());
            modelbuilder.ApplyConfiguration(new AppUserMap());
            base.OnModelCreating(modelbuilder);
        }
        public DbSet<AppUser> AspNetUsers { get; set; }
        public DbSet<AppRole> AspNetRoles { get; set; }
     
    }
}
