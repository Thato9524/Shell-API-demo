using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace shelldemoAPI.Models
{
    public partial class TestApiDbContext : DbContext
    {
        

        public TestApiDbContext(DbContextOptions<TestApiDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TestTable> TestTables { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<TestTable>(entity =>
            {
                entity.ToTable("TestTable");

                entity.Property(e => e.TestDetails)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TestName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestSalary).HasColumnType("decimal(10, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
