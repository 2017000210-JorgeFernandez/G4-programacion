using System;

class Program
{
    static void Main()
    {
        int num, i, resultado;

        Console.WriteLine("Nombre: Jorge Fernandez");

        Console.WriteLine("Ingrese un numero:");
        num = int.Parse(Console.ReadLine());

        for (i = 1; i <= 10; i++)
        {
            resultado = num * i;

            Console.WriteLine(num + " x " + i + " = " + resultado);
        }
    }
}