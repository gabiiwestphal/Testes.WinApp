using System.Collections.Generic;
using Testes.Dominio.Compartilhado;

namespace Testes.Dominio.ModuloDisciplina
{
    public interface IRepositorioDisciplina : IRepositorio<Disciplina>
    {
        List<Disciplina> SelecionarTodos();

        bool DisciplinaJaExiste(string nome);
    }
}
