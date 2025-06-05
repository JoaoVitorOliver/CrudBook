

namespace Livros.livros.Domain.Models.Entities
{
    public class Book
    {
        private static int _nextId = 1;

        public int Id { get; set; } 
        public string Title { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Data { get; set; } = DateTime.Now;

        public Book(string title, string autor, string description)
        {
            Id = _nextId++;
            Title = title;
            Autor = autor;
            Description = description;
        }
    }
}