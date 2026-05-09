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

namespace AppManipulaArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //Iremos utilizar o componenete FolderBrowserDialog
            //Ou seja, tela de pesquisa de pastas do Windows
            //Lembrando que a tela é do proprio windows
            //A rotina será apresentar a tela ao usuário
            //Validar se um diretorio foi selecionado
            //recuperar esta diretorio e exibir no
            //campo txtDiretorio

            //Utilizar o DialogResult para recuperar o retorno 
            //da tela, se foi clicado em OK ou CANCELAR
            //ShowDialog() serve para exibir a tela de pastas
            DialogResult resultado =
                folderBrowserDialog1.ShowDialog();

            //Validar o resultado e se possivel recuperar o diretorio
            //SelectedPath é o diretorio selecionado
            //Precisa validar se não esta nullo
            //pois a cenario onde é retornada vazio (uso de pendrive)
            if (resultado == DialogResult.OK && //Cliquei no Botão OK?
                !string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath)) 
            {
                //Atribuir o diretorio ao txt
                txtDiretorio.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            //Rotina de criação do arquivo no diretorio selecionado
            //Validar se o direotrio existe
            //(pois ele pode ser inserido manualmente pelo usuario)
            //Validar se já existe o arquivo neste diretorio

            //Antes de tudo é preciso validar se os campos estão preenchidos
            if(string.IsNullOrEmpty(txtDiretorio.Text) ||
                string.IsNullOrEmpty(txtNomeArquivo.Text))
            {
                MessageBox.Show("Informe o Diretório e o Nome do arquivo!");
                return; //abortar a execução
            }

            //Validar a existencia do diretorio
            //neste momento é importante utilizar o TryCatch
            //pois caso ocorra problema de permissão de usuário do Windows
            //pode gerar erro, então o try irá tratar este erro
            try
            {
                //Agora podemos validor o diretorio
                //usaremos o Directory para validação
                //Exists retorna a existencia da pasta
                if (!Directory.Exists(txtDiretorio.Text))
                {
                    MessageBox.Show("Diretório não encontrado.");
                    return;
                }

                //Montar o diretorio completo
                //Diretorio da pasta + nome arquivo + extensão do arquivo
                //Path componente para diretorio
                //Combine método para juntar as informações
                //A extensão do arquivo (ex: .txt) é opcional
                string dirCompleto =
                    Path.Combine(txtDiretorio.Text, 
                                 txtNomeArquivo.Text + ".txt");

                //Irei validar se o arquivo ja existe
                //Pois se ja existir o mesmo por ser sobrescrito
                //neste caso não quero q isso ocorra
                //File componente para arquivos
                //Exists método para validr a existencia
                if(File.Exists(dirCompleto))
                {
                    MessageBox.Show("O arquivo já existe.");
                    return;
                }

                //Se chegou até aqui, esta tudo correto
                //podemos criar o arquivo

                //Iremos utilizar o File novamente
                //usaremos o método WriteAllText para criar um arquivo vazio
                //WriteAllText ele serve para escrever no arquivo
                //porém ja tem uma validação da exestencia
                //então se eu escrever no arquivo ele não existir
                //o método faz a criação automaticamente
                File.WriteAllText(dirCompleto, "");

                MessageBox.Show("Arquivo criado com sucesso!");
            }
            catch (Exception ex) //capturar o erro gerado
            {
                MessageBox.Show(
                    "Ocorre um erro ao criar o arquivo. " + 
                    Environment.NewLine + 
                    "Erro original: " + ex.Message);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Iremos seguir a mesma logico da criação do arquivo
            //porém precisamos validar somete a existencia do arquivo
            //e nao o diretorio

            //Neste caso ja posso abrir o try

            try
            {
                string dirCompleto =
                    Path.Combine(txtDiretorio.Text,
                                 txtNomeArquivo.Text + ".txt");

                //Valida a existencia do arquivo
                if(!File.Exists(dirCompleto))
                {
                    MessageBox.Show("Arquivo não encontrado.");
                    return;
                }

                //Agora podemos escrever no arquivo
                //Lembrando que o WriteAllText ira sobrescrever
                //todo o conteudo do arquivo
                File.WriteAllText(dirCompleto, txtTexto.Text);

                MessageBox.Show("Dados gravados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao gravar os Dados.");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Qual a difença entre o Gravar o Adicionar?
            //O gravar irá sobrecrever o arquivo, ocorrendo perca de dados
            //E o Adicionar irá literalmente adicionar o novo conteudo
            //ao conteudo existente, não ocorrendo perca de dados

            //Aplicamos a mesma rotina do gravar apenas trocando
            //o WriteAllText por AppendAllText

            try
            {
                string dirCompleto =
                    Path.Combine(txtDiretorio.Text,
                                 txtNomeArquivo.Text + ".txt");

                if(!File.Exists(dirCompleto))
                {
                    MessageBox.Show("Arquivo não encontrado");
                    return;
                }

                //Adicionamos o conteudo no arquivo
                //OBS: O appendo adiciona o conteudo no final do arquivo
                //ou seja ficara grudado com o dado existente
                //para isso é preciso adicionar uma quebra de linha
                //antes dos dados novos
                File.AppendAllText(dirCompleto, 
                                   Environment.NewLine + txtTexto.Text);

                MessageBox.Show("Dados adicionados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao adicionar os dados.");
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            //Seguir a logica do gravar e adicionar
            //com a diferença que o ocorre a leituro arquivo e não alteração

            try
            {
                string dirCompleto =
                    Path.Combine(txtDiretorio.Text,
                                 txtNomeArquivo.Text + ".txt");

                if(!File.Exists(dirCompleto))
                {
                    MessageBox.Show("Arquivo não encontrado.");
                    return;
                }

                //Agora iremos realizar a leituro do arquivo
                //usando o método ReadAllText
                //usaremos uma variavel auxilar na leitura
                //evitando o carregamento direto no textbox
                //para uma mensagem mais precisa no try
                string retorno = File.ReadAllText(dirCompleto);
                txtTextoArquivo.Text = retorno;

                //Notificar o usuario se torna opicinal
                //pois ja tera o feedback visual
                //do carregamento do conteudo no txtTextoArquivo
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao carregar o arquivo." +
                                Environment.NewLine +
                                "Erro original: " + ex.Message);
            }
        }
    }
}
