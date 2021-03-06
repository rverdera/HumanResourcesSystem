USE [HRIS]
GO
ALTER TABLE [PDS].[WorkExperience] DROP CONSTRAINT [FK_WorkExperience_PersonalInformation]
GO
ALTER TABLE [PDS].[WorkExperience] DROP CONSTRAINT [FK_WorkExperience_EmploymentStatus]
GO
ALTER TABLE [PDS].[VoluntaryWork] DROP CONSTRAINT [FK_VoluntaryWork_PersonalInformation]
GO
ALTER TABLE [PDS].[Reference] DROP CONSTRAINT [FK_Reference_PersonalInformation]
GO
ALTER TABLE [PDS].[PersonalInformation] DROP CONSTRAINT [FK_PersonalInformation_PhilippineDirectory_PermanentCMID]
GO
ALTER TABLE [PDS].[PersonalInformation] DROP CONSTRAINT [FK_PersonalInformation_PhilippineDirectory_CurrentCMID]
GO
ALTER TABLE [PDS].[PersonalInformation] DROP CONSTRAINT [FK_PersonalInformation_Country]
GO
ALTER TABLE [PDS].[PersonalInformation] DROP CONSTRAINT [FK_PersonalInformation_CivilStatus]
GO
ALTER TABLE [PDS].[PersonalInformation] DROP CONSTRAINT [FK_PersonalInformation_BloodType]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [FK_OtherInformation_Questions_PersonalInformation]
GO
ALTER TABLE [PDS].[OtherInformation] DROP CONSTRAINT [FK_OtherInformation_PersonalInformation]
GO
ALTER TABLE [PDS].[LearningAndDevelopment] DROP CONSTRAINT [FK_LearningAndDevelopment_TrainingSeminarProgram]
GO
ALTER TABLE [PDS].[LearningAndDevelopment] DROP CONSTRAINT [FK_LearningAndDevelopment_SchoolTrainingInstitution]
GO
ALTER TABLE [PDS].[LearningAndDevelopment] DROP CONSTRAINT [FK_LearningAndDevelopment_PersonalInformation]
GO
ALTER TABLE [PDS].[FamilyBackground] DROP CONSTRAINT [FK_FamilyBackground_Relationship]
GO
ALTER TABLE [PDS].[FamilyBackground] DROP CONSTRAINT [FK_FamilyBackground_PersonalInformation]
GO
ALTER TABLE [PDS].[EducationalBackground] DROP CONSTRAINT [FK_EducationalBackground_SchoolTrainingInstitution]
GO
ALTER TABLE [PDS].[EducationalBackground] DROP CONSTRAINT [FK_EducationalBackground_PersonalInformation]
GO
ALTER TABLE [PDS].[EducationalBackground] DROP CONSTRAINT [FK_EducationalBackground_EducationalAttainment]
GO
ALTER TABLE [PDS].[EducationalBackground] DROP CONSTRAINT [FK_EducationalBackground_DegreeCourse]
GO
ALTER TABLE [PDS].[CivilServiceEligibility] DROP CONSTRAINT [FK_CivilServiceEligibility_PersonalInformation]
GO
ALTER TABLE [PDS].[CivilServiceEligibility] DROP CONSTRAINT [FK_CivilServiceEligibility_Eligibility]
GO
ALTER TABLE [FM].[TrainingSeminarProgram] DROP CONSTRAINT [FK_TrainingSeminarProgram_LearningAndDevelopmentType]
GO
ALTER TABLE [FM].[Eligibility] DROP CONSTRAINT [FK_Eligibility_EligibilityCategory]
GO
ALTER TABLE [PDS].[WorkExperience] DROP CONSTRAINT [DF__WorkExperience_IsDel]
GO
ALTER TABLE [PDS].[WorkExperience] DROP CONSTRAINT [DF__WorkExperience_IsGovernementService]
GO
ALTER TABLE [PDS].[VoluntaryWork] DROP CONSTRAINT [DF__VoluntaryWork__IsDel]
GO
ALTER TABLE [PDS].[Reference] DROP CONSTRAINT [DF_Reference_DateStamp]
GO
ALTER TABLE [PDS].[Reference] DROP CONSTRAINT [DF_Reference_IsDel]
GO
ALTER TABLE [PDS].[PersonalInformation] DROP CONSTRAINT [DF_PersonalInformation_IsDel]
GO
ALTER TABLE [PDS].[PersonalInformation] DROP CONSTRAINT [DF_PersonalInformation_IsFilipinoOrDualCitizen]
GO
ALTER TABLE [PDS].[PersonalInformation] DROP CONSTRAINT [DF_PersonalInformation_Sex]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_DateStamp]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_IsDel]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_SoloParentID]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_IsSoloParent]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_PWDNo]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_IsPWD]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_EthnicGroupID]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_IsIndigenous]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_ImmigrantDetails]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_IsImmigrant]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_ResignedFromGovernmentDetails]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_IsResignedFromGovernment]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_CandidateDetails]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_IsCandidate]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_SeparatedInServiceDetails]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_IsSeparatedInService]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_ConvictedDetails]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_IsConvicted]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_CriminallyChargedStatusCase]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_CriminallyChargedDateFiled]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_IsCriminallyCharged]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_GuiltyAdministrativeOffenseDetails]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_IsGuiltyAdministrativeOffense]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_FourthDegreeDetails]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_IsWithinFourthDegree]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] DROP CONSTRAINT [DF_OtherInformation_Questions_IsWithinThirdDegree]
GO
ALTER TABLE [PDS].[OtherInformation] DROP CONSTRAINT [DF_OtherInformation_IsDel]
GO
ALTER TABLE [PDS].[LearningAndDevelopment] DROP CONSTRAINT [DF_LearningAndDevelopment_IsDel]
GO
ALTER TABLE [PDS].[FamilyBackground] DROP CONSTRAINT [DF__FamilyBackground__IsDel]
GO
ALTER TABLE [PDS].[FamilyBackground] DROP CONSTRAINT [DF__FamilyBackground__IsDependent]
GO
ALTER TABLE [PDS].[EducationalBackground] DROP CONSTRAINT [DF__EducationalBackground__IsDel]
GO
ALTER TABLE [PDS].[EducationalBackground] DROP CONSTRAINT [DF__EducationalBackgroud__IsGraduated]
GO
ALTER TABLE [PDS].[CivilServiceEligibility] DROP CONSTRAINT [DF__CivilServiceEligibilty__IsDel]
GO
ALTER TABLE [FM].[TrainingSeminarProgram] DROP CONSTRAINT [DF_TrainingSeminarProgram_IsDel]
GO
ALTER TABLE [FM].[SchoolTrainingInstitution] DROP CONSTRAINT [DF_SchoolTrainingInstitution_IsDel]
GO
ALTER TABLE [FM].[SchoolTrainingInstitution] DROP CONSTRAINT [DF_SchoolTrainingInstitution_IsCSCAccredited]
GO
ALTER TABLE [FM].[SchoolTrainingInstitution] DROP CONSTRAINT [DF_SchoolTrainingInstitution_IsTrainingFacility]
GO
ALTER TABLE [FM].[SchoolTrainingInstitution] DROP CONSTRAINT [DF_SchoolTrainingInstitution_IsSchoolFacility]
GO
ALTER TABLE [FM].[Relationship] DROP CONSTRAINT [DF_Relationship_IsDel]
GO
ALTER TABLE [FM].[PhilippineDirectory] DROP CONSTRAINT [DF_PhilippineDirectory_IsDel]
GO
ALTER TABLE [FM].[PhilippineDirectory] DROP CONSTRAINT [DF_PhilippineDirectory_PostalCode]
GO
ALTER TABLE [FM].[LearningAndDevelopmentType] DROP CONSTRAINT [DF_LearningAndDevelopmentType_IsDel]
GO
ALTER TABLE [FM].[EmploymentStatus] DROP CONSTRAINT [DF_EmploymentStatus_IsDel]
GO
ALTER TABLE [FM].[EligibilityCategory] DROP CONSTRAINT [DF_EligibilityCategory_IsDel]
GO
ALTER TABLE [FM].[Eligibility] DROP CONSTRAINT [DF_Eligibility_IsDel]
GO
ALTER TABLE [FM].[EducationalAttainment] DROP CONSTRAINT [DF_EducationalAttainment_IsDel]
GO
ALTER TABLE [FM].[DegreeCourse] DROP CONSTRAINT [DF_DegreeCourse_IsDel]
GO
ALTER TABLE [FM].[Country] DROP CONSTRAINT [DF__Country__IsDel]
GO
ALTER TABLE [FM].[CivilStatus] DROP CONSTRAINT [DF__CivilStatus__IsDel]
GO
ALTER TABLE [FM].[BloodType] DROP CONSTRAINT [DF__BloodType__IsDel__2C3393D0]
GO
/****** Object:  Table [PDS].[WorkExperience]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[PDS].[WorkExperience]') AND type in (N'U'))
DROP TABLE [PDS].[WorkExperience]
GO
/****** Object:  Table [PDS].[VoluntaryWork]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[PDS].[VoluntaryWork]') AND type in (N'U'))
DROP TABLE [PDS].[VoluntaryWork]
GO
/****** Object:  Table [PDS].[Reference]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[PDS].[Reference]') AND type in (N'U'))
DROP TABLE [PDS].[Reference]
GO
/****** Object:  Table [PDS].[PersonalInformation]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[PDS].[PersonalInformation]') AND type in (N'U'))
DROP TABLE [PDS].[PersonalInformation]
GO
/****** Object:  Table [PDS].[OtherInformation_Questions]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[PDS].[OtherInformation_Questions]') AND type in (N'U'))
DROP TABLE [PDS].[OtherInformation_Questions]
GO
/****** Object:  Table [PDS].[OtherInformation]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[PDS].[OtherInformation]') AND type in (N'U'))
DROP TABLE [PDS].[OtherInformation]
GO
/****** Object:  Table [PDS].[LearningAndDevelopment]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[PDS].[LearningAndDevelopment]') AND type in (N'U'))
DROP TABLE [PDS].[LearningAndDevelopment]
GO
/****** Object:  Table [PDS].[FamilyBackground]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[PDS].[FamilyBackground]') AND type in (N'U'))
DROP TABLE [PDS].[FamilyBackground]
GO
/****** Object:  Table [PDS].[EducationalBackground]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[PDS].[EducationalBackground]') AND type in (N'U'))
DROP TABLE [PDS].[EducationalBackground]
GO
/****** Object:  Table [PDS].[CivilServiceEligibility]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[PDS].[CivilServiceEligibility]') AND type in (N'U'))
DROP TABLE [PDS].[CivilServiceEligibility]
GO
/****** Object:  Table [FM].[TrainingSeminarProgram]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[FM].[TrainingSeminarProgram]') AND type in (N'U'))
DROP TABLE [FM].[TrainingSeminarProgram]
GO
/****** Object:  Table [FM].[SchoolTrainingInstitution]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[FM].[SchoolTrainingInstitution]') AND type in (N'U'))
DROP TABLE [FM].[SchoolTrainingInstitution]
GO
/****** Object:  Table [FM].[Relationship]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[FM].[Relationship]') AND type in (N'U'))
DROP TABLE [FM].[Relationship]
GO
/****** Object:  Table [FM].[PhilippineDirectory]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[FM].[PhilippineDirectory]') AND type in (N'U'))
DROP TABLE [FM].[PhilippineDirectory]
GO
/****** Object:  Table [FM].[LearningAndDevelopmentType]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[FM].[LearningAndDevelopmentType]') AND type in (N'U'))
DROP TABLE [FM].[LearningAndDevelopmentType]
GO
/****** Object:  Table [FM].[EmploymentStatus]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[FM].[EmploymentStatus]') AND type in (N'U'))
DROP TABLE [FM].[EmploymentStatus]
GO
/****** Object:  Table [FM].[EligibilityCategory]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[FM].[EligibilityCategory]') AND type in (N'U'))
DROP TABLE [FM].[EligibilityCategory]
GO
/****** Object:  Table [FM].[Eligibility]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[FM].[Eligibility]') AND type in (N'U'))
DROP TABLE [FM].[Eligibility]
GO
/****** Object:  Table [FM].[EducationalAttainment]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[FM].[EducationalAttainment]') AND type in (N'U'))
DROP TABLE [FM].[EducationalAttainment]
GO
/****** Object:  Table [FM].[DegreeCourse]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[FM].[DegreeCourse]') AND type in (N'U'))
DROP TABLE [FM].[DegreeCourse]
GO
/****** Object:  Table [FM].[Country]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[FM].[Country]') AND type in (N'U'))
DROP TABLE [FM].[Country]
GO
/****** Object:  Table [FM].[CivilStatus]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[FM].[CivilStatus]') AND type in (N'U'))
DROP TABLE [FM].[CivilStatus]
GO
/****** Object:  Table [FM].[BloodType]    Script Date: 2/22/2022 4:17:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[FM].[BloodType]') AND type in (N'U'))
DROP TABLE [FM].[BloodType]
GO
/****** Object:  Schema [PDS]    Script Date: 2/22/2022 4:17:28 PM ******/
DROP SCHEMA [PDS]
GO
/****** Object:  Schema [FM]    Script Date: 2/22/2022 4:17:28 PM ******/
DROP SCHEMA [FM]
GO
USE [master]
GO
/****** Object:  Database [HRIS]    Script Date: 2/22/2022 4:17:28 PM ******/
DROP DATABASE [HRIS]
GO
/****** Object:  Database [HRIS]    Script Date: 2/22/2022 4:17:28 PM ******/
CREATE DATABASE [HRIS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HRIS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HRIS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HRIS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HRIS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HRIS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HRIS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HRIS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HRIS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HRIS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HRIS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HRIS] SET ARITHABORT OFF 
GO
ALTER DATABASE [HRIS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HRIS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HRIS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HRIS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HRIS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HRIS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HRIS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HRIS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HRIS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HRIS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HRIS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HRIS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HRIS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HRIS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HRIS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HRIS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HRIS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HRIS] SET RECOVERY FULL 
GO
ALTER DATABASE [HRIS] SET  MULTI_USER 
GO
ALTER DATABASE [HRIS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HRIS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HRIS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HRIS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HRIS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HRIS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HRIS', N'ON'
GO
ALTER DATABASE [HRIS] SET QUERY_STORE = OFF
GO
USE [HRIS]
GO
/****** Object:  Schema [FM]    Script Date: 2/22/2022 4:17:28 PM ******/
CREATE SCHEMA [FM]
GO
/****** Object:  Schema [PDS]    Script Date: 2/22/2022 4:17:28 PM ******/
CREATE SCHEMA [PDS]
GO
/****** Object:  Table [FM].[BloodType]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FM].[BloodType](
	[BloodTypeID] [int] IDENTITY(1,1) NOT NULL,
	[BloodTypeDesc] [varchar](100) NOT NULL,
	[IsDel] [bit] NOT NULL,
 CONSTRAINT [PK_BloodTypeID] PRIMARY KEY CLUSTERED 
(
	[BloodTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_BloodTypeDesc] UNIQUE NONCLUSTERED 
(
	[BloodTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [FM].[CivilStatus]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FM].[CivilStatus](
	[CivilStatusID] [int] IDENTITY(1,1) NOT NULL,
	[CivilStatusDesc] [varchar](100) NOT NULL,
	[IsDel] [bit] NOT NULL,
 CONSTRAINT [PK__CivilStatusID] PRIMARY KEY CLUSTERED 
(
	[CivilStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_CivilStatusDesc] UNIQUE NONCLUSTERED 
(
	[CivilStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [FM].[Country]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FM].[Country](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[CountryDesc] [varchar](100) NOT NULL,
	[IsDel] [bit] NOT NULL,
 CONSTRAINT [PK__CountryID] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_CountryDesc] UNIQUE NONCLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [FM].[DegreeCourse]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FM].[DegreeCourse](
	[DegreeCourseID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[IsDel] [bit] NOT NULL,
 CONSTRAINT [PK_CourseID] PRIMARY KEY CLUSTERED 
(
	[DegreeCourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [FM].[EducationalAttainment]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FM].[EducationalAttainment](
	[EducationalAttainmentID] [int] IDENTITY(1,1) NOT NULL,
	[EducationalAttainmentLevel] [varchar](200) NOT NULL,
	[IsDel] [bit] NOT NULL,
 CONSTRAINT [PK_EducationalAttainmentID] PRIMARY KEY CLUSTERED 
(
	[EducationalAttainmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_EducationalAttainmentLevel] UNIQUE NONCLUSTERED 
(
	[EducationalAttainmentLevel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [FM].[Eligibility]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FM].[Eligibility](
	[EligibilityID] [int] IDENTITY(1,1) NOT NULL,
	[EligibilityTitle] [varchar](200) NOT NULL,
	[EligibilityDescription] [varchar](400) NULL,
	[IsDel] [bit] NOT NULL,
	[EligibilityCategoryID] [int] NOT NULL,
 CONSTRAINT [PK_EligibilityID] PRIMARY KEY CLUSTERED 
(
	[EligibilityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_EligibilityTitle] UNIQUE NONCLUSTERED 
(
	[EligibilityTitle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [FM].[EligibilityCategory]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FM].[EligibilityCategory](
	[EligibilityCategoryID] [int] NOT NULL,
	[EligibilityCategoryName] [varchar](20) NOT NULL,
	[EligibilityCategoryDesc] [varchar](200) NULL,
	[IsDel] [bit] NOT NULL,
 CONSTRAINT [PK_EligibilityCategoryID] PRIMARY KEY CLUSTERED 
(
	[EligibilityCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_EligibilityCategoryName] UNIQUE NONCLUSTERED 
(
	[EligibilityCategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [FM].[EmploymentStatus]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FM].[EmploymentStatus](
	[EmploymentStatusID] [int] IDENTITY(1,1) NOT NULL,
	[EmploymentStatusDesc] [varchar](80) NOT NULL,
	[IsDel] [bit] NOT NULL,
 CONSTRAINT [PK_EmploymentStatusID] PRIMARY KEY CLUSTERED 
(
	[EmploymentStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_EmploymentStatusDesc] UNIQUE NONCLUSTERED 
(
	[EmploymentStatusDesc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [FM].[LearningAndDevelopmentType]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FM].[LearningAndDevelopmentType](
	[LearningAndDevelopmentTypeID] [int] IDENTITY(1,1) NOT NULL,
	[LearningAndDevelopmentTypeDesc] [varchar](100) NOT NULL,
	[IsDel] [bit] NOT NULL,
 CONSTRAINT [PK_LearningAndDevelopmentTypeID] PRIMARY KEY CLUSTERED 
(
	[LearningAndDevelopmentTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_LearningAndDevelopmentTypeDesc] UNIQUE NONCLUSTERED 
(
	[LearningAndDevelopmentTypeDesc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [FM].[PhilippineDirectory]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FM].[PhilippineDirectory](
	[CMID] [int] IDENTITY(1,1) NOT NULL,
	[Island] [varchar](60) NOT NULL,
	[Region] [varchar](60) NOT NULL,
	[Province] [varchar](60) NOT NULL,
	[CityMunicipality] [nvarchar](200) NOT NULL,
	[Barangay] [nvarchar](200) NOT NULL,
	[PostalCode] [int] NOT NULL,
	[IsDel] [bit] NOT NULL,
 CONSTRAINT [PK_CMID] PRIMARY KEY CLUSTERED 
(
	[CMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [FM].[Relationship]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FM].[Relationship](
	[RelationshipID] [int] IDENTITY(1,1) NOT NULL,
	[RelationshipDesc] [varchar](100) NOT NULL,
	[IsDel] [bit] NOT NULL,
 CONSTRAINT [PK_RelationshipID] PRIMARY KEY CLUSTERED 
(
	[RelationshipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_RelationshipDesc] UNIQUE NONCLUSTERED 
(
	[RelationshipDesc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [FM].[SchoolTrainingInstitution]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FM].[SchoolTrainingInstitution](
	[SchoolTrainingInstitutionID] [int] IDENTITY(1,1) NOT NULL,
	[SchoolTrainingInstitutionName] [nvarchar](300) NOT NULL,
	[SchoolTrainingInstitutionAddress] [nvarchar](500) NULL,
	[IsSchoolFacility] [bit] NOT NULL,
	[IsTrainingFacility] [bit] NOT NULL,
	[IsCSCAccredited] [bit] NOT NULL,
	[IsDel] [bit] NOT NULL,
 CONSTRAINT [PK__SchoolTrainingInstitutionID] PRIMARY KEY CLUSTERED 
(
	[SchoolTrainingInstitutionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_SchoolTrainingInstitutionName] UNIQUE NONCLUSTERED 
(
	[SchoolTrainingInstitutionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [FM].[TrainingSeminarProgram]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FM].[TrainingSeminarProgram](
	[TrainingSeminarProgramID] [int] IDENTITY(1,1) NOT NULL,
	[TrainingSeminarProgramTitle] [nvarchar](400) NOT NULL,
	[TrainingSeminarProgramDesc] [nvarchar](400) NULL,
	[LearningAndDevelopmentTypeID] [int] NOT NULL,
	[IsDel] [bit] NOT NULL,
 CONSTRAINT [PK_TrainingSeminarProgramID] PRIMARY KEY CLUSTERED 
(
	[TrainingSeminarProgramID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_TrainingSeminarProgramTitle] UNIQUE NONCLUSTERED 
(
	[TrainingSeminarProgramID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [PDS].[CivilServiceEligibility]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PDS].[CivilServiceEligibility](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[EligibilityID] [int] NOT NULL,
	[Rating] [varchar](50) NULL,
	[DateExamination] [date] NULL,
	[PlaceExamination] [nvarchar](200) NULL,
	[LicenseNo] [nvarchar](200) NULL,
	[ValidityDate] [date] NULL,
	[IsDel] [bit] NOT NULL,
	[UserStamp] [varchar](25) NOT NULL,
	[DateStamp] [datetime] NOT NULL,
 CONSTRAINT [PK__CivilServiceEligibilty_RecordID] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [PDS].[EducationalBackground]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PDS].[EducationalBackground](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[EducationalAttainmentID] [int] NOT NULL,
	[SchoolTrainingInstitutionID] [int] NOT NULL,
	[DegreeCourseID] [int] NOT NULL,
	[YearFrom] [int] NOT NULL,
	[YearTo] [int] NOT NULL,
	[IsGraduated] [bit] NOT NULL,
	[HighestLevelUnitsEarned] [nvarchar](100) NULL,
	[YearGraduated] [int] NULL,
	[AcademicHonorReceived] [varchar](400) NULL,
	[IsDel] [bit] NOT NULL,
	[UserStamp] [varchar](25) NOT NULL,
	[DateStamp] [datetime] NOT NULL,
 CONSTRAINT [PK__EducationalBackground_RecordID] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [PDS].[FamilyBackground]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PDS].[FamilyBackground](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[RelationshipID] [int] NOT NULL,
	[Occupation] [varchar](200) NULL,
	[BusinessName] [nvarchar](400) NULL,
	[BusinessAddress] [nvarchar](400) NULL,
	[IsDependent] [bit] NOT NULL,
	[IsDel] [bit] NOT NULL,
	[UserStamp] [varchar](25) NOT NULL,
	[DateStamp] [datetime] NOT NULL,
 CONSTRAINT [PK__FamilyBackground_RecordID] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [PDS].[LearningAndDevelopment]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PDS].[LearningAndDevelopment](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[TrainingSeminarProgramID] [int] NOT NULL,
	[DateFrom] [date] NULL,
	[DateTo] [date] NULL,
	[NoOfHours] [int] NULL,
	[SchoolTrainingInstitutionID] [int] NOT NULL,
	[IsDel] [bit] NOT NULL,
	[UserStamp] [varchar](25) NOT NULL,
	[DateStamp] [datetime] NOT NULL,
 CONSTRAINT [PK_LearningAndDevelopment_RecordID] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [PDS].[OtherInformation]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PDS].[OtherInformation](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[SpecialSkills] [nvarchar](max) NULL,
	[Recognition] [nvarchar](max) NULL,
	[Organization] [nvarchar](max) NULL,
	[IsDel] [bit] NOT NULL,
	[UserStamp] [varchar](25) NOT NULL,
	[DateStamp] [datetime] NOT NULL,
 CONSTRAINT [PK_OtherInformation] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [PDS].[OtherInformation_Questions]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PDS].[OtherInformation_Questions](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[IsWithinThirdDegree] [bit] NOT NULL,
	[IsWithinFourthDegree] [bit] NOT NULL,
	[FourthDegreeDetails] [nvarchar](100) NOT NULL,
	[IsGuiltyAdministrativeOffense] [bit] NOT NULL,
	[GuiltyAdministrativeOffenseDetails] [nvarchar](100) NOT NULL,
	[IsCriminallyCharged] [bit] NOT NULL,
	[CriminallyChargedDateFiled] [date] NOT NULL,
	[CriminallyChargedStatusCase] [nvarchar](100) NOT NULL,
	[IsConvicted] [bit] NOT NULL,
	[ConvictedDetails] [nvarchar](100) NOT NULL,
	[IsSeparatedInService] [bit] NOT NULL,
	[SeparatedInServiceDetails] [nvarchar](100) NOT NULL,
	[IsCandidate] [bit] NOT NULL,
	[CandidateDetails] [nvarchar](100) NOT NULL,
	[IsResignedFromGovernment] [bit] NOT NULL,
	[ResignedFromGovernmentDetails] [nvarchar](100) NOT NULL,
	[IsImmigrant] [bit] NOT NULL,
	[ImmigrantDetails] [nvarchar](100) NOT NULL,
	[IsIndigenous] [bit] NOT NULL,
	[EthnicGroupID] [int] NOT NULL,
	[IsPWD] [bit] NOT NULL,
	[PWDNo] [nvarchar](100) NOT NULL,
	[IsSoloParent] [bit] NOT NULL,
	[SoloParentID] [nvarchar](100) NOT NULL,
	[IsDel] [bit] NOT NULL,
	[UserStamp] [varchar](25) NOT NULL,
	[DateStamp] [datetime] NOT NULL,
 CONSTRAINT [PK_OtherInformation_Questions] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [PDS].[PersonalInformation]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PDS].[PersonalInformation](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[ExtName] [nvarchar](20) NULL,
	[DateOfBirth] [date] NULL,
	[PlaceOfBirth] [nvarchar](100) NULL,
	[Sex] [bit] NOT NULL,
	[CivilStatusID] [int] NULL,
	[Height] [varchar](20) NULL,
	[Weight] [varchar](20) NULL,
	[BloodTypeID] [int] NULL,
	[GSIS] [varchar](20) NULL,
	[PAGIBIG] [varchar](20) NULL,
	[PHILHEALTH] [varchar](20) NULL,
	[SSS] [varchar](20) NULL,
	[TIN] [varchar](20) NULL,
	[AgencyEmployeeNo] [varchar](50) NULL,
	[IsFilipinoOrDualCitizen] [bit] NOT NULL,
	[IsDualCitizenByBirthOrByNaturalization] [bit] NULL,
	[CountryID] [int] NULL,
	[CurrentHouseBlkLotNo] [nvarchar](200) NULL,
	[CurrentStreet] [nvarchar](100) NULL,
	[CurrentSubdivisionVillage] [nvarchar](200) NULL,
	[CurrentCMID] [int] NULL,
	[PermanentHouseBlkLotNo] [nvarchar](200) NULL,
	[PermanentStreet] [nvarchar](100) NULL,
	[PermanentSubdivisionVillage] [nvarchar](200) NULL,
	[PermanentCMID] [int] NULL,
	[TelephoneNo] [varchar](20) NULL,
	[MobilePhone] [varchar](20) NULL,
	[PersonalEmailAddress] [nvarchar](300) NULL,
	[IsDel] [bit] NOT NULL,
	[UserStamp] [varchar](25) NOT NULL,
	[DateStamp] [datetime] NOT NULL,
 CONSTRAINT [PK_PersonalInformation_PersonID] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [PDS].[Reference]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PDS].[Reference](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[NameOfReference] [varchar](200) NOT NULL,
	[ReferenceAddress] [varchar](200) NOT NULL,
	[TelNo] [varchar](20) NOT NULL,
	[IsDel] [bit] NOT NULL,
	[UserStamp] [varchar](25) NOT NULL,
	[DateStamp] [datetime] NOT NULL,
 CONSTRAINT [PK_Reference] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [PDS].[VoluntaryWork]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PDS].[VoluntaryWork](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[OrganizationName] [nvarchar](300) NULL,
	[DateFrom] [date] NULL,
	[DateTo] [date] NULL,
	[NoOfHours] [int] NULL,
	[NatureOfWork] [nvarchar](300) NULL,
	[IsDel] [bit] NOT NULL,
	[UserStamp] [varchar](25) NOT NULL,
	[DateStamp] [datetime] NOT NULL,
 CONSTRAINT [PK__VoluntaryWork_RecordID] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [PDS].[WorkExperience]    Script Date: 2/22/2022 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PDS].[WorkExperience](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NULL,
	[DateFrom] [date] NULL,
	[DateTo] [date] NULL,
	[PositionTitle] [nvarchar](100) NULL,
	[CompanyName] [nvarchar](300) NULL,
	[MonthlySalary] [varchar](50) NULL,
	[SalaryGrade] [nvarchar](100) NULL,
	[EmploymentStatusID] [int] NOT NULL,
	[IsGovernmentService] [bit] NOT NULL,
	[IsDel] [bit] NOT NULL,
	[UserStamp] [varchar](25) NOT NULL,
	[DateStamp] [datetime] NOT NULL,
 CONSTRAINT [PK__WorkExperience_RecordID] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [FM].[BloodType] ADD  CONSTRAINT [DF__BloodType__IsDel__2C3393D0]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [FM].[CivilStatus] ADD  CONSTRAINT [DF__CivilStatus__IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [FM].[Country] ADD  CONSTRAINT [DF__Country__IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [FM].[DegreeCourse] ADD  CONSTRAINT [DF_DegreeCourse_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [FM].[EducationalAttainment] ADD  CONSTRAINT [DF_EducationalAttainment_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [FM].[Eligibility] ADD  CONSTRAINT [DF_Eligibility_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [FM].[EligibilityCategory] ADD  CONSTRAINT [DF_EligibilityCategory_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [FM].[EmploymentStatus] ADD  CONSTRAINT [DF_EmploymentStatus_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [FM].[LearningAndDevelopmentType] ADD  CONSTRAINT [DF_LearningAndDevelopmentType_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [FM].[PhilippineDirectory] ADD  CONSTRAINT [DF_PhilippineDirectory_PostalCode]  DEFAULT ((0)) FOR [PostalCode]
GO
ALTER TABLE [FM].[PhilippineDirectory] ADD  CONSTRAINT [DF_PhilippineDirectory_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [FM].[Relationship] ADD  CONSTRAINT [DF_Relationship_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [FM].[SchoolTrainingInstitution] ADD  CONSTRAINT [DF_SchoolTrainingInstitution_IsSchoolFacility]  DEFAULT ((0)) FOR [IsSchoolFacility]
GO
ALTER TABLE [FM].[SchoolTrainingInstitution] ADD  CONSTRAINT [DF_SchoolTrainingInstitution_IsTrainingFacility]  DEFAULT ((0)) FOR [IsTrainingFacility]
GO
ALTER TABLE [FM].[SchoolTrainingInstitution] ADD  CONSTRAINT [DF_SchoolTrainingInstitution_IsCSCAccredited]  DEFAULT ((0)) FOR [IsCSCAccredited]
GO
ALTER TABLE [FM].[SchoolTrainingInstitution] ADD  CONSTRAINT [DF_SchoolTrainingInstitution_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [FM].[TrainingSeminarProgram] ADD  CONSTRAINT [DF_TrainingSeminarProgram_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [PDS].[CivilServiceEligibility] ADD  CONSTRAINT [DF__CivilServiceEligibilty__IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [PDS].[EducationalBackground] ADD  CONSTRAINT [DF__EducationalBackgroud__IsGraduated]  DEFAULT ((0)) FOR [IsGraduated]
GO
ALTER TABLE [PDS].[EducationalBackground] ADD  CONSTRAINT [DF__EducationalBackground__IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [PDS].[FamilyBackground] ADD  CONSTRAINT [DF__FamilyBackground__IsDependent]  DEFAULT ((0)) FOR [IsDependent]
GO
ALTER TABLE [PDS].[FamilyBackground] ADD  CONSTRAINT [DF__FamilyBackground__IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [PDS].[LearningAndDevelopment] ADD  CONSTRAINT [DF_LearningAndDevelopment_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [PDS].[OtherInformation] ADD  CONSTRAINT [DF_OtherInformation_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_IsWithinThirdDegree]  DEFAULT ((0)) FOR [IsWithinThirdDegree]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_IsWithinFourthDegree]  DEFAULT ((0)) FOR [IsWithinFourthDegree]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_FourthDegreeDetails]  DEFAULT ('N/A') FOR [FourthDegreeDetails]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_IsGuiltyAdministrativeOffense]  DEFAULT ((0)) FOR [IsGuiltyAdministrativeOffense]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_GuiltyAdministrativeOffenseDetails]  DEFAULT ('N/A') FOR [GuiltyAdministrativeOffenseDetails]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_IsCriminallyCharged]  DEFAULT ((0)) FOR [IsCriminallyCharged]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_CriminallyChargedDateFiled]  DEFAULT (getdate()) FOR [CriminallyChargedDateFiled]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_CriminallyChargedStatusCase]  DEFAULT ('N/A') FOR [CriminallyChargedStatusCase]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_IsConvicted]  DEFAULT ((0)) FOR [IsConvicted]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_ConvictedDetails]  DEFAULT ('N/A') FOR [ConvictedDetails]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_IsSeparatedInService]  DEFAULT ((0)) FOR [IsSeparatedInService]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_SeparatedInServiceDetails]  DEFAULT ('N/A') FOR [SeparatedInServiceDetails]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_IsCandidate]  DEFAULT ((0)) FOR [IsCandidate]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_CandidateDetails]  DEFAULT ('N/A') FOR [CandidateDetails]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_IsResignedFromGovernment]  DEFAULT ((0)) FOR [IsResignedFromGovernment]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_ResignedFromGovernmentDetails]  DEFAULT ('N/A') FOR [ResignedFromGovernmentDetails]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_IsImmigrant]  DEFAULT ((0)) FOR [IsImmigrant]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_ImmigrantDetails]  DEFAULT ('N/A') FOR [ImmigrantDetails]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_IsIndigenous]  DEFAULT ((0)) FOR [IsIndigenous]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_EthnicGroupID]  DEFAULT ((0)) FOR [EthnicGroupID]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_IsPWD]  DEFAULT ((0)) FOR [IsPWD]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_PWDNo]  DEFAULT ('N/A') FOR [PWDNo]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_IsSoloParent]  DEFAULT ((0)) FOR [IsSoloParent]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_SoloParentID]  DEFAULT ('N/A') FOR [SoloParentID]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [PDS].[OtherInformation_Questions] ADD  CONSTRAINT [DF_OtherInformation_Questions_DateStamp]  DEFAULT (getdate()) FOR [DateStamp]
GO
ALTER TABLE [PDS].[PersonalInformation] ADD  CONSTRAINT [DF_PersonalInformation_Sex]  DEFAULT ((0)) FOR [Sex]
GO
ALTER TABLE [PDS].[PersonalInformation] ADD  CONSTRAINT [DF_PersonalInformation_IsFilipinoOrDualCitizen]  DEFAULT ((0)) FOR [IsFilipinoOrDualCitizen]
GO
ALTER TABLE [PDS].[PersonalInformation] ADD  CONSTRAINT [DF_PersonalInformation_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [PDS].[Reference] ADD  CONSTRAINT [DF_Reference_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [PDS].[Reference] ADD  CONSTRAINT [DF_Reference_DateStamp]  DEFAULT (getdate()) FOR [DateStamp]
GO
ALTER TABLE [PDS].[VoluntaryWork] ADD  CONSTRAINT [DF__VoluntaryWork__IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [PDS].[WorkExperience] ADD  CONSTRAINT [DF__WorkExperience_IsGovernementService]  DEFAULT ((0)) FOR [IsGovernmentService]
GO
ALTER TABLE [PDS].[WorkExperience] ADD  CONSTRAINT [DF__WorkExperience_IsDel]  DEFAULT ((0)) FOR [IsDel]
GO
ALTER TABLE [FM].[Eligibility]  WITH CHECK ADD  CONSTRAINT [FK_Eligibility_EligibilityCategory] FOREIGN KEY([EligibilityCategoryID])
REFERENCES [FM].[EligibilityCategory] ([EligibilityCategoryID])
GO
ALTER TABLE [FM].[Eligibility] CHECK CONSTRAINT [FK_Eligibility_EligibilityCategory]
GO
ALTER TABLE [FM].[TrainingSeminarProgram]  WITH CHECK ADD  CONSTRAINT [FK_TrainingSeminarProgram_LearningAndDevelopmentType] FOREIGN KEY([LearningAndDevelopmentTypeID])
REFERENCES [FM].[LearningAndDevelopmentType] ([LearningAndDevelopmentTypeID])
GO
ALTER TABLE [FM].[TrainingSeminarProgram] CHECK CONSTRAINT [FK_TrainingSeminarProgram_LearningAndDevelopmentType]
GO
ALTER TABLE [PDS].[CivilServiceEligibility]  WITH CHECK ADD  CONSTRAINT [FK_CivilServiceEligibility_Eligibility] FOREIGN KEY([EligibilityID])
REFERENCES [FM].[Eligibility] ([EligibilityID])
GO
ALTER TABLE [PDS].[CivilServiceEligibility] CHECK CONSTRAINT [FK_CivilServiceEligibility_Eligibility]
GO
ALTER TABLE [PDS].[CivilServiceEligibility]  WITH CHECK ADD  CONSTRAINT [FK_CivilServiceEligibility_PersonalInformation] FOREIGN KEY([PersonID])
REFERENCES [PDS].[PersonalInformation] ([PersonID])
GO
ALTER TABLE [PDS].[CivilServiceEligibility] CHECK CONSTRAINT [FK_CivilServiceEligibility_PersonalInformation]
GO
ALTER TABLE [PDS].[EducationalBackground]  WITH CHECK ADD  CONSTRAINT [FK_EducationalBackground_DegreeCourse] FOREIGN KEY([DegreeCourseID])
REFERENCES [FM].[DegreeCourse] ([DegreeCourseID])
GO
ALTER TABLE [PDS].[EducationalBackground] CHECK CONSTRAINT [FK_EducationalBackground_DegreeCourse]
GO
ALTER TABLE [PDS].[EducationalBackground]  WITH CHECK ADD  CONSTRAINT [FK_EducationalBackground_EducationalAttainment] FOREIGN KEY([EducationalAttainmentID])
REFERENCES [FM].[EducationalAttainment] ([EducationalAttainmentID])
GO
ALTER TABLE [PDS].[EducationalBackground] CHECK CONSTRAINT [FK_EducationalBackground_EducationalAttainment]
GO
ALTER TABLE [PDS].[EducationalBackground]  WITH CHECK ADD  CONSTRAINT [FK_EducationalBackground_PersonalInformation] FOREIGN KEY([PersonID])
REFERENCES [PDS].[PersonalInformation] ([PersonID])
GO
ALTER TABLE [PDS].[EducationalBackground] CHECK CONSTRAINT [FK_EducationalBackground_PersonalInformation]
GO
ALTER TABLE [PDS].[EducationalBackground]  WITH CHECK ADD  CONSTRAINT [FK_EducationalBackground_SchoolTrainingInstitution] FOREIGN KEY([SchoolTrainingInstitutionID])
REFERENCES [FM].[SchoolTrainingInstitution] ([SchoolTrainingInstitutionID])
GO
ALTER TABLE [PDS].[EducationalBackground] CHECK CONSTRAINT [FK_EducationalBackground_SchoolTrainingInstitution]
GO
ALTER TABLE [PDS].[FamilyBackground]  WITH CHECK ADD  CONSTRAINT [FK_FamilyBackground_PersonalInformation] FOREIGN KEY([PersonID])
REFERENCES [PDS].[PersonalInformation] ([PersonID])
GO
ALTER TABLE [PDS].[FamilyBackground] CHECK CONSTRAINT [FK_FamilyBackground_PersonalInformation]
GO
ALTER TABLE [PDS].[FamilyBackground]  WITH CHECK ADD  CONSTRAINT [FK_FamilyBackground_Relationship] FOREIGN KEY([RelationshipID])
REFERENCES [FM].[Relationship] ([RelationshipID])
GO
ALTER TABLE [PDS].[FamilyBackground] CHECK CONSTRAINT [FK_FamilyBackground_Relationship]
GO
ALTER TABLE [PDS].[LearningAndDevelopment]  WITH CHECK ADD  CONSTRAINT [FK_LearningAndDevelopment_PersonalInformation] FOREIGN KEY([PersonID])
REFERENCES [PDS].[PersonalInformation] ([PersonID])
GO
ALTER TABLE [PDS].[LearningAndDevelopment] CHECK CONSTRAINT [FK_LearningAndDevelopment_PersonalInformation]
GO
ALTER TABLE [PDS].[LearningAndDevelopment]  WITH CHECK ADD  CONSTRAINT [FK_LearningAndDevelopment_SchoolTrainingInstitution] FOREIGN KEY([SchoolTrainingInstitutionID])
REFERENCES [FM].[SchoolTrainingInstitution] ([SchoolTrainingInstitutionID])
GO
ALTER TABLE [PDS].[LearningAndDevelopment] CHECK CONSTRAINT [FK_LearningAndDevelopment_SchoolTrainingInstitution]
GO
ALTER TABLE [PDS].[LearningAndDevelopment]  WITH CHECK ADD  CONSTRAINT [FK_LearningAndDevelopment_TrainingSeminarProgram] FOREIGN KEY([TrainingSeminarProgramID])
REFERENCES [FM].[TrainingSeminarProgram] ([TrainingSeminarProgramID])
GO
ALTER TABLE [PDS].[LearningAndDevelopment] CHECK CONSTRAINT [FK_LearningAndDevelopment_TrainingSeminarProgram]
GO
ALTER TABLE [PDS].[OtherInformation]  WITH CHECK ADD  CONSTRAINT [FK_OtherInformation_PersonalInformation] FOREIGN KEY([PersonID])
REFERENCES [PDS].[PersonalInformation] ([PersonID])
GO
ALTER TABLE [PDS].[OtherInformation] CHECK CONSTRAINT [FK_OtherInformation_PersonalInformation]
GO
ALTER TABLE [PDS].[OtherInformation_Questions]  WITH CHECK ADD  CONSTRAINT [FK_OtherInformation_Questions_PersonalInformation] FOREIGN KEY([PersonID])
REFERENCES [PDS].[PersonalInformation] ([PersonID])
GO
ALTER TABLE [PDS].[OtherInformation_Questions] CHECK CONSTRAINT [FK_OtherInformation_Questions_PersonalInformation]
GO
ALTER TABLE [PDS].[PersonalInformation]  WITH CHECK ADD  CONSTRAINT [FK_PersonalInformation_BloodType] FOREIGN KEY([BloodTypeID])
REFERENCES [FM].[BloodType] ([BloodTypeID])
GO
ALTER TABLE [PDS].[PersonalInformation] CHECK CONSTRAINT [FK_PersonalInformation_BloodType]
GO
ALTER TABLE [PDS].[PersonalInformation]  WITH CHECK ADD  CONSTRAINT [FK_PersonalInformation_CivilStatus] FOREIGN KEY([CivilStatusID])
REFERENCES [FM].[CivilStatus] ([CivilStatusID])
GO
ALTER TABLE [PDS].[PersonalInformation] CHECK CONSTRAINT [FK_PersonalInformation_CivilStatus]
GO
ALTER TABLE [PDS].[PersonalInformation]  WITH CHECK ADD  CONSTRAINT [FK_PersonalInformation_Country] FOREIGN KEY([CountryID])
REFERENCES [FM].[Country] ([CountryID])
GO
ALTER TABLE [PDS].[PersonalInformation] CHECK CONSTRAINT [FK_PersonalInformation_Country]
GO
ALTER TABLE [PDS].[PersonalInformation]  WITH CHECK ADD  CONSTRAINT [FK_PersonalInformation_PhilippineDirectory_CurrentCMID] FOREIGN KEY([CurrentCMID])
REFERENCES [FM].[PhilippineDirectory] ([CMID])
GO
ALTER TABLE [PDS].[PersonalInformation] CHECK CONSTRAINT [FK_PersonalInformation_PhilippineDirectory_CurrentCMID]
GO
ALTER TABLE [PDS].[PersonalInformation]  WITH CHECK ADD  CONSTRAINT [FK_PersonalInformation_PhilippineDirectory_PermanentCMID] FOREIGN KEY([PermanentCMID])
REFERENCES [FM].[PhilippineDirectory] ([CMID])
GO
ALTER TABLE [PDS].[PersonalInformation] CHECK CONSTRAINT [FK_PersonalInformation_PhilippineDirectory_PermanentCMID]
GO
ALTER TABLE [PDS].[Reference]  WITH CHECK ADD  CONSTRAINT [FK_Reference_PersonalInformation] FOREIGN KEY([PersonID])
REFERENCES [PDS].[PersonalInformation] ([PersonID])
GO
ALTER TABLE [PDS].[Reference] CHECK CONSTRAINT [FK_Reference_PersonalInformation]
GO
ALTER TABLE [PDS].[VoluntaryWork]  WITH CHECK ADD  CONSTRAINT [FK_VoluntaryWork_PersonalInformation] FOREIGN KEY([PersonID])
REFERENCES [PDS].[PersonalInformation] ([PersonID])
GO
ALTER TABLE [PDS].[VoluntaryWork] CHECK CONSTRAINT [FK_VoluntaryWork_PersonalInformation]
GO
ALTER TABLE [PDS].[WorkExperience]  WITH CHECK ADD  CONSTRAINT [FK_WorkExperience_EmploymentStatus] FOREIGN KEY([EmploymentStatusID])
REFERENCES [FM].[EmploymentStatus] ([EmploymentStatusID])
GO
ALTER TABLE [PDS].[WorkExperience] CHECK CONSTRAINT [FK_WorkExperience_EmploymentStatus]
GO
ALTER TABLE [PDS].[WorkExperience]  WITH CHECK ADD  CONSTRAINT [FK_WorkExperience_PersonalInformation] FOREIGN KEY([PersonID])
REFERENCES [PDS].[PersonalInformation] ([PersonID])
GO
ALTER TABLE [PDS].[WorkExperience] CHECK CONSTRAINT [FK_WorkExperience_PersonalInformation]
GO
USE [master]
GO
ALTER DATABASE [HRIS] SET  READ_WRITE 
GO
