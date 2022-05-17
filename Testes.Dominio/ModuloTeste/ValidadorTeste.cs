using FluentValidation;

namespace Testes.Dominio.ModuloTeste
{
    public class ValidadorTeste : AbstractValidator<Teste>
    {
        public ValidadorTeste()
        {
            RuleFor(x => x.Titulo)
               .NotNull().NotEmpty();

            RuleFor(x => x.Data)
              .NotNull().NotEmpty();

            RuleFor(x => x.Data)
              .GreaterThan(new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 0, 0, 0));

            RuleFor(x => x.Disciplina)
               .NotNull().NotEmpty();

            RuleFor(x => x.Materia)
               .NotNull().NotEmpty().When(x => x.Recuperacao == false)
               .WithMessage("Matéria ou campo de Recuperação deve ser selecionado.");

            RuleFor(x => x.NumeroQuestoes)
               .NotNull().NotEmpty();
        }

    }
}
