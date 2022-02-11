using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public string? CountryDesc { get; set; }
        public bool? IsDel { get; set; }
    }
}
