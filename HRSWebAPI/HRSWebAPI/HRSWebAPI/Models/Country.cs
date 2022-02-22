using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class Country
    {
        public Country()
        {
            PersonalInformations = new HashSet<PersonalInformation>();
        }

        public int CountryId { get; set; }
        public string CountryDesc { get; set; } = null!;
        public bool IsDel { get; set; }

        public virtual ICollection<PersonalInformation> PersonalInformations { get; set; }
    }
}
