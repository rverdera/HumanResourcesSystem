namespace HRSWebAPI.Models
{
    public partial class WorkExperience
    {
        public int RecordId { get; set; }
        public int? PersonId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string? PositionTitle { get; set; }
        public string? CompanyName { get; set; }
        public string? MonthlySalary { get; set; }
        public string? SalaryGrade { get; set; }
        public int EmploymentStatusId { get; set; }
        public bool IsGovernmentService { get; set; }
        public bool IsDel { get; set; }
        public string UserStamp { get; set; } = null!;
        public DateTime DateStamp { get; set; }

        public virtual EmploymentStatus EmploymentStatus { get; set; } = null!;
        public virtual PersonalInformation? Person { get; set; }
    }
}
