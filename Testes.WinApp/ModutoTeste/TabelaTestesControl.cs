using System.Collections.Generic;
using System.Windows.Forms;
using Testes.Dominio.ModuloTeste;
using Testes.WinApp.Compartilhado;

namespace Testes.WinApp.ModutoTeste
{
    public partial class TabelaTestesControl : UserControl
    {
        public TabelaTestesControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Número", HeaderText = "Número"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Título", HeaderText = "Título"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina" },

                new DataGridViewTextBoxColumn { DataPropertyName = "Matéria", HeaderText = "Matéria" },

                new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade de Questões", HeaderText = "Quantidade de Questões" }
            };

            return colunas;
        }

        public int ObtemNumeroTesteSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Teste> testes)
        {
            grid.Rows.Clear();

            foreach (var teste in testes)
            {
                var textoMateria = teste.Materia == null ? "Todas" : teste.Materia.Nome;

                grid.Rows.Add(teste.Numero, teste.Titulo, teste.Data.ToString(),
                    teste.Disciplina.Nome, textoMateria, teste.NumeroQuestoes);
            }
        }
    }
}
