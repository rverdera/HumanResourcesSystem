using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class EducationalAttainment
    {
        public int EducationalAttainmentId { get; set; }
        public string EducationalAttainmentLevel { get; set; } = null!;
        public bool IsDel { get; set; }
    }
}
