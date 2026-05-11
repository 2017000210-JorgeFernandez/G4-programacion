using System;

class Program
{
    static void Main()
    {
        int num, i, contador, suma;

        suma = 0;

        Console.WriteLine("Nombre: Jorge Fernandez");

        for (num = 1; num <= 22; num++)
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
                Console.WriteLine("Numero primo: " + num);

                suma = suma + num;
            }
        }

        Console.WriteLine("La suma de los numeros primos es: " + suma);
    }
}