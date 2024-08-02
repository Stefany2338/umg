using figuras.BackEnd;
//using System;


class Program
{
    static void Main(string[] args)
    {

        int op;

        Console.WriteLine(  "Ingresa el numero del calculo que quieres realizar: ");
        Console.WriteLine( " 1)Circulo \n 2)cuadrado \n 3)Pentagono \n 4)Rectangulo \n 5)Rombo \n 6)Romboide \n 7)Trapecio \n 8)Triangulo");
        op=int.Parse(Console.ReadLine());

      


        switch (op)
        {
            case 1:
                Console.WriteLine("---AREA DE UN CIRCULO---");
                Circulo circulo=new Circulo();
                circulo.ImprimirResultado();
                break;
                
            case 2:
                Console.WriteLine("---AREA DE CUADRADO---");
                Cuadrado cuadrado=new Cuadrado();
                cuadrado.MostrarResultado();
                break;

            case 3:
                Console.WriteLine("---AREA DE PENTAGONO---");
                Pentagono pentagono=new Pentagono();
                pentagono.MostrarResultado();
                break;

            case 4:
                Console.WriteLine("---AREA DE RECTANGULO---");
                Rectangulo rectangulo=new Rectangulo();
                rectangulo.MostrarResultado();
                break;

            case 5:
                Console.WriteLine("---AREA DE ROMBO---");
                Rombo rombo=new Rombo();
                rombo.MostrarResultado();
                break;

            case 6:
                Console.WriteLine("---AREA DE ROMBOIDE---");
                Romboide romboide=new Romboide();
                romboide.MostrarResultado();
                break;

            case 7:
                Console.WriteLine("---AREA DE TRAPECIO---");
                Trapecio trapecio=new Trapecio();
                trapecio.MostrarResultado();
                break;

            case 8:
                Console.WriteLine("---AREA DE TRIANGULO---");
                Triangulo triangulo=new Triangulo();    
                //triangulo.ObtenerArea();
                triangulo.ImprimirResultado();
                break;
        }

        Console.ReadKey();
    }
}