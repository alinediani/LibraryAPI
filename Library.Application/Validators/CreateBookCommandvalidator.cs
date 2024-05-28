using Library.Application.Commands.CreateBook;
using FluentValidation;

namespace Library.Application.Validators
{
    public class CreateBookCommandvalidator : AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandvalidator()
        {
                RuleFor(p => p.Title)
                .MaximumLength(30)
                .WithMessage("Tamanho máximo de Título é de 30 caracteres");
        }
    }
}
