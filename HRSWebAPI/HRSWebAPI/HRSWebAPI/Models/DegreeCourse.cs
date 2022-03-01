namespace HRSWebAPI.Models
{
    public partial class DegreeCourse
    {
        public DegreeCourse()
        {
            EducationalBackgrounds = new HashSet<EducationalBackground>();
        }

        public int DegreeCourseId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsDel { get; set; }

        public virtual ICollection<EducationalBackground> EducationalBackgrounds { get; set; }
    }
}
