using System;

class Program
{
    static void Main()
    {
        int num, i;

        Console.WriteLine("Nombre: Jorge Fernandez");

        Console.WriteLine("Ingrese un numero:");
        num = int.Parse(Console.ReadLine());

        for (i = 20; i <= num; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}