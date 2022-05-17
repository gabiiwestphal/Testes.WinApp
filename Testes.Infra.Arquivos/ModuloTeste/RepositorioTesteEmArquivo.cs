using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using Testes.Dominio.ModuloTeste;
using Testes.Infra.Arquivos.Compartilhado;
using Testes.Infra.Arquivos.Compartilhado.Serializador;

namespace Testes.Infra.Arquivos.ModuloTeste
{
    public class RepositorioTesteEmArquivo : RepositorioEmArquivoBase<Teste>, IRepositorioTeste
    {
        public RepositorioTesteEmArquivo(DataContext dataContext) : base(dataContext)
        {

        }

        public override List<Teste> ObterRegistros()
        {
            return dataContext.Testes;
        }

        public override AbstractValidator<Teste> ObterValidador()
        {
            return new ValidadorTeste();
        }
    }
}
