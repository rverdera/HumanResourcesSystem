using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class TrainingSeminarProgram
    {
        public TrainingSeminarProgram()
        {
            LearningAndDevelopments = new HashSet<LearningAndDevelopment>();
        }

        public int TrainingSeminarProgramId { get; set; }
        public string TrainingSeminarProgramTitle { get; set; } = null!;
        public string? TrainingSeminarProgramDesc { get; set; }
        public int LearningAndDevelopmentTypeId { get; set; }
        public bool IsDel { get; set; }

        public virtual LearningAndDevelopmentType LearningAndDevelopmentType { get; set; } = null!;
        public virtual ICollection<LearningAndDevelopment> LearningAndDevelopments { get; set; }
    }
}
