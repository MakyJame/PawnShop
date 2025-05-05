using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DraftAboutReserveEngineer.Helpers;
using Microsoft.Extensions.Configuration;

namespace DraftAboutReserveEngineer.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=DraftAboutReverseEngineer;Trusted_Connection=True;TrustServerCertificate=True;");

        //=> optionsBuilder.UseSqlServer(
        //    "Your_Connnection_String",
        //    options => options.EnableRetryOnFailure());

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    var config = ConfigurationHelper.GetConfiguration();
    //    var connectionString = config.GetConnectionString("DefaultConnection");

    //    optionsBuilder.UseSqlServer(connectionString);
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asset>(entity =>
        {
            entity.HasKey(e => e.VehicleNumber).HasName("PK__Assets__ABAD8858FF66D958");

            entity.Property(e => e.VehicleNumber).HasMaxLength(50);
            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.StorageLocation).HasMaxLength(10);
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AuditLog__3214EC077F77FDFE");
            entity.Property(e => e.UserId);
            entity.Property(e => e.Action).HasMaxLength(150);
            entity.Property(e => e.DateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PK__Users__536C85E5ECC7EA33");

            entity.Property(e => e.Username).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Role).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
