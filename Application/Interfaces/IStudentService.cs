using Application.Result;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IStudentService
    {
        Task<Result<IEnumerable<Student>>> GetAllAsync();
        Task<Result<bool>> SetActiveStatusAsync(int studentId,bool isActive); 
        Task<Result<IEnumerable<Subject>>> GetStudentSubjectsAsync(int studentId);
        //AddSubject(int subjectId);
        

        
    }
}
