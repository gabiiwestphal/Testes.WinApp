using Testes.WinApp.Compartilhado;

namespace Testes.WinApp.ModuloMateria
{
    public class ConfiguracaoToolboxMateria : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Matérias";

        public override string TooltipInserir { get { return "Inserir uma nova Matéria"; } }

        public override string TooltipEditar { get { return "Editar uma Matéria existente"; } }

        public override string TooltipExcluir { get { return "Excluir uma Matéria existente"; } }
    }
}
