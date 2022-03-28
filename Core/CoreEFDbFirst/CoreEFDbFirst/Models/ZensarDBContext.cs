using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CoreEFDbFirst.Models
{
    public partial class ZensarDBContext : DbContext
    {
        public ZensarDBContext()
        {
        }

        public ZensarDBContext(DbContextOptions<ZensarDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dummy> Dummies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-PU8R89M\\BRSQL;Database=ZensarDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dummy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dummy");

                entity.HasIndex(e => e.Dummydesc, "idxdummydesc")
                    .IsClustered();

                entity.HasIndex(e => e.Phone, "idxphone")
                    .IsUnique();

                entity.Property(e => e.Col1).HasColumnName("col1");

                entity.Property(e => e.Dummydesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("dummydesc");

                entity.Property(e => e.Dummyid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("dummyid");

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
