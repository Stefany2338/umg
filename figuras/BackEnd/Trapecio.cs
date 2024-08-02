using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras.BackEnd
{
    internal class Trapecio
    {

        public float Altura;
        public float Base1;
        public float Base2;


        public float CalcularArea()
        {
            return((Base1*Base2)/2*Altura);
        }





        public string MostrarResultado()
        {
            Console.WriteLine("Ingresa el valor de la primera base: ");
            Base1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de la segunda base: ");
            Base2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de la altura: ");
            Altura = float.Parse(Console.ReadLine());
            float Area = CalcularArea();

            Console.WriteLine($"un trapecio con una primera base de {Base1} una segunda base de {Base2} y una altura de {Altura} tiene un area de {Area}");
            return "";

        }
    }
}
