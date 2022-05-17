using System.Windows.Forms;

namespace Testes.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract void Inserir();

        public abstract void Editar();
        
        public abstract void Excluir();

        public virtual void Agrupar() { }

        public abstract UserControl ObtemListagem();

        public abstract ConfiguracaoToolboxBase ObtemConfiguracaoToolbox();
    }
}
