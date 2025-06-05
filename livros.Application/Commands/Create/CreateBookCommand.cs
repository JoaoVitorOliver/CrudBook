

namespace Livros.livros.Application.Commands.Create
{
    public class CreateBookCommand
    {
        public string Title { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}