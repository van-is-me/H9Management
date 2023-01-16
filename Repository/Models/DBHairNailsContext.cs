using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Repository.Models
{
    public partial class DBHairNailsContext : DbContext
    {
        public DBHairNailsContext()
        {
        }

        public DBHairNailsContext(DbContextOptions<DBHairNailsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database= DBHairNails;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CateId)
                    .HasName("PK__Category__A88B4DC4E5EC0E24");

                entity.ToTable("Category");

                entity.Property(e => e.CateId).HasColumnName("cateID");

                entity.Property(e => e.CateName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("cateName");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CusId)
                    .HasName("PK__Customer__BA9897D3A3A0A139");

                entity.ToTable("Customer");

                entity.Property(e => e.CusId).HasColumnName("cusID");

                entity.Property(e => e.CusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cusName");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('false')");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrId)
                    .HasName("PK__Order__4FCC892A54F9311C");

                entity.ToTable("Order");

                entity.Property(e => e.OrId).HasColumnName("orID");

                entity.Property(e => e.CusId).HasColumnName("cusID");

                entity.Property(e => e.DateCheckIn)
                    .HasColumnType("date")
                    .HasColumnName("dateCheckIn")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateCheckOut)
                    .HasColumnType("date")
                    .HasColumnName("dateCheckOut");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.Property(e => e.MainEmp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mainEmp");

                entity.Property(e => e.SubEmp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("subEmp");

                entity.HasOne(d => d.Cus)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Customer");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_User");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrDeId)
                    .HasName("PK__OrderDet__04BAB8A822572363");

                entity.ToTable("OrderDetail");

                entity.Property(e => e.OrDeId).HasColumnName("orDeID");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.OrId).HasColumnName("orID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SerId).HasColumnName("serID");

                entity.HasOne(d => d.Or)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_Order");

                entity.HasOne(d => d.Ser)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.SerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_Service");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.SerId)
                    .HasName("PK__Service__DFDAC510034241D3");

                entity.ToTable("Service");

                entity.Property(e => e.SerId).HasColumnName("serID");

                entity.Property(e => e.CateId).HasColumnName("cateID");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.SerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("serName");

                entity.HasOne(d => d.Cate)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.CateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_Category");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__User__66DCF95D7F289C47");

                entity.ToTable("User");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("passWord");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role")
                    .HasDefaultValueSql("(user_name())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
