using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras.BackEnd
{
    class Circulo
    {


        //atributos
        public float Radio;
        public float Pi = 3.1416f;

        //metodos
        public float ObtenerArea()
        {
            return (Radio*Radio) * Pi;
        }

        public string ImprimirResultado()
        {
            Console.WriteLine("Ingresa el radio del circulo: ");
            Radio=float.Parse(Console.ReadLine());
            float area =ObtenerArea();
            Console.WriteLine( $"un circulo de radio {Radio} tiene un area de {area}");

            

            return "";
        }

    }
}
