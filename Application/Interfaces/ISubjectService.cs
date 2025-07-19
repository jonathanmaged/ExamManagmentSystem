using Application.Dtos.Subject;
using Application.Result;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ISubjectService
    {
        Task<Result<IEnumerable<SubjectResponse>>> GetAllAsync();
        Task<Result<bool>> AddSubjectAsync(CreateSubjectRequest dto);
        Task<Result<bool>> UpdateSubjectAsync(UpdateSubjectRequest subjectDto);

    }
}
