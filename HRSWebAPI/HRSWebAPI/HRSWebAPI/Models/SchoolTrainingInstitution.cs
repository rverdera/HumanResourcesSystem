using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class SchoolTrainingInstitution
    {
        public int SchoolTrainingInstitutionId { get; set; }
        public string SchoolTrainingInstitutionName { get; set; } = null!;
        public string SchoolTrainingInstitutionAddress { get; set; } = null!;
        public bool IsSchoolFacility { get; set; }
        public bool IsTrainingFacility { get; set; }
        public bool IsCscaccredited { get; set; }
        public bool IsDel { get; set; }
    }
}
