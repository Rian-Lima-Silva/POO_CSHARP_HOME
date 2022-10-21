using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_01
{
    internal class Calcular
    {

        public double numero1,numero2;

        internal double Soma(double n1,double n2)
        {
            return n1 + n2;


        }
        internal double Sub(double n1,double n2)
        {
            return n1 - n2;


        }

        internal double Multi(double n1, double n2)
        {
            return n1 * n2;


        }

        internal double Div(double n1, double n2)
        {
            return n1 / n2;


        }

    }
}
