namespace Testes.WinApp.ModutoTeste
{
    partial class TelaCadastroTestesForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtQtdQuestoes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.checkBoxRecuperacao = new System.Windows.Forms.CheckBox();
            this.cmbDisciplinas = new System.Windows.Forms.ComboBox();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.btnSortearQuestoes = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listQuestoesSorteadas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(110, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(126, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(103, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Disciplina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(113, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Matéria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(7, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade de Questões:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(213, 50);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(41, 26);
            this.txtNumero.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(213, 99);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(169, 26);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtQtdQuestoes
            // 
            this.txtQtdQuestoes.Location = new System.Drawing.Point(213, 248);
            this.txtQtdQuestoes.Name = "txtQtdQuestoes";
            this.txtQtdQuestoes.Size = new System.Drawing.Size(45, 26);
            this.txtQtdQuestoes.TabIndex = 7;
            this.txtQtdQuestoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdQuestoes_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(402, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data:";
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(459, 52);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(96, 26);
            this.dtData.TabIndex = 9;
            // 
            // checkBoxRecuperacao
            // 
            this.checkBoxRecuperacao.AutoSize = true;
            this.checkBoxRecuperacao.ForeColor = System.Drawing.Color.Navy;
            this.checkBoxRecuperacao.Location = new System.Drawing.Point(402, 102);
            this.checkBoxRecuperacao.Name = "checkBoxRecuperacao";
            this.checkBoxRecuperacao.Size = new System.Drawing.Size(169, 23);
            this.checkBoxRecuperacao.TabIndex = 10;
            this.checkBoxRecuperacao.Text = "Prova de Recuperação?";
            this.checkBoxRecuperacao.UseVisualStyleBackColor = true;
            this.checkBoxRecuperacao.CheckedChanged += new System.EventHandler(this.checkBoxRecuperacao_CheckedChanged);
            // 
            // cmbDisciplinas
            // 
            this.cmbDisciplinas.DisplayMember = "Nome";
            this.cmbDisciplinas.FormattingEnabled = true;
            this.cmbDisciplinas.Location = new System.Drawing.Point(213, 148);
            this.cmbDisciplinas.Name = "cmbDisciplinas";
            this.cmbDisciplinas.Size = new System.Drawing.Size(169, 27);
            this.cmbDisciplinas.TabIndex = 11;
            this.cmbDisciplinas.SelectedValueChanged += new System.EventHandler(this.cmbDisciplinas_SelectedValueChanged);
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.DisplayMember = "Nome";
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(213, 198);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(169, 27);
            this.cmbMaterias.TabIndex = 12;
            // 
            // btnSortearQuestoes
            // 
            this.btnSortearQuestoes.ForeColor = System.Drawing.Color.Navy;
            this.btnSortearQuestoes.Location = new System.Drawing.Point(25, 574);
            this.btnSortearQuestoes.Name = "btnSortearQuestoes";
            this.btnSortearQuestoes.Size = new System.Drawing.Size(134, 55);
            this.btnSortearQuestoes.TabIndex = 14;
            this.btnSortearQuestoes.Text = "Sortear Questões";
            this.btnSortearQuestoes.UseVisualStyleBackColor = true;
            this.btnSortearQuestoes.Click += new System.EventHandler(this.btnSortearQuestoes_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.ForeColor = System.Drawing.Color.Navy;
            this.btnGravar.Location = new System.Drawing.Point(331, 574);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(134, 55);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.Location = new System.Drawing.Point(471, 574);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 55);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // listQuestoesSorteadas
            // 
            this.listQuestoesSorteadas.DisplayMember = "Enunciado";
            this.listQuestoesSorteadas.FormattingEnabled = true;
            this.listQuestoesSorteadas.ItemHeight = 19;
            this.listQuestoesSorteadas.Location = new System.Drawing.Point(25, 306);
            this.listQuestoesSorteadas.Name = "listQuestoesSorteadas";
            this.listQuestoesSorteadas.Size = new System.Drawing.Size(580, 251);
            this.listQuestoesSorteadas.TabIndex = 17;
            // 
            // TelaCadastroTestesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 661);
            this.Controls.Add(this.listQuestoesSorteadas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnSortearQuestoes);
            this.Controls.Add(this.cmbMaterias);
            this.Controls.Add(this.cmbDisciplinas);
            this.Controls.Add(this.checkBoxRecuperacao);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQtdQuestoes);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroTestesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tela de Cadastro de Testes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtQtdQuestoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbDisciplinas;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.Button btnSortearQuestoes;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.CheckBox checkBoxRecuperacao;
        private System.Windows.Forms.ListBox listQuestoesSorteadas;
    }
}