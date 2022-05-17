using System.Collections.Generic;
using Testes.Dominio.Compartilhado;

namespace Testes.Dominio.ModuloQuestao
{
    public interface IRepositorioQuestaoObjetiva : IRepositorio<QuestaoObjetiva>
    {
        List<QuestaoObjetiva> SelecionarTodos();
    }
}
