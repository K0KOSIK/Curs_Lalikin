using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Curs_Lalikin.Models;

public partial class Ispr2525LalykinAdConstructionContext : DbContext
{
    public Ispr2525LalykinAdConstructionContext()
    {
    }

    public Ispr2525LalykinAdConstructionContext(DbContextOptions<Ispr2525LalykinAdConstructionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectMaterial> ProjectMaterials { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=cfif31.ru;database=ISPr25-25_LalykinAD_construction;uid=ISPr25-25_LalykinAD;pwd=ISPr25-25_LalykinAD", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.42-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.IdCategories).HasName("PRIMARY");

            entity.Property(e => e.IdCategories).HasColumnName("idCategories");
            entity.Property(e => e.CategoriesName).HasMaxLength(45);
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.MaterialId).HasName("PRIMARY");

            entity.ToTable("materials");

            entity.HasIndex(e => e.CategoriesIdCategories, "fk_materials_Categories1_idx");

            entity.HasIndex(e => e.MaterialName, "material_name").IsUnique();

            entity.Property(e => e.MaterialId).HasColumnName("material_id");
            entity.Property(e => e.CategoriesIdCategories).HasColumnName("Categories_idCategories");
            entity.Property(e => e.MaterialName)
                .HasMaxLength(100)
                .HasColumnName("material_name");
            entity.Property(e => e.UnitOfMeasure)
                .HasMaxLength(20)
                .HasColumnName("unit_of_measure");
            entity.Property(e => e.UnitPrice)
                .HasPrecision(10, 2)
                .HasColumnName("unit_price");

            entity.HasOne(d => d.CategoriesIdCategoriesNavigation).WithMany(p => p.Materials)
                .HasForeignKey(d => d.CategoriesIdCategories)
                .HasConstraintName("fk_materials_Categories1");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("PRIMARY");

            entity.ToTable("projects");

            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.Budget)
                .HasPrecision(15, 2)
                .HasColumnName("budget");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(100)
                .HasColumnName("project_name");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasColumnType("enum('Планирование','В процессе','Завершено','На удержании')")
                .HasColumnName("status");
        });

        modelBuilder.Entity<ProjectMaterial>(entity =>
        {
            entity.HasKey(e => new { e.ProjectId, e.MaterialId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("project_materials");

            entity.HasIndex(e => e.MaterialId, "material_id");

            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.MaterialId).HasColumnName("material_id");
            entity.Property(e => e.Quantity)
                .HasPrecision(10, 2)
                .HasColumnName("quantity");

            entity.HasOne(d => d.Material).WithMany(p => p.ProjectMaterials)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("project_materials_ibfk_2");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectMaterials)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("project_materials_ibfk_1");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("PRIMARY");

            entity.ToTable("Role");

            entity.Property(e => e.IdRole).HasColumnName("idRole");
            entity.Property(e => e.NameRole)
                .HasMaxLength(45)
                .HasColumnName("name role");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Iduser).HasName("PRIMARY");

            entity.Property(e => e.Iduser).HasColumnName("IDuser");
            entity.Property(e => e.Login).HasMaxLength(45);
            entity.Property(e => e.Password).HasMaxLength(45);
            entity.Property(e => e.Role).HasColumnType("enum('Администратор','Пользователь')");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
