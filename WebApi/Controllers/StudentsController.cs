using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController(IStudentService studentService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var result = await studentService.GetAllAsync();

            if (!result.IsSuccess)  return StatusCode(result.StatusCode, result.Message);                
            return Ok(result.Data);

        }

    }
}
