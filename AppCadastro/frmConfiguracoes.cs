using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCadastro
{
    public partial class frmConfiguracoes : Form
    {
        public frmConfiguracoes()
        {
            InitializeComponent();

            //Iremos carregar a imagem salvar
            //durante a abaertura da tela

            //Iremos recuperar o diretorio pelo método CarregarImagem
            //e preencher no nosso textBox
            txtDiretorio.Text = CarregarImagem();
            //Para carregar a imagem no pictureBox
            //basta recuperar o diretorio do textBox
            //Usamos o proprio textBox para não executar 
            //o CarregarImagem novamente
            pcbImagem.ImageLocation = txtDiretorio.Text;
            //Atualizar a imagem
            pcbImagem.Refresh();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //Realizar a seleção de imagem pelo compoanente
            //OpenFileDialog que ira chamara a tela de selação
            //de arquivo padrão do proprio Windows

            //Seguir o mesmo do FolderBrowserDialog
            //ou seja preciso recuperar o DialogResult
            //e validar se foi clicar no botão Ok ou Cancelar
            DialogResult retorno = openFileDialog1.ShowDialog();

            if(retorno == DialogResult.OK)
            {
                //Não precisamos validar se teve realmente 
                //um arquivo selecionado ou não 
                //pois o proprio componenete ja realiza essa validação

                //Se for clicado no botão OK
                //Iremos apresentar o diretorio da imagem selecionada
                //no textBox
                //FileName retorna o diretorio do arquivo
                //selecionado
                txtDiretorio.Text = openFileDialog1.FileName;

                //Iremos carregar a imagem diretamente no PictureBox
                //OBS: Iremos apenas exibir a imagem que está no dispositivo
                //ou seja essa função não importa a imagem para dentro 
                //do projeto, caso a mesma seja excluida ou movida de local
                //ela não será localizada
                pcbImagem.ImageLocation = txtDiretorio.Text;
                //Atualizar o pictureBox para carregar a imagem
                pcbImagem.Refresh();
            }
        }

        private void btnRemoverImagem_Click(object sender, EventArgs e)
        {
            //Aqui o processo de remoção é simples
            //Batas limpar o textBox e setar um valor
            //null no picture para realizar a limpeza
            //OBS: aplicar um refresh no pictureBox
            txtDiretorio.Text = "";
            pcbImagem.ImageLocation = null;
            pcbImagem.Refresh();
        }

        //Método para salvar o arquivo de configuração
        //Será um arquivo fixo chamada Config.conf
        //.conf faz referencia a arquivo de configuração
        //é a mesma coisa de um arquivo de texto (.txt)
        //porém só mudamos a extensão para difultar o 
        //acesso ao arquivo por usuários comuns
        //Pois bastar clicar com botão e abrir no bloco de notas
        void SalvarArquivo(string conteudo)
        {
            //Para salvar o arquivo, precisamos de 3 informações
            //1 - A pasta raid da aplicação
            //2 - pasta padão de configuração
            //3 - nome padrão do arquivo
            string dirPasta =
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, //Local da aplicação
                    "Configuracoes"); //Pasta padrão
            string dirArquivo = Path.Combine(dirPasta, "Config.conf");

            try
            {
                //Segui o padrão para salvar arquivo
                //validar o diretorio da pasta
                //e criar caso não exista
                if (!Directory.Exists(dirPasta))
                    Directory.CreateDirectory(dirPasta);

                //Agora podemos salvar o arquivo
                File.WriteAllText(dirArquivo, conteudo);
                //Notificar o usuario
                MessageBox.Show("Arquivo salvo com sucesso.", "Informação");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao salvar a configuração." +
                    Environment.NewLine +
                    "Erro original: " + ex.Message,
                    "Erro");
            }
        }

        //Método para salvar a imagem
        //pois iremos adicionar no arquivo o campo
        //e o diretorio da imagem
        //EX: Imagem=C:\Imagens\Carro.png

        void SalvarImagem(string dirImagem)
        {
            SalvarArquivo("Imagem=" + dirImagem);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //De fato salvamos a imagem no arquivo
            SalvarImagem(txtDiretorio.Text);
        }

        //Funação para carregar a confgiuração da imagem
        //Ou seja iremos ser o arquivo de configuração
        //e retornar o diretorio da imagem salva

        //Adicionar o public para deixar a função Publica
        //dessa forma ele pode ser acessado de outras telas
        //quando uma função ou método não possui uma diretiva de acesso
        //(public ou private) por padrão ela é privada(private)
        //ou seja só pode ser acessada de dentro da porpria tela
        //para isto basta adicionar a palavra reservada public
        //no começo do método ou função
        public string CarregarImagem()
        {
            //Criar uma variavel para o diretorio
            //com o valor padrão vazio
            //pois caso ocorre algum problema na leitura do arquivo
            //o retrono pode ser null gerando erro de tipo de dado
            //para corrigir definimos um valor de string padrão
            //caso ocorro erro será retornado o padrão
            //lembrando que vazio("") é diferente de null
            string dirImagem = "";

            //Para leitura do arquivo de configuração
            //Precisamos montar o diretorio de acesso do arquivo
            //Pasta Raiz + Pasta Padrão + Nome Arquivo
            //Ex: C:\AppCadastro\Configuracoes\Config.conf
            string dirArquivo =
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, //Pasta Raiz
                            "Configuracoes", //Pasta Padrão
                            "Config.conf"); //Nome Aarquivo

            //Variavel conteudo para armazenar o conteudo do arquivo;
            string conteudo = "";

            //Validar a existencia do arquivo de configuração
            //Se existir, lemos o conteudo dele
            if (File.Exists(dirArquivo))
                conteudo = File.ReadAllText(dirArquivo);

            //Para extrair o diretorio da imagem do nosso conteudo
            //é preciso remover o nome do campo (Imagem=)
            //Iremos usar o recurso Replace para subistituir
            //uma string por outra
            //Nesse iremos remover o nome do campos
            //o subistituindo para vazio
            //deixando apenas o diretorio
            //Antes: Imagem=C:\AppCadastro\Imagens\Carro.png
            //Depois: C:\AppCadastro\Imagens\Carro.png
            //O codigo seria
            //Replace("valor_antigo", "valor_novo")

            dirImagem = conteudo.Replace("Imagem=", "");
            //Só retornar o diretorio da imagem
            return dirImagem;
        }
    }
}
