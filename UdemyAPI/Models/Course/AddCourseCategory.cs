using System.ComponentModel.DataAnnotations;

namespace UdemyAPI.Models.Course
{
    public class AddCourseCategory
    {
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }

        public string CourseDescription { get; set; }

        public string Level { get; set; }

        public string CourseCategoryName { get; set; }

        public string Thumbnail { get;set; }

        public decimal Price {  get; set; }

        public DateTime CreatedAt { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

        public string? Tag { get; set; }




    }
}
