using Application.Dtos.CreateDto;
using Application.Dtos.GetDto;
using Application.Dtos.UpdateDto;
using Application.Result;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ISubjectService
    {
        Task<Result<IEnumerable<GetSubjectDto>>> GetAllAsync();
        Task<Result<bool>> AddSubjectAsync(CreateSubjectDto dto);
        Task<Result<bool>> UpdateSubjectAsync(UpdateSubjectDto subjectDto);

    }
}
