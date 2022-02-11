using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class BloodType
    {
        public BloodType()
        {
            PersonalInformations = new HashSet<PersonalInformation>();
        }

        public int BloodTypeID { get; set; }
        public string? BloodTypeDesc { get; set; }
        public bool? IsDel { get; set; }

        public virtual ICollection<PersonalInformation> PersonalInformations { get; set; }
    }
}
