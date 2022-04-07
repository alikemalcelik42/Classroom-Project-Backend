using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeworksController : ControllerBase
    {
        IHomeworkService _homeworkService;

        public HomeworksController(IHomeworkService homeworkService)
        {
            _homeworkService = homeworkService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _homeworkService.GetAll();

            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getallbylessonid")]
        public IActionResult GetAllByLessonId(int lessonId)
        {
            var result = _homeworkService.GetAllByLessonId(lessonId);

            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getallbyclassid")]
        public IActionResult GetAllByClassId(int classId)
        {
            var result = _homeworkService.GetAllByClassId(classId);

            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getallbyteacherid")]
        public IActionResult GetAllByTeacherId(int teacherId)
        {
            var result = _homeworkService.GetAllByTeacherId(teacherId);

            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("gethomeworkdetails")]
        public IActionResult GetHomeworkDetails()
        {
            var result = _homeworkService.GetHomeworkDetails();

            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _homeworkService.GetById(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] Homework homework, IFormFile file)
        {
            var result = _homeworkService.Add(homework, file);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Homework homework)
        {
            var result = _homeworkService.Update(homework);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("updatewithfile")]
        public IActionResult UpdateWithFile([FromForm] Homework homework, IFormFile file)
        {
            var result = _homeworkService.UpdateWithFile(homework, file);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Homework homework)
        {
            var result = _homeworkService.Delete(homework);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
