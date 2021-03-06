namespace HRSWebAPI.Models
{
    public partial class CivilStatus
    {
        public CivilStatus()
        {
            PersonalInformations = new HashSet<PersonalInformation>();
        }

        public int CivilStatusId { get; set; }
        public string CivilStatusDesc { get; set; } = null!;
        public bool IsDel { get; set; }

        public virtual ICollection<PersonalInformation> PersonalInformations { get; set; }
    }
}
