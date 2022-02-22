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
        public virtual DbSet<LearningAndDevelopment> LearningAndDevelopments { get; set; } = null!;
        public virtual DbSet<LearningAndDevelopmentType> LearningAndDevelopmentTypes { get; set; } = null!;
        public virtual DbSet<OtherInformation> OtherInformations { get; set; } = null!;
        public virtual DbSet<OtherInformationQuestion> OtherInformationQuestions { get; set; } = null!;
        public virtual DbSet<PersonalInformation> PersonalInformations { get; set; } = null!;
        public virtual DbSet<PhilippineDirectory> PhilippineDirectories { get; set; } = null!;
        public virtual DbSet<Reference> References { get; set; } = null!;
        public virtual DbSet<Relationship> Relationships { get; set; } = null!;
        public virtual DbSet<SchoolTrainingInstitution> SchoolTrainingInstitutions { get; set; } = null!;
        public virtual DbSet<TrainingSeminarProgram> TrainingSeminarPrograms { get; set; } = null!;
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

                entity.HasIndex(e => e.BloodTypeId, "UK_BloodTypeDesc")
                    .IsUnique();

                entity.Property(e => e.BloodTypeId).HasColumnName("BloodTypeID");

                entity.Property(e => e.BloodTypeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CivilServiceEligibility>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__CivilServiceEligibilty_RecordID");

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

                entity.HasOne(d => d.Eligibility)
                    .WithMany(p => p.CivilServiceEligibilities)
                    .HasForeignKey(d => d.EligibilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CivilServiceEligibility_Eligibility");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.CivilServiceEligibilities)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CivilServiceEligibility_PersonalInformation");
            });

            modelBuilder.Entity<CivilStatus>(entity =>
            {
                entity.ToTable("CivilStatus", "FM");

                entity.HasIndex(e => e.CivilStatusId, "UK_CivilStatusDesc")
                    .IsUnique();

                entity.Property(e => e.CivilStatusId).HasColumnName("CivilStatusID");

                entity.Property(e => e.CivilStatusDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country", "FM");

                entity.HasIndex(e => e.CountryId, "UK_CountryDesc")
                    .IsUnique();

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);
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
                    .HasName("PK__EducationalBackground_RecordID");

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalBackground_DegreeCourse");

                entity.HasOne(d => d.EducationalAttainment)
                    .WithMany(p => p.EducationalBackgrounds)
                    .HasForeignKey(d => d.EducationalAttainmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalBackground_EducationalAttainment");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.EducationalBackgrounds)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalBackground_PersonalInformation");

                entity.HasOne(d => d.SchoolTrainingInstitution)
                    .WithMany(p => p.EducationalBackgrounds)
                    .HasForeignKey(d => d.SchoolTrainingInstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalBackground_SchoolTrainingInstitution");
            });

            modelBuilder.Entity<Eligibility>(entity =>
            {
                entity.ToTable("Eligibility", "FM");

                entity.HasIndex(e => e.EligibilityTitle, "UK_EligibilityTitle")
                    .IsUnique();

                entity.Property(e => e.EligibilityId).HasColumnName("EligibilityID");

                entity.Property(e => e.EligibilityCategoryId).HasColumnName("EligibilityCategoryID");

                entity.Property(e => e.EligibilityDescription)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.EligibilityCategory)
                    .WithMany(p => p.Eligibilities)
                    .HasForeignKey(d => d.EligibilityCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eligibility_EligibilityCategory");
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

                entity.HasIndex(e => e.EmploymentStatusDesc, "UK_EmploymentStatusDesc")
                    .IsUnique();

                entity.Property(e => e.EmploymentStatusId).HasColumnName("EmploymentStatusID");

                entity.Property(e => e.EmploymentStatusDesc)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FamilyBackground>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__FamilyBackground_RecordID");

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FamilyBackground_PersonalInformation");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.FamilyBackgrounds)
                    .HasForeignKey(d => d.RelationshipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FamilyBackground_Relationship");
            });

            modelBuilder.Entity<LearningAndDevelopment>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK_LearningAndDevelopment_RecordID");

                entity.ToTable("LearningAndDevelopment", "PDS");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.SchoolTrainingInstitutionId).HasColumnName("SchoolTrainingInstitutionID");

                entity.Property(e => e.TrainingSeminarProgramId).HasColumnName("TrainingSeminarProgramID");

                entity.Property(e => e.UserStamp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.LearningAndDevelopments)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LearningAndDevelopment_PersonalInformation");

                entity.HasOne(d => d.SchoolTrainingInstitution)
                    .WithMany(p => p.LearningAndDevelopments)
                    .HasForeignKey(d => d.SchoolTrainingInstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LearningAndDevelopment_SchoolTrainingInstitution");

                entity.HasOne(d => d.TrainingSeminarProgram)
                    .WithMany(p => p.LearningAndDevelopments)
                    .HasForeignKey(d => d.TrainingSeminarProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LearningAndDevelopment_TrainingSeminarProgram");
            });

            modelBuilder.Entity<LearningAndDevelopmentType>(entity =>
            {
                entity.ToTable("LearningAndDevelopmentType", "FM");

                entity.HasIndex(e => e.LearningAndDevelopmentTypeDesc, "UK_LearningAndDevelopmentTypeDesc")
                    .IsUnique();

                entity.Property(e => e.LearningAndDevelopmentTypeId).HasColumnName("LearningAndDevelopmentTypeID");

                entity.Property(e => e.LearningAndDevelopmentTypeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OtherInformation>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("OtherInformation", "PDS");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.UserStamp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.OtherInformations)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OtherInformation_PersonalInformation");
            });

            modelBuilder.Entity<OtherInformationQuestion>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("OtherInformation_Questions", "PDS");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.CandidateDetails)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.ConvictedDetails)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.CriminallyChargedDateFiled)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CriminallyChargedStatusCase)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.DateStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EthnicGroupId).HasColumnName("EthnicGroupID");

                entity.Property(e => e.FourthDegreeDetails)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.GuiltyAdministrativeOffenseDetails)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.ImmigrantDetails)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.IsPwd).HasColumnName("IsPWD");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Pwdno)
                    .HasMaxLength(100)
                    .HasColumnName("PWDNo")
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.ResignedFromGovernmentDetails)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.SeparatedInServiceDetails)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.SoloParentId)
                    .HasMaxLength(100)
                    .HasColumnName("SoloParentID")
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.UserStamp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.OtherInformationQuestions)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OtherInformation_Questions_PersonalInformation");
            });

            modelBuilder.Entity<PersonalInformation>(entity =>
            {
                entity.HasKey(e => e.PersonId)
                    .HasName("PK_PersonalInformation_PersonID");

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
                    .HasConstraintName("FK_PersonalInformation_BloodType");

                entity.HasOne(d => d.CivilStatus)
                    .WithMany(p => p.PersonalInformations)
                    .HasForeignKey(d => d.CivilStatusId)
                    .HasConstraintName("FK_PersonalInformation_CivilStatus");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PersonalInformations)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_PersonalInformation_Country");

                entity.HasOne(d => d.CurrentCm)
                    .WithMany(p => p.PersonalInformationCurrentCms)
                    .HasForeignKey(d => d.CurrentCmid);

                entity.HasOne(d => d.PermanentCm)
                    .WithMany(p => p.PersonalInformationPermanentCms)
                    .HasForeignKey(d => d.PermanentCmid);
            });

            modelBuilder.Entity<PhilippineDirectory>(entity =>
            {
                entity.HasKey(e => e.Cmid)
                    .HasName("PK_CMID");

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

            modelBuilder.Entity<Reference>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("Reference", "PDS");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.DateStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NameOfReference)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ReferenceAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TelNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserStamp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.References)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reference_PersonalInformation");
            });

            modelBuilder.Entity<Relationship>(entity =>
            {
                entity.ToTable("Relationship", "FM");

                entity.HasIndex(e => e.RelationshipDesc, "UK_RelationshipDesc")
                    .IsUnique();

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.RelationshipDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SchoolTrainingInstitution>(entity =>
            {
                entity.ToTable("SchoolTrainingInstitution", "FM");

                entity.HasIndex(e => e.SchoolTrainingInstitutionId, "UK_SchoolTrainingInstitutionName")
                    .IsUnique();

                entity.Property(e => e.SchoolTrainingInstitutionId).HasColumnName("SchoolTrainingInstitutionID");

                entity.Property(e => e.IsCscaccredited).HasColumnName("IsCSCAccredited");

                entity.Property(e => e.SchoolTrainingInstitutionAddress).HasMaxLength(500);

                entity.Property(e => e.SchoolTrainingInstitutionName).HasMaxLength(300);
            });

            modelBuilder.Entity<TrainingSeminarProgram>(entity =>
            {
                entity.ToTable("TrainingSeminarProgram", "FM");

                entity.HasIndex(e => e.TrainingSeminarProgramId, "UK_TrainingSeminarProgramTitle")
                    .IsUnique();

                entity.Property(e => e.TrainingSeminarProgramId).HasColumnName("TrainingSeminarProgramID");

                entity.Property(e => e.LearningAndDevelopmentTypeId).HasColumnName("LearningAndDevelopmentTypeID");

                entity.Property(e => e.TrainingSeminarProgramDesc).HasMaxLength(400);

                entity.Property(e => e.TrainingSeminarProgramTitle).HasMaxLength(400);

                entity.HasOne(d => d.LearningAndDevelopmentType)
                    .WithMany(p => p.TrainingSeminarPrograms)
                    .HasForeignKey(d => d.LearningAndDevelopmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingSeminarProgram_LearningAndDevelopmentType");
            });

            modelBuilder.Entity<VoluntaryWork>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__VoluntaryWork_RecordID");

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VoluntaryWork_PersonalInformation");
            });

            modelBuilder.Entity<WorkExperience>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__WorkExperience_RecordID");

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkExperience_EmploymentStatus");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.WorkExperiences)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_WorkExperience_PersonalInformation");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
