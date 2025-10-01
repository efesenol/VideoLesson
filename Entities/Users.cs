using VideoLessone.Entities;

namespace VideoLesson.Entities
{
    public class Users : BaseEntity
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }


    }

}