using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyAPI.Models.Course;
using UdemyAPI.Repo;

namespace UdemyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly IRepositry repo;
        public CourseController(IRepositry repo)
        {
            this.repo = repo;
        }

        [HttpPost]
        [Route("AddCategory")]
        public IActionResult AddnewCategorey( AddCourseCategory cate)
        {
            repo.CreateCategoreyCourse(cate);
            return Ok("Categorey Added sucessfully");
        }

        [HttpPost]
        [Route("AddContent")]
        public IActionResult AddContent( AddCourseContent cont)
        {
            repo.AddContentCourse(cont);
            return Ok("Content Added sucessfully");
        }

        [HttpGet]
        [Route("GetCourseName")]
        public IActionResult GetCourse()
        {
            var data = repo.GetCourseName();
            return Ok(data);
        }

        [HttpPost]
        [Route("CreateQuizes")]
        public IActionResult CreateOwnQuiz(Quiz quiz)
        {
            repo.AddQuizes(quiz);
            return Ok("Quiz Added sucessfully");
        }

        [HttpGet]
        [Route("GetAllQuiz")]
        public IActionResult GetQuizes()
        {
            var data = repo.GetQuizs();
            return Ok(data);
        }

    }
}
