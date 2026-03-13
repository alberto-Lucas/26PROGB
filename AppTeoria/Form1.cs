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
    }
}
