using FluentValidation;
using System.Linq;

namespace Testes.Dominio.ModuloQuestao
{
    public class ValidadorQuestaoObjetiva : AbstractValidator<QuestaoObjetiva>
    {
        public ValidadorQuestaoObjetiva()
        {
            RuleFor(x => x.Materia)
               .NotNull().NotEmpty();

            RuleFor(x => x.Disciplina)
              .NotNull().NotEmpty();

            RuleFor(x => x.Bimestre)
               .NotNull().NotEmpty();

            RuleFor(x => x.Alternativas)
               .NotNull().NotEmpty();

            RuleFor(x => x.Enunciado)
              .NotNull().NotEmpty();

            RuleFor(x => x.Alternativas)
                .Must(lista => lista.Any(x => x.Correta))
                .WithMessage("Obrigatório marcar uma alternativa como correta");
        }
    }
}
