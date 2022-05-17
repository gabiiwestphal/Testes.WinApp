using System.Collections.Generic;
using Testes.Dominio.Compartilhado;

namespace Testes.Dominio.ModuloMateria
{
    public interface IRepositorioMateria : IRepositorio<Materia>
    {
        List<Materia> SelecionarTodos();

        bool ExisteMateriaPeloNumeroDisciplina(int numero);

        bool MateriaJaExiste(string nome);
    }
}
