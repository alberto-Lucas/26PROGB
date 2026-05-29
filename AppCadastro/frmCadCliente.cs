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

        //Função que retorna o caminho do arquivo completo
        string GetDirArquivo(string TipoCadastro, string NomeArquivo)
        {
            //O caminho será montado:
            //Diretorio Raiz do executavel
            //Tipo do Cadastro: Cliente
            //Nome Arquivo: CPF
            //Ex: C:/Programas/AppCadastros/Cliente/00000000000.txt

            //Diretorio Raiz
            //AppDomain = O Executavel em si
            //CurrentDomain = O processo em execução (gerenciador de tarefas)
            //BaseDirectory = local da onde o .exe está sendo executado
            string raiz = AppDomain.CurrentDomain.BaseDirectory;

            //Montar o diretorio
            return Path.Combine(
                raiz, TipoCadastro, NomeArquivo + ".txt");

            //OBS: A extensão é opicional como tambem o uso 
            //de arquivo de texto, pois o sistema ira ler o arquivo 
            //bruto, a extensão não tem impacto
            //mudar ou não usar extensão dificulta o uso de 
            //engenharia reversa para roubo de dados
        }

        //Funação de montagem do conteudo do arquivo
        string GetCadastro()
        {
            //Iremos concatenar a informação da tela
            //em uma unica string
            //ja no formato de cadastro
            //assim salvando tudo no arquivo
            //Cada linha do arquivo será um campo

            string cadastro =
                "CPF=" + txtCPF.Text +
                Environment.NewLine + //Quebra de Linha
                "NOME=" + txtNome.Text +
                Environment.NewLine +
                "DTNASC=" + dtpDtNascimento.Value +
                Environment.NewLine +
                "RG=" + txtRG.Text;

            return cadastro;
        }

        //Método Principal
        //Salvar o cadastro, reuni todos os demais método e funções
        void Salvar()
        {
            //Primeiro precisamos montar/recuperar
            //o diretorio do arquivo

            string diretorio = GetDirArquivo("Cliente", txtCPF.Text);

            //Validar a existencia do arquivo
            //se ja existir quer dizer que possui um cadasrto
            try
            {
                //Validacao
                if (ArquivoExiste(diretorio))
                {
                    MsgAlerta("Já existe um cadastro com este CPF.");
                    return; //abortar
                }
            }
            catch (Exception ex)
            {
                MsgErro("Falha ao validar o arquivo.", ex);
                return; //Abortar a rotina
            }

            //Parte de gravação do arquivo
            try
            {
                //Gravar o cadastro
                GravarArquivo(diretorio, GetCadastro());

                //Notificar o usuario
                MsgInformacao("Cadastro realizado com sucesso!");

                //Apenas para caracter de TESTE
                //iremos exibir uma mensagem informando onde o arquivo 
                //foi salvo
                //Esta mensagem não deve ir na versão final do sistema
                MsgInformacao("Salvo em:" + diretorio);
            }
            catch (Exception ex)
            {
                MsgErro("Falha ao salvar o cadastro.", ex);
                //Não precisa do return para abortar por ser o final da rotina
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();

            //Limpar os campos
            txtCPF.Clear();
            txtNome.Clear();
            txtRG.Clear();

            //Unico diferente é o campo de data
            //pois iremos resetar a data, usando a data atual
            //DateTime componente de Data e Hora
            //Now retorna a data e hora atual do computador
            dtpDtNascimento.Value = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Validação se realmente deseja cancelar
            bool resultado =
                MessageBox.Show("Deseja realmente cancelar?",
                                "Confirmação",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)
                                //Validando se foi clicado no botão sim
                                == DialogResult.Yes;
            if (resultado)
                this.Close(); //fechamos a tela

            //Se clicar em não, não realizamos nenhuma ação
        }
    }
}
