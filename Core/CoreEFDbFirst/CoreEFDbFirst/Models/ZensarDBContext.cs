using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CoreEFDbFirst.Models
{
    public partial class ZensarDBContext : DbContext
    {
        //public ZensarDBContext()
        //{
        //}

        public ZensarDBContext(DbContextOptions<ZensarDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AuditTable> AuditTables { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Dummy> Dummies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSale> ProductSales { get; set; }
        public virtual DbSet<TableA> TableAs { get; set; }
        public virtual DbSet<TableB> TableBs { get; set; }

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
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AccountNumber)
                    .HasName("PK__Accounts__BE2ACD6ED583CFDD");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Audit_table");

                entity.Property(e => e.Msg)
                    .IsUnicode(false)
                    .HasColumnName("msg");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PK__Departme__014881AE0E714755");

                entity.ToTable("Department");

                entity.Property(e => e.DeptId).ValueGeneratedNever();

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Loc)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

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

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__AF2DBB99DB2AFF70");

                entity.ToTable("Employee");

                entity.HasIndex(e => e.Email, "UQ__Employee__A9D10534C4220B32")
                    .IsUnique();

                entity.Property(e => e.EmpId).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(20);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.DeptNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Dept)
                    .HasConstraintName("FK__Employee__Dept__3E52440B");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductSale>(entity =>
            {
                entity.HasKey(e => e.ProductSalesId)
                    .HasName("PK__ProductS__1B97309ED1CD19E5");

                entity.Property(e => e.ProductSalesId).ValueGeneratedNever();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<TableA>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TableA");

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gendr)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TableB>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TableB");

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gendr)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
