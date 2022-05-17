using System.Collections.Generic;
using System.Windows.Forms;
using Testes.Dominio.ModuloDisciplina;
using Testes.Dominio.ModuloMateria;
using Testes.Dominio.ModuloQuestao;
using Testes.Dominio.ModuloTeste;
using Testes.WinApp.Compartilhado;
using System.Text;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;

namespace Testes.WinApp.ModutoTeste
{
    public class ControladorTeste : ControladorBase
    {
        private readonly IRepositorioTeste _repositorioTeste;
        private readonly IRepositorioQuestaoObjetiva _repositorioQuestao;
        private readonly IRepositorioMateria _repositorioMateria;
        private readonly IRepositorioDisciplina _repositorioDisciplina;
        private TabelaTestesControl tabelaTestes;

        public ControladorTeste(IRepositorioTeste repositorioTeste, IRepositorioQuestaoObjetiva repositorioQuestao,
            IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            _repositorioTeste = repositorioTeste;
            _repositorioQuestao = repositorioQuestao;
            _repositorioMateria = repositorioMateria;
            _repositorioDisciplina = repositorioDisciplina;
        }

        public override void Inserir()
        {
            var questoes = _repositorioQuestao.SelecionarTodos();
            var disciplinas = _repositorioDisciplina.SelecionarTodos();
            var materias = _repositorioMateria.SelecionarTodos();

            TelaCadastroTestesForm tela = new TelaCadastroTestesForm(disciplinas, materias, questoes);
            tela.Teste = new Teste();

            tela.GravarRegistro = _repositorioTeste.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTestes();
            }
        }

        public override void Editar()
        {
            var testeSelecionado = ObtemTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um Teste primeiro",
                "Edição de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var questoes = _repositorioQuestao.SelecionarTodos();
            var disciplinas = _repositorioDisciplina.SelecionarTodos();
            var materias = _repositorioMateria.SelecionarTodos();

            TelaCadastroTestesForm tela = new TelaCadastroTestesForm(disciplinas, materias, questoes);

            tela.Teste = testeSelecionado;

            tela.GravarRegistro = _repositorioTeste.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTestes();
            }
        }

        public void Duplicar()
        {
            var testeSelecionado = ObtemTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um Teste primeiro",
                "Duplicação de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var questoes = _repositorioQuestao.SelecionarTodos();
            var disciplinas = _repositorioDisciplina.SelecionarTodos();
            var materias = _repositorioMateria.SelecionarTodos();

            TelaCadastroTestesForm tela = new TelaCadastroTestesForm(disciplinas, materias, questoes);

            tela.Teste = testeSelecionado.Clone();

            tela.GravarRegistro = _repositorioTeste.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTestes();
            }
        }

        public void GerarPdf()
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var testeSelecionado = ObtemTesteSelecionado();

                if (testeSelecionado == null)
                {
                    MessageBox.Show("Selecione um Teste primeiro",
                    "Edição de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                var page = doc.AddPage();
                var graphics = XGraphics.FromPdfPage(page);
                var textFormatter = new XTextFormatter(graphics);
                var fontTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var fontCorpo = new XFont("Arial", 14);

                XRect rect = new XRect(0, 50, page.Width, page.Height);
                textFormatter.Alignment = XParagraphAlignment.Center;
                textFormatter.DrawString(($"Teste: {testeSelecionado.Titulo}"),
                    fontTitulo, XBrushes.Navy, rect,XStringFormats.TopLeft);

                XRect rect1 = new XRect(50, 100, page.Width, page.Height);
                textFormatter.Alignment = XParagraphAlignment.Left;
                textFormatter.DrawString("Disciplina:",
                    fontTitulo, XBrushes.Black, rect1, XStringFormats.TopLeft);

                XRect rect2 = new XRect(125, 100, page.Width, page.Height);
                textFormatter.Alignment = XParagraphAlignment.Left;
                textFormatter.DrawString(testeSelecionado.Disciplina.Nome,
                    fontCorpo, XBrushes.Black, rect2, XStringFormats.TopLeft);

                XRect rect3 = new XRect(50, 125, page.Width, page.Height);
                textFormatter.Alignment = XParagraphAlignment.Left;
                textFormatter.DrawString("Matéria:",
                    fontTitulo, XBrushes.Black, rect3, XStringFormats.TopLeft);

                XRect rect4 = new XRect(105, 125, page.Width, page.Height);
                textFormatter.Alignment = XParagraphAlignment.Left;
                textFormatter.DrawString(testeSelecionado.Materia.Nome,
                    fontCorpo, XBrushes.Black, rect4, XStringFormats.TopLeft);

                XRect rect5 = new XRect(50, 150, page.Width, page.Height);
                textFormatter.Alignment = XParagraphAlignment.Left;
                textFormatter.DrawString("Data:",
                    fontTitulo, XBrushes.Black, rect5, XStringFormats.TopLeft);

                XRect rect6 = new XRect(85, 150, page.Width, page.Height);
                textFormatter.Alignment = XParagraphAlignment.Left;
                textFormatter.DrawString(testeSelecionado.Data.ToShortDateString(),
                    fontCorpo, XBrushes.Black, rect6, XStringFormats.TopLeft);

                XRect rect7 = new XRect(50, 200, page.Width, page.Height);
                textFormatter.Alignment = XParagraphAlignment.Left;
                textFormatter.DrawString(("Questões: "),
                    fontTitulo, XBrushes.Navy, rect7, XStringFormats.TopLeft);

                var y = 200;
                var numeroQuestao = 1;
                foreach (var questao in testeSelecionado.QuestoesObjetivas)
                {
                    XRect rect8 = new XRect(50, y += 40, page.Width, page.Height);
                    textFormatter.Alignment = XParagraphAlignment.Left;
                    textFormatter.DrawString($"{numeroQuestao}. {questao.Enunciado.ToString()}",
                        fontTitulo, XBrushes.Black, rect8, XStringFormats.TopLeft);

                    foreach (var alternativa in questao.Alternativas)
                    {
                        XRect rect9 = new XRect(75, y += 25, page.Width, page.Height);
                        textFormatter.Alignment = XParagraphAlignment.Left;
                        textFormatter.DrawString(alternativa.Resposta.ToString(),
                            fontCorpo, XBrushes.Black, rect9, XStringFormats.TopLeft);
                    }                 
                    
                    numeroQuestao++;
                }

                doc.Save(@"C:\temp\Testes.pdf");

                MessageBox.Show("Arquivo Gerado com Sucesso!",
                    "Gerando PDF de Testes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        public override void Excluir()
        {
            Teste TesteSelecionado = ObtemTesteSelecionado();

            if (TesteSelecionado == null)
            {
                MessageBox.Show("Selecione um Teste primeiro",
                "Exclusão de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o Teste?",
                "Exclusão de Testes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioTeste.Excluir(TesteSelecionado);
                CarregarTestes();
            }
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaTestes == null)
                tabelaTestes = new TabelaTestesControl();

            CarregarTestes();

            return tabelaTestes;
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxTeste();
        }


        private Teste ObtemTesteSelecionado()
        {
            var numero = tabelaTestes.ObtemNumeroTesteSelecionado();

            return _repositorioTeste.SelecionarPorNumero(numero);
        }

        private void CarregarTestes()
        {
            List<Teste> testes = _repositorioTeste.SelecionarTodos();

            tabelaTestes.AtualizarRegistros(testes);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {testes.Count} Teste(s)");
        }

    }
}
