namespace AppManipulaArquivo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTextoArquivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diretório:";
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(15, 25);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(361, 20);
            this.txtDiretorio.TabIndex = 1;
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Location = new System.Drawing.Point(15, 73);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(361, 20);
            this.txtNomeArquivo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Arquivo:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(15, 128);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(442, 111);
            this.txtTexto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Texto:";
            // 
            // txtTextoArquivo
            // 
            this.txtTextoArquivo.Location = new System.Drawing.Point(15, 302);
            this.txtTextoArquivo.Multiline = true;
            this.txtTextoArquivo.Name = "txtTextoArquivo";
            this.txtTextoArquivo.Size = new System.Drawing.Size(442, 84);
            this.txtTextoArquivo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Texto Arquivo:";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(382, 23);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 8;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(382, 71);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 9;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(15, 245);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(96, 245);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(12, 392);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 12;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Selecione uma pasta para salvar o arquivo de texto.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 427);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.txtTextoArquivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiretorio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTextoArquivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

