using System.Collections.Generic;
using System.Windows.Forms;
using Testes.Dominio.ModuloQuestao;
using Testes.WinApp.Compartilhado;

namespace Testes.WinApp.ModuloQuestao
{
    public partial class TabelaQuestoesControl : UserControl
    {
        public TabelaQuestoesControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina" },

                new DataGridViewTextBoxColumn { DataPropertyName = "Matéria", HeaderText = "Matéria" },

                new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado" },

                new DataGridViewTextBoxColumn { DataPropertyName = "Bimestre", HeaderText = "Bimestre" }
            };

            return colunas;
        }

        public int ObtemNumeroQuestaoSelecionada()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<QuestaoObjetiva> questoes)
        {
            grid.Rows.Clear();

            foreach (var questao in questoes)
            {
                grid.Rows.Add(questao.Numero, questao.Disciplina.Nome, questao.Materia.Nome, 
                    questao.Enunciado, questao.Bimestre);
            }
        }
    }
}
