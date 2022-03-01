namespace HRSWebAPI.Models
{
    public partial class BloodType
    {
        public BloodType()
        {
            PersonalInformations = new HashSet<PersonalInformation>();
        }

        public int BloodTypeId { get; set; }
        public string BloodTypeDesc { get; set; } = null!;
        public bool IsDel { get; set; }

        public virtual ICollection<PersonalInformation> PersonalInformations { get; set; }
    }
}
