using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class TrainingSeminarProgram
    {
        public int TrainingSeminarProgramId { get; set; }
        public string? TrainingSeminarProgramTitle { get; set; }
        public string? TrainingSeminarProgramDesc { get; set; }
        public bool IsDel { get; set; }
    }
}
