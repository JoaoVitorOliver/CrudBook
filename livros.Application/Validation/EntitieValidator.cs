using FluentValidation;
using Livros.livros.Application.Commands.Create;

namespace Livros.livros.Application.Validation
{
    public class EntitieValidator : AbstractValidator<CreateBookCommand>
    {
        public EntitieValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("O campo Titulo não pode ser nulo! ");
            RuleFor(p => p.Autor)
                .NotEmpty().WithMessage("O Autor não pode ser nulo! ");
            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("Campo description não pode ser nulo! ");
        }
    }
}