using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using Testes.Dominio.ModuloDisciplina;
using Testes.Infra.Arquivos.Compartilhado;
using Testes.Infra.Arquivos.Compartilhado.Serializador;

namespace Testes.Infra.Arquivos.ModuloDisciplina
{
    public class RepositorioDisciplinaEmArquivo : RepositorioEmArquivoBase<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaEmArquivo(DataContext dataContext) 
            : base(dataContext) { }

        public bool DisciplinaJaExiste(string nome)
        {
            return dataContext.Disciplinas.Any(x => x.Nome.Equals(nome));
        }

        public override List<Disciplina> ObterRegistros()
        {
            return dataContext.Disciplinas;
        }

        public override AbstractValidator<Disciplina> ObterValidador()
        {
            return new ValidadorDisciplina();
        }
    }
}