using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class EducationalAttainment
    {
        public EducationalAttainment()
        {
            EducationalBackgrounds = new HashSet<EducationalBackground>();
        }

        public int EducationalAttainmentId { get; set; }
        public string EducationalAttainmentLevel { get; set; } = null!;
        public bool IsDel { get; set; }

        public virtual ICollection<EducationalBackground> EducationalBackgrounds { get; set; }
    }
}
