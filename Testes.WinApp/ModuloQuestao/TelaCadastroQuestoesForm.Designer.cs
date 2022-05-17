namespace Testes.WinApp.ModuloQuestao
{
    partial class TelaCadastroQuestoesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cmbDisciplinas = new System.Windows.Forms.ComboBox();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbPrimeiroBimestre = new System.Windows.Forms.RadioButton();
            this.rbSegundoBimestre = new System.Windows.Forms.RadioButton();
            this.rbTerceiroBimestre = new System.Windows.Forms.RadioButton();
            this.rbQuartoBimestre = new System.Windows.Forms.RadioButton();
            this.txtEnunciado = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelIdAlternativa = new System.Windows.Forms.Label();
            this.listAlternativas = new System.Windows.Forms.ListBox();
            this.checkBoxAlternativaCorreta = new System.Windows.Forms.CheckBox();
            this.btnAdicionarResposta = new System.Windows.Forms.Button();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(47, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disciplina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(57, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matéria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(41, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enunciado:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(168, 42);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(63, 26);
            this.txtNumero.TabIndex = 4;
            // 
            // cmbDisciplinas
            // 
            this.cmbDisciplinas.DisplayMember = "Nome";
            this.cmbDisciplinas.FormattingEnabled = true;
            this.cmbDisciplinas.Location = new System.Drawing.Point(168, 94);
            this.cmbDisciplinas.Name = "cmbDisciplinas";
            this.cmbDisciplinas.Size = new System.Drawing.Size(240, 27);
            this.cmbDisciplinas.TabIndex = 6;
            this.cmbDisciplinas.SelectedValueChanged += new System.EventHandler(this.cmbDisciplinas_SelectedValueChanged);
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.DisplayMember = "Nome";
            this.cmbMaterias.Enabled = false;
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(168, 147);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(240, 27);
            this.cmbMaterias.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(517, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 53);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.ForeColor = System.Drawing.Color.Navy;
            this.btnGravar.Location = new System.Drawing.Point(402, 627);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(97, 53);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(54, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bimestre:";
            // 
            // rbPrimeiroBimestre
            // 
            this.rbPrimeiroBimestre.AutoSize = true;
            this.rbPrimeiroBimestre.ForeColor = System.Drawing.Color.Navy;
            this.rbPrimeiroBimestre.Location = new System.Drawing.Point(173, 197);
            this.rbPrimeiroBimestre.Name = "rbPrimeiroBimestre";
            this.rbPrimeiroBimestre.Size = new System.Drawing.Size(98, 23);
            this.rbPrimeiroBimestre.TabIndex = 13;
            this.rbPrimeiroBimestre.TabStop = true;
            this.rbPrimeiroBimestre.Text = "1º Bimestre";
            this.rbPrimeiroBimestre.UseVisualStyleBackColor = true;
            // 
            // rbSegundoBimestre
            // 
            this.rbSegundoBimestre.AutoSize = true;
            this.rbSegundoBimestre.ForeColor = System.Drawing.Color.Navy;
            this.rbSegundoBimestre.Location = new System.Drawing.Point(173, 226);
            this.rbSegundoBimestre.Name = "rbSegundoBimestre";
            this.rbSegundoBimestre.Size = new System.Drawing.Size(98, 23);
            this.rbSegundoBimestre.TabIndex = 14;
            this.rbSegundoBimestre.TabStop = true;
            this.rbSegundoBimestre.Text = "2º Bimestre";
            this.rbSegundoBimestre.UseVisualStyleBackColor = true;
            // 
            // rbTerceiroBimestre
            // 
            this.rbTerceiroBimestre.AutoSize = true;
            this.rbTerceiroBimestre.ForeColor = System.Drawing.Color.Navy;
            this.rbTerceiroBimestre.Location = new System.Drawing.Point(310, 198);
            this.rbTerceiroBimestre.Name = "rbTerceiroBimestre";
            this.rbTerceiroBimestre.Size = new System.Drawing.Size(98, 23);
            this.rbTerceiroBimestre.TabIndex = 15;
            this.rbTerceiroBimestre.TabStop = true;
            this.rbTerceiroBimestre.Text = "3º Bimestre";
            this.rbTerceiroBimestre.UseVisualStyleBackColor = true;
            // 
            // rbQuartoBimestre
            // 
            this.rbQuartoBimestre.AutoSize = true;
            this.rbQuartoBimestre.ForeColor = System.Drawing.Color.Navy;
            this.rbQuartoBimestre.Location = new System.Drawing.Point(310, 228);
            this.rbQuartoBimestre.Name = "rbQuartoBimestre";
            this.rbQuartoBimestre.Size = new System.Drawing.Size(98, 23);
            this.rbQuartoBimestre.TabIndex = 16;
            this.rbQuartoBimestre.TabStop = true;
            this.rbQuartoBimestre.Text = "4º Bimestre";
            this.rbQuartoBimestre.UseVisualStyleBackColor = true;
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Location = new System.Drawing.Point(168, 286);
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(447, 59);
            this.txtEnunciado.TabIndex = 17;
            this.txtEnunciado.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelIdAlternativa);
            this.groupBox1.Controls.Add(this.listAlternativas);
            this.groupBox1.Controls.Add(this.checkBoxAlternativaCorreta);
            this.groupBox1.Controls.Add(this.btnAdicionarResposta);
            this.groupBox1.Controls.Add(this.txtResposta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(26, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 270);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alternativas";
            // 
            // labelIdAlternativa
            // 
            this.labelIdAlternativa.AutoSize = true;
            this.labelIdAlternativa.Location = new System.Drawing.Point(105, 17);
            this.labelIdAlternativa.Name = "labelIdAlternativa";
            this.labelIdAlternativa.Size = new System.Drawing.Size(0, 19);
            this.labelIdAlternativa.TabIndex = 5;
            this.labelIdAlternativa.Visible = false;
            // 
            // listAlternativas
            // 
            this.listAlternativas.DisplayMember = "Resposta";
            this.listAlternativas.FormattingEnabled = true;
            this.listAlternativas.ItemHeight = 19;
            this.listAlternativas.Location = new System.Drawing.Point(6, 111);
            this.listAlternativas.Name = "listAlternativas";
            this.listAlternativas.Size = new System.Drawing.Size(599, 137);
            this.listAlternativas.TabIndex = 4;
            this.listAlternativas.Click += new System.EventHandler(this.listAlternativas_Click);
            // 
            // checkBoxAlternativaCorreta
            // 
            this.checkBoxAlternativaCorreta.AutoSize = true;
            this.checkBoxAlternativaCorreta.Location = new System.Drawing.Point(105, 82);
            this.checkBoxAlternativaCorreta.Name = "checkBoxAlternativaCorreta";
            this.checkBoxAlternativaCorreta.Size = new System.Drawing.Size(144, 23);
            this.checkBoxAlternativaCorreta.TabIndex = 3;
            this.checkBoxAlternativaCorreta.Text = "Alternativa Correta";
            this.checkBoxAlternativaCorreta.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarResposta
            // 
            this.btnAdicionarResposta.Location = new System.Drawing.Point(501, 31);
            this.btnAdicionarResposta.Name = "btnAdicionarResposta";
            this.btnAdicionarResposta.Size = new System.Drawing.Size(88, 40);
            this.btnAdicionarResposta.TabIndex = 2;
            this.btnAdicionarResposta.Text = "Adicionar";
            this.btnAdicionarResposta.UseVisualStyleBackColor = true;
            this.btnAdicionarResposta.Click += new System.EventHandler(this.btnAdicionarResposta_Click);
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(105, 39);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(390, 26);
            this.txtResposta.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Resposta:";
            // 
            // TelaCadastroQuestoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEnunciado);
            this.Controls.Add(this.rbQuartoBimestre);
            this.Controls.Add(this.rbTerceiroBimestre);
            this.Controls.Add(this.rbSegundoBimestre);
            this.Controls.Add(this.rbPrimeiroBimestre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.cmbMaterias);
            this.Controls.Add(this.cmbDisciplinas);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroQuestoesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tela de Cadastro de Questões";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cmbDisciplinas;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbPrimeiroBimestre;
        private System.Windows.Forms.RadioButton rbSegundoBimestre;
        private System.Windows.Forms.RadioButton rbTerceiroBimestre;
        private System.Windows.Forms.RadioButton rbQuartoBimestre;
        private System.Windows.Forms.RichTextBox txtEnunciado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionarResposta;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listAlternativas;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBoxAlternativaCorreta;
        private System.Windows.Forms.Label labelIdAlternativa;
    }
}