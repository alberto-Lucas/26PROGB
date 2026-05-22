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
    }
}
