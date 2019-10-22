using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eTrack.Models
{
    public partial class eTrackAppDbContext : DbContext
    {
        public eTrackAppDbContext()
        {
        }

        public eTrackAppDbContext(DbContextOptions<eTrackAppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AssetCondition> AssetCondition { get; set; }
        public virtual DbSet<AssetDetails> AssetDetails { get; set; }
        public virtual DbSet<AssetHistory> AssetHistory { get; set; }
        public virtual DbSet<AssetType> AssetType { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Region> Region { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SIMIBABALOLA;Database=eTrackAppDb;user id=sa;password=@Similee355;Trusted_Connection=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetCondition>(entity =>
            {
                entity.ToTable("Asset_Condition");

                entity.Property(e => e.AssetConditionId)
                    .HasColumnName("Asset_Condition_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssetCondition1)
                    .HasColumnName("Asset_Condition")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<AssetDetails>(entity =>
            {
                entity.ToTable("Asset_Details");

                entity.Property(e => e.AssetDetailsId)
                    .HasColumnName("AssetDetailsID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalInformation)
                    .HasColumnName("Additional_Information")
                    .HasMaxLength(50);

                entity.Property(e => e.AssetActive).HasColumnName("Asset_Active");

                entity.Property(e => e.AssetConditionId).HasColumnName("Asset_Condition_ID");

                entity.Property(e => e.AssetModel)
                    .HasColumnName("Asset_Model")
                    .HasMaxLength(50);

                entity.Property(e => e.AssetOs)
                    .HasColumnName("Asset_OS")
                    .HasMaxLength(50);

                entity.Property(e => e.AssetSerialNumber)
                    .HasColumnName("Asset_Serial_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.AssetStatusId).HasColumnName("Asset_Status_ID");

                entity.Property(e => e.AssetTimeOfPurchase)
                    .HasColumnName("Asset_Time_of_Purchase")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssetTypeId).HasColumnName("Asset_Type_ID");

                entity.Property(e => e.AssetUniqueId)
                    .IsRequired()
                    .HasColumnName("Asset_UniqueID")
                    .HasMaxLength(50);

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.NameOfAssetUser)
                    .HasColumnName("Name_Of_Asset_User")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.AssetDetails)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Asset_Details_Department");
            });

            modelBuilder.Entity<AssetHistory>(entity =>
            {
                entity.ToTable("Asset_History");

                entity.Property(e => e.AssetHistoryId)
                    .HasColumnName("Asset_History_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssetHistoryAdditionalInformation)
                    .HasColumnName("Asset_History_Additional_Information")
                    .HasMaxLength(100);

                entity.Property(e => e.AssetHistoryAssetActive).HasColumnName("Asset_History_Asset_Active");

                entity.Property(e => e.AssetHistoryAssetOs)
                    .HasColumnName("Asset_History_Asset_OS")
                    .HasMaxLength(50);

                entity.Property(e => e.AssetHistoryAssetStatusId).HasColumnName("Asset_History_Asset_Status_ID");

                entity.Property(e => e.AssetHistoryConditionId).HasColumnName("Asset_History_Condition_ID");

                entity.Property(e => e.AssetHistoryDepartmentId).HasColumnName("Asset_History_Department_ID");

                entity.Property(e => e.AssetHistoryModel)
                    .HasColumnName("Asset_History_Model")
                    .HasMaxLength(50);

                entity.Property(e => e.AssetHistoryNameOfAssetUser)
                    .HasColumnName("Asset_History_Name_Of_Asset_User")
                    .HasMaxLength(50);

                entity.Property(e => e.AssetHistoryProductId).HasColumnName("Asset_History_Product_ID");

                entity.Property(e => e.AssetHistoryRegionId).HasColumnName("Asset_History_Region_ID");

                entity.Property(e => e.AssetHistorySerialNumber)
                    .HasColumnName("Asset_History_Serial_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.AssetHistoryTimeOfPurchase)
                    .HasColumnName("Asset_History_Time_of_Purchase")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssetHistoryTypeId).HasColumnName("Asset_History_Type_ID");

                entity.Property(e => e.AssetHistoryUniqueId)
                    .HasColumnName("Asset_History_Unique_ID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AssetType>(entity =>
            {
                entity.Property(e => e.AssetTypeId)
                    .HasColumnName("AssetTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssetCode)
                    .IsRequired()
                    .HasColumnName("Asset_Code")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.AssetName)
                    .HasColumnName("Asset_Name")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartmentCode)
                    .HasColumnName("Department_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("Department_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Department_Region");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId)
                    .HasColumnName("Product_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProductName)
                    .HasColumnName("Product_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RegionName)
                    .HasColumnName("Region_Name")
                    .HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
