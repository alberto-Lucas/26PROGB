namespace AppCadastro
{
    partial class frmMovimentacao
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
            this.lblMovimentacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMovimentacao
            // 
            this.lblMovimentacao.BackColor = System.Drawing.Color.Gray;
            this.lblMovimentacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimentacao.Location = new System.Drawing.Point(0, 0);
            this.lblMovimentacao.Name = "lblMovimentacao";
            this.lblMovimentacao.Size = new System.Drawing.Size(585, 55);
            this.lblMovimentacao.TabIndex = 0;
            this.lblMovimentacao.Text = "label1";
            this.lblMovimentacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 234);
            this.Controls.Add(this.lblMovimentacao);
            this.Name = "frmMovimentacao";
            this.Text = "frmMovimentacao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMovimentacao;
    }
}