using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeReviewApp.Src.Infraestructure.Context;

public partial class CmsPublisherContext : DbContext
{
    public CmsPublisherContext()
    {
    }

    public CmsPublisherContext(DbContextOptions<CmsPublisherContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AsignarPermiso> AsignarPermisos { get; set; }

    public virtual DbSet<Cuenta> Cuentas { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<TipoCuenta> TipoCuentas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost; TrustServerCertificate=True; Encrypt=false; User ID=sa;Password=Az19882009; Initial Catalog=CmsPublisher;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AsignarPermiso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AsignarPermiso", "Usuarios");

            entity.Property(e => e.ActualizarAsignar).HasColumnType("datetime");
            entity.Property(e => e.CrearAsignar).HasColumnType("datetime");
            entity.Property(e => e.InactivarAsignar).HasColumnType("datetime");

            entity.HasOne(d => d.IdCuentaNavigation).WithMany()
                .HasForeignKey(d => d.IdCuenta)
                .HasConstraintName("FK__AsignarPe__IdCue__619B8048");

            entity.HasOne(d => d.IdPermisoNavigation).WithMany()
                .HasForeignKey(d => d.IdPermiso)
                .HasConstraintName("FK__AsignarPe__IdPer__628FA481");
        });

        modelBuilder.Entity<Cuenta>(entity =>
        {
            entity.HasKey(e => e.IdCuenta).HasName("PK__Cuentas__D41FD706F54F6437");

            entity.ToTable("Cuentas", "Usuarios");

            entity.Property(e => e.IdCuenta).ValueGeneratedNever();
            entity.Property(e => e.ActualizarCuenta).HasColumnType("datetime");
            entity.Property(e => e.ContrasenaCuenta)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.CorreoCuenta)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CrearCuenta).HasColumnType("datetime");
            entity.Property(e => e.InactivarCuenta).HasColumnType("datetime");
            entity.Property(e => e.NombreCuenta)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("FK__Cuentas__IdEmple__5FB337D6");

            entity.HasOne(d => d.IdTipoCuentaNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.IdTipoCuenta)
                .HasConstraintName("FK__Cuentas__IdTipoC__5EBF139D");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK__Empleado__CE6D8B9E4E7AD045");

            entity.ToTable("Empleados", "Personas");

            entity.Property(e => e.IdEmpleado).ValueGeneratedNever();
            entity.Property(e => e.ActualizarEmpleado).HasColumnType("datetime");
            entity.Property(e => e.CrearEmpleado).HasColumnType("datetime");
            entity.Property(e => e.InactivarEmpleado).HasColumnType("datetime");
            entity.Property(e => e.MaternoEmpleado)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.NombreEmpleado)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PaternoEmpleado)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.IdPermiso).HasName("PK__Permisos__0D626EC8E6D38A5B");

            entity.ToTable("Permisos", "Usuarios");

            entity.Property(e => e.IdPermiso).ValueGeneratedNever();
            entity.Property(e => e.ActualizarPermiso).HasColumnType("datetime");
            entity.Property(e => e.CrearPermiso).HasColumnType("datetime");
            entity.Property(e => e.DescripcionPermiso).HasColumnType("text");
            entity.Property(e => e.InactivarPermisos).HasColumnType("datetime");
            entity.Property(e => e.NombrePermiso)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCuenta>(entity =>
        {
            entity.HasKey(e => e.IdTipoCuenta).HasName("PK__TipoCuen__9CCA285018BE48E3");

            entity.ToTable("TipoCuentas", "Usuarios");

            entity.Property(e => e.IdTipoCuenta).ValueGeneratedNever();
            entity.Property(e => e.ActualizarTipoCuenta).HasColumnType("datetime");
            entity.Property(e => e.CrearTipoCuenta).HasColumnType("datetime");
            entity.Property(e => e.InactivoTipoCuenta).HasColumnType("datetime");
            entity.Property(e => e.NombreTipoCuenta)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
