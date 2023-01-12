using CalendarFormula1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace CalendarFormula1.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)


        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Piloti_Cursa>().HasKey(am => new
            {
                am.PilotiId,
                am.CursaId
            });

            modelBuilder.Entity<Piloti_Cursa>().HasOne(m => m.Cursa).WithMany(am => am.Pilotii_Cursaa).HasForeignKey(am => am.CursaId);
            modelBuilder.Entity<Piloti_Cursa>().HasOne(m => m.Piloti).WithMany(am => am.Pilotii_Cursaa).HasForeignKey(am => am.PilotiId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Cursa> Cursaa { get; set; }
        public DbSet<Piloti> Pilotii { get; set; }
        public DbSet<Tara> Taraa { get; set; }

        public DbSet<Piloti_Cursa> Pilotii_Cursaa { get; set; }
    }
}
