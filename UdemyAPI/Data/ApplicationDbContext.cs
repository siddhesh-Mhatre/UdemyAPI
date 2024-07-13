using Microsoft.EntityFrameworkCore;
using UdemyAPI.Models;
using UdemyAPI.Models.Course;

namespace UdemyAPI.Data
{
    public class ApplicationDbContext:DbContext
    {

       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

       public DbSet<User> Users { get; set; }
       public DbSet<AddCourseCategory> addCourseCategories { get; set; }
       public DbSet<AddCourseContent> addCourseContents { get; set; }

       public DbSet<Quiz> quizs { get; set; }
    }
}
