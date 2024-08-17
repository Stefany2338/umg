using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones.Back
{
    class Operaciones
    {


        //-------------------------SUMAS
        public double Suma(double valor1, double valor2)
        {
            
            return valor1+valor2;
        }

        public double Suma(double valor1, double valor2, double valor3)
        {
            return valor1 + valor2 + valor3;
        }

        public double Suma(double valor1, double valor2, double valor3, double valor4)
        {
            return valor1 + valor2 + valor3 + valor4;
        }


        //-------------------------RESTAS

        public double Resta(ref double valor1, ref double valor2)
        {
            return valor1 - valor2;
        }
        public double Resta(ref double valor1, ref double valor2, ref double valor3)
        {
            return valor1 - valor2 - valor3;
        }

        //-------------------------DIVISION
        public double Division(ref double valor1, ref double valor2)
        {
            return valor1 / valor2;
        }

        //-----------------------MULTIPLICACIÓN
        public double Multiplicacion(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
        public double Multiplicacion(double valor1, double valor2, double valor3)
        {
            return valor1 * valor2 * valor3;
        }
        public double Multiplicacion(double valor1, double valor2, double valor3, double valor4)
        {
            return valor1 * valor2 * valor3 * valor4;
        }



    }
}
