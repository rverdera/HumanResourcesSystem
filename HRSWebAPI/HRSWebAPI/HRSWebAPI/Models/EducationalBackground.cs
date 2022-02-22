using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class EducationalBackground
    {
        public int RecordId { get; set; }
        public int? PersonId { get; set; }
        public int? EducationalAttainmentId { get; set; }
        public int? SchoolTrainingInstitutionId { get; set; }
        public int? DegreeCourseId { get; set; }
        public int YearFrom { get; set; }
        public int YearTo { get; set; }
        public bool IsGraduated { get; set; }
        public string? HighestLevelUnitsEarned { get; set; }
        public int? YearGraduated { get; set; }
        public string? AcademicHonorReceived { get; set; }
        public bool IsDel { get; set; }
        public string UserStamp { get; set; } = null!;
        public DateTime DateStamp { get; set; }

        public virtual DegreeCourse? DegreeCourse { get; set; }
        public virtual EducationalAttainment? EducationalAttainment { get; set; }
        public virtual PersonalInformation? Person { get; set; }
    }
}
