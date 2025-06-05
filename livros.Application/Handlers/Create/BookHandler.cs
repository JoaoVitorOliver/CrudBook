using Livros.livros.Application.Commands.Create;
using Livros.livros.Domain.Interfaces;
using Livros.livros.Domain.Models.Entities;
using Livros.livros.Application.Commands.Update;

namespace Livros.livros.Application.Handlers
{
    public class BookHandler
    {

        private readonly IBookInterface _book;

        public BookHandler(IBookInterface book)
        {
            _book = book;
        }

        public Task CreateBookHandle(CreateBookCommand command)
        {
            if (command != null)
            {
                return _book.CreateBook(command);
            }
            return Task.CompletedTask;
        }

        public List<Book> GetBookHandle()
        {
            return _book.GetAllBooks();
        }

        public Task<Book> UpdateBookHandle(int id, UpdateBookCommand command)
        {
            return _book.UpdateBook(id, command);
        }
    }
}