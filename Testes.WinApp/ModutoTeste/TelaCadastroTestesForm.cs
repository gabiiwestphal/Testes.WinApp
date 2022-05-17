using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Testes.Dominio.ModuloDisciplina;
using Testes.Dominio.ModuloMateria;
using Testes.Dominio.ModuloQuestao;
using Testes.Dominio.ModuloTeste;

namespace Testes.WinApp.ModutoTeste
{
    public partial class TelaCadastroTestesForm : Form
    {
        private Teste _teste;
        private List<Materia> _materias;
        private List<Disciplina> _disciplinas;
        private List<QuestaoObjetiva> _questoesDisponiveis = new List<QuestaoObjetiva>();
        private List<QuestaoObjetiva> _questoesSorteadas = new List<QuestaoObjetiva>();

        public TelaCadastroTestesForm(List<Disciplina> disciplinas, List<Materia> materias, List<QuestaoObjetiva> questoesDisponiveis)
        {
            InitializeComponent();

            dtData.MinDate = DateTime.Now;

            _materias = materias;
            _disciplinas = disciplinas;
            _questoesDisponiveis = questoesDisponiveis;

            CarregarDisciplinas(disciplinas);
            CarregarMaterias(materias);
        }

        private void CarregarMaterias(List<Materia> materias)
        {
            cmbMaterias.Items.Clear();

            foreach (var item in materias)
            {
                cmbMaterias.Items.Add(item);
            }
        }

        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cmbDisciplinas.Items.Clear();

            foreach (var item in disciplinas)
            {
                cmbDisciplinas.Items.Add(item);
            }
        }

        public Func<Teste, ValidationResult> GravarRegistro { get; set; }

        public Teste Teste
        {
            get { return _teste; }
            set
            {
                _teste = value;

                txtNumero.Text = _teste.Numero.ToString();
                txtTitulo.Text = _teste.Titulo;
                txtQtdQuestoes.Text = _teste.NumeroQuestoes.ToString();
                checkBoxRecuperacao.Checked = _teste.Recuperacao;
                _questoesSorteadas = _teste.QuestoesObjetivas == null ? new List<QuestaoObjetiva>() : _teste.QuestoesObjetivas;

                DefinirMateriaSelecionada();

                DefinirDisciplinaSelecionada();

                CarregarListaQuestoesSorteadas();

                if (_teste.Data > DateTime.MinValue)
                {
                    dtData.MinDate = _teste.Data;
                    dtData.Value = _teste.Data;
                }
            }
        }

        private void CarregarListaQuestoesSorteadas()
        {
            listQuestoesSorteadas.Items.Clear();

            foreach (var questao in _questoesSorteadas)
            {
                listQuestoesSorteadas.Items.Add(questao);
            }
        }

        private void DefinirDisciplinaSelecionada()
        {
            var disciplina = _disciplinas.FirstOrDefault(x => x.Numero == _teste.Disciplina?.Numero);
            cmbDisciplinas.SelectedItem = disciplina;
        }

        private void DefinirMateriaSelecionada()
        {
            var materia = _materias.FirstOrDefault(x => x.Numero == _teste.Materia?.Numero);
            cmbMaterias.SelectedItem = materia;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            _teste.Titulo = txtTitulo.Text;
            _teste.Disciplina = (Disciplina)cmbDisciplinas.SelectedItem;
            _teste.Materia = (Materia)cmbMaterias.SelectedItem;
            _teste.NumeroQuestoes = Convert.ToInt32(txtQtdQuestoes.Text);
            _teste.Data = dtData.Value;
            _teste.Recuperacao = checkBoxRecuperacao.Checked;
            _teste.QuestoesObjetivas = _questoesSorteadas;

            var resultadoValidacao = GravarRegistro(Teste);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }


        private void TelaCadastroQuestoesForm_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroQuestoesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void cmbDisciplinas_SelectedValueChanged(object sender, EventArgs e)
        {
            var disciplina = (Disciplina)cmbDisciplinas.SelectedItem;
            var materiasFiltradas = _materias.Where(x => x.Disciplina.Numero == disciplina.Numero).ToList();

            CarregarMaterias(materiasFiltradas);
            cmbMaterias.Enabled = true;
            DefinirMateriaSelecionada();
        }

        private void txtQtdQuestoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void btnSortearQuestoes_Click(object sender, EventArgs e)
        {
            var questoesFiltradas = new List<QuestaoObjetiva>();
            var disciplina = (Disciplina)cmbDisciplinas.SelectedItem;

            questoesFiltradas = _questoesDisponiveis.Where(x => x.Disciplina.Numero.Equals(disciplina.Numero)).ToList();

            if (checkBoxRecuperacao.Checked == false)
            {
                var materia = (Materia)cmbMaterias.SelectedItem;
                questoesFiltradas = questoesFiltradas.Where(x => x.Materia.Numero.Equals(materia.Numero)).ToList();
            }

            var qtdQuestoes = Convert.ToInt32(txtQtdQuestoes.Text);

            if (qtdQuestoes > questoesFiltradas.Count)
            {
                MessageBox.Show("O número solicitado ultrapassa o número de questões cadastradas.");
            }
            else
            {
                var questoesJaAdicionadas = new List<int>();

                listQuestoesSorteadas.Items.Clear();
                _questoesSorteadas.Clear();

                var random = new Random();
                for (int i = 0; i < qtdQuestoes; i++)
                {
                    var indiceSorteado = random.Next(0, questoesFiltradas.Count);

                    while (questoesJaAdicionadas.Any(x => x == indiceSorteado))
                        indiceSorteado = random.Next(0, qtdQuestoes);

                    var questaoSorteada = questoesFiltradas[indiceSorteado];
                    questoesJaAdicionadas.Add(indiceSorteado);
                    _questoesSorteadas.Add(questaoSorteada);

                    listQuestoesSorteadas.Items.Add(questaoSorteada);
                }
            }
        }

        private void checkBoxRecuperacao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecuperacao.Checked)
            {
                cmbMaterias.Enabled = false;
                cmbMaterias.SelectedIndex = -1;
            }
            else
            {
                cmbMaterias.Enabled = true;
            }
        }
    }
}
