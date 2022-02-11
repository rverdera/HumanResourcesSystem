using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class CivilStatus
    {
        public CivilStatus()
        {
            PersonalInformations = new HashSet<PersonalInformation>();
        }

        public int CivilStatusID { get; set; }
        public string? CivilStatusDesc { get; set; }
        public bool? IsDel { get; set; }

        public virtual ICollection<PersonalInformation> PersonalInformations { get; set; }
    }
}
