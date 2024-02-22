using System;
class Program
{
    static void Main(string[] args)
    {
        //Pida 3 numeros por pantalla: al primero elévelo al cuadrado;
        //el segundo saquéle raiz cuadrada y al tercero raiz cúbica.
        //Muestre los 3 resultados por pantalla.

        int n1, n2, n3;
        double elv, rcua, rcub;

        Console.Write("Ingrese el 1er número ");

        //Leer los números solicitados

        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Ingrese el 2do número ");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Ingrese el 3er número ");
        n3 = Convert.ToInt32(Console.ReadLine());

        //Hacer los cálculos

        elv = Math.Pow(n1, 2);
        rcua = Math.Sqrt(n2);
        rcub = Math.Cbrt(n3);


        //Imprimir en pantalla

        Console.WriteLine("El primer número elevado al cuadrado es " + elv + ".");

        Console.WriteLine("La raíz cuadrada del segundo número es " + rcua + ".");

        Console.WriteLine("La raíz cúbica del tercer número es  " + rcub + ".");
    }
}