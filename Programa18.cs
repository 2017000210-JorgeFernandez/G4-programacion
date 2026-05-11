using System;

class Program
{
    static void Main()
    {
        int i, multiplo, suma, pares;

        suma = 0;
        pares = 0;

        Console.WriteLine("Nombre: Jorge Fernandez");

        for (i = 1; i <= 20; i++)
        {
            multiplo = i * 7;

            Console.WriteLine(multiplo);

            suma = suma + multiplo;

            if (multiplo % 2 == 0)
            {
                pares++;
            }
        }

        Console.WriteLine("La suma de los multiplos es: " + suma);
        Console.WriteLine("Cantidad de multiplos pares: " + pares);
    }
}