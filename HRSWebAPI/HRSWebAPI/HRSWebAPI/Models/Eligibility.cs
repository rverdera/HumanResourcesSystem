using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class Eligibility
    {
        public int EligibilityId { get; set; }
        public string? EligibilityTitle { get; set; }
        public string? EligibilityDescription { get; set; }
        public bool? IsDel { get; set; }
    }
}
