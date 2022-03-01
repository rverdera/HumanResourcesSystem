namespace HRSWebAPI.Models
{
    public partial class PhilippineDirectory
    {
        public PhilippineDirectory()
        {
            PersonalInformationCurrentCms = new HashSet<PersonalInformation>();
            PersonalInformationPermanentCms = new HashSet<PersonalInformation>();
        }

        public int Cmid { get; set; }
        public string Island { get; set; } = null!;
        public string Region { get; set; } = null!;
        public string Province { get; set; } = null!;
        public string CityMunicipality { get; set; } = null!;
        public string Barangay { get; set; } = null!;
        public int PostalCode { get; set; }
        public bool IsDel { get; set; }

        public virtual ICollection<PersonalInformation> PersonalInformationCurrentCms { get; set; }
        public virtual ICollection<PersonalInformation> PersonalInformationPermanentCms { get; set; }
    }
}
