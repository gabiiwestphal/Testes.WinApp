using System.Collections.Generic;
using Testes.Dominio.Compartilhado;
using Testes.Dominio.ModuloQuestao;

namespace Testes.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public Disciplina()
        {
        }

        public string Nome { get; set; }

        public override void Atualizar(Disciplina registro)
        {
        }
    }
}
