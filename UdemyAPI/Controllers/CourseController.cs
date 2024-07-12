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
        public IActionResult AddnewCategorey([FromForm] AddCourseCategory cate)
        {
            repo.CreateCategoreyCourse(cate);
            return Ok("Categorey Added sucessfully");
        }

        [HttpPost]
        [Route("AddContent")]
        public IActionResult AddContent([FromForm] AddCourseContent cont)
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



    }
}
