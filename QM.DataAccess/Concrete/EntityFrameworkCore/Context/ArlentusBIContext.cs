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
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-P12SOIP\SQLEXPRESS;Database=ArlentusDeneme1;uid=umutd;pwd=Ud4583!");
            //optionsBuilder.UseSqlServer(@"Server=localhost;Database=ArlentusBIQM;uid=sa;pwd=arlentus");
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=ArlentusBIQM;uid=sa;pwd=arlentus");
            //optionsBuilder.UseSqlServer(@"Server =94.73.146.3;Database=u0294692_ACBI;uid=u0294692_AC2013;pwd=ArlentusControl2013**);
            //optionsBuilder.UseSqlServer(@"Server=94.73.170.2;Database=u0406106_ACQMS;uid=u0406106_AC2022;pwd=ArlentusControl2013**");
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
