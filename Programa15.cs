using System;

class Program
{
    static void Main()
    {
        int num, suma;

        suma = 0;

        Console.WriteLine("Nombre: Jorge Fernandez");

        do
        {
            Console.WriteLine("Ingrese un numero:");
            num = int.Parse(Console.ReadLine());

            suma = suma + num;

        } while (num != 9);

        Console.WriteLine("La suma total es: " + suma);
    }
}