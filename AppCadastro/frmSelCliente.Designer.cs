namespace AppCadastro
{
    partial class frmSelCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstRegistros = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDtNascimento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar por Nome:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(12, 25);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(286, 20);
            this.txtPesquisa.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(304, 23);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registros:";
            // 
            // lstRegistros
            // 
            this.lstRegistros.FormattingEnabled = true;
            this.lstRegistros.Location = new System.Drawing.Point(12, 77);
            this.lstRegistros.Name = "lstRegistros";
            this.lstRegistros.Size = new System.Drawing.Size(367, 95);
            this.lstRegistros.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRG);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDtNascimento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(182, 83);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(179, 20);
            this.txtRG.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "RG:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(6, 83);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(170, 20);
            this.txtCPF.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF:";
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Location = new System.Drawing.Point(241, 42);
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.Size = new System.Drawing.Size(120, 20);
            this.txtDtNascimento.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data Nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(229, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(304, 297);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(223, 297);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // frmSelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 327);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelCliente";
            this.Text = "Seleção de Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstRegistros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDtNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVisualizar;
    }
}