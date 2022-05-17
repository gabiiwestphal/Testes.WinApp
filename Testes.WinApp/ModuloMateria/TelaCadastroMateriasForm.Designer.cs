namespace Testes.WinApp.ModuloMateria
{
    partial class TelaCadastroMateriasForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbDisciplinas = new System.Windows.Forms.ComboBox();
            this.rbPrimeiraSerie = new System.Windows.Forms.RadioButton();
            this.rbSegundaSerie = new System.Windows.Forms.RadioButton();
            this.grupoSerie = new System.Windows.Forms.GroupBox();
            this.grupoSerie.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(41, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Disciplina: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(53, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Série:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(315, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.ForeColor = System.Drawing.Color.Navy;
            this.btnGravar.Location = new System.Drawing.Point(200, 208);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(97, 53);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(138, 21);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(82, 26);
            this.txtNumero.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(138, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(222, 26);
            this.txtNome.TabIndex = 7;
            // 
            // cmbDisciplinas
            // 
            this.cmbDisciplinas.DisplayMember = "Nome";
            this.cmbDisciplinas.FormattingEnabled = true;
            this.cmbDisciplinas.Location = new System.Drawing.Point(138, 110);
            this.cmbDisciplinas.Name = "cmbDisciplinas";
            this.cmbDisciplinas.Size = new System.Drawing.Size(121, 27);
            this.cmbDisciplinas.TabIndex = 8;
            // 
            // rbPrimeiraSerie
            // 
            this.rbPrimeiraSerie.AutoSize = true;
            this.rbPrimeiraSerie.ForeColor = System.Drawing.Color.Indigo;
            this.rbPrimeiraSerie.Location = new System.Drawing.Point(8, 25);
            this.rbPrimeiraSerie.Name = "rbPrimeiraSerie";
            this.rbPrimeiraSerie.Size = new System.Drawing.Size(73, 23);
            this.rbPrimeiraSerie.TabIndex = 9;
            this.rbPrimeiraSerie.TabStop = true;
            this.rbPrimeiraSerie.Text = "1ª Série";
            this.rbPrimeiraSerie.UseVisualStyleBackColor = true;
            // 
            // rbSegundaSerie
            // 
            this.rbSegundaSerie.AutoSize = true;
            this.rbSegundaSerie.ForeColor = System.Drawing.Color.Indigo;
            this.rbSegundaSerie.Location = new System.Drawing.Point(122, 25);
            this.rbSegundaSerie.Name = "rbSegundaSerie";
            this.rbSegundaSerie.Size = new System.Drawing.Size(73, 23);
            this.rbSegundaSerie.TabIndex = 10;
            this.rbSegundaSerie.TabStop = true;
            this.rbSegundaSerie.Text = "2ª Série";
            this.rbSegundaSerie.UseVisualStyleBackColor = true;
            // 
            // grupoSerie
            // 
            this.grupoSerie.Controls.Add(this.rbSegundaSerie);
            this.grupoSerie.Controls.Add(this.rbPrimeiraSerie);
            this.grupoSerie.ForeColor = System.Drawing.Color.Navy;
            this.grupoSerie.Location = new System.Drawing.Point(138, 143);
            this.grupoSerie.Name = "grupoSerie";
            this.grupoSerie.Size = new System.Drawing.Size(215, 55);
            this.grupoSerie.TabIndex = 11;
            this.grupoSerie.TabStop = false;
            // 
            // TelaCadastroMateriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 277);
            this.Controls.Add(this.grupoSerie);
            this.Controls.Add(this.cmbDisciplinas);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkOrchid;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroMateriasForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tela de Cadastro de Matérias";
            this.grupoSerie.ResumeLayout(false);
            this.grupoSerie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbDisciplinas;
        private System.Windows.Forms.RadioButton rbPrimeiraSerie;
        private System.Windows.Forms.RadioButton rbSegundaSerie;
        private System.Windows.Forms.GroupBox grupoSerie;
    }
}