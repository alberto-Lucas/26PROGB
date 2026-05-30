using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Atualizar a imagem de fundo
            AtualizarImagemFundo();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chamar a tela de movimentação no Modo Venda
            //Ou seja vou passar o 0 como parametro
            //Para chamar uma tela, é precisso carrega-la
            //em memoria, ou seja criar uma instancia
            //Para isso vamo definir
            //o Tipo de dado (nome do arquivo da tela)
            //a variavel que recebera a instancia
            //o sinal de igual = para atribuição
            //a palavra reservada new resposavel pela instancia
            //e or ultimo a chamada do método construtor do arquivo
            //sera o mesmo nome do tipo de dados com a adição do parenteses
            //no final
            //ex: frmTela variavel = new frmTela();
            frmMovimentacao frm = new frmMovimentacao(0);
            //Para chamar a tela basta utilizar a variavel
            //e definir o a abertura
            //Show = abrir a tela separadamente
            //ShowDialog = abrir a tela vinculada a anterior
            frm.Show();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chamar a tela em modo de orçamento
            frmMovimentacao frm = new frmMovimentacao(1);
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chamar a tela de cliente
            //Sem parametros e como ShowDialog, travando a tela de fundo
            frmCadCliente frm = new frmCadCliente();
            frm.ShowDialog();
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chamar a tela de configurações
            frmConfiguracoes frm = new frmConfiguracoes();
            frm.ShowDialog();
            //Assim que configurar a nova imagem
            //ja atualizo a tela principal
            AtualizarImagemFundo();
        }

        //Método para atualizar a imagem de fundo
        void AtualizarImagemFundo()
        {
            //Para não precisar programar todo o carregamento
            //de imagem novamente
            //iremos reutilização a função que está na
            //tela de configuração
            //Para o método ou função de outra tela
            //é preciso transforma-lo em método public
            //assim ele pode ser acessado de qualquer lugar 
            //do projeto

            //Para acessar o método publico
            //é preciso instancia a tela na memoria
            //e neste caso só iremos acessar a função
            //não iremos exibir a tela

            frmConfiguracoes frm = new frmConfiguracoes();
            //Atualizar a imagam de fundo
            pcbImagemFundo.ImageLocation = frm.CarregarImagem();
            //Atualizar o pictureBox
            pcbImagemFundo.Refresh();
        }

        private void listagemDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelCliente frm = new frmSelCliente();
            frm.ShowDialog();
        }
    }
}
