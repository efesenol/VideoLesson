

namespace VideoLesson.Models;

public class VideoCourseViewModel
{

   public int VideoId { get; set; }
   public string? VideoTitle { get; set; }
   public string? VideoDescription { get; set; }
   public int VideoDuration { get; set; }
   public int VideoOrder { get; set; }

   // Course Bilgileri
   public int CourseId { get; set; }
   public string? CourseTitle { get; set; }
   public string? CourseDescription { get; set; }
   public TimeSpan CourseTotalDuration { get; set; }
   public string? CourseLanguage { get; set; }
   public string? CourseThumbnailUrl { get; set; }

   // Eğitmen (Opsiyonel ama mantıklı olur)
   public string? InstructorName { get; set; }
}

