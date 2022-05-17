using Testes.WinApp.Compartilhado;

namespace Testes.WinApp.ModuloDisciplina
{
        public class ConfiguracaoToolboxDisciplina : ConfiguracaoToolboxBase
        {
            public override string TipoCadastro => "Cadastro de Disciplinas";

            public override string TooltipInserir { get { return "Inserir uma nova Disciplina"; } }

            public override string TooltipEditar { get { return "Editar uma Disciplina existente"; } }

            public override string TooltipExcluir { get { return "Excluir uma Disciplina existente"; } }
        }
}
