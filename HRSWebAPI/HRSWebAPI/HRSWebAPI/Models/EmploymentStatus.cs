using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class EmploymentStatus
    {
        public int EmploymentStatusId { get; set; }
        public string EmploymentStatusDesc { get; set; } = null!;
        public bool IsDel { get; set; }
    }
}
