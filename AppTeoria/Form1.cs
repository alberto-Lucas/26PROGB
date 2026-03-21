using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTeoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIF_Click(object sender, EventArgs e)
        {
            //Aqui iremos utilizar o IF
            //Como método validação
            //Portanto iremos validar com base no texto
            //da opção selecionada

            //Utilizamos quando não temos uma variação
            //do mesmo dado

            //Criar um variavel para armazenar
            //o resutado da opção

            string opcao;

            if (cbbExrcicios.Text == "LEGPRESS")
                opcao = "Opção LEGPRESS";
            else if (cbbExrcicios.Text == "ADUTORA")
                opcao = "Opção ADUTORA";
            else if (cbbExrcicios.Text == "ABDUTORA")
                opcao = "Opção ABDUTORA";
            else if (cbbExrcicios.Text == "SUPINO")
                opcao = "Opção SUPINO";
            else if (cbbExrcicios.Text == "ROSCA")
                opcao = "Opção ROSCA";
            else
                opcao = "Opção Desconhecida";

            MessageBox.Show(opcao);
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            //Aqui a validação se pela variação do 
            //tipo de dado e não pelo texto

            //Ou seja aqui estou olhando diretamente
            //para a lista de opções

            string opcao;

            //SelectedIndex é a posição do item
            //selecionado no array
            switch (cbbExrcicios.SelectedIndex)
            {
                case 0: opcao = "Opção 1"; break;
                case 1: opcao = "Opção 2"; break;
                case 2: opcao = "Opção 3"; break;
                case 3: opcao = "Opção 4"; break;
                case 4: opcao = "Opção 5"; break;
                default: opcao = "Opção Desconhecida"; break;
            }

            MessageBox.Show(opcao);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Iremos limpar os items do ListBox
            lstLoop.Items.Clear();
        }

        private void btnForIncremento_Click(object sender, EventArgs e)
        {
            //Laço de repetição FOR
            //Iremos executar um loop de um valor
            //que sabemos a quantidade de excuções
            //por exemplo
            //um loop para listar os numero entre 0 e 10

            //A cada execução iremos adicionar o numero atual
            //a listBox

            for(int i = 0; i <= 10; i++)
                //Irei adicionar o valor de i
                //na istbox
                //Utilizando o ToString() para converte
                //a valor de int para string
                lstLoop.Items.Add(i.ToString());
        }

        private void btnForDecremento_Click(object sender, EventArgs e)
        {
            //Aplicando agora o decremento seguindo o principio
            //do anterior (incremento)

            for(int i = 10; i >= 0; i--)
                lstLoop.Items.Add(i.ToString());
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            //Laço de repetição While
            //Utilizado qunado não sabemos a quantidade de 
            //vezes que será executado
            //por tanto será executado até a condição ser valida
            //Primeiro ocorre a validação e depois
            //ocorre a execução
            //Ou seja se a condição ja for satisfeita
            //a execução não ocorrera

            //Iremos simular um sorteador de números
            //pois não sabemos quantas vezes o sroteio
            //ocorrera até o número desejado ser sorteado

            //Primeiro deve criar a nova varia Randomica
            //responsavel pelo sorteio

            //Random é um classe de geração de
            //números randomico ou seja aleatorios
            Random sorteador = new Random();

            //Irei criar a variavel para
            //armazenar o numero sorteador

            int numeroSortado;

            //Irei sortear um número entre 1 e 10
            //a armezenar o numero na variavel
            //Next() responsavel pelo sorteio
            numeroSortado = sorteador.Next(1, 10);

            //Agora iremos implementar o While
            //para validar o numero sorteador
            //e executar novamente se nescessario
            //até que o número da sorte 8 seja sorteado

            //o While executa enquanto a condição for verdadeira
            //ou seja preciso trabalhar com a negação
            //neste iremos executar enquanto o número sorteado
            //for diferente de 8
            //pois se o número sorteador for 8 será falso 
            //e encerra a execução
            while(numeroSortado != 8)
            {
                //Irei adicionar o número sorteado oao listBox
                lstLoop.Items.Add(numeroSortado.ToString());
                //Irei sortear um novo número
                numeroSortado = sorteador.Next(1, 10);
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            //Iremos aplicar o mesmo conceito do While
            //porém no DO WHILE a validaçao da condição
            //ocorre depois da execução, garantindo
            //que execute pelo menos uma vez

            //Iremos simular o sorteador
            //sendo o 8 o número da sorte

            Random sorteador = new Random();

            int numeroSorteado;

            do
            {
                numeroSorteado = sorteador.Next(1, 10);
                lstLoop.Items.Add(numeroSorteado.ToString());
            }
            while (numeroSorteado != 8);
        }

        private void btnSoNumero_Click(object sender, EventArgs e)
        {
            //Está execução irá extrair somente os números
            //de um string
            //utilizando laço de reptição for, para validar
            //cada caracter da string

            //Criar uma variavel para receber o conteudo digitado
            string valor = txtValor.Text;

            //Criar uma variavel para armazenar o resultado
            string resultado = "";

            //Agora iremos aplicar o loop iniciando na posição 0
            //até a ultima posição da string
            //ou seja o nosso valor final é o tamanho da string
            //O método Length retorna o tamanho de um string

            for(int i = 0; i < valor.Length; i++)
            {
                //Agora o nosso i é uma posição 
                //do array da string
                //e cada posição terá um caracter
                //portanto cada i é um caracter
                //iremos validar agora caracter por caracter

                //Irei usar o tipo de dado char
                //e o método IsDigit de char para validar
                //se o caracter atual de i é um digito numerico
                //se positivo irei adicionar a variavel resultado
                //se negativo irei ignorar e pular para o proximo
                //caracter

                if (char.IsDigit(valor[i]))
                    resultado += valor[i];
            }

            //Por ultimo irei popular o campo txtResultado
            //com a variavel resultado
            txtResultado.Text = resultado;
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            //Toda a execuçao será realizada pelo método
            MetodoSomar();
        }

        //Método somar
        //onde iremos somar 2 valores
        //informado pelo usuario
        //Método não possuem retornos
        //Portanto são do tipo VOID
        void MetodoSomar()
        {
            //Ações do método serão
            //Recuperar os dados informados na tela
            //Converter os valores de string para int
            //Atribuir esses valores as variaveis
            //Somar os valores
            //Apresentar o resultado de volta na tela

            //Criar as variaveis de apoio
            int v1, v2, resultado;

            //Para converter um valor numerico
            //é preciso informar o tipo de dado
            //desejado(int, float, double, decimal)
            //e chamar a função nativa do tipo de dado
            //Parse(Converter) e devemos passar
            //via parametro em formato de string
            //o valor a ser convertido
            //o Parse converte apenas string
            //para valor numerico
            //Exexemplo irei converte o texto '1' em int
            //ex: int.Parse("1");
            //ex: float.Parse("1.5");

            v1 = int.Parse(txtValor1.Text);
            v2 = int.Parse(txtValor2.Text);

            //realizaremos a soma e o armazenamento 
            //do resultado

            resultado = v1 + v2;

            //Para exibir o resultado
            //de volta ao textBox é preciso converter
            //o conteudo para String
            //todo tipo de dado numero
            //possui a função de conversão nativa
            //basta adicionar .ToString() a variavel

            txtResultadoMF.Text = resultado.ToString();
        }

        private void btnFuncao_Click(object sender, EventArgs e)
        {
            //Por usarmos função
            //Precisamos que o botão
            //organize a execução do codigo
            //diferente do método que
            //faz todo o serviço

            //Com o uso de função
            //precisamo "prepara o terreno" 
            //antes da chamda da função

            //seguir a mesma logica do método

            int v1, v2, resultado;

            //Chamar a função de conversão
            //e por ter parametro
            //sou obrigado a passar algum valor 
            //dentro dos parenteses (parametro)
            v1 = StringParaInt(txtValor1.Text);
            //Similar ao 
            //v1 = int.Parse(txtValor1.Text);
            v2 = StringParaInt(txtValor2.Text);

            //E para soma vamos chamar a nossa função
            resultado = FuncaoSomar(v1, v2);

            //e por ultimo exibir o resultado no textbox
            txtResultadoMF.Text = resultado.ToString();
        }

        //Função somar
        //Irá receber 2 valores
        //realiza a soma e retorna o resultado
        int FuncaoSomar(int v1, int v2)
        {
            return v1 + v2;
        }

        //Função para converter string em int
        //Uma função é divida em 4 partes
        //Tipo de dado de retorno (string, int, bool...)
        //Nome da função que seja clara e objetiva
        //Os parametros, informações que recebemos
        //para manipular dentro da função
        //e por ultimo a ação em si
        int StringParaInt(string valor)
        {
            //Como estamos convertendo 
            //a string diretamente para int
            //caso a string possua qualquer
            //caracter diferente de numero
            //ocorrera erro
            //return int.Parse(valor);

            //Portanto iremos utilizar 
            //o recurso de TryParse
            //Onde iremos validar
            //se a conversao foi possivel
            //e se não for, retorna um valor padrão
            //no caso o valor zero(0)

            //o TryParse possui 3 retornos
            //Se convertido
            //retorna true e o valor convertido
            //se não convertido 
            //retorna apenas false

            //utilizar um if comum

            //Utilizar comentario por bloco usando 
            //
            /* 
            colocar aqui dentro todas as linha q deseja
            */

            /*
            if(int.TryParse(valor, out int numero))
                //retorno o valor convertido
                return numero; 
            else
                //Retornar um valor padrão
                return 0;
            */


            //Podemos utilizar um if ternario
            //para gourmetizar o codigo
            //executado tudo em uma unica linha

            return
                int.TryParse(valor, out int numero) ?
                numero : //retono o numero convertido
                0; //retorno o valor default se falso

            //if ternario é dividido em 3 partes
            //condicao
            //resultado true
            //resultado false
            //primeiro a condição
            //depois o valor a ser retornado se true
            //depois o valor a ser retornado se false
            //? significa if
            //: signigica else
            //ou seja leio como se fosse uma pergunta
            //ex:
            //se minha idade for maior ou igaul a 18
            //sou maior de idade se não sou menor de idade
            //usando if ternario ficaria
            //(idade >= 18 ? "sou de maior" : "sou de menor");
        }

        private void btnFuncao2_Click(object sender, EventArgs e)
        {
            //Iremos realiza exato mesmo processo
            //do Método e da Função
            //porém em apenas um linha

            txtResultadoMF.Text =
                FuncaoSomar(
                    StringParaInt(txtValor1.Text),
                    StringParaInt(txtValor2.Text)).ToString();
        }

        //Acima dessas 2 chaves que vc deve criar
        //os métods e as funções
    }//é da tela
}//é do projeto
