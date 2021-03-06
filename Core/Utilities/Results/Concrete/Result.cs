using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool success)
        {
            this.Success = success;
        }

        public Result(bool success, string message):this(success)
        {
            this.Success = success;
            this.Message = message;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
