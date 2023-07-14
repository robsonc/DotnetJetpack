using System.Collections.Generic;

namespace DotnetJetpack.Core.Application
{
    public class Result<T>
    {
        public bool Success { get; private set; }
        public T Data { get; private set; }
        public IEnumerable<string> Errors { get; private set; }

        private Result(bool success, T data, IEnumerable<string> errors)
        {
            Success = success;
            Data = data;
            Errors = errors;
        }

        public static Result<T> Ok(T data)
        {
            return new Result<T>(true, data, new List<string>());
        }

        public static Result<T> Fail(IEnumerable<string> errors)
        {
            return new Result<T>(false, default(T), errors);
        }
    }
}
