using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Praticando_ComponenteTextBox
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
           /*Verifica se a textBox está vazia*/
            if (textBox.Text == "")
            {
                /*Caso esteja, esse comando será executado*/
                MessageBox.Show("Por Favor, Digite um texto");//Essa mensagem aparece para o usuario
                textBox.Focus();//após apertar 'OK' na mensagem, o curso é direcionado para a textBox
                return;//Esse comando é encerrado
            }

            /*A textBoxLista, esta recebendo o valor de textBox mais <espaço><,><espaço>, e quando o 
            segundo valor é digitado ela o recebe, e soma com o primeiro*/
            textBoxLista.Text += textBox.Text+" , ";//envia o valor de textBox para textBoxLista
            textBox.Clear();//textBox tem seu texto apagado
            textBox.Focus();//o cursor está sendo mandado para textBox

            
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxLista.Clear();//textBoxLista tem seus valores apagados ao click do botão limpar
            textBox.Clear();//textBox tem seus valor apagado ao click do botão limpar
            textBox.Focus();//o cursor está sendo mandado para textBox

        }

        
    }
}
