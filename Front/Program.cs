using operaciones.Back;
using System;

internal class Program
{
    private static void Main(string[] args)
    {


        //----------------------sumas
        Operaciones sumas = new Operaciones();
        Console.WriteLine("-------------SUMAS-------------");
        Console.WriteLine("El resultado de la suma es "+ sumas.Suma(5, 10));
        Console.WriteLine("El resultado de la suma es "+ sumas.Suma(1, 10, 15));
        Console.WriteLine("El resultado de la suma es "+ sumas.Suma(5, 10, 15, 20));

        //---------------------restas
        Operaciones restas = new Operaciones();
        double valorSum1 = 5;
        double valorSum2 = 10;
        double valorSum3 = 15;
        Console.WriteLine("-------------RESTAS-------------");
        Console.WriteLine("El resultado de la resta es "+ restas.Resta(ref valorSum1, ref valorSum2));
        Console.WriteLine("El resultado de la resta es "+ restas.Resta(ref valorSum1, ref valorSum2, ref valorSum3));

        //----------------------divisiones
        Operaciones division = new Operaciones();
        double valorRes1 = 5;
        double valorRes2 = 10; 
        Console.WriteLine("-------------DIVISION-------------");
        Console.WriteLine("El resultado de la división es "+ division.Division(ref valorRes1,ref valorRes2));

        //----------------------multiplicacion
        Operaciones multiplicacion = new Operaciones();
        Console.WriteLine("-------------MULTIPLICACION-------------");
        Console.WriteLine("El resultado de la multiplicación es "+ multiplicacion.Multiplicacion (5, 10));
        Console.WriteLine("El resultado de la multiplicación es "+ multiplicacion.Multiplicacion(1, 10, 15));
        Console.WriteLine("El resultado de la multiplicación es "+ multiplicacion.Multiplicacion(5, 10, 15, 20));




    }
}