using Livros.livros.Application.Commands.Create;
using Livros.livros.Domain.Models.Entities;
using Livros.livros.Application.DTOs.Response;


namespace Livros.livros.Domain.Interfaces
{
    public interface IBookInterface
    {
        Task<Book> CreateBook(CreateBookCommand command);
        List<Book> GetAllBooks();
        Task<Book> UpdateBook(int id, CreateBookCommand command);

    }
}