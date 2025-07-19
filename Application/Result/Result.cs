using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Application.Result
{
    public class Result<T> 
    {
        public bool IsSuccess { get; init; }
        public int StatusCode { get; init; }
        public T? Data { get; init; } 
        public string? Message { get; init; }
        public IEnumerable<string> ErrorList { get; init; }


        public static Result<T> Success(int statusCode, string? message = default)
            => new() { IsSuccess = true, StatusCode = statusCode, Message = message };
        public static Result<T> Success(int statusCode, T data )
            => new() { IsSuccess = true, StatusCode = statusCode, Data = data };
        public static Result<T> Faliure(int statusCode, string? message = default) 
            => new() { IsSuccess = false, StatusCode = statusCode, Message = message};
        public static Result<T> Faliure(int statusCode, IEnumerable<string> errorList)
           => new() { IsSuccess = false, StatusCode = statusCode, ErrorList = errorList };

    }
}
