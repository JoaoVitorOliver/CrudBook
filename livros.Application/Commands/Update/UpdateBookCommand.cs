using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livros.livros.Application.Commands.Update
{
    public class UpdateBookCommand
    {
        public string Title { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}