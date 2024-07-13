using Microsoft.EntityFrameworkCore;
using UdemyAPI.Data;
using UdemyAPI.Models;
using UdemyAPI.Models.Course;
using UdemyAPI.Repo;

namespace UdemyAPI.Service
{
    public class Services : IRepositry
    {
        private readonly ApplicationDbContext db;

        private readonly IRepositry repo;
        public Services(ApplicationDbContext db) 
        { 
         this.db = db;
        }

        // -----------------------   USER AUTHENTICATION  ----------------------
        public void CreateUser(User u)
        {
         
            db.Users.Add(u);
            db.SaveChanges();
        }

        public User? Login(string Email, string password)
        {
            try
            {
                // Find user by email and password
                var user = db.Users.FirstOrDefault(u => u.Email == Email && u.Password == password);

                return user;

            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log them)
                throw new Exception("Error during login", ex);
            }
        }


        public User GetUserByEmail(string email)
        {
            return db.Users.FirstOrDefault(u => u.Email == email);
        }



        // --------------------------------  COURSE CONTENT

        public void CreateCategoreyCourse(AddCourseCategory cate)
        {
            db.addCourseCategories.Add(cate);
            db.SaveChanges();
        }

        public void AddContentCourse(AddCourseContent cont)
        {
          db.addCourseContents.Add(cont);
          db.SaveChanges();
        }

        public List<string> GetCourseName()
        {
            var data = db.addCourseCategories
                          .Select(c => c.CourseName)
                          .ToList();
            return data;
        }

        public void AddQuizes(Quiz quiz)
        {
            db.quizs.Add(quiz);
            db.SaveChanges();
        }

        public List<Quiz> GetQuizs()
        {
            var data = db.quizs.ToList();
            return data;
        }
    }
}
