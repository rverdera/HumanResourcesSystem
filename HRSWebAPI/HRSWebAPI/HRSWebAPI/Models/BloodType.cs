using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class BloodType
    {
        public int BloodTypeId { get; set; }
        public string? BloodTypeDesc { get; set; }
        public bool IsDel { get; set; }
    }
}
