using VideoLessone.Entities;

namespace VideoLesson.Entities
{
    public class Videos : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? VideoUrl { get; set; }
        public int DurationInSeconds { get; set; }
        public int Order { get; set; }

        public int CourseId { get; set; }
        public Courses? Course { get; set; }
        

    }

}