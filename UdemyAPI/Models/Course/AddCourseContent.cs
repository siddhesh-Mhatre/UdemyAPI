using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyAPI.Models.Course
{
    public class AddCourseContent
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string MetaUrl { get; set;}
        //public DateTime CreatedAt { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 15); // For the 15th day of the month

        [ForeignKey("CourseName")]
        public string CourseName { get; set; }
        public string? CourseTopic { get; set;}
        // optinal null 



    }
}
