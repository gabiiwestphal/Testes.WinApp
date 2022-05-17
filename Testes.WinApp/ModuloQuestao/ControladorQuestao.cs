using System.Collections.Generic;
using System.Windows.Forms;
using Testes.Dominio.ModuloDisciplina;
using Testes.Dominio.ModuloMateria;
using Testes.Dominio.ModuloQuestao;
using Testes.WinApp.Compartilhado;

namespace Testes.WinApp.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private readonly IRepositorioQuestaoObjetiva repositorioQuestao;
        private readonly IRepositorioMateria repositorioMateria;
        private readonly IRepositorioDisciplina repositorioDisciplina;
        private TabelaQuestoesControl tabelaQuestoes;

        public ControladorQuestao(IRepositorioQuestaoObjetiva repositorioQuestao, IRepositorioMateria repositorioMateria,
            IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override void Inserir()
        {
            var disciplinas = repositorioDisciplina.SelecionarTodos();
            var materias = repositorioMateria.SelecionarTodos();

            TelaCadastroQuestoesForm tela = new TelaCadastroQuestoesForm(disciplinas, materias);
            tela.QuestaoObjetiva = new QuestaoObjetiva();

            tela.GravarRegistro = repositorioQuestao.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarQuestoes();
            }
        }

        public override void Editar()
        {
            var QuestaoSelecionada = ObtemQuestaoSelecionada();

            if (QuestaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma Questão primeiro",
                "Edição de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var disciplinas = repositorioDisciplina.SelecionarTodos();
            var materias = repositorioMateria.SelecionarTodos();

            TelaCadastroQuestoesForm tela = new TelaCadastroQuestoesForm(disciplinas, materias);

            tela.QuestaoObjetiva = QuestaoSelecionada;

            tela.GravarRegistro = repositorioQuestao.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarQuestoes();
            }
        }

        public override void Excluir()
        {
            QuestaoObjetiva QuestaoSelecionada = ObtemQuestaoSelecionada();

            if (QuestaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma Questão primeiro",
                "Exclusão de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a Questão?",
                "Exclusão de Questões", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioQuestao.Excluir(QuestaoSelecionada);
                CarregarQuestoes();
            }
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaQuestoes == null)
                tabelaQuestoes = new TabelaQuestoesControl();

            CarregarQuestoes();

            return tabelaQuestoes;
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxQuestao();
        }


        private QuestaoObjetiva ObtemQuestaoSelecionada()
        {
            var numero = tabelaQuestoes.ObtemNumeroQuestaoSelecionada();

            return repositorioQuestao.SelecionarPorNumero(numero);
        }

        private void CarregarQuestoes()
        {
            List<QuestaoObjetiva> questoes = repositorioQuestao.SelecionarTodos();

            tabelaQuestoes.AtualizarRegistros(questoes);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {questoes.Count} Questão(ões)");
        }
    }
}