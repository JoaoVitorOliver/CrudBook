using Livros.livros.Application.Commands.Update;
using Livros.livros.Domain.Interfaces;
using Livros.livros.Application.Commands.Create;
using Livros.livros.Domain.Models.Entities;

namespace Livros.livros.Domain.Repositories
{
    public class BookRepository : IBookInterface
    {
        private static readonly List<Book> _Listbook = new();

        public Task<Book> CreateBook(CreateBookCommand command)
        {
            var data = new Book(command.Title, command.Autor, command.Description);
            _Listbook.Add(data);

            return Task.FromResult(data);
        }

        public List<Book> GetAllBooks()
        {
            return _Listbook;
        }

        public Task<Book> UpdateBook(int id, UpdateBookCommand command)
        {
            var search = _Listbook.FirstOrDefault(p => p.Id == id);

            if (search != null)
            {
                search.Title = command.Title;
                search.Autor = command.Autor;
                search.Description = command.Description;
            }

            return Task.FromResult(search!);
        }
    }
}