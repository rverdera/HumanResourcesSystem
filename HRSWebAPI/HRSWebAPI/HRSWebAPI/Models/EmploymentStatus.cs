namespace HRSWebAPI.Models
{
    public partial class EmploymentStatus
    {
        public EmploymentStatus()
        {
            WorkExperiences = new HashSet<WorkExperience>();
        }

        public int EmploymentStatusId { get; set; }
        public string EmploymentStatusDesc { get; set; } = null!;
        public bool IsDel { get; set; }

        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
    }
}
