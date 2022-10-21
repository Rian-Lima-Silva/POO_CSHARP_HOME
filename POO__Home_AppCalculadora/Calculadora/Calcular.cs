using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calcular
    {
        

        public double num1;
        public double num2;
        public double n1, n2;
        public string op;

        
        public string Soma(double n1,double n2)
        {            
            double resultado = n1 + n2;
            string res=resultado.ToString();
            return res;
        }
        internal string Subtrair(double n1, double n2)
        {
            double resultado = n1 + n2;
            string res = resultado.ToString();
            return res;
        }
        internal string Multiplicar(double n1,double n2)
        {            
            double resultado = n1 + n2;
            string res=resultado.ToString();
            return res;
        }internal string Dividir(double n1,double n2)
        {            
            double resultado = n1 + n2;
            string res=resultado.ToString();
            return res;
        }
    }
}
