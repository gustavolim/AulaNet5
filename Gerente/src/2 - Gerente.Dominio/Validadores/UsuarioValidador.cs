using FluentValidation;
using Gerente.Dominio.Entidades;

namespace Gerente.Dominio.Validadores
{
    public class UsuarioValidador : AbstractValidator<Usuario>
    {
        public UsuarioValidador()
        {
            RuleFor(x => x)
                .NotEmpty()
                .WithMessage("Não pode ser Vazio/a")
                .NotNull()
                .WithMessage("Não pode ser null");

            RuleFor(x => x.Nome)
                .MinimumLength(3)
                .WithMessage("O nome tem que ter no minimo 3 ctrs.")
                .MaximumLength(30)
                .WithMessage("O nome tem que ter no máximo 30 ctrs.");

            RuleFor(x => x.Email)
                .MinimumLength(3)
                .WithMessage("O nome tem que ter no minimo 3 ctrs.")
                .MaximumLength(30)
                .WithMessage("O nome tem que ter no máximo 30 ctrs.")
                .EmailAddress()
                .WithMessage("Email inválido");

        }
    }
}