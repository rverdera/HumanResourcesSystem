namespace HRSWebAPI.Models
{
    public partial class OtherInformation
    {
        public int RecordId { get; set; }
        public int PersonId { get; set; }
        public string? SpecialSkills { get; set; }
        public string? Recognition { get; set; }
        public string? Organization { get; set; }
        public bool IsDel { get; set; }
        public string UserStamp { get; set; } = null!;
        public DateTime DateStamp { get; set; }

        public virtual PersonalInformation Person { get; set; } = null!;
    }
}
