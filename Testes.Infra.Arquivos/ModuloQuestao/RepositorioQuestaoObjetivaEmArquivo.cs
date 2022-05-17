using FluentValidation;
using System.Collections.Generic;
using Testes.Dominio.ModuloQuestao;
using Testes.Infra.Arquivos.Compartilhado;
using Testes.Infra.Arquivos.Compartilhado.Serializador;

namespace Testes.Infra.Arquivos.ModuloQuestao
{
    public class RepositorioQuestaoObjetivaEmArquivo : RepositorioEmArquivoBase<QuestaoObjetiva>, IRepositorioQuestaoObjetiva
    {
        public RepositorioQuestaoObjetivaEmArquivo(DataContext dataContext) : base(dataContext)
        {

        }

        public override List<QuestaoObjetiva> ObterRegistros()
        {
            return dataContext.Questoes;
        }

        public override AbstractValidator<QuestaoObjetiva> ObterValidador()
        {
            return new ValidadorQuestaoObjetiva();
        }
    }
}
