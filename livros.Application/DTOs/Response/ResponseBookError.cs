using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livros.livros.Application.DTOs.Response
{
    public class ResponseBookError
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; } = [];

        public ResponseBookError(bool isSuccess, IEnumerable<string> errors)
        {
            IsSuccess = isSuccess;
            Errors = errors;
        }

        public ResponseBookError(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
    }
}