using System.Collections.Generic;

namespace KatalogApp.Application.Core.Dtos
{
    public class ResponseDto<T>
    {
        public T data { get; set; } = default!;
        public int statusCode { get; set; }
        public bool isSuccess { get; set; }
        public List<string> errors { get; set; } = new List<string>();

        public ResponseDto<T> Success()
        {
            return new ResponseDto<T> { data = default, statusCode = 200, isSuccess = true, errors = new List<string>() };
        }
        public ResponseDto<T> Success(T data)
        {
            return new ResponseDto<T> { data = data, statusCode = 200, isSuccess = true, errors = new List<string>() };
        }
        public ResponseDto<T> Fail(List<string> errors)
        {
            return new ResponseDto<T> { data = default, statusCode = 400, isSuccess = false, errors = errors };
        }
        public ResponseDto<T> Fail(string error)
        {
            errors.Add(error);
            return new ResponseDto<T> { data = default, errors = errors, statusCode = 400, isSuccess = false };
        }
    }
}
