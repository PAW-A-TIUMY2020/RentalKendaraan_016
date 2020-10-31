using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RentalKendaraan_016.Models
{
    public partial class RentalKendaraanContext : DbContext
    {
        public RentalKendaraanContext()
        {
        }

        public RentalKendaraanContext(DbContextOptions<RentalKendaraanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Jaminan> Jaminan { get; set; }
        public virtual DbSet<JenisKendaraan> Jenis_Kendaraan { get; set; }
        public virtual DbSet<Kendaraan> Kendaraan { get; set; }
        public virtual DbSet<KondisiKendaraan> Kondisi_Kendaraan { get; set; }
        public virtual DbSet<Peminjaman> Peminjaman { get; set; }
        public virtual DbSet<Pengembalian> Pengembalian { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.ID_Customer);

                entity.Property(e => e.ID_Customer)
                    .HasColumnName("ID_Customer")
                    .ValueGeneratedNever();

                entity.Property(e => e.Alamat)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ID_Gender).HasColumnName("ID_Gender");

                entity.Property(e => e.Nama_Customer)
                    .HasColumnName("Nama_Customer")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NIK)
                    .HasColumnName("NIK")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.No_Hp)
                    .HasColumnName("No_Hp")
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.ID_Gender);

                entity.Property(e => e.ID_Gender)
                    .HasColumnName("ID_Gender")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nama_Gender)
                    .HasColumnName("Nama_Gender")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Jaminan>(entity =>
            {
                entity.HasKey(e => e.ID_Jaminan);

                entity.Property(e => e.ID_Jaminan)
                    .HasColumnName("ID_Jaminan")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nama_Jaminan)
                    .HasColumnName("Nama_Jaminan")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JenisKendaraan>(entity =>
            {
                entity.HasKey(e => e.ID_Jenis_Kendaraan);

                entity.ToTable("Jenis_Kendaraan");

                entity.Property(e => e.ID_Jenis_Kendaraan)
                    .HasColumnName("ID_Jenis_Kendaraan")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nama_Jenis_Kendaraan)
                    .HasColumnName("Nama_Jenis_Kendaraan")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kendaraan>(entity =>
            {
                entity.HasKey(e => e.ID_Kendaraan);

                entity.Property(e => e.ID_Kendaraan)
                    .HasColumnName("ID_Kendaraan")
                    .ValueGeneratedNever();

                entity.Property(e => e.ID_Jenis_Kendaraan).HasColumnName("ID_Jenis_Kendaraan");

                entity.Property(e => e.Ketersediaan)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Nama_Kendaraan)
                    .HasColumnName("Nama_Kendaraan")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.No_Polisi)
                    .HasColumnName("No_Polisi")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.No_STNK)
                    .HasColumnName("No_STNK")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KondisiKendaraan>(entity =>
            {
                entity.HasKey(e => e.ID_Kondisi);

                entity.ToTable("Kondisi_Kendaraan");

                entity.Property(e => e.ID_Kondisi)
                    .HasColumnName("ID_Kondisi")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nama_Kondisi)
                    .HasColumnName("Nama_Kondisi")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Peminjaman>(entity =>
            {
                entity.HasKey(e => e.ID_Peminjaman);

                entity.Property(e => e.ID_Peminjaman)
                    .HasColumnName("ID_Peminjaman")
                    .ValueGeneratedNever();

                entity.Property(e => e.ID_Costumer).HasColumnName("ID_Costumer");

                entity.Property(e => e.ID_Jaminan).HasColumnName("ID_Jaminan");

                entity.Property(e => e.ID_Kendaraan).HasColumnName("ID_Kendaraan");

                entity.Property(e => e.Tgl_Peminjaman)
                    .HasColumnName("Tgl_Peminjaman")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Pengembalian>(entity =>
            {
                entity.HasKey(e => e.ID_Pengembalian);

                entity.Property(e => e.ID_Pengembalian)
                    .HasColumnName("ID_Pengembalian")
                    .ValueGeneratedNever();

                entity.Property(e => e.ID_Kondisi).HasColumnName("ID_Kondisi");

                entity.Property(e => e.ID_Peminjaman).HasColumnName("ID_Peminjaman");

                entity.Property(e => e.Tgl_Pengembalian)
                    .HasColumnName("Tgl_Pengembalian")
                    .HasColumnType("datetime");
            });
        }
    }
}
