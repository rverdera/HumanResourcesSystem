namespace HRSWebAPI.Models
{
    public partial class VoluntaryWork
    {
        public int RecordId { get; set; }
        public int PersonId { get; set; }
        public string? OrganizationName { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? NoOfHours { get; set; }
        public string? NatureOfWork { get; set; }
        public bool IsDel { get; set; }
        public string UserStamp { get; set; } = null!;
        public DateTime DateStamp { get; set; }

        public virtual PersonalInformation Person { get; set; } = null!;
    }
}
