using Application.Dtos.Student;
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

            if (!result.IsSuccess) return StatusCode(result.StatusCode, result.Message);
            return Ok(result.Data);

        }
        [HttpPatch("{studentId}/active")]
        public async Task<IActionResult> UpdateActiveStatus(int studentId, ActivePatchRequest request)
        {
            var result = await studentService.SetActiveStatusAsync(studentId, request.Active);
            return StatusCode(result.StatusCode, result.Message);
            
        }
        [HttpGet("{studentId}/subjects")]
        public async Task<IActionResult> GetStudentSubjects(int studentId) 
        {
            var result = await studentService.GetStudentSubjectsAsync(studentId);
            if (!result.IsSuccess) return StatusCode(result.StatusCode, result.Message);
            return Ok(result.Data);
        }
        [HttpPost("{studentId}/subjects/{subjectId}")]
        public async Task<IActionResult> AddStudentSubject(int studentId, int subjectId) 
        { 
            var result = await studentService.AddSubjectAsync(studentId, subjectId);
            return StatusCode(result.StatusCode, result.Message);

        }
        [HttpGet("{studentId}/exams")]
        public async Task<IActionResult> GetStudentExams(int studentId)
        {
            var result = await studentService.GetExamHistoryAsync(studentId);
            if (!result.IsSuccess) return StatusCode(result.StatusCode, result.Message);
            return Ok(result.Data);

        }
    }
}
