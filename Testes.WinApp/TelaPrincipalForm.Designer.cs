namespace Testes.WinApp
{
    partial class TelaPrincipalForm
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
            this.toolbox = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questaoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDuplicar = new System.Windows.Forms.ToolStripButton();
            this.btnGerarPdf = new System.Windows.Forms.ToolStripButton();
            this.toolbox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbox
            // 
            this.toolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.toolbox.Location = new System.Drawing.Point(0, 0);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(1003, 33);
            this.toolbox.TabIndex = 0;
            this.toolbox.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinaMenuItem,
            this.materiaMenuItem,
            this.questaoMenuItem,
            this.testeMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // disciplinaMenuItem
            // 
            this.disciplinaMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.disciplinaMenuItem.Name = "disciplinaMenuItem";
            this.disciplinaMenuItem.Size = new System.Drawing.Size(167, 30);
            this.disciplinaMenuItem.Text = "Disciplina";
            this.disciplinaMenuItem.Click += new System.EventHandler(this.disciplinaMenuItem_Click);
            // 
            // materiaMenuItem
            // 
            this.materiaMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.materiaMenuItem.Name = "materiaMenuItem";
            this.materiaMenuItem.Size = new System.Drawing.Size(167, 30);
            this.materiaMenuItem.Text = "Matéria";
            this.materiaMenuItem.Click += new System.EventHandler(this.materiaMenuItem_Click);
            // 
            // questaoMenuItem
            // 
            this.questaoMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.questaoMenuItem.Name = "questaoMenuItem";
            this.questaoMenuItem.Size = new System.Drawing.Size(167, 30);
            this.questaoMenuItem.Text = "Questão";
            this.questaoMenuItem.Click += new System.EventHandler(this.questaoMenuItem_Click);
            // 
            // testeMenuItem
            // 
            this.testeMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.testeMenuItem.Name = "testeMenuItem";
            this.testeMenuItem.Size = new System.Drawing.Size(167, 30);
            this.testeMenuItem.Text = "Teste";
            this.testeMenuItem.Click += new System.EventHandler(this.testeMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodape});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1003, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(60, 19);
            this.labelRodape.Text = "[rodapé]";
            // 
            // panelRegistros
            // 
            this.panelRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistros.Location = new System.Drawing.Point(0, 58);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(1003, 369);
            this.panelRegistros.TabIndex = 3;
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserir.Image = global::Testes.WinApp.Properties.Resources.outline_add_circle_outline_black_24dp;
            this.btnInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(28, 28);
            this.btnInserir.Text = "Inserir";
            this.btnInserir.ToolTipText = "Inserir";
            this.btnInserir.Visible = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::Testes.WinApp.Properties.Resources.outline_mode_edit_black_24dp;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(28, 28);
            this.btnEditar.Text = "toolStripButton1";
            this.btnEditar.ToolTipText = "Editar";
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::Testes.WinApp.Properties.Resources.outline_delete_black_24dp;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(28, 28);
            this.btnExcluir.Text = "toolStripButton1";
            this.btnExcluir.ToolTipText = "Excluir";
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.ActiveLinkColor = System.Drawing.Color.Navy;
            this.labelTipoCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTipoCadastro.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(115, 22);
            this.labelTipoCadastro.Text = "[tipoCadastro]";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnExcluir,
            this.btnDuplicar,
            this.btnGerarPdf,
            this.labelTipoCadastro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1003, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDuplicar
            // 
            this.btnDuplicar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDuplicar.Image = global::Testes.WinApp.Properties.Resources.file_copy_FILL0_wght400_GRAD0_opsz24__1_;
            this.btnDuplicar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDuplicar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuplicar.Name = "btnDuplicar";
            this.btnDuplicar.Size = new System.Drawing.Size(28, 28);
            this.btnDuplicar.Text = "toolStripButton1";
            this.btnDuplicar.Visible = false;
            this.btnDuplicar.Click += new System.EventHandler(this.btnDuplicar_Click);
            // 
            // btnGerarPdf
            // 
            this.btnGerarPdf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGerarPdf.Image = global::Testes.WinApp.Properties.Resources.picture_as_pdf_FILL0_wght400_GRAD0_opsz24__1_;
            this.btnGerarPdf.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGerarPdf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGerarPdf.Name = "btnGerarPdf";
            this.btnGerarPdf.Size = new System.Drawing.Size(28, 28);
            this.btnGerarPdf.Text = "toolStripButton2";
            this.btnGerarPdf.Visible = false;
            this.btnGerarPdf.Click += new System.EventHandler(this.btnGerarPdf_Click);
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 451);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.toolbox;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipalForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Testes";
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip toolbox;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questaoMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelRegistros;
        private System.Windows.Forms.ToolStripStatusLabel labelRodape;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripLabel labelTipoCadastro;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDuplicar;
        private System.Windows.Forms.ToolStripButton btnGerarPdf;
    }
}