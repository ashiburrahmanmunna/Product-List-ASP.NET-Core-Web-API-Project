using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace EmployeeList.WebApi.Model
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee>? Employees { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");
                entity.Property(e => e.ID).HasColumnName("ID");
                entity.Property(e => e.CategoryName).HasMaxLength(15).IsUnicode(false);
                entity.Property(e => e.UnitName).HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.Name).HasMaxLength(256).IsUnicode(false);
                entity.Property(e => e.Code).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.ParentCode).IsUnicode(false);
                entity.Property(e => e.ProductBarcode).HasMaxLength(1).IsUnicode(false);
                entity.Property(e => e.Description).HasMaxLength(1).IsUnicode(false);
                entity.Property(e => e.BrandName).IsUnicode(false);
                entity.Property(e => e.SizeName).IsUnicode(false);
                entity.Property(e => e.ColorName).IsUnicode(false);
                entity.Property(e => e.ModelName).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.VariantName).IsUnicode(false);
                entity.Property(e => e.OldPrice).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Price).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.CostPrice).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.WarehouseList).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.stock).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.TotalPurchase).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.LastPurchaseDate).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.LastPurchaseSupplier).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.TotalSales).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.LastSalesDate).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.LastSalesCustomer).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.ImagePath).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Type).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Status).HasMaxLength(50).IsUnicode(false);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
