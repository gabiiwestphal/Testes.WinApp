using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using Testes.Dominio.ModuloMateria;
using Testes.Infra.Arquivos.Compartilhado;
using Testes.Infra.Arquivos.Compartilhado.Serializador;

namespace Testes.Infra.Arquivos.ModuloMateria
{
    public class RepositorioMateriaEmArquivo : RepositorioEmArquivoBase<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaEmArquivo(DataContext dataContext) : base(dataContext)
        {

        }

        public bool ExisteMateriaPeloNumeroDisciplina(int numero)
        {
            return dataContext.Materias.Any(x => x.Disciplina.Numero == numero);
        }

        public bool MateriaJaExiste(string nome)
        {
            return dataContext.Materias.Any(x => x.Nome.Equals(nome));
        }

        public override List<Materia> ObterRegistros()
        {
            return dataContext.Materias;
        }

        public override AbstractValidator<Materia> ObterValidador()
        {
            return new ValidadorMateria();
        }
    }
}
