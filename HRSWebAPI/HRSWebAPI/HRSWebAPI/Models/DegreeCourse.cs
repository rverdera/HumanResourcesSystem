using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class DegreeCourse
    {
        public int DegreeCourseId { get; set; }
        public string? Name { get; set; }
        public bool IsDel { get; set; }
    }
}
