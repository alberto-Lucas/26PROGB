namespace AppTeoria
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.cbbExrcicios = new System.Windows.Forms.ComboBox();
            this.btnIF = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnForIncremento = new System.Windows.Forms.Button();
            this.btnForDecremento = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lstLoop = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSoNumero = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultadoMF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMetodo = new System.Windows.Forms.Button();
            this.btnFuncao = new System.Windows.Forms.Button();
            this.btnFuncao2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // cbbExrcicios
            // 
            this.cbbExrcicios.FormattingEnabled = true;
            this.cbbExrcicios.Items.AddRange(new object[] {
            "LEGPRESS",
            "ADUTORA",
            "ABDUTORA",
            "SUPINO",
            "ROSCA"});
            this.cbbExrcicios.Location = new System.Drawing.Point(12, 12);
            this.cbbExrcicios.Name = "cbbExrcicios";
            this.cbbExrcicios.Size = new System.Drawing.Size(225, 21);
            this.cbbExrcicios.TabIndex = 0;
            // 
            // btnIF
            // 
            this.btnIF.Location = new System.Drawing.Point(12, 39);
            this.btnIF.Name = "btnIF";
            this.btnIF.Size = new System.Drawing.Size(75, 23);
            this.btnIF.TabIndex = 1;
            this.btnIF.Text = "IF";
            this.btnIF.UseVisualStyleBackColor = true;
            this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(12, 68);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "SWITCH";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnForIncremento
            // 
            this.btnForIncremento.Location = new System.Drawing.Point(12, 114);
            this.btnForIncremento.Name = "btnForIncremento";
            this.btnForIncremento.Size = new System.Drawing.Size(131, 23);
            this.btnForIncremento.TabIndex = 3;
            this.btnForIncremento.Text = "FOR INCREMENTO";
            this.btnForIncremento.UseVisualStyleBackColor = true;
            this.btnForIncremento.Click += new System.EventHandler(this.btnForIncremento_Click);
            // 
            // btnForDecremento
            // 
            this.btnForDecremento.Location = new System.Drawing.Point(12, 143);
            this.btnForDecremento.Name = "btnForDecremento";
            this.btnForDecremento.Size = new System.Drawing.Size(131, 23);
            this.btnForDecremento.TabIndex = 4;
            this.btnForDecremento.Text = "FOR DECREMENTO";
            this.btnForDecremento.UseVisualStyleBackColor = true;
            this.btnForDecremento.Click += new System.EventHandler(this.btnForDecremento_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(12, 201);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(131, 23);
            this.btnDoWhile.TabIndex = 6;
            this.btnDoWhile.Text = "DO WHILE";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(12, 172);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(131, 23);
            this.btnWhile.TabIndex = 5;
            this.btnWhile.Text = "WHILE";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 230);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(131, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lstLoop
            // 
            this.lstLoop.FormattingEnabled = true;
            this.lstLoop.Location = new System.Drawing.Point(149, 114);
            this.lstLoop.Name = "lstLoop";
            this.lstLoop.Size = new System.Drawing.Size(88, 147);
            this.lstLoop.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(287, 28);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 10;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(287, 117);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Resultado";
            // 
            // btnSoNumero
            // 
            this.btnSoNumero.Location = new System.Drawing.Point(287, 68);
            this.btnSoNumero.Name = "btnSoNumero";
            this.btnSoNumero.Size = new System.Drawing.Size(100, 23);
            this.btnSoNumero.TabIndex = 13;
            this.btnSoNumero.Text = "SÓ NÚMERO";
            this.btnSoNumero.UseVisualStyleBackColor = true;
            this.btnSoNumero.Click += new System.EventHandler(this.btnSoNumero_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(287, 172);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Valor 1:";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(287, 217);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Valor 2:";
            // 
            // txtResultadoMF
            // 
            this.txtResultadoMF.Location = new System.Drawing.Point(287, 262);
            this.txtResultadoMF.Name = "txtResultadoMF";
            this.txtResultadoMF.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoMF.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Resultado:";
            // 
            // btnMetodo
            // 
            this.btnMetodo.Location = new System.Drawing.Point(393, 172);
            this.btnMetodo.Name = "btnMetodo";
            this.btnMetodo.Size = new System.Drawing.Size(100, 23);
            this.btnMetodo.TabIndex = 20;
            this.btnMetodo.Text = "MÉTODO";
            this.btnMetodo.UseVisualStyleBackColor = true;
            this.btnMetodo.Click += new System.EventHandler(this.btnMetodo_Click);
            // 
            // btnFuncao
            // 
            this.btnFuncao.Location = new System.Drawing.Point(393, 215);
            this.btnFuncao.Name = "btnFuncao";
            this.btnFuncao.Size = new System.Drawing.Size(100, 23);
            this.btnFuncao.TabIndex = 21;
            this.btnFuncao.Text = "FUNÇÃO";
            this.btnFuncao.UseVisualStyleBackColor = true;
            this.btnFuncao.Click += new System.EventHandler(this.btnFuncao_Click);
            // 
            // btnFuncao2
            // 
            this.btnFuncao2.Location = new System.Drawing.Point(393, 260);
            this.btnFuncao2.Name = "btnFuncao2";
            this.btnFuncao2.Size = new System.Drawing.Size(100, 23);
            this.btnFuncao2.TabIndex = 22;
            this.btnFuncao2.Text = "FUNÇÃO 2";
            this.btnFuncao2.UseVisualStyleBackColor = true;
            this.btnFuncao2.Click += new System.EventHandler(this.btnFuncao2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 358);
            this.Controls.Add(this.btnFuncao2);
            this.Controls.Add(this.btnFuncao);
            this.Controls.Add(this.btnMetodo);
            this.Controls.Add(this.txtResultadoMF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSoNumero);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLoop);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnForDecremento);
            this.Controls.Add(this.btnForIncremento);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnIF);
            this.Controls.Add(this.cbbExrcicios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ComboBox cbbExrcicios;
        private System.Windows.Forms.Button btnIF;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnForIncremento;
        private System.Windows.Forms.Button btnForDecremento;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox lstLoop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSoNumero;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultadoMF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMetodo;
        private System.Windows.Forms.Button btnFuncao;
        private System.Windows.Forms.Button btnFuncao2;
    }
}

