using Application.Dtos.Exam;
using Application.Dtos.Student;
using Application.Dtos.Subject;
using Application.Result;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IStudentService
    {
        Task<Result<IEnumerable<StudentResponse>>> GetAllAsync();
        Task<Result<bool>> SetActiveStatusAsync(int studentId,bool isActive); 
        Task<Result<IEnumerable<SubjectResponse>>> GetStudentSubjectsAsync(int studentId);
        Task<Result<bool>> AddSubjectAsync(int studentId,int subjectId );
        Task<Result<IEnumerable<ExamResponse>>> GetExamHistoryAsync(int studentId);

        
    }
}
