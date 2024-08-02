using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras.BackEnd
{
    internal class Rombo
    {
        public float DiagonalMa;
        public float DiagonalMe;

        public float CalcularArea()
        {
            return (DiagonalMa*DiagonalMe)/2;
        }





        public string MostrarResultado()
        {
            Console.WriteLine("Ingresa el valor de la diagonal mayor: ");
            DiagonalMa = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de la diagonal menor: ");
            DiagonalMe = float.Parse(Console.ReadLine());
            float Area = CalcularArea();

            Console.WriteLine($"un rombo con diagonal mayor de {DiagonalMa} y una diagonal menor de {DiagonalMe} tiene un area de {Area}");
            return "";

        }


    }
}
