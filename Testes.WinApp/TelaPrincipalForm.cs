using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Testes.Infra.Arquivos.Compartilhado.Serializador;
using Testes.Infra.Arquivos.ModuloDisciplina;
using Testes.Infra.Arquivos.ModuloMateria;
using Testes.Infra.Arquivos.ModuloQuestao;
using Testes.Infra.Arquivos.ModuloTeste;
using Testes.WinApp.Compartilhado;
using Testes.WinApp.ModuloDisciplina;
using Testes.WinApp.ModuloMateria;
using Testes.WinApp.ModuloQuestao;
using Testes.WinApp.ModutoTeste;

namespace Testes.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        private DataContext contextoDados;

        public TelaPrincipalForm(DataContext contextoDados)
        {
            InitializeComponent();

            Instancia = this;

            labelRodape.Text = string.Empty;
            labelTipoCadastro.Text = string.Empty;

            this.contextoDados = contextoDados;

            InicializarControladores();
        }

        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void disciplinaMenuItem_Click(object sender, EventArgs e)
        {
            MostrarBtnCopiarEPdf(false);
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void materiaMenuItem_Click(object sender, EventArgs e)
        {
            MostrarBtnCopiarEPdf(false);
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void questaoMenuItem_Click(object sender, EventArgs e)
        {
            MostrarBtnCopiarEPdf(false);
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void testeMenuItem_Click(object sender, EventArgs e)
        {
            MostrarBtnCopiarEPdf(true);
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void MostrarBtnCopiarEPdf(bool mostrar)
        {
            btnDuplicar.Visible = mostrar;
            btnGerarPdf.Visible = mostrar;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            ((ControladorTeste)controlador).Duplicar();
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            ((ControladorTeste)controlador).GerarPdf();
        }

        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.Visible = configuracao.InserirHabilitado;
            btnEditar.Visible = configuracao.EditarHabilitado;
            btnExcluir.Visible = configuracao.ExcluirHabilitado;
        }

        private void ConfigurarTooltips(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;
            btnGerarPdf.ToolTipText = configuracao.TooltipGerarPdf;
            btnDuplicar.ToolTipText = configuracao.TooltipDuplicar;
        }

        private void ConfigurarTelaPrincipal(ToolStripMenuItem opcaoSelecionada)
        {
            var tipo = opcaoSelecionada.Text;

            controlador = controladores[tipo];

            ConfigurarToolbox();

            ConfigurarListagem();
        }

        private void ConfigurarToolbox()
        {
            ConfiguracaoToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                toolbox.Enabled = true;

                labelTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            panelRegistros.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagemControl);
        }

        private void InicializarControladores()
        {
            var repositorioDisciplina = new RepositorioDisciplinaEmArquivo(contextoDados);
            var repositorioMateria = new RepositorioMateriaEmArquivo(contextoDados);
            var repositorioQuestao = new RepositorioQuestaoObjetivaEmArquivo(contextoDados);
            var repositorioTeste = new RepositorioTesteEmArquivo(contextoDados);

            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("Disciplina", new ControladorDisciplina(repositorioDisciplina, repositorioMateria));
            controladores.Add("Matéria", new ControladorMateria(repositorioMateria, repositorioDisciplina));
            controladores.Add("Questão", new ControladorQuestao(repositorioQuestao, repositorioMateria, repositorioDisciplina));
            controladores.Add("Teste", new ControladorTeste(repositorioTeste, repositorioQuestao, repositorioMateria, repositorioDisciplina));
        }
    }
}
