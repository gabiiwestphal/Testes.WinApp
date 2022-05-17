using Testes.Dominio.Compartilhado;
using Testes.Dominio.ModuloDisciplina;

namespace Testes.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public string Nome { get; set; }

        public string Serie { get; set; }

        public Disciplina Disciplina { get; set; }

        public override void Atualizar(Materia registro)
        {
        }
    }
}
