using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras.BackEnd
{
    class Triangulo
    {

        //atributos
        public float Base;
        public float Altura;

        //metodos
        public float ObtenerArea()
        {
            return ((Base * Altura) / 2);
        }


        
        public float ObtenerBase()
        {
            return Base;
        }

        public float ObtenerAltura()
        {
            return Altura;
        }
        

        public string ImprimirResultado()
        {
            Console.WriteLine("un triangulo de base {0} y altura {1} tiene un area de {2}", Base, Altura, ObtenerArea());
            //return string.Format("un triangulo de base {0} y altura {1} tiene un area de {2}",Base,Altura,ObtenerArea());
            return "";
        }

        



    }
}
