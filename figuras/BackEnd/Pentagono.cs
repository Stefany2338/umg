using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras.BackEnd
{
    internal class Pentagono
    {

        public float Perimetro;
        public float Apotema;

        public float CalcularArea()
        {
            return (Perimetro * Apotema) / 2;
            
        }


        public string MostrarResultado()
        {
            Console.WriteLine("Ingresa el valor del perimetro: ");
            Perimetro = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor del Apotema: ");
            Apotema = float.Parse(Console.ReadLine());
            float Area = CalcularArea();

            Console.WriteLine ($"un pentagono con un perimetro de {Perimetro} y un Apotema de {Apotema} tiene un area de {Area}");
            return "";

        }



    }
}
