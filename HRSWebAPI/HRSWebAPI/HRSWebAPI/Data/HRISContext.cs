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
        public virtual DbSet<CivilServiceEligibility> CivilServiceEligibilities { get; set; } = null!;
        public virtual DbSet<CivilStatus> CivilStatuses { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<DegreeCourse> DegreeCourses { get; set; } = null!;
        public virtual DbSet<EducationalAttainment> EducationalAttainments { get; set; } = null!;
        public virtual DbSet<EducationalBackground> EducationalBackgrounds { get; set; } = null!;
        public virtual DbSet<Eligibility> Eligibilities { get; set; } = null!;
        public virtual DbSet<EligibilityCategory> EligibilityCategories { get; set; } = null!;
        public virtual DbSet<EmploymentStatus> EmploymentStatuses { get; set; } = null!;
        public virtual DbSet<FamilyBackground> FamilyBackgrounds { get; set; } = null!;
        public virtual DbSet<PersonalInformation> PersonalInformations { get; set; } = null!;
        public virtual DbSet<PhilippineDirectory> PhilippineDirectories { get; set; } = null!;
        public virtual DbSet<Relationship> Relationships { get; set; } = null!;
        public virtual DbSet<SchoolTrainingInstitution> SchoolTrainingInstitutions { get; set; } = null!;
        public virtual DbSet<VoluntaryWork> VoluntaryWorks { get; set; } = null!;
        public virtual DbSet<WorkExperience> WorkExperiences { get; set; } = null!;

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

                entity.Property(e => e.IsDel).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CivilServiceEligibility>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__CivilSer__FBDF78C9A9495940");

                entity.ToTable("CivilServiceEligibility", "PDS");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.DateExamination).HasColumnType("date");

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.EligibilityId).HasColumnName("EligibilityID");

                entity.Property(e => e.LicenseNo).HasMaxLength(200);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PlaceExamination).HasMaxLength(200);

                entity.Property(e => e.Rating)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserStamp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ValidityDate).HasColumnType("date");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.CivilServiceEligibilities)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__CivilServ__Perso__59063A47");
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

                entity.HasIndex(e => e.EducationalAttainmentLevel, "UK_EducationalAttainmentLevel")
                    .IsUnique();

                entity.Property(e => e.EducationalAttainmentId).HasColumnName("EducationalAttainmentID");

                entity.Property(e => e.EducationalAttainmentLevel)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EducationalBackground>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__Educatio__FBDF78C92389DF5F");

                entity.ToTable("EducationalBackground", "PDS");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.AcademicHonorReceived)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.DegreeCourseId).HasColumnName("DegreeCourseID");

                entity.Property(e => e.EducationalAttainmentId).HasColumnName("EducationalAttainmentID");

                entity.Property(e => e.HighestLevelUnitsEarned).HasMaxLength(100);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.SchoolTrainingInstitutionId).HasColumnName("SchoolTrainingInstitutionID");

                entity.Property(e => e.UserStamp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.DegreeCourse)
                    .WithMany(p => p.EducationalBackgrounds)
                    .HasForeignKey(d => d.DegreeCourseId)
                    .HasConstraintName("FK__Education__Degre__4CA06362");

                entity.HasOne(d => d.EducationalAttainment)
                    .WithMany(p => p.EducationalBackgrounds)
                    .HasForeignKey(d => d.EducationalAttainmentId)
                    .HasConstraintName("FK__Education__Educa__4D94879B");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.EducationalBackgrounds)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Education__Perso__4E88ABD4");
            });

            modelBuilder.Entity<Eligibility>(entity =>
            {
                entity.ToTable("Eligibility", "FM");

                entity.HasIndex(e => e.EligibilityTitle, "UK_EligibilityTitle")
                    .IsUnique();

                entity.Property(e => e.EligibilityId).HasColumnName("EligibilityID");

                entity.Property(e => e.EligibilityCategoryId)
                    .HasColumnName("EligibilityCategoryID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EligibilityDescription)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsDel).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.EligibilityCategory)
                    .WithMany(p => p.Eligibilities)
                    .HasForeignKey(d => d.EligibilityCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Eligibili__Eligi__5EBF139D");
            });

            modelBuilder.Entity<EligibilityCategory>(entity =>
            {
                entity.ToTable("EligibilityCategory", "FM");

                entity.HasIndex(e => e.EligibilityCategoryName, "UK_EligibilityCategoryName")
                    .IsUnique();

                entity.Property(e => e.EligibilityCategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("EligibilityCategoryID");

                entity.Property(e => e.EligibilityCategoryDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityCategoryName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmploymentStatus>(entity =>
            {
                entity.ToTable("EmploymentStatus", "FM");

                entity.HasIndex(e => e.EmploymentStatusDesc, "EmploymentStatusDesc")
                    .IsUnique();

                entity.Property(e => e.EmploymentStatusId).HasColumnName("EmploymentStatusID");

                entity.Property(e => e.EmploymentStatusDesc)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FamilyBackground>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__FamilyBa__FBDF78C969C56734");

                entity.ToTable("FamilyBackground", "PDS");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.BusinessAddress).HasMaxLength(400);

                entity.Property(e => e.BusinessName).HasMaxLength(400);

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.UserStamp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.FamilyBackgrounds)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__FamilyBac__Perso__3D5E1FD2");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.FamilyBackgrounds)
                    .HasForeignKey(d => d.RelationshipId)
                    .HasConstraintName("FK__FamilyBac__Relat__3E52440B");
            });

            modelBuilder.Entity<PersonalInformation>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.ToTable("PersonalInformation", "PDS");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.AgencyEmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloodTypeId).HasColumnName("BloodTypeID");

                entity.Property(e => e.CivilStatusId).HasColumnName("CivilStatusID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CurrentCmid).HasColumnName("CurrentCMID");

                entity.Property(e => e.CurrentHouseBlkLotNo).HasMaxLength(200);

                entity.Property(e => e.CurrentStreet).HasMaxLength(100);

                entity.Property(e => e.CurrentSubdivisionVillage).HasMaxLength(200);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.ExtName).HasMaxLength(20);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Gsis)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GSIS");

                entity.Property(e => e.Height)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pagibig)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PAGIBIG");

                entity.Property(e => e.PermanentCmid).HasColumnName("PermanentCMID");

                entity.Property(e => e.PermanentHouseBlkLotNo).HasMaxLength(200);

                entity.Property(e => e.PermanentStreet).HasMaxLength(100);

                entity.Property(e => e.PermanentSubdivisionVillage).HasMaxLength(200);

                entity.Property(e => e.PersonalEmailAddress).HasMaxLength(300);

                entity.Property(e => e.Philhealth)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHILHEALTH");

                entity.Property(e => e.PlaceOfBirth).HasMaxLength(100);

                entity.Property(e => e.Sss)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SSS");

                entity.Property(e => e.TelephoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TIN");

                entity.Property(e => e.UserStamp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.BloodType)
                    .WithMany(p => p.PersonalInformations)
                    .HasForeignKey(d => d.BloodTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonalI__Blood__30F848ED");

                entity.HasOne(d => d.CivilStatus)
                    .WithMany(p => p.PersonalInformations)
                    .HasForeignKey(d => d.CivilStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonalI__Civil__31EC6D26");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PersonalInformations)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__PersonalI__Count__32E0915F");

                entity.HasOne(d => d.CurrentCm)
                    .WithMany(p => p.PersonalInformationCurrentCms)
                    .HasForeignKey(d => d.CurrentCmid)
                    .HasConstraintName("FK__PersonalI__Curre__33D4B598");

                entity.HasOne(d => d.PermanentCm)
                    .WithMany(p => p.PersonalInformationPermanentCms)
                    .HasForeignKey(d => d.PermanentCmid)
                    .HasConstraintName("FK__PersonalI__Perma__34C8D9D1");
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

            modelBuilder.Entity<VoluntaryWork>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__Voluntar__FBDF78C9E09F40CC");

                entity.ToTable("VoluntaryWork", "PDS");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.NatureOfWork).HasMaxLength(300);

                entity.Property(e => e.OrganizationName).HasMaxLength(300);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.UserStamp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.VoluntaryWorks)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Voluntary__Perso__6C190EBB");
            });

            modelBuilder.Entity<WorkExperience>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__WorkExpe__FBDF78C931C6AD49");

                entity.ToTable("WorkExperience", "PDS");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.CompanyName).HasMaxLength(300);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.EmploymentStatusId).HasColumnName("EmploymentStatusID");

                entity.Property(e => e.MonthlySalary)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PositionTitle).HasMaxLength(100);

                entity.Property(e => e.SalaryGrade).HasMaxLength(100);

                entity.Property(e => e.UserStamp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.EmploymentStatus)
                    .WithMany(p => p.WorkExperiences)
                    .HasForeignKey(d => d.EmploymentStatusId)
                    .HasConstraintName("FK__WorkExper__Emplo__6754599E");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.WorkExperiences)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__WorkExper__Perso__68487DD7");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
