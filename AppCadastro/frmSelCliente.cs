using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AppCadastro
{
    public partial class frmSelCliente : Form
    {
        //Criar variaveis globais para os arrays
        //para isso usamos o tipo de dados desejado
        //e adicionamos colchetes([]) no final ex: string[]
        //para determinar o array
        //utilizar o underline(_) para indicar que a variavel é global
        string[] _arquivos;

        //Criar uma lista de array
        //Nescessario importar o using System.Collections.Generic;
        List<string[]> _lista = new List<string[]>();
        public frmSelCliente()
        {
            InitializeComponent();
        }

        //Método para carregar os arquivos
        //Ou seja, popular o array _arquivos com os diretorios
        void CarregarArquivos()
        {
            //primeiro precisamo construir o diretorio da pasta cliente
            string caminho = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "Cliente");

            //iremos recuperar todos os arquivos .txt do caminho
            //e iremos armazenar no array, o diretorio de cada arquivo
            try
            {
                //Usaremos o método GetFiles par recuperar os diretorios
                //aplicamos um filtro para retornar apenas os arquivos
                //do tipo texto (.txt) e usaremos o * para
                //ignorar o nome do arquivo ex: *.txt
                _arquivos = Directory.GetFiles(caminho, "*.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar arquivos: " + ex.Message);
            }
        }

        //Método para carregar os conteudo dos arquivos
        void CarregarConteudo()
        {
            //Primeiro precisamos verificar se existe
            //algum diretorio no array
            if (_arquivos == null || _arquivos.Length == 0)
            {
                MessageBox.Show("Nenhum arquivo encontrado.");
                return; //abortamos a rotina
            }

            //Variavel para armazenar temporiamente o conteudo
            string[] conteudo;

            //Limpar a lista de cadastro para evitar duplicidade
            _lista.Clear();

            try
            {
                //Loop para ler cada arquivo usando o diretorio
                for(int i = 0; i < _arquivos.Length; i++)
                {
                    //Utilizar o método ReadAllLines para ler
                    //o conteudo do arquivo
                    conteudo = File.ReadAllLines(_arquivos[i]);

                    //Criar um array temporario para leitura das linhas
                    //e iniciamos a variavel definindo o tamanho desejado
                    string[] registro = new string[5];

                    //Mapeamento do conteudo
                    //O primeiro sera o diretorio do proprio arquivo
                    //assim nao preciso depender mais do _arquivos
                    //e posso trabalhar apenas com a _lista
                    registro[0] = _arquivos[i];
                    //Iremos armazenar as linhas do arquivo em 
                    //cada posição do arry, onde cada linha
                    //é um campo diferente
                    //e ja usaremos o método Replace, para remover
                    //o nome do campo, popular o array apenas com 
                    //a informação
                    //ou seja no arquivo estára da seguinte forma
                    //CPF=12345678901
                    //porém eu desejo salvar apenas o valor do CPF
                    //usando o Replace remover o "CPF="
                    //ficando apenas com: 12345678901
                    registro[1] = conteudo[0].Replace("CPF=", "");
                    registro[2] = conteudo[1].Replace("NOME=", "");
                    registro[3] = conteudo[2].Replace("DTNASC=", "");
                    registro[4] = conteudo[3].Replace("RG=", "");

                    //Agora temos um registro com todas as informações do arquivo
                    //Adicionar o registro a nossa lista
                    //ou seja cada item da lista será um array
                    //onde cada array tera as informações do arquivo
                    _lista.Add(registro);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Falhar ao carregar conteudos: " + ex.Message);
            }
        }

        //Método para filtrar o conteudo do arquivo
        //iremos passar por cada item da lista
        //e por cada informação do registro(arquivo)
        //e vamos comparar se essa informaçaõ filtrada existe
        //para isso iremos pegar a posição do array
        //referente a informação filtrada
        //no caso vamos filtrar pelo nome
        //q se encontrada na posição 2 do array
        void FiltrarLista(string filtro)
        {
            //Se o parametro extiver vazio, não iremos realizar
            //nenhuma ação e abortaremos o filtro
            //por tanto nesse caso será retornado todos os registro
            //Ou se eu quiser trazer todos os registro
            //não aplico nenhum filtro
            if (string.IsNullOrEmpty(filtro))
                return; //abortar o filtro

            //Variavel para armazenar a lista filtrada
            List<string[]> listaFiltrada = new List<string[]>();

            //Realizar um loop para percorrer a lista de registro original
            for(int i = 0; i < _lista.Count; i++)
            {
                //Vamos comprar o conteudo nome do registro com o filtro
                //verificando se o arquivo contem o texto digitado
                //semelhante ao LIKE do SQL: LIKE(%VALOR%)
                //Utilizar o conteins para fazer a função do LIKE

                //Criar uma variavel para armazenar o item atual
                string[] item = _lista[i];

                //Validar o conteudo
                if (item[2].Contains(filtro))
                {
                    //Se a informação bater
                    //adiciono na lista filtrada
                    listaFiltrada.Add(item);
                }
            }

            //Limpar a lista original
            _lista.Clear();
            //Sobrecever a original com a lista filtrada
            _lista = listaFiltrada;
        }
    }
}
