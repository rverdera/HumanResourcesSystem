using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class PhilippineDirectory
    {
        public PhilippineDirectory()
        {
            PersonalInformationCurrentCMs = new HashSet<PersonalInformation>();
            PersonalInformationPermanentCMs = new HashSet<PersonalInformation>();
        }

        public int CMID { get; set; }
        public string Island { get; set; } = null!;
        public string Region { get; set; } = null!;
        public string Province { get; set; } = null!;
        public string CityMunicipality { get; set; } = null!;
        public string Barangay { get; set; } = null!;
        public int PostalCode { get; set; }
        public bool IsDel { get; set; }

        public virtual ICollection<PersonalInformation> PersonalInformationCurrentCMs { get; set; }
        public virtual ICollection<PersonalInformation> PersonalInformationPermanentCMs { get; set; }
    }
}
