using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaBox.Storing
{
    public partial class PizzaBoxDBContext : DbContext
    {
        public PizzaBoxDBContext()
        {
        }

        public PizzaBoxDBContext(DbContextOptions<PizzaBoxDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<Toppings> Toppings { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=localhost;database=PizzaBoxDB; user id=sa;password=Password123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__F1FF8453DF7B360D");

                entity.ToTable("Orders", "PizzaBox");

                entity.Property(e => e.OrderId).HasColumnName("Order_id");

                entity.Property(e => e.PizzaId).HasColumnName("Pizza_id");

                entity.HasOne(d => d.Pizza)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PizzaId)
                    .HasConstraintName("FK__Orders__Pizza_id__3B75D760");
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.ToTable("Pizza", "PizzaBox");

                entity.Property(e => e.PizzaId).HasColumnName("Pizza_id");

                entity.Property(e => e.Crust).HasMaxLength(100);

                entity.Property(e => e.Size).HasMaxLength(100);
            });

            modelBuilder.Entity<Stores>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK__Stores__A0F0671914E0314C");

                entity.ToTable("Stores", "PizzaBox");

                entity.Property(e => e.StoreId).HasColumnName("Store_id");

                entity.Property(e => e.OrderId).HasColumnName("Order_id");

                entity.Property(e => e.StoreLocation).HasMaxLength(100);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Stores__Order_id__3E52440B");
            });

            modelBuilder.Entity<Toppings>(entity =>
            {
                entity.HasKey(e => e.ToppingItem)
                    .HasName("PK__Toppings__53D46871A35EE129");

                entity.ToTable("Toppings", "PizzaBox");

                entity.Property(e => e.PizzaId).HasColumnName("Pizza_id");

                entity.HasOne(d => d.Pizza)
                    .WithMany(p => p.Toppings)
                    .HasForeignKey(d => d.PizzaId)
                    .HasConstraintName("FK__Toppings__Pizza___38996AB5");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users", "PizzaBox");

                entity.Property(e => e.UsersId).HasColumnName("Users_id");

                entity.Property(e => e.LastOrderTime)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StoresId).HasColumnName("Stores_id");

                entity.HasOne(d => d.Stores)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.StoresId)
                    .HasConstraintName("FK__Users__Stores_id__412EB0B6");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
