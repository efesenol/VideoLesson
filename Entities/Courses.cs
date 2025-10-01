using VideoLessone.Entities;

namespace VideoLesson.Entities
{
    public class Courses : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Img { get; set; }
        public decimal Price { get; set; }

        // Kursun toplam süresi (videoların toplamı)
        public TimeSpan TotalDuration { get; set; }

        // Kursun dili
        public string? Language { get; set; }

        // // Kursu oluşturan eğitmen
        // public int InstructorId { get; set; }
        // public Instructor Instructor { get; set; }

        // // Kurs hangi kategoriye bağlı
        // public int CategoryId { get; set; }
        // public Category Category { get; set; }

        // Kursun videoları
                 
        public Videos? videos { get; set; }          
        
        

    }

}