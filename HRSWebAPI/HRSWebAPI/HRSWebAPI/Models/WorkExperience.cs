﻿using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class WorkExperience
    {
        public int RecordId { get; set; }
        public int? PersonId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string PositionTitle { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string MonthlySalary { get; set; } = null!;
        public string? SalaryGrade { get; set; }
        public int? EmploymentStatusId { get; set; }
        public bool IsGovernmentService { get; set; }
        public bool IsDel { get; set; }
        public string UserStamp { get; set; } = null!;
        public DateTime DateStamp { get; set; }

        public virtual EmploymentStatus? EmploymentStatus { get; set; }
        public virtual PersonalInformation? Person { get; set; }
    }
}
