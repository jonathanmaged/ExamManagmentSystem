using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.AuthDto;
using Application.Result;

namespace Application.Interfaces
{
    public interface IUserManagerService
    {

        Task<Result<bool>> CreateUserAsync(RegisterRequest request);
    }
}
