using Microsoft.EntityFrameworkCore;
using Cidax.Domain.Entities;
using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Cidax.Infrastructure.Context
{
    public class CidaxDbContext : DbContext
    {
        public CidaxDbContext(DbContextOptions<CidaxDbContext> options) : base(options) { }
        public DbSet<Domain.Entities.Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.Location>(entity =>
            {
                entity.ToTable("Locations");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(e => e.Category)
                      .HasConversion<int>()
                      .IsRequired();

                entity.Property(e => e.Point)
                      .HasColumnType("geography (point)")
                      .IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
