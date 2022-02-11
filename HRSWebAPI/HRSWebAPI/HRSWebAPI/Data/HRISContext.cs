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
        public virtual DbSet<DegreeCourse> DegreeCourses { get; set; } = null!;
        public virtual DbSet<EducationalAttainment> EducationalAttainments { get; set; } = null!;
        public virtual DbSet<Eligibility> Eligibilities { get; set; } = null!;
        public virtual DbSet<EmploymentStatus> EmploymentStatuses { get; set; } = null!;
        public virtual DbSet<PhilippineDirectory> PhilippineDirectories { get; set; } = null!;
        public virtual DbSet<Relationship> Relationships { get; set; } = null!;
        public virtual DbSet<SchoolTrainingInstitution> SchoolTrainingInstitutions { get; set; } = null!;
        public virtual DbSet<TrainingSeminarProgram> TrainingSeminarPrograms { get; set; } = null!;

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

                entity.Property(e => e.BloodTypeId).HasColumnName("BloodTypeID");

                entity.Property(e => e.BloodTypeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CivilStatus>(entity =>
            {
                entity.ToTable("CivilStatus", "FM");

                entity.Property(e => e.CivilStatusId).HasColumnName("CivilStatusID");

                entity.Property(e => e.CivilStatusDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDel).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country", "FM");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDel).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DegreeCourse>(entity =>
            {
                entity.ToTable("DegreeCourse", "FM");

                entity.HasIndex(e => e.Name, "UK_Name")
                    .IsUnique();

                entity.Property(e => e.DegreeCourseId).HasColumnName("DegreeCourseID");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EducationalAttainment>(entity =>
            {
                entity.ToTable("EducationalAttainment", "FM");

                entity.Property(e => e.EducationalAttainmentId).HasColumnName("EducationalAttainmentID");

                entity.Property(e => e.EducationalAttainmentLevel)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Eligibility>(entity =>
            {
                entity.ToTable("Eligibility", "FM");

                entity.Property(e => e.EligibilityId).HasColumnName("EligibilityID");

                entity.Property(e => e.EligibilityDescription)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsDel).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EmploymentStatus>(entity =>
            {
                entity.ToTable("EmploymentStatus", "FM");

                entity.Property(e => e.EmploymentStatusId).HasColumnName("EmploymentStatusID");

                entity.Property(e => e.EmploymentStatusDesc)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PhilippineDirectory>(entity =>
            {
                entity.HasKey(e => e.Cmid);

                entity.ToTable("PhilippineDirectory", "FM");

                entity.Property(e => e.Cmid).HasColumnName("CMID");

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

            modelBuilder.Entity<Relationship>(entity =>
            {
                entity.ToTable("Relationship", "FM");

                entity.HasIndex(e => e.RelationshipDesc, "UK_RelationshipDesc")
                    .IsUnique();

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.IsDel).HasDefaultValueSql("((0))");

                entity.Property(e => e.RelationshipDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SchoolTrainingInstitution>(entity =>
            {
                entity.ToTable("SchoolTrainingInstitution", "FM");

                entity.Property(e => e.SchoolTrainingInstitutionId).HasColumnName("SchoolTrainingInstitutionID");

                entity.Property(e => e.IsCscaccredited).HasColumnName("IsCSCAccredited");

                entity.Property(e => e.SchoolTrainingInstitutionAddress).HasMaxLength(500);

                entity.Property(e => e.SchoolTrainingInstitutionName).HasMaxLength(300);
            });

            modelBuilder.Entity<TrainingSeminarProgram>(entity =>
            {
                entity.ToTable("TrainingSeminarProgram", "FM");

                entity.Property(e => e.TrainingSeminarProgramId).HasColumnName("TrainingSeminarProgramID");

                entity.Property(e => e.TrainingSeminarProgramDesc).HasMaxLength(400);

                entity.Property(e => e.TrainingSeminarProgramTitle).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
