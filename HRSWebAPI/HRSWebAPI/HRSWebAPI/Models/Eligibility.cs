namespace HRSWebAPI.Models
{
    public partial class Eligibility
    {
        public Eligibility()
        {
            CivilServiceEligibilities = new HashSet<CivilServiceEligibility>();
        }

        public int EligibilityId { get; set; }
        public string EligibilityTitle { get; set; } = null!;
        public string? EligibilityDescription { get; set; }
        public bool IsDel { get; set; }
        public int EligibilityCategoryId { get; set; }

        public virtual EligibilityCategory EligibilityCategory { get; set; } = null!;
        public virtual ICollection<CivilServiceEligibility> CivilServiceEligibilities { get; set; }
    }
}
