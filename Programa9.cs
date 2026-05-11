using System;

class Program
{
    static void Main()
    {
        int num, i;

        Console.WriteLine("Nombre: Jorge Fernandez");

        Console.WriteLine("Ingrese un numero:");
        num = int.Parse(Console.ReadLine());

        for (i = 2; i <= num; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }
}