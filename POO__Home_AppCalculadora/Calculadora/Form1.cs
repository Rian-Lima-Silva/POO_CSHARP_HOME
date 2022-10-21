using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }


        // decimal numero1,numero2;
        //double numero1=0, numero2;
         //string operacao="Nada";
         double n1=0,n2=0;
        string op = "nada";
        


        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text += 0;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text += 1;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text += 2;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text += 3;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text += 4;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text += 5;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text += 6;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text += 7;
        }

        private void buttonEigth_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text += 8;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text += 9;
        }
        private void buttonPonto_Virgula_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text +=",";
        }
        

       private void buttonSoma_Click(object sender, EventArgs e)
       {
                       
            if (textBox_Resultado.Text == " ")
            {
                MessageBox.Show("Informe um valor para efetuar a Soma");
                
                if (n1 != 0)
                {
                    op = "soma";
                    labelOperacao.Text = "+";
                    textBox_Resultado.Text = " ";
                }
            }
            else if(textBox_Resultado.Text != "")
            {
                n1 = double.Parse(textBox_Resultado.Text);                
                op = "soma";//Para o programa
                labelOperacao.Text = "+";//Para o usuario           
                textBox_Resultado.Text =" ";//Apagar o texto               
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Soma");

            }
       }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            
            
            if (textBox_Resultado.Text == " ")
            {
                MessageBox.Show("Informe um valor para efetuar a Subtração");

                if (n1 != 0)
                {
                    op = "subtracao";
                    labelOperacao.Text = "-";
                    textBox_Resultado.Text = " ";
                }
            }
            else if (textBox_Resultado.Text != "")
            {
                n1 = double.Parse(textBox_Resultado.Text);               
                op = "subtracao";//Para o programa
                labelOperacao.Text = "-";//Para o usuario           
                //Apagar o texto
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Subtração");
            }
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            Calcular calcular = new Calcular();
             if (textBox_Resultado.Text == " ")
             {
                MessageBox.Show("Informe um valor para efetuar a Multiplicação");
                if (n1 != 0)
                {
                    op = "multiplicacao";
                    labelOperacao.Text = "x";
                    textBox_Resultado.Text = " ";
                }               
             }
             else if (textBox_Resultado.Text != "")
             {
                n1 = double.Parse(textBox_Resultado.Text);
                op = "multiplicacao";//Para o programa
                labelOperacao.Text = "x";//Para o usuario           
                textBox_Resultado.Text = " ";//Apagar o texto
             }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Multiplicação");
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Clear();
            n1 = 0;
            n2 = 0;
            op = " ";
            labelOperacao.Text = " ";
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {           
            if (textBox_Resultado.Text == " ")
            {
                MessageBox.Show("Informe um valor para efetuar a Divisão");
                if (n1 != 0)
                {
                    op = "divisao";
                    labelOperacao.Text = "÷";
                    textBox_Resultado.Text = " ";
                }
            }
            else if (textBox_Resultado.Text != "")
            {               
                n1 = double.Parse(textBox_Resultado.Text);
                op = "divisao";//Para o programa
                labelOperacao.Text = "÷";
                textBox_Resultado.Text = " ";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Divisão");
            }
        }


        private void buttonResultado_Click(object sender, EventArgs e)
        {
            if (textBox_Resultado.Text == "")
            {
                MessageBox.Show("Informe um numero para efetuar seu calculo");
                
            }
            else if (textBox_Resultado.Text != "")
            {
                n2 = double.Parse(textBox_Resultado.Text);
                textBox_Resultado.Text = " ";
            }

            
            

            if (op == "soma")
            {
                textBox_Resultado.Text = Convert.ToString(n1+"+"+n2+"="+Convert.ToString(n1 + n2));
                
            }
            else if (op == "subtracao")
            {
                textBox_Resultado.Text = Convert.ToString(n1 + "-" + n2 + "=" + Convert.ToString(n1 - n2));
            }
            else if (op == "multiplicacao")
            {
                textBox_Resultado.Text = Convert.ToString(n1 + "x" + n2 + "=" + Convert.ToString(n1 * n2));
            }
            else if (op == "divisao")
            {
                textBox_Resultado.Text = Convert.ToString(n1 + "÷" + n2 + "=" + Convert.ToString(n1 / n2));
            } 






            
        }
    }
}
