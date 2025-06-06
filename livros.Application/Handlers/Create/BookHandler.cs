using Livros.livros.Application.Commands.Create;
using Livros.livros.Domain.Interfaces;
using Livros.livros.Domain.Models.Entities;
using Livros.livros.Application.Commands.Update;
using Livros.livros.Application.Validation;
using Livros.livros.Application.DTOs.Response;

namespace Livros.livros.Application.Handlers
{
    public class BookHandler
    {

        private readonly IBookInterface _book;

        public BookHandler(IBookInterface book)
        {
            _book = book;
        }

        public async Task<ResponseBook> CreateBookHandle(CreateBookCommand command)
        {
            var validate = new EntitieValidator();
            var results = validate.Validate(command);
            if (results.IsValid)
            {
                await _book.CreateBook(command);
                var anexar = new ResponseBook(true);
                return anexar;
            }
            else
            {
                var error = results.Errors.Select(p => p.ErrorMessage);
                var anexar = new ResponseBook(false, error);
                return anexar;
            }
        }

        public List<Book> GetBookHandle()
        {
            return _book.GetAllBooks();
        }

        public async Task<ResponseBook> UpdateBookHandle(int id, CreateBookCommand command)
        {
            var validate = new EntitieValidator();
            var results = validate.Validate(command);
            if (results.IsValid)
            {
                await _book.UpdateBook(id, command);
                var anexar = new ResponseBook(true);
                return anexar;
            }
            else
            {
                var error = results.Errors.Select(p => p.ErrorMessage);
                var anexar = new ResponseBook(false, error);
                return anexar;
            }
        }
    }
}