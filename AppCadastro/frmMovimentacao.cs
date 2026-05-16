using System.Drawing;
using System.Windows.Forms;

namespace AppCadastro
{
    public partial class frmMovimentacao : Form
    {
        //Adicionar parametros no construtor da tela
        //Serve para compartilhar informações
        //entre telas ou arquivos
        //O construtor da tela é método executado
        //automaticamente quando é carregado na memoria
        //ou seja instanciado
        //Para identificar o construtor da tela
        //é só localizar o método que tem a chamada
        //do InitializeComponent(); resposavel
        //por renderizar os componentes da tela

        //Agora basta adicionar o parametro desejado
        //Neste usaremos um int para definir o tipo da tela
        //0 - Venda
        //1 - Orçamento
        public frmMovimentacao(int ModoTela)
        {
            InitializeComponent();

            //Personalizar a tela de acordo com o
            //modo recebido via parametro
            if(ModoTela == 0)
            {
                lblMovimentacao.Text = "Venda";
                lblMovimentacao.BackColor = Color.Red;
            }
            else
            {
                lblMovimentacao.Text = "Orçamento";
                lblMovimentacao.BackColor = Color.Blue;
            }
        }
    }
}
