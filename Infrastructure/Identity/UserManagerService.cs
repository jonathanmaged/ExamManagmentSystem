using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.AuthDto;
using Application.Interfaces;
using Application.Result;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class UserManagerService(UserManager<AppUser> userManager) : IUserManagerService
    {
        public async Task<Result<bool>> CreateUserAsync(RegisterRequest request) {

            var existingUser = await userManager.FindByEmailAsync(request.Email);

            if (existingUser is not null)
                return Result<bool>.Faliure(409, "this Email already Exists");

            var result = await userManager.CreateAsync(request.ToAppUser(), request.Password);

            if (!result.Succeeded) {
                var errorsDescription = string.Join(";", result.Errors.Select(q => q.Description));
                return Result<bool>.Faliure(400, errorsDescription);
            }
            return Result<bool>.Success(201, "user created successfully");
        }

    }
    static class RegisterRequestExtensions {
        internal static AppUser ToAppUser(this RegisterRequest req)
        {
            var user = new AppUser
            {
                UserName = req.UserName,
                Email = req.Email
            };
            return user;

    }
}
}
