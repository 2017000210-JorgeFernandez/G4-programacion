using System;

class Program
{
    static void Main()
    {
        int num, i, contador;
        int cantidad = 0;
        int suma = 0;

        Console.WriteLine("Nombre: Jorge Fernandez");

        for (num = 1; num <= 100; num++)
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
                cantidad++;
                suma = suma + num;
            }
        }

        Console.WriteLine("Cantidad de numeros primos: " + cantidad);
        Console.WriteLine("La suma de los numeros primos es: " + suma);
    }
}