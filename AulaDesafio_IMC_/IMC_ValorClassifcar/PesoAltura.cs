using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IMC_ValorClassifcar
{
    internal class PesoAltura
    {
        
        public double peso=0, altura=0;
        public string res;
        public string num;

       
        internal string imc(double p, double a)
        {

            //p += p * 1000;
            a = a / 100;

            double resultado;
            
            resultado = p/(a*a);
            
            
            num = resultado.ToString();
            if (resultado < 18.5)
            {
                return "BaixoPeso";                

            } else if (resultado > 18.5 && resultado < 24.99)
            {
                return "Normal";

            } else if (resultado > 25 && resultado < 29.99)
            {
                return "Sobrepeso";

            } else if (resultado > 30)
            {
                return "Obesidade";
            }

            return "Nada";
                
        }

        internal string Classificar(string c)
        {
            if (c == "BaixoPeso")
            {
                return"Baixo Peso";

            }
            else if (c == "Normal")
            {
               return "Normal";

            }
            else if (c == "Sobrepeso")
            {
                return "Sobrepeso";

            }
            else if (c == "Obesidade")
            {
                return"Obesidade";
            }
            else if (c == "Nada")
            {
                return"Nada" + num;
            }
            return "Erro";
        }
    }
}
