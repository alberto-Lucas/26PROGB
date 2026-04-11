using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabuadaCorrecao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Preparar o terreno criando nosso métodos
        //e função para o desenvolvimento

        //Função que retorna se uma string é somente
        //um número inteiro
        //Is = é
        bool IsNumeroInteiro(string valor)
        {
            //Validar se o parametro não está vazio
            if (valor == "")
                return false; //Ja encerro o método

            //Se chegou aqui posso validar os numero
            //Utilizar um loop para validar cada caracter
            //identificando se todos são numeros inteiros
            //encontrei o primeiro caracter não valido
            //para a execução e retorno falso
            //Usamos o Length para retorna a quantidade
            //de caracteres em uma string

            //Validar do caracter
            //Uso a negação pois eu espero um digito
            //que não é valido
            for (int i = 0; i < valor.Length; i++)
                if (!char.IsDigit(valor[i]))
                    return false;    
            
            //Se chegou até não encontrou nenhum
            //caracter invalido
            //portanto posso retorno que o valor
            //informado é verdadeiro
            return true;
        }

        //Função para validar o intervalo > 0 e < 100
        bool IsIntervaloValido(int valor)
        {
            //Retorna o resultado da condição
            //direto no retorno
            //valido e retorno a validação ao mesmo tempo
            return (valor > 0 && valor < 100);
        }

        //Função que centraliza todas as validações
        bool IsCampoValido(string vInicial, string vFinal)
        {
            //Utilizando o padrão FirstValidation
            //Achou uma falha(false) aborta a execuação
            if(!IsNumeroInteiro(vInicial))
            {
                MessageBox.Show(
                    "Informe um número Inicial válido.");
                return false; //aborta a execução
            }

            if (!IsNumeroInteiro(vFinal))
            {
                MessageBox.Show(
                    "Informe um número Final válido.");
                return false; //aborta a execução
            }

            //Neste momemnto tenho certeza que os valores
            //informados são numeros inteiros validos
            //posso converte-los tranquilamente
            int inicial = int.Parse(vInicial);
            int final = int.Parse(vFinal);

            if(!IsIntervaloValido(inicial))
            {
                MessageBox.Show(
                    "Informe um número Inicial "+
                    "maior que zero (0) e menor que cem(100)");
                return false;
            }

            if (!IsIntervaloValido(final))
            {
                MessageBox.Show(
                    "Informe um número Final " +
                    "maior que zero (0) e menor que cem(100)");
                return false;
            }

            //Validar se o valor final é maior que o inicial
            if(final <= inicial)
            {
                MessageBox.Show(
                    "Informe um número Final maior " +
                    "que o número Inicial");
                return false;
            }

            //Se chegou até aqui 
            //Os valores informados são validos
            //Posso retornar verdadeiro
            return true;
        }

        //Método que irá calcular a tabuada
        void CalcularTabuada(int vInicial, int vFinal)
        {
            //Limpar a listBox
            lstResultado.Items.Clear();

            //Criar o loop princial para o invervalo
            //de tabuadas
            //Passaremos pelos intervalos
            //Ex inicial 2 e final 4
            //o loop passara pelo 2 pelo 3 e pelo 4
            for (int i = vInicial; i <= vFinal; i++)
            {
                //Criar o segundo da tabuada
                //ou seja o que vai calcular o valor atual
                //do 1 ao 10
                //Exemplo o intervalo 2
                //ira apresenta a tabua completa do 1 ao 10
                //Ex: 2 x 1 = 2 
                //Ex: 2 x 10 = 20
                for(int j = 1; j <= 10; j++)
                {
                    //Iremos criar uma variacel
                    //que ira armazenar a concatenação
                    //e multiplicar os valores
                    //Ex: 2 x 1 = 2 

                    //Um recurso legal do ToString é formatar
                    //o valor convertido
                    //neste caso podemos adicionar zero a esquerda
                    //padronizando a quantidade de caracteres
                    //Ex: 3 x 4 = 12
                    //Ex: 03 x 04 = 12
                    //Para isso basta adicionar a formatação
                    //dentro do ToString()
                    string resultado =
                        i.ToString("00") + " x " +
                        j.ToString("00") + " = " +
                        (i * j).ToString("00");

                    //Adicionar esta concatenação ao listBox
                    lstResultado.Items.Add(resultado);
                }//Final do Loop J

                //Adicionar um linha para separar
                //os intervalos de tabuadas
                lstResultado.Items.Add("---------------------");
            }//Final do Loop I
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Realizar as validações
            if (!IsCampoValido(txtNumInicial.Text, txtNumFinal.Text))
                return; 
            //Devido o método não possuir um retorno
            //aplico um return vazio para abortar a execução

            //Se chegou aqui valores validos
            //podemos converter para calcular
            int inicial = int.Parse(txtNumInicial.Text);
            int final = int.Parse(txtNumFinal.Text);

            //Chamamos o método calcular
            CalcularTabuada(inicial, final);
        }
    }
}
