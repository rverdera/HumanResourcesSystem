namespace HRSWebAPI.Models
{
    public partial class CivilServiceEligibility
    {
        public int RecordId { get; set; }
        public int PersonId { get; set; }
        public int EligibilityId { get; set; }
        public string? Rating { get; set; }
        public DateTime? DateExamination { get; set; }
        public string? PlaceExamination { get; set; }
        public string? LicenseNo { get; set; }
        public DateTime? ValidityDate { get; set; }
        public bool IsDel { get; set; }
        public string UserStamp { get; set; } = null!;
        public DateTime DateStamp { get; set; }

        public virtual Eligibility Eligibility { get; set; } = null!;
        public virtual PersonalInformation Person { get; set; } = null!;
    }
}
