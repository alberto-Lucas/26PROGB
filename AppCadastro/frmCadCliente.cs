using System;
using System.IO;
using System.Windows.Forms;

namespace AppCadastro
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        //Criar método para padronizar os MessageBox
        //exibidos ao usuário
        void MsgInformacao(string conteudo)
        {
            //Montar uma MessageBox com botão OK
            //e icone azul referente a informação
            //Iremos receber o conteudo apresentado
            //via parametro
            MessageBox.Show(conteudo, "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Ex de uso
            //MsgInformacao("Conteudo a ser exibido");
        }

        void MsgAlerta(string conteudo)
        {
            MessageBox.Show(conteudo, "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void MsgErro(string conteudo, Exception ex)
        {
            //Como temos mais de uma parametro
            //e posso ter ou não um erro de excessão
            //vindo do try
            //preciso validar se ele está nullo ou não
            //então iremos montar o conteudo separadamente
            string msg = conteudo;

            //Se o meu ex não for nullo
            //adiciono o erro original a mensagem
            if(ex != null)
                //Começamos com quebra linha
                //pois ja tera um texto anterior
                msg += Environment.NewLine +
                        "Erro original: " + ex.Message;

            //Agora podemos montar o MessageBox
            MessageBox.Show(msg, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Função para capturar a interação com o usuário
        bool MsgSimNao(string conteudo)
        {
            //Está função irá exibir uma mensagem
            //Com botão de sim e não que o usuário
            //irá interagir, e precisamos
            //capturar a opção escolhida

            //Para capturar o retorno
            //precisamos usar o tipo de dado
            //DialogResul pois ira salvar o botão clicado

            DialogResult botao =
                MessageBox.Show(conteudo, "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Validar e retornar o botão escolhido
            //Botão Yes retorna True
            //Botão No retorna False
            return botao == DialogResult.Yes;
        }

        //Métodos e funções referente a manipulação do arquivo

        //Função para validar a existencia do arquivo
        bool ArquivoExiste(string Caminho)
        {
            //Validar a existencia do arquivo
            //No caso como usaremos o CPF como 
            //nome do arquivo, se ja existir o arquivo
            //quer dizer que ja possui um cadastro com 
            //este CPF
            //Se apresentar erro no File
            //basta importar a seguinte biblioteca
            //no começo do arquivo
            //using System.IO;
            return File.Exists(Caminho);
        }

        //Método de gravação do conteudo do arquivo
        void GravarArquivo(string Caminho, string Conteudo)
        {
            //Antes de realizar a gravação do conteudo
            //Precisamos validar a existencia do diretorio
            //Pois na primeira gravação o diretorio 
            //pode não existir
            //Essa validação é nescessaria
            //pois iremos gravar o cadastro na pasta
            //onde o programa está sendo executado
            //EX: C:\Arquivos de Progras\AppCadastro

            //Recuperar o diretorio do programa
            //GetDirectoryName extraio a ultima pasta
            //do diretorio informado
            //Ex C:\Arquivos de Progras\AppCadastro\Clientes\1.txt
            //A ultima pasta seria Clientes
            //Preciso validar se ela existe
            //CreateDirectory método para criar pasta
            string pasta = Path.GetDirectoryName(Caminho);
            if(!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            //Podemos gravar o arquivo
            File.WriteAllText(Caminho, Conteudo);
        }
    }
}
