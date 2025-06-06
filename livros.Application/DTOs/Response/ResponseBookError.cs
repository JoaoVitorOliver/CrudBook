using Livros.livros.Domain.Models.Entities;

namespace Livros.livros.Application.DTOs.Response
{
    public class ResponseBook
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; } = [];
        public Book? book { get; set; }

        public ResponseBook(bool isSuccess, IEnumerable<string> errors)
        {
            IsSuccess = isSuccess;
            Errors = errors;
        }

        public ResponseBook(bool isSuccess, IEnumerable<string> errors, Book boook)
        {
            IsSuccess = isSuccess;
            Errors = errors;
            book = boook;
        }

        public ResponseBook(bool isSuccess, Book boook)
        {
            IsSuccess = isSuccess;
            book = boook;
        }

        public ResponseBook(Book boook)
        {
            book = boook;
        }

        public ResponseBook(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
    }
}