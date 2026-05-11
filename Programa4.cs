using System;

class Program
{
    static void Main()
    {
        int num, i, contador;

        contador = 0;

        Console.WriteLine("Nombre: Jorge Fernandez");

        Console.WriteLine("Ingrese un numero:");
        num = int.Parse(Console.ReadLine());

        for (i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                contador++;
            }
        }

        if (contador == 2)
        {
            Console.WriteLine("El numero es primo");
        }
        else
        {
            Console.WriteLine("El numero no es primo");
        }
    }
}