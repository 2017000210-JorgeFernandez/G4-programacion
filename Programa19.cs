using System;

class Program
{
    static void Main()
    {
        int num, i, contador;
        int cantidadPrimos = 0;
        int sumaPares = 0;

        Console.WriteLine("Nombre: Jorge Fernandez");

        for (num = 300; num >= 1; num--)
        {
            contador = 0;

            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                cantidadPrimos++;
            }

            if (num % 2 == 0)
            {
                sumaPares = sumaPares + num;
            }
        }

        Console.WriteLine("Cantidad de numeros primos: " + cantidadPrimos);
        Console.WriteLine("La suma de los pares es: " + sumaPares);
    }
}