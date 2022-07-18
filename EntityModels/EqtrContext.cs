using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EqtrApp.EntityModels
{
    public partial class EqtrContext : DbContext
    {
        public EqtrContext()
        {
        }

        public EqtrContext(DbContextOptions<EqtrContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Citizen> Citizen { get; set; }
        public virtual DbSet<DrivingCategories> DrivingCategories { get; set; }
        public virtual DbSet<DrivingLicense> DrivingLicense { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-MALH4598\\SQLEXPRESS;Database=Eqtr;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");

                entity.Property(e => e.OtherNames).HasMaxLength(128);

                entity.Property(e => e.PlaceOfBirth).HasMaxLength(128);

                entity.Property(e => e.Surname).HasMaxLength(128);
            });

            modelBuilder.Entity<DrivingCategories>(entity =>
            {
                entity.Property(e => e.CategoryCode).HasMaxLength(4);

                entity.Property(e => e.ValidFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.ValidUntil).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<DrivingLicense>(entity =>
            {
                entity.Property(e => e.IssuingAuthority).HasMaxLength(128);

                entity.Property(e => e.LicenseNumber).HasDefaultValueSql("(newid())");

                entity.Property(e => e.PhotoLocation).HasMaxLength(256);

                entity.Property(e => e.ValidFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.ValidUntil).HasColumnType("smalldatetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
