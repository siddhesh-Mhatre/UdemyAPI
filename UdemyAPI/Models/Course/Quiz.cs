using System.ComponentModel.DataAnnotations;

namespace UdemyAPI.Models.Course
{
    public class Quiz
    {
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; } // admin main table
        public string SubCourse { get; set; }  // add course
        public string Title { get; set; } // input name= Topic ,  drop down, add course
        public string Question { get; set; }
        public List<string>  Option { get; set; }
        public string Ans { get; set; }
    }
}
