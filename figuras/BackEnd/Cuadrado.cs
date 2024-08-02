using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras.BackEnd
{
    internal class Cuadrado
    {

        public float Lado;
        public float Area;

        public float ObtenerAreaCuadrado()
        {
           return Area = Lado * Lado;
        }

        public string MostrarResultado()
        {
            Console.WriteLine("Ingresa la medida de un lado del cuadrado: ");
            Lado = float.Parse(Console.ReadLine());
            float Area = ObtenerAreaCuadrado();
            Console.WriteLine(  $"Un cuadrado cuyos lados miden {Lado} tiene una area de {Area}");
            return "";
        }

            


    }
}
