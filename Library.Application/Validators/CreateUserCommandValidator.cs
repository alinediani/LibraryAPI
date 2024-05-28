using Library.Application.Commands.CreateUser;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Library.Application.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(p => p.Email)
                .EmailAddress()
                .WithMessage("E-mail não válido!");

            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome é obrigatório!");
        }
    }
}
