using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HRSWebAPI.Models;

namespace HRSWebAPI.Data
{
    public partial class HRISContext : DbContext
    {
        public HRISContext()
        {
        }

        public HRISContext(DbContextOptions<HRISContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BloodType> BloodTypes { get; set; } = null!;
        public virtual DbSet<CivilStatus> CivilStatuses { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<PersonalInformation> PersonalInformations { get; set; } = null!;
        public virtual DbSet<PhilippineDirectory> PhilippineDirectories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=HRIS");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BloodType>(entity =>
            {
                entity.ToTable("BloodType", "FM");

                entity.Property(e => e.BloodTypeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDel).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CivilStatus>(entity =>
            {
                entity.ToTable("CivilStatus", "FM");

                entity.Property(e => e.CivilStatusDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDel).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country", "FM");

                entity.Property(e => e.CountryDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDel).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PersonalInformation>(entity =>
            {
                entity.HasKey(e => e.PersonID);

                entity.ToTable("PersonalInformation", "PDS");

                entity.Property(e => e.AgencyEmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentHouseBlkLotNo).HasMaxLength(200);

                entity.Property(e => e.CurrentStreet).HasMaxLength(100);

                entity.Property(e => e.CurrentSubdivisionVillage).HasMaxLength(200);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.ExtName).HasMaxLength(20);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.GSIS)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Height)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PAGIBIG)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PHILHEALTH)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentHouseBlkLotNo).HasMaxLength(200);

                entity.Property(e => e.PermanentStreet).HasMaxLength(100);

                entity.Property(e => e.PermanentSubdivisionVillage).HasMaxLength(200);

                entity.Property(e => e.PersonalEmailAddress).HasMaxLength(300);

                entity.Property(e => e.PlaceOfBirth).HasMaxLength(100);

                entity.Property(e => e.SSS)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TIN)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserStamp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.BloodType)
                    .WithMany(p => p.PersonalInformations)
                    .HasForeignKey(d => d.BloodTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonalI__Blood__2D27B809");

                entity.HasOne(d => d.CivilStatus)
                    .WithMany(p => p.PersonalInformations)
                    .HasForeignKey(d => d.CivilStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonalI__Civil__29572725");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PersonalInformations)
                    .HasForeignKey(d => d.CountryID)
                    .HasConstraintName("FK__PersonalI__Count__30F848ED");

                entity.HasOne(d => d.CurrentCM)
                    .WithMany(p => p.PersonalInformationCurrentCMs)
                    .HasForeignKey(d => d.CurrentCMID)
                    .HasConstraintName("FK__PersonalI__Curre__35BCFE0A");

                entity.HasOne(d => d.PermanentCM)
                    .WithMany(p => p.PersonalInformationPermanentCMs)
                    .HasForeignKey(d => d.PermanentCMID)
                    .HasConstraintName("FK__PersonalI__Perma__36B12243");
            });

            modelBuilder.Entity<PhilippineDirectory>(entity =>
            {
                entity.HasKey(e => e.CMID);

                entity.ToTable("PhilippineDirectory", "FM");

                entity.Property(e => e.Barangay).HasMaxLength(200);

                entity.Property(e => e.CityMunicipality).HasMaxLength(200);

                entity.Property(e => e.Island)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
