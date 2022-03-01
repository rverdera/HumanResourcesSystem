namespace HRSWebAPI.Models
{
    public partial class LearningAndDevelopmentType
    {
        public LearningAndDevelopmentType()
        {
            TrainingSeminarPrograms = new HashSet<TrainingSeminarProgram>();
        }

        public int LearningAndDevelopmentTypeId { get; set; }
        public string LearningAndDevelopmentTypeDesc { get; set; } = null!;
        public bool IsDel { get; set; }

        public virtual ICollection<TrainingSeminarProgram> TrainingSeminarPrograms { get; set; }
    }
}
