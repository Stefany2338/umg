using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras.BackEnd
{
    internal class Romboide
    {

        public float Base;
        public float Altura;

        public float CalcularArea()
        {
            return (Base * Altura);
        }



        public string MostrarResultado()
        {
            Console.WriteLine("Ingresa el valor de la base: ");
            Base = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de la altura: ");
            Altura = float.Parse(Console.ReadLine());
            float Area = CalcularArea();

            Console.WriteLine($"un rectangulo con una base de {Base} y una altura de {Altura} tiene un area de {Area}");
            return "";

        }

    }
}
