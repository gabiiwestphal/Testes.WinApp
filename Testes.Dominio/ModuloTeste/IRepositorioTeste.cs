using System.Collections.Generic;
using Testes.Dominio.Compartilhado;

namespace Testes.Dominio.ModuloTeste
{
    public interface IRepositorioTeste : IRepositorio<Teste>
    {
        List<Teste> SelecionarTodos();
    }
}
