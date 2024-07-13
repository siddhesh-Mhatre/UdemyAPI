using UdemyAPI.Models;
using UdemyAPI.Models.Course;
namespace UdemyAPI.Repo
{
    public interface IRepositry
    {
        void CreateUser(User u);
        User? Login(string Email, string password);
        User GetUserByEmail(string email);

        // --------------------------------------  ADDING COURSE  AND QUIZES
        void CreateCategoreyCourse(AddCourseCategory cate);
        void AddContentCourse(AddCourseContent cont);
        void AddQuizes(Quiz quiz);
        List<Quiz> GetQuizs();
        List<string> GetCourseName();  

    }
}
