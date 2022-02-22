using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class LearningAndDevelopmentType
    {
        public int LearningAndDevelopmentTypeId { get; set; }
        public string? LearningAndDevelopmentTypeDesc { get; set; }
        public bool? IsDel { get; set; }
    }
}
