using FluentValidation.Results;
using System;
using System.Windows.Forms;
using Testes.Dominio.ModuloDisciplina;

namespace Testes.WinApp.ModuloDisciplina
{
    public partial class TelaCadastroDisciplinasForm : Form
    {
        private Disciplina _disciplina;
        private IRepositorioDisciplina _repositorioDisciplina;


        public TelaCadastroDisciplinasForm(IRepositorioDisciplina repositorioDisciplina)
        {
            InitializeComponent();

            _repositorioDisciplina = repositorioDisciplina;
        }


        public Func<Disciplina, ValidationResult> GravarRegistro { get; set; }

        public Disciplina Disciplina
        {
            get { return _disciplina; }
            set
            {
                _disciplina = value;

                txtNumero.Text = _disciplina.Numero.ToString();
                txtNome.Text = _disciplina.Nome;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            _disciplina.Nome = txtNome.Text;

            if (_repositorioDisciplina.DisciplinaJaExiste(_disciplina.Nome))
            {
                MessageBox.Show("Já existe uma disciplina com este nome.",
                    "Inserindo Disciplina",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
            }
            else
            {
                var resultadoValidacao = GravarRegistro(_disciplina);

                if (resultadoValidacao.IsValid == false)
                {
                    string erro = resultadoValidacao.Errors[0].ErrorMessage;

                    TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                    DialogResult = DialogResult.None;
                }
            }
        }

        private void TelaCadastroDisciplinasForm_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroDisciplinasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }
    }
}
