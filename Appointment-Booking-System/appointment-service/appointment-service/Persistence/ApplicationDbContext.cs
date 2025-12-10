using appointment_service.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace appointment_service.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public const string Schema = "appointment_service";

        public DbSet<Branch> Branches { get; set; }
        public DbSet<OperationalHours> OperationalHours { get; set; }
        public DbSet<CustomerInfo> CustomerInfo { get; set; }
        public DbSet<AppointmentRequest> AppointmentRequest { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Console.WriteLine(string.Format("Schema: {0}", Schema));
            modelBuilder.HasDefaultSchema(Schema);

            // ----------------------------
            // Branch Entity
            // ----------------------------
            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(b => b.Id);
                entity.HasMany(b => b.OperationalHours)
                      .WithOne(o => o.Branch)
                      .HasForeignKey(o => o.BranchId);
            });


            // ----------------------------
            // OperationalHours Entity
            // ----------------------------
            modelBuilder.Entity<OperationalHours>(entity =>
            {
                entity.HasKey(o => o.Id);
            });


            // ----------------------------
            // AppointmentRequest Entity
            // ----------------------------
            modelBuilder.Entity<AppointmentRequest>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Time)
                                .HasConversion(
                                      v => v.ToString(),
                                      v => TimeSpan.Parse(v)
                                  ); ;

                entity.OwnsOne(a => a.Customer);
            });

            Seed.SeedData.Seed(modelBuilder);
        }
    }
}
