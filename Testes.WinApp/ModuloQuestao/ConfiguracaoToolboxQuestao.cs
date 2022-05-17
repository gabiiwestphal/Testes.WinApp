using Testes.WinApp.Compartilhado;

namespace Testes.WinApp.ModuloQuestao
{
    public class ConfiguracaoToolboxQuestao : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Questões";

        public override string TooltipInserir { get { return "Inserir uma nova Questão"; } }

        public override string TooltipEditar { get { return "Editar uma Questão existente"; } }

        public override string TooltipExcluir { get { return "Excluir uma Questão existente"; } }
    }
}
