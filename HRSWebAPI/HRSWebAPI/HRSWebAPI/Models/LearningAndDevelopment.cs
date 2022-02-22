using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class LearningAndDevelopment
    {
        public int RecordId { get; set; }
        public int? PersonId { get; set; }
        public int? TrainingSeminarProgramId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int NoOfHours { get; set; }
        public int? LearningAndDevelopmentTypeId { get; set; }
        public int? SchoolTrainingInstitutionId { get; set; }
        public bool IsDel { get; set; }
        public string UserStamp { get; set; } = null!;
        public DateTime DateStamp { get; set; }

        public virtual PersonalInformation? Person { get; set; }
        public virtual SchoolTrainingInstitution? SchoolTrainingInstitution { get; set; }
        public virtual TrainingSeminarProgram? TrainingSeminarProgram { get; set; }
    }
}
