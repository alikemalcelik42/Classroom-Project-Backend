using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        ITeacherService _teacherService;

        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _teacherService.GetAll();

            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getallbylessonid")]
        public IActionResult GetAllByLessonId(int lessonId)
        {
            var result = _teacherService.GetAllByLessonId(lessonId);

            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getteacherdetails")]
        public IActionResult GetTeacherDetails()
        {
            var result = _teacherService.GetTeacherDetails();

            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _teacherService.GetById(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Teacher teacher)
        {
            var result = _teacherService.Add(teacher);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Teacher teacher)
        {
            var result = _teacherService.Update(teacher);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Teacher teacher)
        {
            var result = _teacherService.Delete(teacher);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }

}
