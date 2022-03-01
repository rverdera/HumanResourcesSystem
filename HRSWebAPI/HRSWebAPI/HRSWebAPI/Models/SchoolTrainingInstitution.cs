namespace HRSWebAPI.Models
{
    public partial class SchoolTrainingInstitution
    {
        public SchoolTrainingInstitution()
        {
            EducationalBackgrounds = new HashSet<EducationalBackground>();
            LearningAndDevelopments = new HashSet<LearningAndDevelopment>();
        }

        public int SchoolTrainingInstitutionId { get; set; }
        public string SchoolTrainingInstitutionName { get; set; } = null!;
        public string? SchoolTrainingInstitutionAddress { get; set; }
        public bool IsSchoolFacility { get; set; }
        public bool IsTrainingFacility { get; set; }
        public bool IsCscaccredited { get; set; }
        public bool IsDel { get; set; }

        public virtual ICollection<EducationalBackground> EducationalBackgrounds { get; set; }
        public virtual ICollection<LearningAndDevelopment> LearningAndDevelopments { get; set; }
    }
}
