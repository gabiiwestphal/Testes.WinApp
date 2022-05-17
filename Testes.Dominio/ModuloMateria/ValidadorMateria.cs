using FluentValidation;

namespace Testes.Dominio.ModuloMateria
{
    public class ValidadorMateria : AbstractValidator<Materia>
    {
        public ValidadorMateria()
        {
            RuleFor(x => x.Nome)
               .NotNull().NotEmpty();

            RuleFor(x => x.Disciplina)
               .NotNull().NotEmpty();

            RuleFor(x => x.Serie)
               .NotNull().NotEmpty();
        }
    }
}
