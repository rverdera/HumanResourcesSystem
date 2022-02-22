using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class EligibilityCategory
    {
        public EligibilityCategory()
        {
            Eligibilities = new HashSet<Eligibility>();
        }

        public int EligibilityCategoryId { get; set; }
        public string EligibilityCategoryName { get; set; } = null!;
        public string? EligibilityCategoryDesc { get; set; }
        public bool? IsDel { get; set; }

        public virtual ICollection<Eligibility> Eligibilities { get; set; }
    }
}
