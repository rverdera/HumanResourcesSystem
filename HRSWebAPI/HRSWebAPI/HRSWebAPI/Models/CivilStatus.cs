using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class CivilStatus
    {
        public int CivilStatusId { get; set; }
        public string? CivilStatusDesc { get; set; }
        public bool? IsDel { get; set; }
    }
}
