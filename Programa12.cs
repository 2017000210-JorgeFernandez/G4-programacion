using System;

class Program
{
    static void Main()
    {
        int num, i, factorial;

        factorial = 1;

        Console.WriteLine("Nombre: Jorge Fernandez");

        Console.WriteLine("Ingrese un numero:");
        num = int.Parse(Console.ReadLine());

        for (i = 1; i <= num; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine("El factorial es: " + factorial);
    }
}