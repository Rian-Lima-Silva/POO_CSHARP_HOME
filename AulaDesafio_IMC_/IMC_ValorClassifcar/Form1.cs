using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_ValorClassifcar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            PesoAltura c=new PesoAltura();
            string img="limpa";

            if(textBoxPeso.Text == "")           
            {
                MessageBox.Show("Você não digitou nada em PESO");
                textBoxPeso.Focus();
                return;
                    

            }else if (textBoxAltura.Text == "")
            {
                MessageBox.Show("Você não digitou nada em ALTURA");
                textBoxAltura.Focus();
                return;
            }
            else if(c.peso!=0||c.altura!=0)
            {
                MessageBox.Show("Antes de efetuar um segundo calculo tenha certeza, de apagar o anterior");
                buttonLimpar.Focus();
                return;
            }
            else if(textBoxPeso.Text != " " && textBoxAltura.Text != " ")//Calculo e Resultado
            {             
                c.peso = double.Parse(textBoxPeso.Text);
                c.altura = double.Parse(textBoxAltura.Text);
                img = c.Classificar(c.imc(double.Parse(textBoxPeso.Text), double.Parse(textBoxAltura.Text)));
                labelRes.Text = img;

                if (img == "Baixo Peso")
                {
                    label_img_BP.Visible = true;
                    labelRes.Visible = false;

                        if (img != "Baixo Peso")
                        {
                            label_img_BP.Visible = false;
                        }
                }
                else if (img == "Normal")
                {
                    labelNormal.Visible = true;
                    labelRes.Visible = false;
                    if (img != "Normal")
                        {
                            labelNormal.Visible = false;
                        }
                }               
                else if (img == "Sobrepeso")
                {
                    labelSobrepeso.Visible = true;
                    labelRes.Visible = false;
                        if (img != "Sobrepeso")
                        {
                            labelSobrepeso.Visible = false;
                        }
                }
                else if (img == "Obesidade")
                {
                    labelObesidade.Visible = true;
                    labelRes.Visible = false;
                        if (labelRes.Text != "Obesidade")
                        {
                            labelObesidade.Visible = false;
                        }
                }
            }//Calculo e Resultado                     
            else
            {
                MessageBox.Show("Essa ação não pode ser executada");               
            }           
        }
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            PesoAltura c = new PesoAltura();
            c.peso = 0;
            c.altura = 0;
            c.res = " ";            
            textBoxPeso.Clear();
            textBoxAltura.Clear();
            labelRes.Text = " ";
            textBoxPeso.Focus();
            label_img_BP.Visible = false;
            labelNormal.Visible = false;
            labelSobrepeso.Visible = false;
            labelObesidade.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelClassificar_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Form1 form = new Form1();
            pictureBox1.Show();
            
        }
    }
}
